using TaskHero.Models;
using TaskHero.Services;

namespace TaskHero.Views;

public partial class CheckDonePage : ContentPage
{
    private TaskManager _taskManager;
    private AccountManager _accountManager;
    public CheckDonePage(TaskManager taskManager, AccountManager accountManager)
    {
        InitializeComponent();
        BindingContext = taskManager;
        _taskManager = taskManager;
        _accountManager = accountManager;
        _taskManager.GetTaskByOwner(_accountManager.CrtAccount.Login);

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

    private void OnDeleteTaskClicked(object sender, EventArgs e)
    {

        if (sender is BindableObject tappedEllement)
        {
            if (tappedEllement.BindingContext is Tasks clickedTask)
            {
                _taskManager.DeleteTask(clickedTask);
            }
        }

    }

    private void OnAcceptTaskClicked(object sender, EventArgs e)
    {

        if (sender is BindableObject tappedEllement)
        {
            if (tappedEllement.BindingContext is Tasks clickedTask)
            {
                _taskManager.ConfirmTask(clickedTask);
            }
        }

    }

    private void OnRejectTaskClicked(object sender, EventArgs e)
    {

        if (sender is BindableObject tappedEllement)
        {
            if (tappedEllement.BindingContext is Tasks clickedTask)
            {
                _taskManager.RejectTask(clickedTask);
            }
        }

    }
}