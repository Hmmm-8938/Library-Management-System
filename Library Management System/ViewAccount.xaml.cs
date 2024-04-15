using Library_Management_System.Models;

namespace Library_Management_System;

public partial class ViewAccount : ContentPage
{
	public ViewAccount()
	{
		InitializeComponent();
		if (AccessManager.ActiveUser != null)
		{
            string accountFirstName = AccessManager.ActiveUser.FirstName;
			string accountLastName = AccessManager.ActiveUser.LastName;
			string accountCardNum = AccessManager.ActiveUser.UserID.ToString();

            accountName.Text = $"Account: {accountFirstName} {accountLastName}";
			accountCard.Text = $"Library Card #: {accountCardNum}";
        }
        


    }

	

}