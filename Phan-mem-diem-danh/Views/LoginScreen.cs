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

        var account = _configuration.AuthService.Login(msv, password);
        
    }
}