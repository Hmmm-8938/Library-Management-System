using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{
    class MyExceptions : Exception
    {

        public MyExceptions(string message) 
        {
            if (message == "MISSING FIRST NAME")
            {

            }

            else if (message == "MISSING LAST NAME")
            {

            }

            else if (message == "MISSING DATE OF BIRTH")
            {

            }

            else if (message == "MISSING PHONE NUMBER")
            {

            }

            else if (message == "MISSING E-MAIL ADDRESS")
            {

            }

            else if (message == "INCORRECT DOB FORMAT")
            {

            }

            else if (message == "MISSING BOOK TITLE")
            {

            }

            else if (message == "MISSING BOOK AUTHOR")
            {

            }

            else if (message == "MISSING BOOK ISBN")
            {

            }

            else if (message == "MISSING BOOK DESCRIPTION")
            {

            }
        }
    }
}
