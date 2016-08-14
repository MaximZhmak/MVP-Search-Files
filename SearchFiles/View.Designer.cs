using System.Drawing;

namespace Поиск_папок_и_файлов
{
    partial class View1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Mask = new System.Windows.Forms.RichTextBox();
            this.word = new System.Windows.Forms.RichTextBox();
            this.Drives = new System.Windows.Forms.ComboBox();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BigIcon = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Qnt = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Names = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Directory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LargeIcons = new System.Windows.Forms.ImageList(this.components);
            this.SmallIcons = new System.Windows.Forms.ImageList(this.components);
            this.qnt2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Pause = new System.Windows.Forms.Button();
            this.Resume = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Файл";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Слово или фраза в файле";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Диски";
            // 
            // Mask
            // 
            this.Mask.Location = new System.Drawing.Point(12, 34);
            this.Mask.Name = "Mask";
            this.Mask.Size = new System.Drawing.Size(143, 22);
            this.Mask.TabIndex = 3;
            this.Mask.Text = "*.exe";
            // 
            // word
            // 
            this.word.Location = new System.Drawing.Point(184, 34);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(209, 22);
            this.word.TabIndex = 4;
            this.word.Text = "";
            // 
            // Drives
            // 
            this.Drives.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Drives.DisplayMember = "1";
            this.Drives.Location = new System.Drawing.Point(415, 35);
            this.Drives.Name = "Drives";
            this.Drives.Size = new System.Drawing.Size(121, 21);
            this.Drives.TabIndex = 5;
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Start.Location = new System.Drawing.Point(548, 30);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(84, 23);
            this.Start.TabIndex = 6;
            this.Start.Text = "Старт";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Find_Click);
            // 
            // Stop
            // 
            this.Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Stop.Enabled = false;
            this.Stop.Location = new System.Drawing.Point(635, 29);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(84, 23);
            this.Stop.TabIndex = 7;
            this.Stop.Text = "Стоп";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(735, 39);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Подкаталоги";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BigIcon,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(12, 59);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(103, 27);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BigIcon
            // 
            this.BigIcon.BackgroundImage = Image.FromFile(@"..\..\resources\magnifyingglass.ico");
            this.BigIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BigIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BigIcon.BackgroundImage = Image.FromFile(@"..\..\resources\largeIcon.png");
            this.BigIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BigIcon.Name = "BigIcon";
            this.BigIcon.Size = new System.Drawing.Size(24, 24);
            this.BigIcon.Text = "Большие значки";
            this.BigIcon.Click += new System.EventHandler(this.BigIcon_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BigIcon.BackgroundImage = Image.FromFile(@"..\..\resources\smallIcon.png");
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "Маленькие значки";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BigIcon.BackgroundImage = Image.FromFile(@"..\..\resources\list.png");
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "Список";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BigIcon.BackgroundImage = Image.FromFile(@"..\..\resources\details.png");
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton4.Text = "Таблица";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // Qnt
            // 
            this.Qnt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Qnt.AutoSize = true;
            this.Qnt.Location = new System.Drawing.Point(129, 65);
            this.Qnt.Name = "Qnt";
            this.Qnt.Size = new System.Drawing.Size(275, 13);
            this.Qnt.TabIndex = 10;
            this.Qnt.Text = "Результаты поиска: количество найденных файлов :";
            this.Qnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Names,
            this.Directory,
            this.Size,
            this.Date});
            this.listView1.FullRowSelect = true;
            this.listView1.LargeImageList = this.LargeIcons;
            this.listView1.Location = new System.Drawing.Point(12, 85);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(862, 354);
            this.listView1.SmallImageList = this.SmallIcons;
            this.listView1.StateImageList = this.SmallIcons;
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.itemSelected);
            // 
            // Names
            // 
            this.Names.Text = "Имя";
            this.Names.Width = 226;
            // 
            // Directory
            // 
            this.Directory.Text = "Папка";
            this.Directory.Width = 301;
            // 
            // Size
            // 
            this.Size.Text = "Размер";
            this.Size.Width = 139;
            // 
            // Date
            // 
            this.Date.Text = "Дата модификации";
            this.Date.Width = 186;
            // 
            // LargeIcons
            // 
            this.LargeIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.LargeIcons.ImageSize = new System.Drawing.Size(32, 32);
            this.LargeIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // SmallIcons
            // 
            this.SmallIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.SmallIcons.ImageSize = new System.Drawing.Size(16, 16);
            this.SmallIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // qnt2
            // 
            this.qnt2.AutoSize = true;
            this.qnt2.Location = new System.Drawing.Point(410, 67);
            this.qnt2.Name = "qnt2";
            this.qnt2.Size = new System.Drawing.Size(13, 13);
            this.qnt2.TabIndex = 12;
            this.qnt2.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(378, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "* Дважды щелкните выбранный файл, чтобы открыть его расположение";
            // 
            // Pause
            // 
            this.Pause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pause.Enabled = false;
            this.Pause.Location = new System.Drawing.Point(548, 54);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(84, 23);
            this.Pause.TabIndex = 14;
            this.Pause.Text = "Пауза";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Resume
            // 
            this.Resume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Resume.Enabled = false;
            this.Resume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Resume.Location = new System.Drawing.Point(635, 55);
            this.Resume.Name = "Resume";
            this.Resume.Size = new System.Drawing.Size(84, 23);
            this.Resume.TabIndex = 15;
            this.Resume.Text = "Продолжить";
            this.Resume.UseVisualStyleBackColor = true;
            this.Resume.Click += new System.EventHandler(this.Resume_Click);
            // 
            // View1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(886, 463);
            this.Controls.Add(this.Resume);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.qnt2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Qnt);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Drives);
            this.Controls.Add(this.word);
            this.Controls.Add(this.Mask);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "View1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsyncProgramm Поиск файлов ";
        
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox Drives;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BigIcon;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label Qnt;
        private System.Windows.Forms.ColumnHeader Names;
        private System.Windows.Forms.ColumnHeader Directory;
        private System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.ColumnHeader Date;
        internal System.Windows.Forms.RichTextBox Mask;
        internal System.Windows.Forms.RichTextBox word;
        internal System.Windows.Forms.CheckBox checkBox1;
        internal System.Windows.Forms.ListView listView1;
        internal System.Windows.Forms.Label qnt2;
        internal System.Windows.Forms.Button Start;
        internal System.Windows.Forms.Button Stop;
        internal System.Windows.Forms.ImageList LargeIcons;
        internal System.Windows.Forms.ImageList SmallIcons;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button Pause;
        internal System.Windows.Forms.Button Resume;
    }
}

