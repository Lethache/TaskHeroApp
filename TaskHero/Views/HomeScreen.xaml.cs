namespace TaskHero.Views;

public partial class HomeScreen : ContentPage
{
	public HomeScreen()
	{
		InitializeComponent();
	}

    private async void OnSetUpTaskClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ChildAddingPage));
    }

    private void OnSetUpTaskClicked(object sender, TappedEventArgs e)
    {

    }
    private void OnGiveaGiftClicked(object sender, TappedEventArgs e)
    {
        
    }
    private void OnCheckDoneTaskClicked(object sender, TappedEventArgs e)
    {

    }
}