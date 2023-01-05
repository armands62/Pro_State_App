namespace ProStateApp2;
using MySql.Data.MySqlClient;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();

    }

    private void Login_Clicked(object sender, EventArgs e)
    {
        string connectionString = "server=192.168.1.198;user=armands;database=pro_state;password=qwerty;";
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            string inputEmail = EpastsEntry.Text;
            string inputPassword = ParoleEntry.Text;
            using (var command = new MySqlCommand($"SELECT * FROM user WHERE email = \"{inputEmail}\"", connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string password = reader.GetString(4);
                    if (BCrypt.Net.BCrypt.Verify(inputPassword, password))
                    {
                        Application.Current.MainPage = new AppShell();
                    }
                    else
                    {
                      Error.IsVisible = true;
                    }
                }
            }
        }
    }
}

