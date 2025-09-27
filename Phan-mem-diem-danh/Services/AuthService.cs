using Phan_mem_diem_danh.Database.Entities;

namespace Phan_mem_diem_danh.Services;

public class AuthService
{   
    private readonly Configuration _configuration;
    public AuthService(Configuration configuration) 
    {
        _configuration = configuration;
    }

    public Account? Login(string msv, string password)
    {
        Account? account = _configuration.AccountRepository.FindByMSVAndPassword(msv, password);

        if (account != null && account.AccountRoles.Any())
        {
            AuthService authService = _configuration.AuthService;

            if (authService.CheckRole(account, "Teacher"))
            {
                MessageBox.Show("Bạn đăng nhập với vai trò Giáo viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return account;
            }
            else if (authService.CheckRole(account, "Student"))
            {
                MessageBox.Show("Bạn đăng nhập với vai trò Sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return account;
            }

            return account;
        }
        else if (account == null)

            if (string.IsNullOrWhiteSpace(msv) && string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            else if (string.IsNullOrWhiteSpace(msv))
            {
                MessageBox.Show("Vui lòng nhập msv.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }

            else if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            
            else MessageBox.Show("Mã sinh viên hoặc mật khẩu không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
    }
  
    public bool CheckRole(Account account, string roleName)
    {
        if (account == null || account.AccountRoles == null)
            return false;

        return account.AccountRoles.Any(role => role.Name.Equals(roleName, StringComparison.OrdinalIgnoreCase));
    }
}