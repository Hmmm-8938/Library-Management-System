using Library_Management_System.Models;

namespace Library_Management_System;

public partial class CheckOutBooks : ContentPage
{
	public CheckOutBooks()
	{
		InitializeComponent();
	}
    private void CheckOut_Clicked(object sender, EventArgs e)
    {
		string enteredUserID = CheckOutUserEntry.Text;
		bool validUserEntry = Int32.TryParse(enteredUserID, out int userResult);
        string enteredBookID = CheckOutBookEntry.Text;
        bool validBookEntry = Int32.TryParse(enteredBookID, out int bookResult);
        if (validUserEntry == false || validBookEntry == false)
		{
			CheckOutMsg.Text = "Book ID and User ID must contain only numbers";
			return;
		}
		int bookID = Convert.ToInt32(enteredBookID);
		int userID = Convert.ToInt32(enteredUserID);
        //bool userIDIsValid = Database_Manager.validUser();
        //if (userIDIsValid == false)
        //{
        //	CheckOutMsg.Text = "User ID not found";
        //	return;
        //}
        //bool bookIDIsValid = Database_Manager.validBook();
        //if (bookIDIsValid == false)
        //{
        //    CheckOutMsg.Text = "Book ID not found";
        //    return;
        //}
        bool successful = Database_Manager.CheckOutBook(userID, bookID);
        if (successful)
        {
            CheckOutMsg.Text = $"{bookID} successfully checked out to User: {userID}";
        }
        else
        {
            CheckOutMsg.Text = $"Checkout unsuccessful. Check for overdue books and/or unpaid fees for User: {userID}";
        }
    }
}