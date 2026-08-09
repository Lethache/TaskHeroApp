using TaskHero.Models;
using TaskHero.Services;

namespace TaskHero.Views;

public partial class SetUpGiftPage : ContentPage
{
    private GiftManager _giftManager;
    private AccountManager _accountmanager;

    public string GiftName { get; set; }
    public string GiftDescription { get; set; }
    public int GiftCost { get; set; }

    private string _selectedImagePath;
    public string SelectedImagePath
    {
        get => _selectedImagePath;
        set
        {
            if (_selectedImagePath != value)
            {
                _selectedImagePath = value;


                OnPropertyChanged(nameof(SelectedImagePath));
                OnPropertyChanged(nameof(HasImage));
            }
        }
    }

    public bool HasImage => !string.IsNullOrEmpty(SelectedImagePath);

    public SetUpGiftPage(GiftManager giftManager, AccountManager accountmanager)
    {
        InitializeComponent();
        _giftManager = giftManager;
        _accountmanager = accountmanager;

        BindingContext = this;
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(GiftDescription) || string.IsNullOrWhiteSpace(GiftName))
        {
            await DisplayAlert("Error", "Fill all the fields ", "Ok");
        }
        else
        {
            _giftManager.AddGift(new Gift(GiftName, GiftDescription, _accountmanager.CrtAccount.Login, GiftCost, SelectedImagePath));
            await Shell.Current.GoToAsync("GiveGiftPage");
        }
    }

    private async Task PickImageAsync()
    {
        try
        {
            FileResult photo = await MediaPicker.Default.PickPhotoAsync();

            if (photo != null)
            {
                SelectedImagePath = photo.FullPath;
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", "Failed to select photo: " + ex.Message, "ОК");
        }
    }


    private async void OnChooseImage(object sender, EventArgs e)
    {
        await PickImageAsync();
    }
}