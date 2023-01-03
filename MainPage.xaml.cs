namespace ProStateApp2;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void Login_Clicked(object sender, EventArgs e)
    {
		Application.Current.MainPage = new AppShell();
    }
}

