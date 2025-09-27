using Phan_mem_diem_danh.Database.Entities;

namespace Phan_mem_diem_danh.Views;

public partial class StudentFormScreen : Form
{
    public void StudentFormScreen_Load(object sender, EventArgs e)
    {

    }

    public StudentFormScreen(Configuration configurationt)
    {
        InitializeComponent();
    }

    private void StudentFormScreen_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }
}