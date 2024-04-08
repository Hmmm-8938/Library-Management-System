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
        }
    }
}
