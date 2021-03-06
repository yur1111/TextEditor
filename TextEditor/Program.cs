using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using System.Text;

namespace TextEditor
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm mainform = new MainForm();
            MessageService messageService = new MessageService();
            FileManager fileManager = new FileManager();
            MainPresenter presenter = new MainPresenter(mainform, fileManager, messageService);
            Application.Run(mainform);
        }
    }
}
