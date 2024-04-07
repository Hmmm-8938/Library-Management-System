using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{
    public class BookManager
    {
        private string connectionString;
        public BookManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddBook(int bookID, int ISBN, string title, string author, string availability, string location)
        {
            //add new book to database
        }
        public void UpdateBook(int bookID, int ISBN, string title, string author, string availability, string location)
        {
            //update book to database (cannot change book iD? or we can and add antoher parameter for new id)
        }
        public void DeleteBook(int bookID)
        {
            //remove from db
        }
        public List<Book> GetAllBooks()
        {
            //get all books from db and add/return list
            return null;
        }
        public List<Book> GetOverdueBooks() 
        {
            //get overdue books from db and add/return list
            return null;
        }
        public void CheckInBook(int bookID)
        {
            //change availability in db to available (book table)
        }
        public void CheckOutBook(int bookID)
        {
            //change availability in db to unavailable (book table)
        }
        public List<Book> SearchForBook(string searchText)
        {
            //needs to check for location that is selected on screen and filter by location if applicable
            //search book table for matches from filter text first by Book title, then by author... are we doing by anything else?
            return null;
        }
    }
}
