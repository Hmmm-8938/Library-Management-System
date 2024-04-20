using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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

            else if (message == "INCORRECT FIRST NAME FORMAT")
            {

            }

            else if (message == "INCORRECT LAST NAME FORMAT")
            {

            }

            else if (message == "MISSING PHONE NUMBER")
            {

            }

            else if (message == "INCORRECT PHONE NUMBER FORMAT")
            {

            }

            else if (message == "MISSING E-MAIL ADDRESS")
            {

            }

            else if (message == "INCORRECT E-MAIL ADDRESS")
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

            else if (message == "INCORRECT ISBN FORMAT")
            {

            }

            else if (message == "MISSING BOOK DESCRIPTION")
            {

            }
        }
    }
}
