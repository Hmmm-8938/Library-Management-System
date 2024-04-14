using Library_Management_System.Models;

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

        if (AuthorEntry.Text == null)
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

        if (ISBNEntry.Text == null)
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

        if (DescriptionEntry.Text == null)
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

        string titleInput = TitleEntry.Text;
        string authorInput = AuthorEntry.Text;
        string ISBNInput = ISBNEntry.Text;

        if (TitleEntry.Text != null)
        {
            titleInput = TitleEntry.Text.ToUpper();
        }

        
        if (AuthorEntry.Text != null)
        {
            authorInput = AuthorEntry.Text.ToUpper();
        }

        if (ISBNEntry.Text != null)
        {
            Int32.Parse(ISBNInput);
        }

        string descriptionInput = DescriptionEntry.Text;

        if (TitleEntry.Text != null && AuthorEntry.Text != null && ISBNEntry.Text != null && DescriptionEntry != null)
        {
            string bookImage = "na_image.png";
            string bookAvailability = "Available";

            Book newbook = new Book(titleInput, authorInput, descriptionInput, Int32.Parse(ISBNInput), bookImage, bookAvailability);

            Database_Manager.AddBook(newbook);

            TitleEntry.Text = null;
            AuthorEntry.Text = null;
            DescriptionEntry.Text = null;
            ISBNEntry.Text = null;

            bookNotify.Text = "Book Added to Library";

        } 
		
    }
}