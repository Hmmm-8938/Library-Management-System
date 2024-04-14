using Library_Management_System.Models;
using Microsoft.VisualBasic;
using System.Globalization;

namespace Library_Management_System;

public partial class CreateLibraryCard : ContentPage
{
	public CreateLibraryCard()
	{
		InitializeComponent();
	}

    private async void Create_User(object sender, EventArgs e)
    {
		if (firstName.Text == null)
		{
			try
			{
				throw new MyExceptions("MISSING FIRST NAME");
			}

			catch (MyExceptions ex)
			{
				await DisplayAlert("Missing First Name", "Please enter your First Name", "OK");
			}
		}

        if (lastName.Text == null)
        {
            try
            {
                throw new MyExceptions("MISSING LAST NAME");
            }

            catch (MyExceptions ex)
            {
                await DisplayAlert("Missing Last Name", "Please enter your Last Name", "OK");
            }
        }

        if (dob.Text == null)
        {
            try
            {
                throw new MyExceptions("MISSING DATE OF BIRTH NAME");
            }

            catch (MyExceptions ex)
            {
                await DisplayAlert("Missing Date of Birth", "Please enter your Date of Birth", "OK");
            }
        }

        if (phoneNumber.Text == null)
        {
            try
            {
                throw new MyExceptions("MISSING PHONE NUMBER NAME");
            }

            catch (MyExceptions ex)
            {
                await DisplayAlert("Missing Phone Number Name", "Please enter your Phone Number", "OK");
            }
        }

        if (email.Text == null)
        {
            try
            {
                throw new MyExceptions("MISSING E-MAIL ADDRESS");
            }

            catch (MyExceptions ex)
            {
                await DisplayAlert("Missing E-mail Address", "Please enter your E-mail Address", "OK");
            }
        }

        //int userID = GetUserID();
        //string PIN = GetPin();
        int userID = 1000000;
		string PIN = "1111";
		string phoneNumberInput = phoneNumber.Text;

        string firstNameInput = firstName.Text;
        if (firstNameInput != null)
        {
            firstNameInput = firstName.Text.ToUpper();
        }

        string lastNameInput = lastName.Text;

        if (lastNameInput != null)
        {
            lastNameInput = firstName.Text.ToUpper();
        }
        string emailInput = email.Text;


        //Make a TryParse for exception handling
        CultureInfo culture = new CultureInfo("en-US");
        string dobIn = dob.Text;
        DateTime d;
        if (dob.Text != null)
        {
            if (DateTime.TryParseExact(dobIn, "yyyy/MM/dd", culture, DateTimeStyles.None, out d))
            {
                DateTime dobInput = DateTime.ParseExact(dobIn, "yyyy/MM/dd", culture);
                User newUser = new User(userID, PIN, phoneNumberInput, firstNameInput, lastNameInput, emailInput, dobInput);
            }
            else
            {
                try
                {
                    throw new MyExceptions("INCORRECT DOB FORMAT");
                }
                catch (MyExceptions ex)
                {
                    await DisplayAlert("Incorrect Date of Birth Format", "Please enter your Date of Birth in the format (yyyy/mm/dd)", "OK");
                }

            }
        }
        
        
    }
}