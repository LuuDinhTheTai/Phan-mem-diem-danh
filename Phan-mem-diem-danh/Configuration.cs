using Phan_mem_diem_danh.Database.Repositories;
using Phan_mem_diem_danh.Services;
using Phan_mem_diem_danh.Views;

namespace Phan_mem_diem_danh;

public class Configuration
{
    public readonly AccountClassRepository AccountClassRepository;
    public readonly AccountRepository AccountRepository;
    public readonly AttendanceRepository AttendanceRepository;
    public readonly ClassRepository ClassRepository;
    public readonly RoleRepository RoleRepository;
        
    public readonly AccountService AccountService;
    public readonly AttendanceService AttendanceService;
    public readonly AuthService AuthService;
    public readonly ClassService ClassService;
        
    public readonly ClassFormScreen ClassFormScreen;
    public readonly ClassListScreen ClassListScreen;
    public readonly LoginScreen LoginScreen;
    public readonly SettingScreen SettingScreen;
    public readonly StudentFormScreen StudentFormScreen;
    public readonly StudentListScreen StudentListScreen;
    
    public Configuration()
    {
        // Repositories
        AccountClassRepository = new AccountClassRepository();
        AccountRepository = new AccountRepository();
        AttendanceRepository = new AttendanceRepository();
        ClassRepository = new ClassRepository();
        RoleRepository = new RoleRepository();
        
        // Services
        AccountService = new AccountService(this);
        AttendanceService = new AttendanceService(this);
        AuthService = new AuthService(this);
        ClassService = new ClassService(this);
        
        // Screens
        ClassFormScreen = new ClassFormScreen(this);
        ClassListScreen = new ClassListScreen(this);
        LoginScreen = new LoginScreen(this);
        SettingScreen = new SettingScreen(this);
        StudentFormScreen = new StudentFormScreen(this);
        StudentListScreen = new StudentListScreen(this);
    }
}