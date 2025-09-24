using Phan_mem_diem_danh;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Configuration configuration = new Configuration();
        Application.Run(configuration.LoginScreen);
    }
}