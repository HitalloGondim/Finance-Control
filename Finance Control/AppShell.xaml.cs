using Finance_Control.View;

namespace Finance_Control
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ExtractPage), typeof(ExtractPage));
        }
    }
}