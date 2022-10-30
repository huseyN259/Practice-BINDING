using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Bogus;

namespace WpfApp7;

#nullable disable

public partial class MainWindow : Window
{
	public List<User> Users { get; set; }

	public MainWindow()
	{
		InitializeComponent();

		DataContext = this;

		Users = new Faker<User>()
			.RuleFor(u => u.Firstname, f => f.Person.FirstName)
			.RuleFor(u => u.Lastname, f => f.Person.LastName)
			.RuleFor(u => u.Gender, f => f.Person.Gender.ToString())
			.RuleFor(u => u.Phone, f => f.Person.Phone)
			.RuleFor(u => u.ImageUrl, f => f.Person.Avatar)
			.RuleFor(u => u.Email, f => f.Person.Email)
			.RuleFor(u => u.Address, f => f.Person.Address.City)
			.RuleFor(u => u.DateOfBirth, f => f.Person.DateOfBirth)
			.Generate(10);

		//Users.Add(new User { Firstname = "HuseynNuran" });
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		Button btn = sender as Button;
		Grid grid = btn.Parent as Grid;
		StackPanel sp = grid.Children[1] as StackPanel;
		TextBlock tb = sp.Children[0] as TextBlock;

		MessageBox.Show(tb.Text);
	}
}