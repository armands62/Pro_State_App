namespace ProStateApp2;

public partial class App : Application
{
    public App()
	{
		InitializeComponent();


		MainPage = new MainPage();

	}

    public static class GlobalVariables
    {
        public static User CurrentUser { get; set; }
    }
}
