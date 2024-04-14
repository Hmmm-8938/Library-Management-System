using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Library_Management_System.Models
{
    public class Database_Manager
    {
        private static SQLiteConnection database;

        public Database_Manager()
        {
            database = new SQLiteConnection(Constants.DbPath);

            database.CreateTable<Book>();
            database.CreateTable<User>();
            database.CreateTable<UserBook>();
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

        public static void AddUser(User user)
        {
            database.Insert(user);
        }

        public void DeleteUser(int userId)
        {
            database.Delete<User>(userId);
        }

        public List<User> GetAllUsers()
        {
            return database.Table<User>().ToList();
        }
        //
        public void UpdateUser(User user)
        {
            database.Update(user);
        }

        public User GetUserById(int userId)
        {
            return database.Table<User>().Where(u => u.UserID == userId).FirstOrDefault();
        }

        public List<Book> GetBookByTitle(string title)
        {
            return database.Query<Book>($"SELECT * FROM Book WHERE title LIKE(%{title}%)");
        }
        public static bool RowExists(int bookID)
        {
            bool rowExists = false;
            int count = database.ExecuteScalar<int>($"SELECT COUNT(*) FROM UserBook WHERE BookID = {bookID} AND ReturnDate IS NULL;");
            if(count > 0)
            {
                rowExists = true;
            }
            return rowExists;
        }

        public static bool UserExists(int userID)
        {
            bool userExists = false;
            int count = database.ExecuteScalar<int>($"SELECT COUNT(*) FROM User WHERE UserID = {userID};");
            if (count > 0) 
            {
                userExists = true;
            }
            return userExists;
        }

        public static bool BookExists(int bookID)
        {
            bool bookExists = false;
            int count = database.ExecuteScalar<int>($"SELECT COUNT(*) FROM Book WHERE BookID = {bookID};");
            if (count > 0)
            {
                bookExists = true;
            }
            return bookExists;
        }
        public static bool CheckInBook(int bookID)
        {
            if(RowExists(bookID) == true)
            {
                DateTime returnDate = DateTime.Now;
                database.Execute($@"UPDATE UserBook SET ReturnDate = '{returnDate:yyyy-MM-dd HH:mm:ss}', DaysOverdue = ROUND((julianday('{returnDate:yyyy-MM-dd HH:mm:ss}')) - (julianday(DueDate))) WHERE BookID = {bookID} AND ReturnDate IS NULL;");
                int daysOverdue = database.ExecuteScalar<int>($"SELECT DaysOverdue FROM UserBook WHERE BookID = {bookID} AND ReturnDate = '{returnDate:yyyy-MM-dd HH:mm:ss}';");
                if (daysOverdue > 0)
                {
                    int userID = database.ExecuteScalar<int>($"SELECT UserID FROM UserBook WHERE BookID = {bookID} AND ReturnDate = '{returnDate:yyyy-MM-dd HH:mm:ss}';");
                    AddUserFees(userID, daysOverdue);
                }
                database.Execute($@"UPDATE Book SET Availability = 'Available' WHERE BookID = '{bookID}';");
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void AddUserFees(int userID, float daysOverdue)
        {
            float fee = daysOverdue * ((float)0.50);
            database.Execute($@"UPDATE User SET Balance = '{fee}' WHERE UserID = '{userID}';");

        }
        public static bool CheckOutBook(int userID, int bookID)
        {
            DateTime today = DateTime.Now;
            List<Book> hasOverdueBooks = GetUserOverdueBooks(userID);
            float userBalance = database.ExecuteScalar<float>($"SELECT Balance FROM User WHERE UserID = {userID};");
            if (userBalance > 0 || hasOverdueBooks.Count > 0 )
            {
                return false;
            }
            else
            {
                int daysToBorrow = 28;
                string userIDString = userID.ToString();
                if (userIDString[0] == '1')
                {
                    daysToBorrow = 14;
                }
                DateTime dueDate = today.AddDays(daysToBorrow);
                UserBook userBook = new UserBook(userID, bookID, today, dueDate);
                database.Execute($@"INSERT INTO USERBOOK (UserID, BookID, CheckOutDate, DueDate) VALUES ('{userID}', '{bookID}', '{today:yyyy-MM-dd HH:mm:ss}', '{dueDate:yyyy-MM-dd HH:mm:ss}');");
                //database.Insert(userBook);
                database.Execute($@"UPDATE Book SET Availability = 'Unavailable' WHERE BookID = '{bookID}';");
                return true;
            }
        }
        public static List<Book> GetCheckedOutBooks()
        {
            List<Book> checkedOutBooks = database.Query<Book>($@"SELECT Book.* FROM UserBook JOIN Book Using (BookID) WHERE ReturnDate IS NULL;");
            //did we need to return user info too?
            return checkedOutBooks;
        }
        public static List<Book> GetUserCheckedOutBooks(int userID)
        {
            List<Book> checkedOutBooks = database.Query<Book>($@"SELECT Book.* FROM UserBook JOIN Book Using (BookID) JOIN User Using(UserID) WHERE UserID = '{userID}' AND ReturnDate IS NULL;");
            return checkedOutBooks;
        }
        public static List<Book> GetUserOverdueBooks(int userID)
        {
            List<Book> overdueBooks = database.Query<Book>($@"SELECT Book.* FROM UserBook JOIN Book Using(BookID) JOIN User Using(UserID) WHERE UserID = '{userID}' AND ReturnDate IS NULL AND (julianday('now') - julianday('DueDate') > 0);");
            return overdueBooks;
        }
        public static bool ValidateUser(int userID, string pin)
        {
            bool userValid = false;
            int count = database.ExecuteScalar<int>($"SELECT COUNT(*) FROM User WHERE UserID = '{userID}' AND PIN = '{pin}';");
            if (count > 0)
            {
                userValid = true;
            }
            return userValid;
        }
    }
}
