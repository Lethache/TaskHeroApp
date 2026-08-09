using TaskHero.Models;
using TaskHero.Services;

namespace TaskHero.Views;

public partial class ParentRegisterPage : ContentPage
{
    private AccountManager _accountManager;
    public ParentRegisterPage(AccountManager accountManager)
	{
		InitializeComponent();
        _accountManager = accountManager;
	}

    private async void OnSaveClicked(object sender, EventArgs e)
    {
		if(_login.Text == null || _password.Text == null)
        {
            await DisplayAlert("Error", "Fill the missing fields", "Ok");
        }
        else
        {
            _accountManager.Register(_login.Text, _password.Text);
            await Shell.Current.GoToAsync("ChildAddingPage");
        }
		
    }
}