namespace Phan_mem_diem_danh.Database.Entities;

public class Account
{
    public int Id { get; set; }
    public string MSV { get; set; } = "test";
    public string FirstName { get; set; } = "test";
    public string LastName { get; set; } = "test";
    public DateTime Birth { get; set; } = DateTime.Now;
    public string Password { get; set; } = "test";

    public ICollection<Role> AccountRoles { get; set; } = new List<Role>();
    public ICollection<AccountClass> AccountClasses { get; set; } = new List<AccountClass>();
    public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();
}