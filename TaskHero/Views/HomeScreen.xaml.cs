using TaskHero.Services;

namespace TaskHero.Views;

public partial class HomeScreen : ContentPage
{

	public HomeScreen(AccountManager accountManager)
	{
		InitializeComponent();
        BindingContext = accountManager;
	}

    private async void OnSetUpTaskClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SetUpTaskPage));
    }

    private async void OnSetUpGiftClicked(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SetUpGiftPage));
    }
    private async void OnGiveaGiftClicked(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(GiveGiftPage));
    }
    private async void OnCheckDoneTaskClicked(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(CheckDonePage));
       
    }

    private async void OnChangeAccountClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("AuthorizationPage");
    }
}