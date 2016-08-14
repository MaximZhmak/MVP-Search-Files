using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Поиск_папок_и_файлов
{
    public interface IView
    {
        //события
        event EventHandler SearchEvent;             //событие нажата кнопка "Начать поиск"
        event EventHandler StopEvent;               //событие нажата кнопка "Стоп поиск"
        event EventHandler PauseEvent;              //событие нажата кнопка "Пауза поиск"
        event EventHandler ResumeEvent;             //событие нажата кнопка "Продолжить поиск"
        event EventHandler FileClicked;             //событие щелкнут файл на ListView
        //свойства     
        string Text
        {
            //устанавливает заголовок окна
            set;
        }
        string WordText
        {
            //получает текст для поиска внутри файлов
            get;
        }
        bool StartButton
        {
            //активирует кнопку "Старт"
            get;
            set;
        }
        bool StopButton
        {
            //активирует кнопку "Стоп"
            get;
            set;
        }
        bool PauseButton
        {
            //активирует кнопку "Стоп"
            get;
            set;
        }
        bool ResumeButton
        {
            //активирует кнопку "Стоп"
            get;
            set;
        }
        string SearchIsOverMessageText
        {
            set;
        }
        bool SearchInside
        {
            //возвращает значение, стоит ли галочка "искать в подпапках"
            get;
        }
        string Qnt2
        {
            //устанавливает количество найденных файлов
            set;
        }
        string MaskText
        {//возвращает текст маски для поиска
            get;
        }
        int ListItemsCount
        {
            //возвращает количество элементов на форме
            get;
        }
        int DrivesIndex
        {
            //получает и возвращает индекс выбранного диска из комбобокса
            get;
            set;
        }        
        string FileToOpen
        {
            set;
            get;
        }
   

        //методы
        void ListViewItemsClear();               //очищает список найденных файлов на форме
        void ListViewItemAdd( FileInfo file);    //добалвяет найденный файл на форму
        void ViewShow();                         //начинает показ формы
        void AddDrives(string[] Drives);         //добавляет список дисков на форму
      
    }
}
