namespace TaskHero.Models;

public class Account
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
}