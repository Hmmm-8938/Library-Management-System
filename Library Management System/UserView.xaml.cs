using Library_Management_System.Models;

namespace Library_Management_System;

public partial class UserView : ContentPage
{
	public UserView()
	{
		InitializeComponent();

        List<User> UsersList = Database_Manager.GetUsers();
        UserList.ItemsSource = UsersList;
    }
}