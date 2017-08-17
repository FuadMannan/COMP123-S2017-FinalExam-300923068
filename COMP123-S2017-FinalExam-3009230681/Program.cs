using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Fuad Mannan
 * Date: August 8, 2017
 * StudentID: 300923068
 * Description: Driver class for program
 * Version:
 */

namespace COMP123_S2017_FinalExam_3009230681
{
    public static class Program
    {
        public static PickHighestCardForm pickHighestCardForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            pickHighestCardForm = new PickHighestCardForm();

            Application.Run(new SplashForm());
        }
    }
}
