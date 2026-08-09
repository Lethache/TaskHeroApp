using System.ComponentModel;

namespace TaskHero.Models;

public class Account : INotifyPropertyChanged
{
    protected string _login;
    protected AccessType _accessType;

    public string Login
    {
        get => _login;
        set => _login = value ?? throw new ArgumentNullException(nameof(value));
    }

    public AccessType AccessType
    {
        get => _accessType;
        set => _accessType = value;
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged(string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}