using Finance_Control.View;

namespace Finance_Control;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    async private void OnTapExtrato(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ExtractPage));
    }

    /*async private void AddTransation_Tapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(TransactionPage));
    }*/
}