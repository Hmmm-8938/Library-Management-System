using Library_Management_System.Models;
namespace Library_Management_System;

public partial class PayFees : ContentPage
{
    private User User { get; set; }
	public PayFees()
	{
		InitializeComponent();
	}

    private async void SearchBalance_Clicked(object sender, EventArgs e)
    {
        string userIDString = userEntry.Text;
        bool validUserEntry = Int32.TryParse(userIDString, out int userResult);
        if (validUserEntry == false)
        {
            await DisplayAlert("Only Numbers", "User ID must contain only numbers", "OK");
            return;
        }
        int userID = Convert.ToInt32(userIDString);
        bool userIDIsValid = Database_Manager.UserExists(userID);
        if (userIDIsValid == false)
        {
            await DisplayAlert("User ID not found", "User ID was not found. Check ID and try again", "OK");
            return;
        }
        User = Database_Manager.GetUserById(userID);
        float balance = User.Balance;
        if (balance > 0) 
        {
            displayBalance.Text = $"User Balance is: ${balance}0";
            ClearFees.IsVisible = true;
            SearchBalance.IsVisible = false;
        } 
        else
        {
            displayBalance.Text = $"User Balance is: $0.00";
            Reset.IsVisible = true;
            SearchBalance.IsVisible = false;
        }

    }
    private void ClearFees_Clicked(object sender, EventArgs e)
    {
        User.Balance = 0;
        Database_Manager.UpdateUser(User);
        displayBalance.Text = $"User Balance is: $0.00";
        ClearFees.IsVisible = false;
        Reset.IsVisible = true;
    }

    private void Reset_Clicked(object sender, EventArgs e)
    {
        userEntry.Text = "";
        displayBalance.Text = "";
        SearchBalance.IsVisible = true;
        ClearFees.IsVisible = false;
        Reset.IsVisible = false;

    }
}