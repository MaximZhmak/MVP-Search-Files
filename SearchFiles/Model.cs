using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace Поиск_папок_и_файлов
{
    internal class SeachItem
    {
        public int DriveIndex;
        public string Mask;
        public string TextMask;
        public bool SearchInside;
        internal DirectoryInfo Directory;
    }


    class Model
    {
        public event EventHandler FileFound;      //событие "Файл найден"
        public string[] Drives;
        public List<FileInfo> MatchedFiles;       //список найденных файлов,которые соответствуют маске
        string path;
        string Mask;
        public string TextToSearchInFile;
        Regex regMask;
        ManualResetEvent ManualReset = new ManualResetEvent(true);
        public SeachItem SearchItemParams;

        public Model()
        {
            //получаем список логических дисков компьютера
            Drives = Directory.GetLogicalDrives();
            MatchedFiles = new List<FileInfo>();
            SearchItemParams = new SeachItem();
        }
        public void ConvertMaskAndPath()
        {
            //метод который приводит текст маски в регулярное выражение и возвращает директорию для поиска файлов внутри
            path = Drives[SearchItemParams.DriveIndex] + '\\';
            Mask = SearchItemParams.Mask;
            Mask = Mask.Replace(".", @"\.");
            Mask = Mask.Replace("?", ".");
            Mask = Mask.Replace("*", ".*");
            Mask = "^" + Mask + "$";
            regMask = new Regex(Mask, RegexOptions.IgnoreCase);
            SearchItemParams.Directory = new DirectoryInfo(path);
        }
        public void PauseSearch()
        {
            ManualReset.Reset();
        }
        public void ResumeSearch()
        {
            ManualReset.Set();
        }
        public void StopSearch()
        {
            ManualReset.Set();
        }
        public void SearchFiles(CancellationToken token)
        {
            //получаем все файлы в указанной папке
            FileInfo[] fi = null;
            try
            {
                fi = SearchItemParams.Directory.GetFiles();
            }
            catch
            {
                return;
            }
            foreach (FileInfo file in fi)
            {
                ManualReset.WaitOne();
                token.ThrowIfCancellationRequested();
                try
                {
                    //проверка, сответствуют ли найденный фаЙлы маске поиска
                    if (regMask.IsMatch(file.Name))
                    {
                        //если заполнено поле поиска теста внутри файла
                        if (TextToSearchInFile != "")
                        {                            
                            StreamReader reader = new StreamReader(file.FullName);  //создаем поток для чтения внутри файла
                            try
                            {
                                //считываем содежимое файла и проверяем содержил ли он искомый текст                              
                                do            
                                {
                                    string st = reader.ReadLine();
                                    if (st.Contains(TextToSearchInFile))
                                    {
                                        MatchedFiles.Add(file);                 //добавляем найденный файл в список 
                                        FileFound(this, EventArgs.Empty);       //срабатывает событие "Файл найден!"
                                        break;
                                    }
                                }
                                while (reader.Peek() >= 0);
                            }
                            finally
                            {
                                reader.Close();
                            }
                            break;
                        }
                        MatchedFiles.Add(file);                              //добавляем найденный файл в список 
                        FileFound(this, EventArgs.Empty);                    //срабатывает событие "Файл найден!"
                    }
                }
                catch (Exception) { }
            }
            if (SearchItemParams.SearchInside)                                                //если отмечено "искать в подпапках"
            {
                try
                {
                    DirectoryInfo[] diSub = SearchItemParams.Directory.GetDirectories();
                    //получаем все подпапки указанной папки                                                                                                                        
                    foreach (DirectoryInfo diSubDir in diSub)
                    //для каждой подпапки в указанной папке повторяем этот метод - рекурсия
                    {
                        SearchItemParams.Directory = diSubDir;
                        SearchFiles(token);
                    }
                }
                catch (UnauthorizedAccessException) { }
            }
        }
      
    }

}


