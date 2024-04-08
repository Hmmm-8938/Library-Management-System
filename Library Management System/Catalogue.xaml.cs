namespace Library_Management_System;

public partial class Catalogue : ContentPage
{
    public Catalogue()
    {
        InitializeComponent();
        Book1Image.Source = "harry_potter_and_the_philosophers_stone_cover.jpg";
        Book1Title.Text = "Title: Harry Potter and the Philosophers Stone";
        Book1Author.Text = "Author: J.K Rowling";
        Book1ISBN.Text = "ISBN: 1408855895";
        //Book2Image.Source = "harry_potter_and_the_chamber_of_secrets_cover.jpg";
        //Book2Title.Text = "Title: Harry Potter and the Chamber of Secrets";
        //Book2Author.Text = "Author: J.K Rowling";
        //Book2ISBN.Text = "ISBN: 1408855896";
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        
    }
}