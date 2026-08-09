using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TaskHero.Models
{
    public class Gift : INotifyPropertyChanged
    {

        private string _giftName;
        private string _giftDescription;
        private int _giftPrice;
        private string _ownerLogin;
        private string _claimedLogin;
        private string _imagePath;

        private bool _isClaimed = false;

        public string GiftName
        {
            get => _giftName;
            set => _giftName = value;
        }
        public string GiftDescription
        {
            get => _giftDescription;
            set => _giftDescription = value;
        }
        public int GiftPrice
        {
            get => _giftPrice;
            set => _giftPrice = value;
        }
        public string OwnerLogin
        {
            get => _ownerLogin;
            set => _ownerLogin = value;
        }
        public string ClaimedLogin
        {
            get => _claimedLogin;
            set => _claimedLogin = value;
        }

        public bool IsClaimed
        {
            get => _isClaimed;
            set
            {
                _isClaimed = value;
                OnPropertyChanged(nameof(IsClaimed));
            }
        }

        public string ImagePath
        {
            get { return _imagePath; }
        }

        public Gift(string giftName, string giftDesc, string giftOwner, int giftPrice, string imagePath)
        {
            _giftName = giftName;
            _giftDescription = giftDesc;
            _giftPrice = giftPrice;
            _ownerLogin = giftOwner;
            _imagePath = imagePath;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}