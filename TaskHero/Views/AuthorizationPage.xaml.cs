using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskHero.Services;

namespace TaskHero.Views;

public partial class AuthorizationPage : ContentPage
{
    private readonly AccountManager _accountManager;
    
    
    public AuthorizationPage(AccountManager accountManager)
    {
        InitializeComponent();
        _accountManager = accountManager;
        
    }

    private async void OnLogInClicked(object? sender, EventArgs e)
    {
        string login = _loginEntry.Text;
        string password = _passwordEntry.Text;
        string childCode = _childCodeEntry.Text;

        if (login != null && password != null)
        {
            Debug.WriteLine($"login{login} , {password}");
            if (_accountManager.Autorization(login, password))
            {
              await  Shell.Current.GoToAsync("HomeScreen");
            }
            else 
            {
                DisplayAlert("Error", "Login or password is incorrect", "ok");
            }
            
        }
        else if (childCode != String.Empty)
        {
            if (_accountManager.Autorization(childCode))
            {
               await Shell.Current.GoToAsync("ChildHomePage");
            }
            else 
            {
                DisplayAlert("Error", "ChildCode is incorrect", "ok");
            }
        }

    }
}