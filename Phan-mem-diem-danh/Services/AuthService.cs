using Phan_mem_diem_danh.Database.Entities;

namespace Phan_mem_diem_danh.Services;

public class AuthService
{
    public AuthService(Configuration configuration) 
    {
        
    }
    public bool CheckRole(Account account, string roleName)
    {
        if (account == null || account.AccountRoles == null)
            return false;

        return account.AccountRoles.Any(role => role.Name.Equals(roleName, StringComparison.OrdinalIgnoreCase));
    }
}