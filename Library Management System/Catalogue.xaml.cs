using Library_Management_System.Models;

namespace Library_Management_System;

public partial class Catalogue : ContentPage
{
    public Catalogue()
    {
        InitializeComponent();

        Database_Manager database = new Database_Manager();

        Book1Image.Source = "harry_potter_and_the_philosophers_stone_cover.jpg";
        Book1Title.Text = "Title: Harry Potter and the Philosophers Stone";
        Book1Author.Text = "Author: J.K Rowling";
        Book1ISBN.Text = "ISBN: 1408855895";
        Book2Image.Source = "harry_potter_and_the_chamber_of_secrets_cover.jpg";
        Book2Title.Text = "Title: Harry Potter and the Chamber of Secrets";
        Book2Author.Text = "Author: J.K Rowling";
        Book2ISBN.Text = "ISBN: 1408855666";
        Book3Image.Source = "harry_potter_and_the_prisoner_of_azkaban_cover.jpg";
        Book3Title.Text = "Title: Harry Potter and the Prisoner of Azkaban";
        Book3Author.Text = "Author: J.K Rowling";
        Book3ISBN.Text = "ISBN: 1408855674";
        Book4Image.Source = "harry_potter_and_the_goblet_of_fire_cover.jpg";
        Book4Title.Text = "Title: Harry Potter and the Goblet of Fire";
        Book4Author.Text = "Author: J.K Rowling";
        Book4ISBN.Text = "ISBN: 1408855682";
        Book5Image.Source = "harry_potter_and_the_order_of_the_phoenix_cover.jpg";
        Book5Title.Text = "Title: Harry Potter and the Order of The Phoenix";
        Book5Author.Text = "Author: J.K Rowling";
        Book5ISBN.Text = "ISBN: 1408855690";
        Book6Image.Source = "harry_potter_and_the_half_blood_prince_cover.jpg";
        Book6Title.Text = "Harry Potter and the Half Blood Prince";
        Book6Author.Text = "Author: J.K Rowling";
        Book6ISBN.Text = "ISBN: 1408855706";
        Book7Image.Source = "harry_potter_and_the_deathly_hallows_cover.jpg";
        Book7Title.Text = "Harry Potter and the Deathly Hallows";
        Book7Author.Text = "Author: J.K Rowling";
        Book7ISBN.Text = "ISBN: 1408855712";

        Book21Image.Source = "harry_potter_and_the_philosophers_stone_cover.jpg";
        Book21Title.Text = "Title: Harry Potter and the Philosophers Stone";
        Book21Author.Text = "Author: J.K Rowling";
        Book21ISBN.Text = "ISBN: 1408855895";
        Book22Image.Source = "harry_potter_and_the_chamber_of_secrets_cover.jpg";
        Book22Title.Text = "Title: Harry Potter and the Chamber of Secrets";
        Book22Author.Text = "Author: J.K Rowling";
        Book22ISBN.Text = "ISBN: 1408855666";
        Book23Image.Source = "harry_potter_and_the_prisoner_of_azkaban_cover.jpg";
        Book23Title.Text = "Title: Harry Potter and the Prisoner of Azkaban";
        Book23Author.Text = "Author: J.K Rowling";
        Book23ISBN.Text = "ISBN: 1408855674";
        Book24Image.Source = "harry_potter_and_the_goblet_of_fire_cover.jpg";
        Book24Title.Text = "Title: Harry Potter and the Goblet of Fire";
        Book24Author.Text = "Author: J.K Rowling";
        Book24ISBN.Text = "ISBN: 1408855682";
        Book25Image.Source = "harry_potter_and_the_order_of_the_phoenix_cover.jpg";
        Book25Title.Text = "Title: Harry Potter and the Order of The Phoenix";
        Book25Author.Text = "Author: J.K Rowling";
        Book25ISBN.Text = "ISBN: 1408855690";
        Book26Image.Source = "harry_potter_and_the_half_blood_prince_cover.jpg";
        Book26Title.Text = "Title: Harry Potter and the Half Blood Prince";
        Book26Author.Text = "Author: J.K Rowling";
        Book26ISBN.Text = "ISBN: 1408855706";
        Book27Image.Source = "harry_potter_and_the_deathly_hallows_cover.jpg";
        Book27Title.Text = "Title: Harry Potter and the Deathly Hallows";
        Book27Author.Text = "Author: J.K Rowling";
        Book27ISBN.Text = "ISBN: 1408855712";

        Book31Image.Source = "harry_potter_and_the_philosophers_stone_cover.jpg";
        Book31Title.Text = "Title: Harry Potter and the Philosophers Stone";
        Book31Author.Text = "Author: J.K Rowling";
        Book31ISBN.Text = "ISBN: 1408855895";
        Book32Image.Source = "harry_potter_and_the_chamber_of_secrets_cover.jpg";
        Book32Title.Text = "Title: Harry Potter and the Chamber of Secrets";
        Book32Author.Text = "Author: J.K Rowling";
        Book32ISBN.Text = "ISBN: 1408855666";
        Book33Image.Source = "harry_potter_and_the_prisoner_of_azkaban_cover.jpg";
        Book33Title.Text = "Title: Harry Potter and the Prisoner of Azkaban";
        Book33Author.Text = "Author: J.K Rowling";
        Book33ISBN.Text = "ISBN: 1408855674";
        Book34Image.Source = "harry_potter_and_the_goblet_of_fire_cover.jpg";
        Book34Title.Text = "Title: Harry Potter and the Goblet of Fire";
        Book34Author.Text = "Author: J.K Rowling";
        Book34ISBN.Text = "ISBN: 1408855682";
        Book35Image.Source = "harry_potter_and_the_order_of_the_phoenix_cover.jpg";
        Book35Title.Text = "Title: Harry Potter and the Order of The Phoenix";
        Book35Author.Text = "Author: J.K Rowling";
        Book35ISBN.Text = "ISBN: 1408855690";
        Book36Image.Source = "harry_potter_and_the_half_blood_prince_cover.jpg";
        Book36Title.Text = "Title: Harry Potter and the Half Blood Prince";
        Book36Author.Text = "Author: J.K Rowling";
        Book36ISBN.Text = "ISBN: 1408855706";
        Book37Image.Source = "harry_potter_and_the_deathly_hallows_cover.jpg";
        Book37Title.Text = "Title: Harry Potter and the Deathly Hallows";
        Book37Author.Text = "Author: J.K Rowling";
        Book37ISBN.Text = "ISBN: 1408855712";

        Book41Image.Source = "harry_potter_and_the_philosophers_stone_cover.jpg";
        Book41Title.Text = "Title: Harry Potter and the Philosophers Stone";
        Book41Author.Text = "Author: J.K Rowling";
        Book41ISBN.Text = "ISBN: 1408855895";
        Book42Image.Source = "harry_potter_and_the_chamber_of_secrets_cover.jpg";
        Book42Title.Text = "Title: Harry Potter and the Chamber of Secrets";
        Book42Author.Text = "Author: J.K Rowling";
        Book42ISBN.Text = "ISBN: 1408855666";
        Book43Image.Source = "harry_potter_and_the_prisoner_of_azkaban_cover.jpg";
        Book43Title.Text = "Title: Harry Potter and the Prisoner of Azkaban";
        Book43Author.Text = "Author: J.K Rowling";
        Book43ISBN.Text = "ISBN: 1408855674";
        Book44Image.Source = "harry_potter_and_the_goblet_of_fire_cover.jpg";
        Book44Title.Text = "Title: Harry Potter and the Goblet of Fire";
        Book44Author.Text = "Author: J.K Rowling";
        Book44ISBN.Text = "ISBN: 1408855682";
        Book45Image.Source = "harry_potter_and_the_order_of_the_phoenix_cover.jpg";
        Book45Title.Text = "Title: Harry Potter and the Order of The Phoenix";
        Book45Author.Text = "Author: J.K Rowling";
        Book45ISBN.Text = "ISBN: 1408855690";
        Book46Image.Source = "harry_potter_and_the_half_blood_prince_cover.jpg";
        Book46Title.Text = "Title: Harry Potter and the Half Blood Prince";
        Book46Author.Text = "Author: J.K Rowling";
        Book46ISBN.Text = "ISBN: 1408855706";
        Book47Image.Source = "harry_potter_and_the_deathly_hallows_cover.jpg";
        Book47Title.Text = "Title: Harry Potter and the Deathly Hallows";
        Book47Author.Text = "Author: J.K Rowling";
        Book47ISBN.Text = "ISBN: 1408855712";
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        
    }
}