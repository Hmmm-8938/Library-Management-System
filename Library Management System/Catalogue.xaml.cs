using Library_Management_System.Models;
using System.Diagnostics.CodeAnalysis;
using System.Web;

namespace Library_Management_System;

public partial class Catalogue : ContentPage
{
    public Catalogue()
    {
        InitializeComponent();
        Database_Manager database = new Database_Manager();
        List<Book> books2 = Database_Manager.GetAllBooks();
        defaultPage.ItemsSource = books2;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (AccessManager.ActiveUser != null)
        {
            loginbtn.Text = "Logout";
        }
        else
        {
            loginbtn.Text = "Login";
        }
        defaultPage.IsVisible = true;
        searchPage.IsVisible = false;
        searchEntry.Text = "";
    }
    private void Search_Clicked(object sender, EventArgs e)
    {
        string searchText = searchEntry.Text;
        List<Book> books = Database_Manager.GetBookByTitle(searchText);
        defaultPage.IsVisible = false;
        searchPage.IsVisible = true;
        back.IsVisible = true;
        searchPage.ItemsSource = books;

    }

    private void Login_Clicked(object sender, EventArgs e)
    {
        if (AccessManager.ActiveUser != null)
        {
            AccessManager.Logout();
            loginbtn.Text = "Login";
            return;
        }
        Shell.Current.GoToAsync(nameof(Login));
    }

    private void back_Clicked(object sender, EventArgs e)
    {
        defaultPage.IsVisible = true;
        searchPage.IsVisible = false;
        back.IsVisible = false;
        searchEntry.Text = "";
    }

    private void PlaceHold_Clicked(object sender, EventArgs e)
    {
        // Need this to change the Availability of the book to On Hold and then refresh the catalogue page
    }
}