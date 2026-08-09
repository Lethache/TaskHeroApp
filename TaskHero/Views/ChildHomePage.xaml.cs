using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskHero.Models;
using TaskHero.Services;

namespace TaskHero.Views;

public partial class ChildHomePage : ContentPage
{
    TaskManager _taskManager;
    AccountManager _accountManager;

    public Child CurrentAccount { get; set; }
    public ObservableCollection<Tasks> CrtTask { get; set; }
    public ChildHomePage(TaskManager taskManager, AccountManager accountManager)
    {
        InitializeComponent();
        _taskManager = taskManager;
        _accountManager = accountManager;
        

        if (_accountManager.CrtAccount is Child crtChild)
        {
            taskManager.GetTaskByChildren(crtChild.ChildNickName);
            CurrentAccount = crtChild;
        }

        CrtTask = _taskManager.CrtTask;
        BindingContext = this;
    }

    private void OnToggleExpand(object sender, TappedEventArgs e)
    {

        if (sender is BindableObject tappedEllement)
        {
            if (tappedEllement.BindingContext is Tasks clickedTask)
            {
                clickedTask.IsExpanded = !clickedTask.IsExpanded;
            }
        }

    }

    private void OnDoneTaskClicked(object sender, EventArgs e)
    {

        if (sender is BindableObject tappedEllement)
        {
            if (tappedEllement.BindingContext is Tasks clickedTask)
            {
                _taskManager.CompleteTask(clickedTask);
                CrtTask = _taskManager.CrtTask;
            }
        }

    }

    private async void OnChangeAccountClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("AuthorizationPage");
    }
}