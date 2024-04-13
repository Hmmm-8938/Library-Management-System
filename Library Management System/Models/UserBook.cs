using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Library_Management_System
{
    public class UserBook
    {
        [PrimaryKey, AutoIncrement]
        public int Reference { get; set; }

        [Required]
        public int UserID { get; set; }

        [Required]
        public int BookID { get; set; }

        [Required]
        public DateTime CheckOutDate { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        public int? DaysOverdue { get; set; }

        public UserBook() { }
        public UserBook(int userID, int bookID, DateTime checkOutDate, DateTime dueDate)
        {
            this.UserID = userID;
            this.BookID = bookID;
            this.CheckOutDate = checkOutDate;
            this.DueDate = dueDate;
        }
        public UserBook(int reference, int userID, int bookID, DateTime checkOutDate, DateTime dueDate, DateTime returnDate, int daysOverdue)
        {
            this.Reference = reference;
            this.UserID = userID;
            this.BookID = bookID;
            this.CheckOutDate = checkOutDate;
            this.DueDate = dueDate;
            this.ReturnDate = returnDate;
            this.DaysOverdue = daysOverdue;
        }
    }
}
