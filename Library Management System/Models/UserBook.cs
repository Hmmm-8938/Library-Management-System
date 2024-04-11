using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.ComponentModel.DataAnnotations;

namespace Library_Management_System
{
    class UserBook
    {
        [Required]
        [PrimaryKey, AutoIncrement]
        public int Reference { get; set; }
        [Required]
        public int BookId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public string CheckOutDate { get; set; }
        [Required]
        public string DueDate { get; set; }
    }
}
