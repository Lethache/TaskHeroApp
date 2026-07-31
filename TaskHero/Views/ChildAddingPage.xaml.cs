namespace TaskHero.Views;

public partial class ChildAddingPage : ContentPage
{
	public ChildAddingPage()
	{
		InitializeComponent();
	}
    

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(HomeScreen));
    }
}