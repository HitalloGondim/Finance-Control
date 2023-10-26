using Finance_Control.View;
using Finance_Control.ViewModel;
using SQLiteDataAcessLibrary.Services;

namespace Finance_Control;

public partial class MainPage : ContentPage
{
    private readonly TransactionService _transactionService;

    public MainPage(TransactionService service)
    {
        InitializeComponent();
        _transactionService = service;
        BindingContext = new MainPageViewModel(_transactionService);
    }

    private async void Extract_tapped(object sender, EventArgs e)
    {
        //await Shell.Current.GoToAsync(nameof(ExtractPage));
        await Shell.Current.GoToAsync(nameof(CadastroPage));
    }

    private async void XMark_tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(XMarkPopUpPage));


    }

    private void AddTransaction_tapped(object sender, EventArgs e)
    {
       // transaction.IsVisible = true;


    }


}