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
        listView.IsVisible = false;
        searchEntry.Text = "";
    }
    private void Search_Clicked(object sender, EventArgs e)
    {
        string searchText = searchEntry.Text;
        List<Book> books = Database_Manager.GetBookByTitle(searchText);
        defaultPage.IsVisible = false;
        listView.IsVisible = true;
        back.IsVisible = true;
        listView.ItemsSource = books;

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
        listView.IsVisible = false;
        back.IsVisible = false;
        searchEntry.Text = "";
    }
}