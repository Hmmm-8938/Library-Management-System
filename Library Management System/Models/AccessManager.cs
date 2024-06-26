﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System;

namespace Library_Management_System.Models
{
    public class AccessManager
    {
        private static User activeUser;
        public static User ActiveUser { get { return activeUser; } }

        public AccessManager() { }

        private static void SetActiveUser(User user)
        {
            activeUser = user;
        }

        public static bool ValidateUser(int ID, string PIN)
        {
            bool valid = false;
            valid = Database_Manager.ValidateUser(ID, PIN);
            if(valid)
            {
                User activeUser = Database_Manager.GetUserById(ID);
                SetActiveUser(activeUser);
                string UserID = ID.ToString();
                var appShell = (App.Current as App).MainPage as AppShell;
                if (UserID[0] == '9')
                {
                    appShell.ShowLibrarianFeatures();
                }
                else
                {
                    appShell.ShowPatronFeatures();
                }
            }
            return valid;
        }

        public static void Logout()
        {
            var appShell = (App.Current as App).MainPage as AppShell;
            activeUser = null;
            appShell.ShowLoggedOut();
        }

    }
}
