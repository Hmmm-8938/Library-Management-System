using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    //Credit to Jaxson
    class RandomID
    {
        public static string CreateID()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var stringChar = new char[1];
            Random random = new Random();
            for (int i = 0; i < stringChar.Length; i++)
            {
                stringChar[i] = chars[random.Next(chars.Length)];
            }

            var UserID = new StringBuilder();

            UserID.Append(stringChar);
            UserID.Append(random.Next(1000, 9999));


            return UserID.ToString();
        }
    }
}
