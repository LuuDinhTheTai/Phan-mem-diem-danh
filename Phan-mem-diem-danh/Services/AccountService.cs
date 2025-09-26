using Phan_mem_diem_danh.Database.Entities;

namespace Phan_mem_diem_danh.Services;

public class AccountService
{
    public AccountService(Configuration configuration)
    {
        
    }

    private static AccountService? _instance = new AccountService();
    public Account? CurrentAccount { get; private set; }

    private AccountService() { }

    public static AccountService Instance => _instance; 

    public void SetAccount(Account account)
    {
            CurrentAccount = account;
    }
    
}