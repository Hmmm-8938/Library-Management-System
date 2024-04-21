using Library_Management_System.Models;

namespace Library_Management_System;

public partial class BooksOnHold : ContentPage
{
	public BooksOnHold()
	{
		InitializeComponent();

        List<Book> bookList = Database_Manager.GetBooksOnHold();
        OnHoldList.ItemsSource = bookList;
    }
}