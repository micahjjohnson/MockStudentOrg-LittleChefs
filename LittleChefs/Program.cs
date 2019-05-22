using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleChefs
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            List<int> test = new List<int>();
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            //test.Reverse();

            //string combindedString = string.Join(",", test.ToArray());
            //MessageBox.Show(combindedString);
            //test.Reverse(2, 3);
            //string combindedString2 = string.Join(",", test.ToArray());
            //MessageBox.Show(combindedString2);

            Application.Run(new Form1());
            //Application.Run(new FormWeekView());

            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form5(lc.studentOne, lc));
            //Application.Run(new Form8(1));
            //Application.Run(new Form14());
            //Application.Run(new Form2(lc));
            //Application.Run(new Form13(lc));
            */
        }
    }
}
