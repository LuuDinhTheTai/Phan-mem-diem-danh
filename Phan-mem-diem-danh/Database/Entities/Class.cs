namespace Phan_mem_diem_danh.Database.Entities;

public class Class
{
    public int Id { get; set; }
    public string Name { get; set; } = "test";
    public string Subject { get; set; } = "test";
    public string Department { get; set; } = "test";
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    
    public List<AccountClass> AccountClasses { get; set; } = new List<AccountClass>();
    public List<Attendance> Attendances { get; set; } = new List<Attendance>();
}