using Library_Management_System.Models;
namespace Library_Management_System;

public partial class CatalogueSearchResults : ContentPage
{
	public CatalogueSearchResults()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (AccessManager.ActiveUser != null)
        {
            loginbtnSearch.Text = "Logout";
        }
        else
        {
            loginbtnSearch.Text = "Login";
        }

    }

    private void searchBtnSearch_Clicked(object sender, EventArgs e)
    {

    }

    private void LoginSearch_Clicked(object sender, EventArgs e)
    {

    }
}