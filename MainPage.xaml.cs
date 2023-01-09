namespace ProStateApp2;
using MySql.Data.MySqlClient;
using static ProStateApp2.App;

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
                        GlobalVariables.CurrentUser = new User { id = Convert.ToInt32(reader.GetString(0)), name = reader.GetString(1), surname = reader.GetString(2), email = inputEmail, password = inputPassword, social_number = reader.GetString(5), birth_date = Convert.ToDateTime(reader.GetString(6)), gender= reader.GetString(7) };
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

