
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskHero.Services;

namespace TaskHero.Views;

public partial class ChildHomePage : ContentPage
{
    private TaskManager _taskManager;
    private AccountManager _accountManager;
    public ChildHomePage(TaskManager taskManager, AccountManager accountManager)
    {
        InitializeComponent();
        BindingContext = taskManager;
        _taskManager = taskManager;
        _accountManager = accountManager;
        _taskManager.GetTaskByChildren(_accountManager.CrtAccount.Login);

    }

    private void OnToggleExpand(object sender, TappedEventArgs e)
    {

    }
}