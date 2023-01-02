namespace ProStateApp2;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private async void Login_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("HomePage");
    }
}

