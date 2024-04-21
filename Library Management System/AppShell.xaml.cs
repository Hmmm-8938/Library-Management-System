namespace Library_Management_System
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("Catalogue", typeof(Catalogue));
            Routing.RegisterRoute("CheckInBooks", typeof(CheckInBooks));
            Routing.RegisterRoute("CheckOutBooks", typeof(CheckOutBooks));
            Routing.RegisterRoute("CreateLibraryCard", typeof(CreateLibraryCard));
            Routing.RegisterRoute("PayFees", typeof(PayFees));
            Routing.RegisterRoute("BooksCheckedOut", typeof(BooksCheckedOut));
            Routing.RegisterRoute("BooksAvailable", typeof(BooksAvailable));
            Routing.RegisterRoute("BooksOnHold", typeof(BooksOnHold));
            Routing.RegisterRoute("BooksOverdue", typeof(BooksOverdue));
            Routing.RegisterRoute("BooksAdd", typeof(BooksAdd));
            Routing.RegisterRoute("Login", typeof(Login));
            Routing.RegisterRoute("UserView", typeof(UserView));

        }

        public void ShowLoggedOut()
        {
            cLibCard.IsVisible = false;
            checkInOut.IsVisible = false;
            payFees.IsVisible = false;
            libFunctions.IsVisible = false;
            viewAccount.IsVisible = false;
        }
        public void ShowLibrarianFeatures()
        {
            cLibCard.IsVisible = true;
            checkInOut.IsVisible = true;
            payFees.IsVisible = true;
            libFunctions.IsVisible = true;
            viewAccount.IsVisible = true;
        }
        public void ShowPatronFeatures()
        {
            viewAccount.IsVisible = true;
        }
    }
}
