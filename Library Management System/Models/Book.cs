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
        public string Author { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Isbn { get; set; }
        [Required]
        public string Cover { get; set; }
        [Required]
        public string Availability { get; set; }

        public Book()
        {

        }

        public Book(string title, string author, string description, int isbn, string cover, string availability)
        {
            Title = title;
            Author = author;
            Description = description;
            Isbn = isbn;
            Cover = cover;
            Availability = availability;
        }


    }
}
