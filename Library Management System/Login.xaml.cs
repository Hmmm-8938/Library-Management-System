using Library_Management_System.Models;

namespace Library_Management_System;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void LoginBtn2_Clicked(object sender, EventArgs e)
    {
        if (AccessManager.ActiveUser == null) 
        {
            string userIDString = UserIDEntry.Text;
            string pin = PINEntry.Text;
            bool validUserEntry = Int32.TryParse(userIDString, out int userResult);
            bool validPINEntry = Int32.TryParse(pin, out int pinResult);
            if (validUserEntry == false || validPINEntry == false)
            {
                CheckOutMsg.Text = "User ID and PIN must contain only numbers";
                return;
            }
            int userID = Convert.ToInt32(userIDString);
            bool validUser = AccessManager.ValidateUser(userID, pin);
            if (validUser == false)
            {
                CheckOutMsg.Text = "Invalid Credentials";
            }
            else
            {
                Shell.Current.GoToAsync(nameof(Catalogue));
                Catalogue.updateLogin($"Logout: {userID}");
            }
        }
        else
        {
            AccessManager.Logout();
            Catalogue.updateLogin("Login");
        }
    }
}