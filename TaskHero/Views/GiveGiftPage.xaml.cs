using TaskHero.Models;
using TaskHero.Services;

namespace TaskHero.Views;

public partial class GiveGiftPage : ContentPage
{
    private GiftManager _giftManager;
    private AccountManager _accountManager;
    public GiveGiftPage(GiftManager giftManager, AccountManager accountManager)
    {
        InitializeComponent();
        BindingContext = giftManager;
        _giftManager = giftManager;
        _accountManager = accountManager;
        _giftManager.GetGiftByOwner(_accountManager.CrtAccount.Login);

    }

    private void OnDeleteTaskClicked(object sender, EventArgs e)
    {

        if (sender is BindableObject tappedEllement)
        {
            if (tappedEllement.BindingContext is Gift clickedGift)
            {
                _giftManager.DeleteGift(clickedGift);
            }
        }

    }

    private void OnAcceptTaskClicked(object sender, EventArgs e)
    {

        if (sender is BindableObject tappedEllement)
        {
            if (tappedEllement.BindingContext is Gift clickedGift)
            {
                _giftManager.ConfirmGift(clickedGift);
            }
        }

    }
}