using System.Data.Entity;
using Library_Management_System.Models;

namespace Library_Management_System;

public partial class BooksAvailable : ContentPage
{
	public BooksAvailable()
	{
		InitializeComponent();

        List<Book> bookList = Database_Manager.GetBooksAvailable();
        AvailableList.ItemsSource = bookList;
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        List<Book> bookList = Database_Manager.GetBooksAvailable();
        AvailableList.ItemsSource = bookList;
    }

}