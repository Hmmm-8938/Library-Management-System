using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{
    public class Instructor : User
    {
        public Instructor(string phoneNumber, string firstName, string lastName, string email, DateTime dOB) : base(phoneNumber, firstName, lastName, email, dOB)
        {
            this.UserID = NewInstructorId();
        }
        public int NewInstructorId()
        {
            //Sequential or random 14 digit ID starting with 29065
            return 0;
        }
        public override string ToString()
        {
            return $"Instructor Details:\nLibrary Card Number: {UserID}, Fees: ${Balance}, " + base.ToString();
        }
    }
}
