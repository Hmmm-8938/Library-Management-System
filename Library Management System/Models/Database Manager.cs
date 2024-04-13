﻿using System;
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
        public static bool CheckInBook(int bookID)
        {
            if(RowExists(bookID) == true)
            {
                DateTime returnDate = DateTime.Now;
                database.UpdateAll($"UPDATE UserBook SET ReturnDate = {returnDate} AND DaysOverdue = ROUND(julianday({returnDate}) - julianday(DueDate)) WHERE BookID = {bookID} AND ReturnDate IS NULL;");
                int daysOverdue = database.ExecuteScalar<int>($"SELECT DaysOverdue FROM UserBook WHERE BookID = {bookID} AND ReturnDate = {returnDate};");
                if (daysOverdue > 0)
                {
                    int userID = database.ExecuteScalar<int>($"SELECT UserID FROM UserBook WHERE BookID = {bookID} AND ReturnDate = {returnDate};");
                    AddUserFees(userID, daysOverdue);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void AddUserFees(int userID, int daysOverdue)
        {

        }
        public static bool CheckOutBook(int userID, int bookID)
        {
            DateTime today = DateTime.Now;
            List<Book> hasOverdueBooks = GetUserOverdueBooks(userID);
            float userBalance = database.ExecuteScalar<float>($"SELECT Balance FROM User WHERE UserID = {userID};");
            if (userBalance > 0 || hasOverdueBooks != null )
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
                database.Insert(userBook);
                //ChangeBookStatus(bookID);
                return true;
            }
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
            //if (hasCheckedOutBooks == true)
            //{
            //    DateTime dueDate = database.ExecuteScalar<DateTime>($"SELECT DueDate FROM UserBook WHERE BookID = {bookID} AND ReturnDate IS NULL;");
            //    daysOverdue = (today - dueDate).TotalDays;
            //}
            return null;
        }

        //public void AddUser(int userID, string PIN, string phoneNumber, string firstName, string lastName, string email, DateOnly dOB, float balance)
        //{
        //    //can we do user here instead of three separate adds?
        //    //add to user table in db
        //}
        //public void RemoveUser(int userID)
        //{
        //    //remove user from table in db
        //}
        //public void UpdateUser(int userID, string phoneNumber, string firstName, string lastName, string email, float Balance)
        //{
        //    //update in db- i think balance would only have to be here if we don't implement the fee table which might be easier to keep track of
        //}
        //public List<User> GetAllUsers()
        //{
        //    //create/return list of all users from db
        //    return null;
        //}
        //public List<User> SearchUsers(string searchValue)
        //{
        //    //search db table and add to/return list
        //    //first name, last name, userID
        //    return null;
        //}
    }
}