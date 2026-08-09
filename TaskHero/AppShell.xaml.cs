using TaskHero.Views;

namespace TaskHero
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("ParentChildPage", typeof(ParentChildPage));
            Routing.RegisterRoute("ChildAddingPage", typeof(ChildAddingPage));
            Routing.RegisterRoute("ChildRegisterPage", typeof(ChildRegisterPage));
            Routing.RegisterRoute("HomeScreen", typeof(HomeScreen));
            Routing.RegisterRoute("AuthorizationPage", typeof(AuthorizationPage));
            Routing.RegisterRoute("ChildHomePage" , typeof(ChildHomePage));
            Routing.RegisterRoute("SetUpTaskPage", typeof(SetUpTaskPage));
            Routing.RegisterRoute("CheckDonePage", typeof(CheckDonePage));
            Routing.RegisterRoute("SetUpGiftPage", typeof(SetUpGiftPage));
            Routing.RegisterRoute("SetUpGiftPage", typeof(SetUpGiftPage));
            Routing.RegisterRoute("GiveGiftPage", typeof(GiveGiftPage));
            Routing.RegisterRoute("ParentRegisterPage", typeof(ParentRegisterPage));
            Routing.RegisterRoute("ChildHomePage", typeof(ChildHomePage));
        }
    }
}
