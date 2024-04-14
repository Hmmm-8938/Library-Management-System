namespace Library_Management_System
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("CatalogueSearchResults", typeof(CatalogueSearchResults));
            Routing.RegisterRoute("CheckInBooks", typeof(CheckInBooks));
            Routing.RegisterRoute("CheckOutBooks", typeof(CheckOutBooks));
            Routing.RegisterRoute("CreateLibraryCard", typeof(CreateLibraryCard));
            Routing.RegisterRoute("BooksCheckedOut", typeof(BooksCheckedOut));
            Routing.RegisterRoute("BooksAvailable", typeof(BooksAvailable));
            Routing.RegisterRoute("BooksOnHold", typeof(BooksOnHold));
            Routing.RegisterRoute("BooksOverdue", typeof(BooksOverdue));
            Routing.RegisterRoute("BooksAdd", typeof(BooksAdd));
            Routing.RegisterRoute("Login", typeof(Login));
        }
    }
}
