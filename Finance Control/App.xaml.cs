using SQLiteDataAcessLibrary.Services;

namespace Finance_Control
{
    public partial class App : Application
    {
        public App(ITransactionService transactionService)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage(transactionService));
        }
    }
}