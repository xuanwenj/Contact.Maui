namespace Contact.Maui.Properties.Views;

public partial class EditContactPage : ContentPage
{
	public EditContactPage()
	{
		InitializeComponent();
	}
    private void btnCancel_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    //". ." means going back to parent page == ($"{nameof(,,,)}") this is absolute path
            }
}