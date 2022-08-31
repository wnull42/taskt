﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskt_updater
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Debug
            //if (args.Length == 0)
            //{
            //    //args[0] = "https://github.com/rcktrncn/taskt-up-test/releases/download/v3.5.1.5/taskt-uob_v3.5.1.5.zip";
            //    string[] newArg = new string[2];
            //    newArg[0] = "/r";
            //    newArg[1] = "\"C:\\Users\\rr\\Documents\\GitHub\\taskt\\taskt-updater\\bin\\Debug\"";
            //    args = newArg;
            //}

            if (args.Count() == 0)
            {
                MessageBox.Show("Update Tool requires a package argument!");
                Application.Exit();
            }
            else
            {
                try
                {
                    Application.Run(new frmUpdating(args[0], args[1]));
                }
                catch
                {

                }
            }
        }
    }
}
