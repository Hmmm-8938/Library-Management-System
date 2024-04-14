using Library_Management_System.Models;

namespace Library_Management_System;

public partial class CheckOutBooks : ContentPage
{
	public CheckOutBooks()
	{
		InitializeComponent();
	}
    private async void CheckOut_Clicked(object sender, EventArgs e)
    {
		string enteredUserID = CheckOutUserEntry.Text;
		bool validUserEntry = Int32.TryParse(enteredUserID, out int userResult);
        string enteredBookID = CheckOutBookEntry.Text;
        bool validBookEntry = Int32.TryParse(enteredBookID, out int bookResult);
        if (validUserEntry == false || validBookEntry == false)
        {
            await DisplayAlert("Only Numbers", "Book ID and User ID must contain only numbers", "OK");
			return;
		}
		int bookID = Convert.ToInt32(enteredBookID);
		int userID = Convert.ToInt32(enteredUserID);
        bool userIDIsValid = Database_Manager.UserExists(userID);
        if (userIDIsValid == false)
        {
            await DisplayAlert("User ID not found", "User ID was not found. Check ID and try again", "OK");
            return;
        }
        bool bookIDIsValid = Database_Manager.BookExists(bookID);
        if (bookIDIsValid == false)
        {
            await DisplayAlert("Book ID not found", "Book ID was not found. Check ID and try again", "OK");
            return;
        }
        bool successful = Database_Manager.CheckOutBook(userID, bookID);
        if (successful)
        {
            await DisplayAlert("Checkout Successful", $"Book: {bookID} successfully checked out to User: {userID}", "OK");
        }
        else
        {
            await DisplayAlert("Checkout Unsuccessful", $"Book {bookID} is not able to be checked out \n" +
                                                  $"The book may be checked out to another user \n" +
                                                  $"or check for unpaid fees for User: {userID}", "OK");
        }
        CheckOutUserEntry.Text = null;
        CheckOutBookEntry.Text = null;
    }
}