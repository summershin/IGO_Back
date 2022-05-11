using IGO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using 期中專題;
using 期中專題.BackEnd;

namespace Igo_Back
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new UserManagement());
            //Application.Run(new Product_Management());
            //Application.Run(new HomePage_Back());
            Application.Run(new Order_Management());
        }
    }
}
