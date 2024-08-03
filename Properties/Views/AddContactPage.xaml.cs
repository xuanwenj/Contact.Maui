namespace Contact.Maui.Properties.Views;

public partial class AddContactPage : ContentPage
{
	public AddContactPage()
	{
		InitializeComponent();
	}

    private void BtnCanel_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(ContactPage));

    }
}