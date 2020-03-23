
// http://community.bartdesmet.net/blogs/bart/archive/2006/10/24/Windows-Vista-_2D00_-Creating-symbolic-links-with-C_2300_.aspx


namespace mymklink
{


    static class Program
    {


        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [System.STAThread]
        static void Main()
        {
            bool bShowWindow = false;

            if (bShowWindow)
            {
                System.Windows.Forms.Application.EnableVisualStyles();
                System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
                System.Windows.Forms.Application.Run(new Form1());
            }

            /*
            //
            // Symbolic file link bar.txt <<===>> foo.txt
            //
            string symF = "bar.txt";
            string targetF = "foo.txt";

            System.Console.WriteLine(">echo \"Hello World\" > {0}", targetF);
            StreamWriter sw = File.CreateText(targetF);
            sw.WriteLine("Hello World");
            sw.Close();
            System.Console.WriteLine();

            System.Console.WriteLine(">mklink {0} {1}", symF, targetF);
            if (mklink.CreateSymbolicLink(symF, targetF, 0))
                System.Console.WriteLine("symbolic link created for {0} <<===>> {1}", symF, targetF);
            System.Console.WriteLine();

            System.Console.WriteLine(">type {0}", targetF);
            System.Console.WriteLine(File.ReadAllText(targetF));
            System.Console.WriteLine();

            //
            // Symbolic directory link bar <<===>> foo
            //
            string symD = "bar";
            string targetD = "foo";

            System.Console.WriteLine(">mkdir {0}", targetD);
            Directory.CreateDirectory(targetD);
            System.Console.WriteLine();

            System.Console.WriteLine(">echo \"Hello World\" > {0}\\demo.txt", targetD);
            StreamWriter sw2 = File.CreateText(targetD + "\\demo.txt");
            sw2.WriteLine("Hello World");
            sw2.Close();
            System.Console.WriteLine();

            System.Console.WriteLine(">mklink /d {0} {1}", symD, targetD);

            if (mklink.CreateSymbolicLink(symD, targetD, mklink.SYMBOLIC_LINK_FLAG.Directory))
                System.Console.WriteLine("symbolic link created for {0} <<===>> {1}", symD, targetD);
            System.Console.WriteLine();

            System.Console.WriteLine(">dir {0}", targetD);
            foreach (string f in Directory.GetFiles(targetD))
                System.Console.WriteLine(f);
            */
            //bool bbb = mklink.CreateSymbolicLink(@"d:\temp", @"D:\Temp2", mklink.SYMBOLIC_LINK_FLAG.File);
            // System.Console.WriteLine(bbb);


            string strSource = $@"D:\{System.Environment.UserName.ToLowerInvariant()}\Documents\Visual Studio 2019\TFS\COR-Basic\COR-Basic\Basic";
            string strTarget = $@"D:\{System.Environment.UserName.ToLowerInvariant()}\Documents\Visual Studio 2019\Gitlab\COR-Basic\COR-Basic\Basic";


            string[] dirs = System.IO.Directory.GetDirectories(strSource, "*.*", System.IO.SearchOption.TopDirectoryOnly);


            foreach (string dir in dirs)
            {
                // string dirname = System.IO.Path.GetDirectoryName(dir);
                string dirname = new System.IO.DirectoryInfo(dir).Name;

                if (".vs".Equals(dirname, System.StringComparison.OrdinalIgnoreCase))
                    continue;


                string junctionPoint = System.IO.Path.Combine(strTarget, dirname);

                System.Console.WriteLine(junctionPoint);
                // Symlink-name, TargetName, AllowOverwrite
                FS.NTFS.JunctionPoint.Create(junctionPoint, dir, false);
            }

        } // End Sub Main


        public static void CreateUsernameAlias()
        {
            string sourceDir = System.IO.Path.Combine(@"D:\", System.Environment.UserName.ToLowerInvariant());
            string junctionPoint = System.IO.Path.Combine(@"D:\", "username");
            // Symlink-name, TargetName, AllowOverwrite
            FS.NTFS.JunctionPoint.Create(junctionPoint, sourceDir, false);
        }



    } // End Class Program


} // End Namespace mymklink
