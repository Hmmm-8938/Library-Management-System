using Library_Management_System.Models;

namespace Library_Management_System;

public partial class BooksCheckedOut : ContentPage
{
	public BooksCheckedOut()
	{
		InitializeComponent();

        List<Book> bookList = Database_Manager.GetBooksCheckedOut();
        CheckedOutList.ItemsSource = bookList;
	}
}