using Library_Management_System.Models;
using System.Net;

namespace Library_Management_System;

public partial class CheckInBooks : ContentPage
{
	public CheckInBooks()
	{
		InitializeComponent();
	}

    private async void CheckIn_Clicked(object sender, EventArgs e)
    {
		string entry = CheckInEntry.Text;
		bool validEntry = Int32.TryParse(entry, out int result);
		if (validEntry)
		{
			int bookID = Convert.ToInt32(entry);
            bool successful = Database_Manager.CheckInBook(bookID);
			if (successful)
			{
				await DisplayAlert("Successful Check-In", "Book was successfully checked in!", "OK");
			}
			else
			{
				await DisplayAlert("Check-In Unseccessful", $"Book {bookID} was not found. Please check Book ID and try again", "OK");
			}
        }
		else
		{
			await DisplayAlert("Invalid Book ID", "The provided book ID is not valid. Please use only numbers and try again", "OK");
		}
		
    }
}