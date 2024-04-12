namespace Library_Management_System;

public partial class CreateLibraryCard : ContentPage
{
	public CreateLibraryCard()
	{
		InitializeComponent();
	}

    private void Create_User(object sender, EventArgs e)
    {
		//string userID = GetUserID();
		//int PIN = GetPin();
		string phoneNumberInput = phoneNumber.Text;
		string firstNameInput = firstName.Text;
		string lastNameInput = lastName.Text;
		string emailInput = email.Text;
		//Make a TryParse for exception handling
		DateOnly dobInput = DateOnly.ParseExact(dob.Text, "yyyy/MM/dd", null);
    }
}