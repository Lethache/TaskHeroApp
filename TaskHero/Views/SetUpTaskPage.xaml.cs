using System.Collections.ObjectModel;
using TaskHero.Models;
using TaskHero.Services;

namespace TaskHero.Views;

public partial class SetUpTaskPage : ContentPage
{
	private TaskManager _taskmanager;
	private AccountManager _accountmanager;
	public string TaskName
	{
		get;
		set;
	}
	public string TaskDescription { get; set; }
	public string TaskReward { get; set; }
	public string ChildTarget { get; set; }
	private ObservableCollection<string> _childName = new ObservableCollection<string>();
	private Dictionary<string, string> _childDictionary = new Dictionary<string, string>();
	
	public ObservableCollection<string> ChildName
	{
		get { return _childName; }
	}
	public SetUpTaskPage(TaskManager taskManager, AccountManager accountmanager)
	{
		InitializeComponent();
		BindingContext = this;
		_taskmanager = taskManager;
		_accountmanager = accountmanager;

		foreach (Child child in _accountmanager.GetChildByParent())
		{
			_childDictionary.Add(child.ChildName, child.ChildNickName);
			_childName.Add(child.ChildName);
		}
	}

    private async void OnSaveClicked(object sender, EventArgs e)
    {
		if (TaskDescription == null || TaskName == null || TaskReward == null || ChildTarget == null)
		{
			await DisplayAlert("Error", "Fill all the fields ", "Ok");
		}

		else
		{
			_taskmanager.AddTask(new Tasks(TaskName, TaskDescription, _accountmanager.CrtAccount.Login, _childDictionary[ChildTarget]));
			await Shell.Current.GoToAsync("CheckDonePage");
		}
    }
	
}