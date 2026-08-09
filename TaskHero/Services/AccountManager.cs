using TaskHero.Models;

namespace TaskHero.Services;

public class AccountManager
{
    private List<Account> _accountList;
    private Account _crtAccount;

    public Account CrtAccount => _crtAccount;


    public AccountManager()
    {
        _accountList = new List<Account>
        {
            new Parent("Misha" , "12345" ),
            new Child("Alex","Dinoco" , "Misha" )
        };
    }

    public async Task Register(string login, string password)
    {

        foreach (Account account in _accountList)
        {
            if (account.Login == login)
            {
                new Exception("This login alredy exist");
                return;
            }
        }
        _accountList.Add(new Parent(login, password));
        Autorization(login, password);
    }
    public async Task RegisterChild(string childCode, string childName)
    {
        foreach (Account account in _accountList)
        {
            if (account is Child child)
            {
                if (child.ChildNickName == childCode)
                {
                    new Exception("This login alredy exist");
                    return;
                }
            }
       }
        _accountList.Add(new Child(childName , childCode,CrtAccount.Login ));
    }


    public bool Autorization(string login, string password)
    {
        foreach (Account account in _accountList)
        {
            if (account is Parent parentAccount)
            {


                if (parentAccount.Login == login && parentAccount.CheckPassword(password))
                {
                    _crtAccount = parentAccount;
                    return true;

                }
            }
        }

        return false;
    }

    public bool Autorization(string childCode)
    {
        foreach (Account account in _accountList)
        {
            if (account is Child childAccount)
            {


                if (childAccount.ChildNickName == childCode)
                {
                    _crtAccount = childAccount;
                    return true;
                }
            }
        }

        return false;
    }
    public List<Child> GetChildByParent()
    {
        List<Child> children = new List<Child>();
        foreach (Account account in _accountList)
        {
            if (account is Child child)
            {
                if (child.ParentId == _crtAccount.Login)
                {
                    children.Add(child);
                }
            }
        }
        return children;
    }


}