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
        }
    }
}
