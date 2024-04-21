using Library_Management_System.Models;

namespace Library_Management_System;

public partial class BooksOverdue : ContentPage
{
	public BooksOverdue()
	{
		InitializeComponent();

        List<Book> bookList = Database_Manager.GetBooksOverdue();
        OverdueList.ItemsSource = bookList;
    }
}