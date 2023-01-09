using static ProStateApp2.App;

namespace ProStateApp2;

public partial class Profile : ContentPage
{
	public Profile()
	{
		InitializeComponent();

		NameLabel.Text = GlobalVariables.CurrentUser.name + " " + GlobalVariables.CurrentUser.surname;

		EmailLabel.Text = GlobalVariables.CurrentUser.email;

		DateTime BirthDate = GlobalVariables.CurrentUser.birth_date;

		string BirthDateString = BirthDate.ToString("dd/MM/yyyy");

		BirthDateLabel.Text = BirthDateString;

        string Gender = GlobalVariables.CurrentUser.gender;
		string GenderString;

        if (Gender == "male")
        {
            GenderString = "Vīrietis";
            GenderIcon.Source = "male_user.png"; 
        }
        else if (Gender == "female")
        {
            GenderString = "Sieviete";
            GenderIcon.Source = "female_user.png";
        }
        else
        {
            GenderString = "Nezinu";
            GenderIcon.Source = "question_mark.png";
        }

        GenderLabel.Text = GenderString;
    }

    private void Edit_Clicked(object sender, EventArgs e)
    {

    }
}