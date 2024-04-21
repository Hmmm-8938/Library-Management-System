using Library_Management_System.Models;
using Microsoft.VisualBasic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Library_Management_System;

public partial class CreateLibraryCard : ContentPage
{
	public CreateLibraryCard()
	{
		InitializeComponent();
        
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        createNotify.Text = "";
    }

        private async void Create_User(object sender, EventArgs e)
    {   
        //Exception for missing and letter only in Names
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
        else if (!Regex.IsMatch(firstName.Text, @"^[a-zA-Z]+$"))
        {
            try
            {
                throw new MyExceptions("INCORRECT FIRST NAME FORMAT");
            }

            catch (MyExceptions ex)
            {
                await DisplayAlert("Incorrect Format For First Name", "Name must only contain letters", "OK");
            }
        }

        else if (lastName.Text == null)
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
        else if (!Regex.IsMatch(lastName.Text, @"^[a-zA-Z]+$"))
        {
            try
            {
                throw new MyExceptions("INCORRECT LAST NAME FORMAT");
            }

            catch (MyExceptions ex)
            {
                await DisplayAlert("Incorrect Format For Last Name", "Name must only contain letters", "OK");
            }
        }
        else
        {
            string firstNameInput = firstName.Text.ToUpper();

            string lastNameInput = lastName.Text.ToUpper();
            
            //Exceptions for phone Number being blank or only numbers and 10 digits long
            if (phoneNumber.Text == null)
            {
                try
                {
                    throw new MyExceptions("MISSING PHONE NUMBER");
                }

                catch (MyExceptions ex)
                {
                    await DisplayAlert("Missing Phone Number", "Please enter your Phone Number", "OK");
                }
            }
            else if (!Regex.IsMatch(phoneNumber.Text, @"(\d{3})+[-](\d{3})+[-](\d{4}$)"))
            {
                try
                {
                    throw new MyExceptions("INCORRECT PHONE NUMBER FORMAT");
                }

                catch (MyExceptions ex)
                {
                    await DisplayAlert("Incorrect Format For Phone Number", "Phone Number must contain only digits and formatted as ###-###-####", "OK");
                }
            }
            else
            {
                
                //Regex.Replace(phoneNumber.Text, @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");
                string phoneNumberInput = phoneNumber.Text;
                


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
                else if (!Regex.IsMatch(email.Text, @"[^@/s]+@[^@/s]+\.[^@/s]"))
                {
                    try
                    {
                        throw new MyExceptions("INCORRECT E-MAIL FORMAT");
                    }

                    catch (MyExceptions ex)
                    {
                        await DisplayAlert("Incorrect Format For Email", "Email must be formatted as XXXX@XXX.XXX", "OK");
                    }
                }
                else
                {
                    string emailInput = email.Text;

                    DateTime dobInput = dob.Date;
                    int userID = 0;
                    int uniqueID = 0;

                    if (studentButton.IsChecked == true)
                    {
                        uniqueID = 1;
                        userID = RandomID.CreateUserID(uniqueID);
                    }
                    else if (instructorButton.IsChecked == true)
                    {
                        uniqueID = 2;
                        userID = RandomID.CreateUserID(uniqueID);
                    }
                    else
                    {
                        uniqueID = 9;
                        userID = RandomID.CreateUserID(uniqueID);
                    }

                    string pin = RandomID.GeneratePIN(phoneNumberInput);
                    float balance = 0;
                    //User newUser = new User(userID, pin, phoneNumberInput, firstNameInput, lastNameInput, emailInput, dobInput, balance);

                    Database_Manager.AddUser(userID, pin, phoneNumberInput, firstNameInput, lastNameInput, emailInput, dobInput, balance);

                    createNotify.Text = "User Created";

                    firstName.Text = null;
                    lastName.Text = null;
                    phoneNumber.Text = null;
                    email.Text = null;


                }
            }          
        }
    }
}