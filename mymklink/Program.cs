﻿
using System;
using System.Collections.Generic;
using System.Windows.Forms;

using System.IO;

// http://community.bartdesmet.net/blogs/bart/archive/2006/10/24/Windows-Vista-_2D00_-Creating-symbolic-links-with-C_2300_.aspx

namespace mymklink
{


    static class Program
    {


        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool bShowWindow = false;

            if (bShowWindow)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }

            /*
            //
            // Symbolic file link bar.txt <<===>> foo.txt
            //
            string symF = "bar.txt";
            string targetF = "foo.txt";

            Console.WriteLine(">echo \"Hello World\" > {0}", targetF);
            StreamWriter sw = File.CreateText(targetF);
            sw.WriteLine("Hello World");
            sw.Close();
            Console.WriteLine();

            Console.WriteLine(">mklink {0} {1}", symF, targetF);
            if (mklink.CreateSymbolicLink(symF, targetF, 0))
                Console.WriteLine("symbolic link created for {0} <<===>> {1}", symF, targetF);
            Console.WriteLine();

            Console.WriteLine(">type {0}", targetF);
            Console.WriteLine(File.ReadAllText(targetF));
            Console.WriteLine();

            //
            // Symbolic directory link bar <<===>> foo
            //
            string symD = "bar";
            string targetD = "foo";

            Console.WriteLine(">mkdir {0}", targetD);
            Directory.CreateDirectory(targetD);
            Console.WriteLine();

            Console.WriteLine(">echo \"Hello World\" > {0}\\demo.txt", targetD);
            StreamWriter sw2 = File.CreateText(targetD + "\\demo.txt");
            sw2.WriteLine("Hello World");
            sw2.Close();
            Console.WriteLine();

            Console.WriteLine(">mklink /d {0} {1}", symD, targetD);

            if (mklink.CreateSymbolicLink(symD, targetD, mklink.SYMBOLIC_LINK_FLAG.Directory))
                Console.WriteLine("symbolic link created for {0} <<===>> {1}", symD, targetD);
            Console.WriteLine();

            Console.WriteLine(">dir {0}", targetD);
            foreach (string f in Directory.GetFiles(targetD))
                Console.WriteLine(f);
            */
            //bool bbb = mklink.CreateSymbolicLink(@"d:\temp", @"D:\Temp2", mklink.SYMBOLIC_LINK_FLAG.File);
            // Console.WriteLine(bbb);

            // Symlink-name, TargetName, AllowOverwrite
            FS.NTFS.JunctionPoint.Create(@"d:\temp2", @"D:\Temp", false);

            

        } // End Sub Main


    } // End Class Program


} // End Namespace mymklink
