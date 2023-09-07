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
        await Shell.Current.GoToAsync(nameof(NewPage1));
    }

}