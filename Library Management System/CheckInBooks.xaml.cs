using Library_Management_System.Models;
using System.Net;

namespace Library_Management_System;

public partial class CheckInBooks : ContentPage
{
	public CheckInBooks()
	{
		InitializeComponent();
	}

    private void CheckIn_Clicked(object sender, EventArgs e)
    {
		string entry = CheckInEntry.Text;
		bool validEntry = Int32.TryParse(entry, out int result);
		if (validEntry)
		{
			int bookID = Convert.ToInt32(entry);
            bool successful = Database_Manager.CheckInBook(bookID);
			if (successful)
			{
				CheckInMsg.Text = "Check In was successful";
			}
			else
			{
				CheckInMsg.Text = "Check In unsuccessful. Book not found. Please check Book ID and try again.";
			}
        }
		else
		{
			CheckInMsg.Text = "Book ID not valid. Please enter only numbers.";
		}
		
    }
}