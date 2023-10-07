namespace Finance_Control.View;

public partial class XMarkPopUpPage : ContentPage
{
	public XMarkPopUpPage()
	{
		InitializeComponent();
	}


	private async void ReturnPage_tapped(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("..");
	}

    private async void AddTransaction_tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
        await Shell.Current.GoToAsync(nameof(CadastroPage));
    }





}