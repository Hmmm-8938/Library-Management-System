using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Constants
    {
        public const string DatabaseFilename = "Library.db3";

        public static string DbPath =>
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
        @"..\..\..\..\..\", DatabaseFilename);

        public Constants()
        {
            
        }
    }
}
