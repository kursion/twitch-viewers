using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchViewers
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Window form = new Window();
            form.TopLevel = true;

            Console.WriteLine("Starting thread");
            Crawler crawler = new Crawler(form);
            Thread oThread = new Thread(new ThreadStart(crawler.Start));
            oThread.Start();

            Console.WriteLine("Starting window");
            Application.Run(form);


            oThread.Abort();
            
        }
    }
}
