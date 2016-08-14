using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Поиск_папок_и_файлов
{

    class Presenter
    {
        private Model _model = new Model();
        private IView _view;
        private CancellationTokenSource cts;

        public Presenter(IView view)
        {
            _view = view;
            _view.SearchEvent += StartEventHandler;           //подписка на событие нажатия кнопки "Найти"
            _view.PauseEvent += PauseEventHandler;            //подписка на событие нажатия  кнопки "Пауза"
            _view.ResumeEvent += ResumeEventHandler;          //подписка на событие нажатия  кнопки "Продолжить"
            _view.StopEvent += StopEventHandler;              //подписка на событие нажатия  кнопки "Стоп"
            _view.FileClicked += FileToOpen;                  //подписка на событие "Файл щелкнут на ListView"
            _model.FileFound += FileFound;                    //подписка на событие "Файл найден" из Модели    

            _view.AddDrives(_model.Drives);
            _view.DrivesIndex = 1;
        }
 
        private async void StartEventHandler(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            _model.TextToSearchInFile = _view.WordText;     //передаем в модель введенный на View текст, для поиска внутри файла
            await Search();                        //запуск поиска       
        }
        private void StopEventHandler(object sender, EventArgs e)
        {
            cts.Cancel();                                   //токен отправляет команду отмены
            cts.Dispose();                                  //токен сброшен  
            _model.StopSearch();
        }
        private void PauseEventHandler(object sender, EventArgs e)
        {
            _model.PauseSearch();
        }
        private void ResumeEventHandler(object sender, EventArgs e)
        {
            _model.ResumeSearch();
        }
        private async Task Search()
        {
            _model.SearchItemParams.DriveIndex = _view.DrivesIndex;
            _model.SearchItemParams.Mask = _view.MaskText;
            _model.SearchItemParams.SearchInside = _view.SearchInside;
            _model.SearchItemParams.TextMask = _view.WordText;
            _model.ConvertMaskAndPath();
            try
            {
                await Task.Run(() =>_model.SearchFiles(cts.Token));
            }
            catch (Exception) { }
            finally
            {
                SearchIsOver(null);
            }
        }
        private void FileFound(object sender, EventArgs e)
        {
            _view.ListViewItemAdd(_model.MatchedFiles[_model.MatchedFiles.Count - 1]);             //добавляем на ListView последний в списке найденных файлов
        }
        private void FileToOpen(Object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("explorer.exe", " /select, " + _view.FileToOpen));  //открыть папку в проводнике и выделить файл
            //Process.Start(_view.FileToOpen);                                                     //открыть выделенный файл
        }
        private void SearchIsOver(object obj)
        {
            _view.SearchIsOverMessageText = _model.MatchedFiles.Count == 0 ?  "Файлы не найдены." : "Поиск успешно завершен.";          
        }
    }
}
