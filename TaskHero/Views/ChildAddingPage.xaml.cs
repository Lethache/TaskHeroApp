
using TaskHero.Services;

namespace TaskHero.Views;

public partial class ChildAddingPage : ContentPage
{
    private AccountManager _accountManager;
    public ChildAddingPage(AccountManager accountManager)
    {
        InitializeComponent();
        BindingContext = accountManager;
        _accountManager = accountManager;
    }


    private async void OnSaveClicked(object sender, EventArgs e)
    {
        try
        {
            if (_childName.Text == null || _childNick.Text == null)
            {
                await DisplayAlert("Error", "Fill the missing fields", "Ok");
            }
            else
            {
                _accountManager.RegisterChild(_childNick.Text,_childName.Text );
                await Shell.Current.GoToAsync(nameof(HomeScreen));
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", ex.Message, "ok");
        }
        
    }
}