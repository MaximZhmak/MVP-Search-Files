using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Поиск_папок_и_файлов
{
    public partial class View1 : Form, IView
    {
        public View1()
        {
            InitializeComponent();
            IconIndex = -1;
            ItemIndex = -1;
        }
        private string FilePath;

        #region IView Interface Implementation

        public event EventHandler SearchEvent;
        public event EventHandler StopEvent;
        public event EventHandler PauseEvent;
        public event EventHandler ResumeEvent;

        public event EventHandler FileClicked; //выбран файл для открытия в проводнике
        int IconIndex;
        int ItemIndex;
        public string FileToOpen
        {
            set { FilePath = value; }
            get { return FilePath; }
        }
        public void AddDrives(string[] Drives)
        {
            foreach (string drive in Drives)        //получаем список дисков из модели
                this.Drives.Items.Add(drive);       //и добавляем их в чекбокс на View         
        }
        public void ListViewItemsClear()
        {
            listView1.Items.Clear();
        }
        public string WordText
        {
            get
            {
                return word.Text;
            }
        }
        public string MaskText
        {
            get
            {
                return Mask.Text;
            }
        }
        public bool SearchInside
        {
            get
            {
                return checkBox1.Checked;
            }
        }
        public bool StartButton
        {
            get
            {
                return Start.Enabled;
            }
            set
            {
                Start.Enabled = value;
            }
        }
        public bool StopButton
        {
            get
            {
                return Stop.Enabled;
            }
            set
            {
                Stop.Enabled = value;
            }
        }
        public bool PauseButton
        {
            get
            {
                return Stop.Enabled;
            }
            set
            {
                Stop.Enabled = value;
            }
        }
        public bool ResumeButton
        {
            get
            {
                return Stop.Enabled;
            }
            set
            {
                Stop.Enabled = value;
            }
        }

        public string Qnt2
        {
            set
            {
                qnt2.Text = value;

            }
        }
        public string SearchIsOverMessageText
        {
            set
            {              
                MessageBox.Show(value, "Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Text = "Поиск завершен";
            }
        }
        public int ListItemsCount
        {
            get
            {
                return listView1.Items.Count;
            }
        }
        public int DrivesIndex
        {
            get
            {
                return Drives.SelectedIndex;
            }
            set
            {
                Drives.SelectedIndex = value;
            }
        }
        public void ListViewItemAdd(FileInfo file)
        {
            Qnt2 = (ListItemsCount + 1).ToString();
            Icon icon = Icon.ExtractAssociatedIcon(file.FullName);
            IconIndex++;
            ItemIndex++;
            LargeIcons.Images.Add(icon);
            SmallIcons.Images.Add(icon);

            //для отображения детальной информации о найденном файле надо заполнить подэлементы, которые будут отображены в табличном виде
            ListViewItem item = null;                                                                               //сам элемент найденного файла
            ListViewItem.ListViewSubItem[] subItems;                                                                //создаю массив подэлементов найденного файла
            subItems = new ListViewItem.ListViewSubItem[]                                                           //заполняю массив подэлементов
                {
                        new ListViewItem.ListViewSubItem(item, file.Name),
                        new ListViewItem.ListViewSubItem(item, file.FullName),                                      //полный путь файла
                        new ListViewItem.ListViewSubItem(item, String.Format((file.Length/1024).ToString()+" кб")), //размер файла в КБ
                        new ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortDateString())             //дата последнего доступа в файл
                };
            listView1.Items.Add(new ListViewItem(subItems, IconIndex));
            listView1.Items[ItemIndex].ToolTipText = file.FullName;
        }
        public void ViewShow()
        {
            this.Show();
        }

        #endregion

        #region Buttons Event Handling
        private void BigIcon_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }
        private void Find_Click(object sender, EventArgs e)
        {
            Qnt2 = 0.ToString();                      //обнуление счетчика найденный файлов при новом поиске
            ListViewItemsClear();
            //меняем заголовок окна
            Text = " Идет поиск файлов...";
            Stop.Enabled = true;
            Pause.Enabled = true;
            SearchEvent(this, e);
            Start.Enabled = false;
        }
        private void Stop_Click(object sender, EventArgs e)
        {
            Stop.Enabled = false;
            Start.Enabled = true;
            Pause.Enabled = false;
            Resume.Enabled = false;
            Text = "Поиск файлов - Поиск завершен";
            StopEvent(this, e);
        }
        private void Pause_Click(object sender, EventArgs e)
        {
            Text = "Поиск файлов - Поиск приостановлен";
            Stop.Enabled = true; ;
            Start.Enabled = false;
            Pause.Enabled = false;
            Resume.Enabled = true;
            PauseEvent(this, e);
        }
        private void Resume_Click(object sender, EventArgs e)
        {
            Text = " Идет поиск файлов...";
            Stop.Enabled = true;
            Start.Enabled = false;
            Pause.Enabled = true;
            Resume.Enabled = false;
            ResumeEvent(this, e);
        }
        private void itemSelected(object sender, MouseEventArgs e)
        {
            FileToOpen = listView1.GetItemAt(e.X, e.Y).ToolTipText;
            FileClicked(this, EventArgs.Empty);
        }
        #endregion


    }
}
