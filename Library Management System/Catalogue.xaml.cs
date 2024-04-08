namespace Library_Management_System;

public partial class Catalogue : ContentPage
{
    public Catalogue()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Book1Image.Source = "harry_potter_and_the_philosophers_stone_cover.jpg";
        Book1Title.Text = "Harry Potter and the Philosopher's Stone";
        Book1Author.Text = "J.K Rowling";
        Book1ISBN.Text = "1408855895";
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Book1Image.Source = "harry_potter_and_the_chamber_of_secrets_cover.jpg";
        Book1Title.Text = "Harry Potter and the Chamber of Secrets";
        Book1Author.Text = "J.K Rowling";
        Book1ISBN.Text = "1408855896";
    }
}