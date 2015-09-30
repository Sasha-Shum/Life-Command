using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainScreen
{
    class Singleton
    {
        public static string relativeDirectory = Environment.CurrentDirectory;
        public static string connectionStringGlobal = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + relativeDirectory + "\\LifeCommandDb.mdf;Integrated Security=True";
    }
}
