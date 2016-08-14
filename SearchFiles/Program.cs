using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Поиск_папок_и_файлов
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            View1 view = new View1();
            Presenter presenter = new Presenter(view);
            Application.Run(view);
        }
    }
}
