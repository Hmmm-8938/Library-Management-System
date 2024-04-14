using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    class RandomID
    {
        //This function generates an ID after given a starting number
        public static int CreateUserID(int StartId)
        {
            //Declare Variables
            var IdCode = new StringBuilder();
            var random = new Random();

            //Add first number then generate random ID
            IdCode.Append(StartId.ToString());
            IdCode.Append(random.Next(1000, 9999));

            //Convert to int
            int IdCodeInt = Convert.ToInt32(IdCode.ToString());

            return IdCodeInt;
        }
    }
}
