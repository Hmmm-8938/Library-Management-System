using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{
    public class UserBookManager
    {
        private string connectionString;

        public UserBookManager(string connectionString)
        {
            this.connectionString = connectionString;
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
    }
}
