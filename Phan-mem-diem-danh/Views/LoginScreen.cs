using System.Configuration;
using System.Drawing.Text;
using Phan_mem_diem_danh.Services;

namespace Phan_mem_diem_danh.Views;

public partial class LoginScreen : Form
{
    private readonly Configuration _configuration;
    public LoginScreen(Configuration configuration)
    {
        _configuration = configuration;
        InitializeComponent();
    }

    private void LoginScreen_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        string msv = txtMSV.Text.Trim();
        string password = txtPassword.Text.Trim();

        var account = _configuration.AccountRepository.Login(msv, password);

        if (account != null && account.AccountRoles.Any())
        {

            AuthService authService = _configuration.AuthService;

            if (authService.CheckRole(account, "Teacher"))
            {
                MessageBox.Show("Bạn đăng nhập với vai trò Giáo viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (authService.CheckRole(account, "Student"))
            {
                MessageBox.Show("Bạn đăng nhập với vai trò Sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AccountService.Instance.SetAccount(account);
                StudentFormScreen studentFormScreen = new StudentFormScreen(_configuration, AccountService.Instance.CurrentAccount);
                studentFormScreen.Show();
                this.Hide();

            }
        }
        else
        {
            MessageBox.Show("Sai tài khoản hoặc mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}