using Library_Management_System.Models;
using System.Text.RegularExpressions;

namespace Library_Management_System;

public partial class BooksAdd : ContentPage
{
	public BooksAdd()
	{
		InitializeComponent();
	}
    private async void AddClicked(object sender, EventArgs e)
    {
        if (TitleEntry.Text == null)
        {
            try
            {
                throw new MyExceptions("MISSING BOOK TITLE");
            }

            catch (MyExceptions ex)
            {
                await DisplayAlert("Missing Book Title", "Please enter the Book Title", "OK");
            }
        }

        else if (AuthorEntry.Text == null)
        {
            try
            {
                throw new MyExceptions("MISSING BOOK AUTHOR");
            }

            catch (MyExceptions ex)
            {
                await DisplayAlert("Missing Book Author", "Please enter the Book Author", "OK");
            }
        }

        else if (ISBNEntry.Text == null)
        {
            try
            {
                throw new MyExceptions("MISSING BOOK ISBN");
            }

            catch (MyExceptions ex)
            {
                await DisplayAlert("Missing Book ISBN ", "Please enter The Book ISBN", "OK");
            }
        }

        else if (!Regex.IsMatch(ISBNEntry.Text, @"^[0-9]"))
        {
            try
            {
                throw new MyExceptions("INCORRECT ISBN FORMAT");
            }

            catch (MyExceptions ex)
            {
                await DisplayAlert("Incorrect ISBN Format ", "The Book ISBN Must Only Contain Numbers", "OK");
            }
        }

        else if (DescriptionEntry.Text == null)
        {
            try
            {
                throw new MyExceptions("MISSING BOOK DESCRIPTION");
            }

            catch (MyExceptions ex)
            {
                await DisplayAlert("Missing Book Description ", "Please enter The Book Description", "OK");
            }
        }

        else
        {

            string titleInput = TitleEntry.Text.ToUpper();
            string authorInput = AuthorEntry.Text.ToUpper();
            long ISBNInput = Int64.Parse(ISBNEntry.Text);

            string descriptionInput = DescriptionEntry.Text;

            string bookImage = "na_image.png";
            string bookAvailability = "Available";

            Book newbook = new Book(titleInput, authorInput, descriptionInput, ISBNInput, bookImage, bookAvailability);

            Database_Manager.AddBook(newbook);

            TitleEntry.Text = null;
            AuthorEntry.Text = null;
            DescriptionEntry.Text = null;
            ISBNEntry.Text = null;

            bookNotify.Text = "Book Added to Library";
        }
        
		
    }
}