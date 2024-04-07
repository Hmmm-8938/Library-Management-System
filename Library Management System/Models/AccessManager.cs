using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{
    public class AccessManager
    {
        private User activeUser;
        public User ActiveUser { get { return activeUser; } }

        public AccessManager() { }

        private void SetActiveUser(User user)
        {
            activeUser = user;
        }

        public bool ValidateUser(int ID, string PIN)
        {
            //checks database for match
            //if user is valid, sets active user and returns true
            //if user is not valid return false
            return false;
        }

        public void Logout()
        {
            activeUser = null;
        }
    }
}
