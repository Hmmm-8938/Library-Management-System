using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Library_Management_System.Models
{
    public class Database_Manager
    {
        private SQLiteConnection database;

        public Database_Manager()
        {
            database = new SQLiteConnection(Constants.DbPath);

            database.CreateTable<Book>();
            database.CreateTable<User>();
            // Define some for users
        }

        public void AddBook(Book book)
        {
            database.Insert(book);
        }

        public void DeleteBook(int bookId)
        {
            database.Delete<Book>(bookId);
        }

        public List<Book> GetAllBooks()
        {
            return database.Table<Book>().ToList();
        }

        public void UpdateBook(Book book)
        {
            database.Update(book);
        }

        public Book GetBookById(int bookId)
        {
            return database.Table<Book>().Where(b => b.BookId == bookId).FirstOrDefault();
        }

        public List<Book> GetBookByTitle(string title)
        {
            return database.Query<Book>($"SELECT * FROM Book WHERE title LIKE(%{title}%)");
        }

        public void CheckInBook(int userID, int bookID)
        {
            //check if book is in table
            //if it is, remove row from table and call BookManager.CheckInBook to change book status
            //decide it something happens with fees as well
        }
        public void CheckOutBook(int userID, int bookID)
        {
            //checks if user has any fees- if they do, cannot check out book (potentially also if they have overdue books)
            //checks if user is student or instructor
            //if student, duedate will be +14 days
            //if instructor duedate will be +28 days
            //adds user ID, book ID and duedate to bridge table
            //calls BookManager.CheckOutBook to change status
        }
        public List<Book> GetCheckedOutBooks()
        {
            //search db and add/return list of books in bridge table
            //join to other tables in sql query to get info on book and user?
            return null;
        }
        public List<Book> GetUserCheckedOutBooks(int userID)
        {
            //return all books in table with matching userID
            return null;
        }
        public List<Book> GetUserOverdueBooks(int userID)
        {
            //return all overdue books in table with matching userID
            return null;
        }

        public void AddUser(int userID, string PIN, string phoneNumber, string firstName, string lastName, string email, DateOnly dOB, float balance)
        {
            //can we do user here instead of three separate adds?
            //add to user table in db
        }
        public void RemoveUser(int userID)
        {
            //remove user from table in db
        }
        public void UpdateUser(int userID, string phoneNumber, string firstName, string lastName, string email, float Balance)
        {
            //update in db- i think balance would only have to be here if we don't implement the fee table which might be easier to keep track of
        }
        public List<User> GetAllUsers()
        {
            //create/return list of all users from db
            return null;
        }
        public List<User> SearchUsers(string searchValue)
        {
            //search db table and add to/return list
            //first name, last name, userID
            return null;
        }
    }
}
