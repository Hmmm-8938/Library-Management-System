using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Library_Management_System
{
    public class Database_Manager
    {
        private SQLiteConnection database;

        public Database_Manager()
        {
            this.database = new SQLiteConnection(Constants.DbPath);

            this.database.CreateTable<Book>();
            // Define some for users

        }

        public void AddBook(Book book)
        {
            this.database.Insert(book);
        }

        public void DeleteBook(int bookId)
        {
            this.database.Delete<Book>(bookId);
        }

        public List<Book> GetAllBooks()
        {
            return this.database.Table<Book>().ToList();
        }

        public void UpdateBook(Book book)
        {
            this.database.Update(book);
        }

        public Book GetBookById(int bookId)
        {
            return this.database.Table<Book>().Where(b => b.BookId == bookId).FirstOrDefault();
        }

        public List<Book> GetBookByTitle(string title)
        {
            return this.database.Query<Book>($"SELECT * FROM Book WHERE title LIKE(%{title}%)");
        }

    }
}
