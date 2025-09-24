namespace Phan_mem_diem_danh.Database.Entities;

public class AccountClass
{
    public int AccountId { get; set; }
    public int ClassId { get; set; }
    public string Role { get; set; } = IsStudent;
    
    public Account Account { get; set; }
    public Class Class { get; set; }
    
    // Predefined roles
    public static readonly string IsStudent = "Student";
    public static readonly string IsTeacher = "Teacher";
}