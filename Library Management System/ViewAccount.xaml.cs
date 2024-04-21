//using Contacts;
using Library_Management_System.Models;
using Microsoft.Maui.ApplicationModel.Communication;
using System.Text.RegularExpressions;

namespace Library_Management_System;

public partial class ViewAccount : ContentPage
{
    public ViewAccount()
    {
        InitializeComponent();

    }
    protected override void OnAppearing()
    {
        base.OnAppearing();

        int accountCardNum = AccessManager.ActiveUser.UserID;
        string accountPIN = AccessManager.ActiveUser.PIN;
        string accountPhoneNumber = AccessManager.ActiveUser.PhoneNumber;
        string accountFirstName = AccessManager.ActiveUser.FirstName;
        string accountLastName = AccessManager.ActiveUser.LastName;
        string accountEmail = AccessManager.ActiveUser.Email;
        DateTime accountDate = AccessManager.ActiveUser.DOB;

        firstNameChange.Text = accountFirstName;
        lastNameChange.Text = accountLastName;
        phoneNumberChange.Text = accountPhoneNumber;
        emailChange.Text = accountEmail;


        accountName.Text = $"Account: {accountFirstName} {accountLastName}";
        accountCard.Text = $"Library Card #: {accountCardNum}";
        List<Book> UserCOBookList = Database_Manager.GetUserCheckedOutBooks(accountCardNum);
        UserCheckedOutList.ItemsSource = UserCOBookList;
        List<Book> UserODBookList = Database_Manager.GetUserCheckedOutBooks(accountCardNum);
        UserOverdueList.ItemsSource = UserODBookList;

        updateNotify.Text = "";

    }

    private async void Update_User(object sender, EventArgs e)
    {

        int accountCardNum = AccessManager.ActiveUser.UserID;
        string accountPIN = AccessManager.ActiveUser.PIN;
        string accountPhoneNumber = AccessManager.ActiveUser.PhoneNumber;
        string accountFirstName = AccessManager.ActiveUser.FirstName;
        string accountLastName = AccessManager.ActiveUser.LastName;
        string accountEmail = AccessManager.ActiveUser.Email;
        DateTime accountDate = AccessManager.ActiveUser.DOB;
        float accountBalance = AccessManager.ActiveUser.Balance;

        //Exception for missing and letter only in Names
        if (firstNameChange.Text == null)
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
        else if (!Regex.IsMatch(firstNameChange.Text, @"^[a-zA-Z]+$"))
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

        else if (lastNameChange.Text == null)
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
        else if (!Regex.IsMatch(lastNameChange.Text, @"^[a-zA-Z]+$"))
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
            string firstNameInput = firstNameChange.Text.ToUpper();

            string lastNameInput = lastNameChange.Text.ToUpper();

            if (emailChange.Text == null)
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
            else if (!Regex.IsMatch(emailChange.Text, @"[^@/s]+@[^@/s]+\.[^@/s]"))
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
                string emailInput = emailChange.Text;

                //Exceptions for phone Number being blank or only numbers and 10 digits long
                if (phoneNumberChange.Text == null)
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
                else if (!Regex.IsMatch(phoneNumberChange.Text, @"(\d{3})+[-](\d{3})+[-](\d{4}$)"))
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
                    string phoneNumberInput = phoneNumberChange.Text;

                    Database_Manager.UpdateUserInfo(accountCardNum, accountPIN, phoneNumberInput, firstNameInput, lastNameInput, emailInput, accountDate, accountBalance);

                    updateNotify.Text = "Information has been updated";

                }
            }
        }
    }
}