namespace Finance_Control.View;

public partial class CadastroPage : ContentPage
{
	public CadastroPage()
	{
		InitializeComponent();
	}


    private async void ReturnPage_tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");

    }
}