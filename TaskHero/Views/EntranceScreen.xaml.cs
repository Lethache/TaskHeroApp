namespace TaskHero.Views;

public partial class EntranceScreen : ContentPage
{
	public EntranceScreen()
	{
		InitializeComponent();
	}

    private async void OnStartButtonClicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("ParentChildPage");
    }

    private async void OnAuthorizationClicked(object? sender, EventArgs e)
    {
	    await Shell.Current.GoToAsync("AuthorizationPage");
    }
}