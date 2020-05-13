using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace My_project
{
   
   class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //string writePath = @"C:\ESD\input_all_prices.txt";
            
            //int a2 = Data.price_bus;
            //int b2 = Data.price_minibus;
            //int c2 = Data.price_taxi;
            //try
            //{
            //    using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            //    {
            //    sw.WriteLine(a2);
            //        sw.WriteLine(b2);
            //        sw.WriteLine(c2);
            //    }

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            
        }


        }
    }

