
using System.Collections.ObjectModel;
using TaskHero.Models;
using TaskHero.Services;

namespace TaskHero.Views;

public partial class ChildGiftShopPage : ContentPage
{
    private GiftManager _giftManager;
    private AccountManager _accountManager;

    public Child CurrentAccount { get; set; }
    public ObservableCollection<Gift> CrtGift { get; set; }

    public ChildGiftShopPage(GiftManager giftManager, AccountManager accountManager)
    {
        InitializeComponent();
        _giftManager = giftManager;
        _accountManager = accountManager;
        if (_accountManager.CrtAccount is Child child)
        {
            _giftManager.GetGiftByOwner(child.ParentId);
            CurrentAccount = child;
        }

        CrtGift = giftManager.CrtGift;

        BindingContext = this;
    }

    private async void OnClaimGiftClicked(object sender, EventArgs e)
    {

        if (sender is BindableObject tappedEllement)
        {
            if (tappedEllement.BindingContext is Gift clickedGift)
            {
                if (CurrentAccount.ChildBalance >= clickedGift.GiftPrice)
                {
                _giftManager.ClaimGift(clickedGift);
                    CurrentAccount.ChildBalance -= clickedGift.GiftPrice;
                }
                else
                {
                    await DisplayAlert("Error", "you broke", "ok");
                }
               
            }
        }

    }
}