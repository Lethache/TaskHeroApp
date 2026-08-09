namespace TaskHero.Views;

public partial class ParentChildPage : ContentPage
{
	public ParentChildPage()
	{
		InitializeComponent();
	}
	private async void OnParentBorderTapped(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(ParentRegisterPage));
	}
    private async void OnChildBorderTapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ChildRegisterPage));
    }
}