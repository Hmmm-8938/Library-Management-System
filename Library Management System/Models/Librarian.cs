using Library_Management_System.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{
    public class Librarian : User
    {
        public float Balance { get; set; }

        public Librarian(string phoneNumber, string firstName, string lastName, string email, DateOnly dOB) : base(phoneNumber, firstName, lastName, email, dOB)
        {
            this.UserID = NewLibrarianId();
        }

        public int NewLibrarianId()
        {
            ////Sequential or random 14 digit ID starting with 99065
            return 0;
        }

        public override string ToString()
        {
            return $"Librarian Details:\nEmployee ID: {UserID}, " + base.ToString();
        }
    }
}
