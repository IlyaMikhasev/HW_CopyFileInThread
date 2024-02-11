using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace HW_CopyFileInThread
{
    internal class CopyFileInThread
    {
        public delegate void CopyFileComplite(int step);
        public event CopyFileComplite path_copy;


        string _newPath = string.Empty;
        string _pathFile = string.Empty;
        long _step = 0;
        int _threads = 0;
        public CopyFileInThread(string pathFile, string newPath, int cointThread)
        {
            _pathFile = pathFile;
            _newPath = newPath;
            _threads = cointThread;
        }
        public async void CopyFile()
        {
            string textFromFile = string.Empty;
            // выделяем массив для считывания данных из файла
            FileInfo fileInfo = new FileInfo(_pathFile);
            var size = fileInfo.Length;
            _step = size / _threads;

            var stepComplete = size % _step == 0 ? 100 / (_threads * 2) : (100 / (_threads * 2) + 2);
            for (int i = 0; _step * i < size; i++)
            {
                await Task.Factory.StartNew(() =>
                  {
                      byte[] buffer = new byte[_step];
                      using (FileStream fstream = new FileStream(_pathFile, FileMode.OpenOrCreate))
                      {
                          fstream.Seek(_step * i, SeekOrigin.Begin);
                          // считываем данные
                          fstream.Read(buffer, 0, buffer.Length);
                          path_copy(stepComplete);
                      }
                      using (FileStream fstream = new FileStream(_newPath, FileMode.OpenOrCreate))
                      {
                          fstream.Seek(_step * i, SeekOrigin.Begin);
                          //записываем данные
                          fstream.Write(buffer, 0, buffer.Length);
                          path_copy(stepComplete);
                      }
                  });
            }
        }
        public async void CopyDir()
        {
            if (!Directory.Exists(_newPath))
            {
                Directory.CreateDirectory(_newPath);
            }

            string[] files = Directory.GetFiles(_pathFile);
            int totalFiles = files.Length;
            _step = totalFiles / 100;
            int countThread = 0;
            foreach (string file in files)
            {
                while (countThread >_threads) { }
                    await Task.Factory.StartNew(async () =>
                    {
                        countThread++;
                        string destFile = Path.Combine(_newPath, Path.GetFileName(file));
                        using (FileStream sourceStream = new FileStream(file, FileMode.Open, FileAccess.Read))
                        {
                            using (FileStream destStream = new FileStream(destFile, FileMode.Create, FileAccess.Write))
                            {
                                await sourceStream.CopyToAsync(destStream, 4096);
                            }
                        }
                        path_copy((int)_step);
                        countThread--;
                    });
                
            }
        }
    }
}
