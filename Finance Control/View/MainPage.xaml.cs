using Finance_Control.View;

namespace Finance_Control;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
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