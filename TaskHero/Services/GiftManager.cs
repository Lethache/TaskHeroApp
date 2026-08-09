using System.Collections.ObjectModel;
using System.ComponentModel;
using TaskHero.Models;

namespace TaskHero.Services
{
    public class GiftManager : INotifyPropertyChanged
    {
        private ObservableCollection<Gift> _giftList = new ObservableCollection<Gift>();
        private ObservableCollection<Gift> _crtGift = new ObservableCollection<Gift>();

        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<Gift> CrtGift
        {
            get { return _crtGift; }
        }
        public GiftManager()
        {
            _giftList = new ObservableCollection<Gift>
            {
                new Gift("PlayStation 5", "the most desired gift", "Misha" , 0, "play_station.jpg")
            };

        }

        public void AddGift(Gift gift)
        {
            _giftList.Add(gift);
        }
        public void GetGiftByOwner(string owner)
        {
            _crtGift.Clear();
            if (_giftList.Count > 0)
            {
                foreach (Gift gift in _giftList)
                {
                    if (gift.OwnerLogin == owner)
                    {
                        _crtGift.Add(gift);
                    }
                }

            }


        }

        public void ClaimGift(Gift gift)
        {
            gift.IsClaimed = true;
        }

        public void ConfirmGift(Gift gift)
        {
            //adding a reward
            DeleteGift(gift);
        }

        public void DeleteGift(Gift gift)
        {
            _giftList.Remove(gift);
            _crtGift.Remove(gift);
        }

        private void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}