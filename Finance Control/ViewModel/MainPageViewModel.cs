using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SQLiteDataAcessLibrary.Models;
using SQLiteDataAcessLibrary.Services;

namespace Finance_Control.ViewModel;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    private List<Transaction> _transactions;

    [ObservableProperty]
    private Transaction _currentTransaction;

    public AsyncRelayCommand AddTransaction { get; set; }
    public AsyncRelayCommand UpdateTransaction { get; set; }
    public AsyncRelayCommand DeleteTransaction { get; set; }
    public AsyncRelayCommand DisplayTransaction { get; set; }

    public MainPageViewModel(TransactionService context)
    {
        CurrentTransaction = new Transaction();
        AddTransaction = new AsyncRelayCommand(async () =>
        {
            await context.InitializeAsync();
            await context.AddTransaction(CurrentTransaction);
            await Refresh(context);
        });

        UpdateTransaction = new AsyncRelayCommand(async () =>
        {
            await context.InitializeAsync();
            await context.UpdateTransaction(CurrentTransaction);
            await Refresh(context);
        });


        DeleteTransaction = new AsyncRelayCommand(async () =>
        {
            await context.InitializeAsync();
            await context.DeleteTransaction(CurrentTransaction);
            await Refresh(context);
        });


        DisplayTransaction = new AsyncRelayCommand(async () =>
        {
            await context.InitializeAsync();
            await Refresh(context);
        });
    }

    private async Task Refresh(TransactionService transaction)
    {
        Transactions = await transaction.GetTransactions();
    }


}
