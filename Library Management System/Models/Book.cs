using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.ComponentModel.DataAnnotations;

namespace Library_Management_System.Models
{
    public class Book
    {
        [Required]
        [PrimaryKey, AutoIncrement]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string author { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public int isbn { get; set; }
        [Required]
        public string cover { get; set; }

        public Book()
        {

        }


    }
}
