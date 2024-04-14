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
            return Database_Manager.ValidateUser(ID, PIN);
        }

        public void Logout()
        {
            activeUser = null;
        }
    }
}
