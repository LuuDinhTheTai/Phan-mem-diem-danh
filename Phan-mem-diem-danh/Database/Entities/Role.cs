namespace Phan_mem_diem_danh.Database.Entities;

public class Role
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public List<Account> Accounts { get; set; } = new List<Account>();
    
    // Predefined roles
    public static readonly string Student = "Student";
    public static readonly string Teacher = "Teacher";
}