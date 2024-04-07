using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{
    public class UserManager
    {
        private string connectionString;

        public UserManager(string connectionString)
        {
            this.connectionString = connectionString;
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
        }
    }
}
