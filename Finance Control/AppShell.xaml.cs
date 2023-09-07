using Finance_Control.View;

namespace Finance_Control
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(NewPage1), typeof(NewPage1));
        }
    }
}