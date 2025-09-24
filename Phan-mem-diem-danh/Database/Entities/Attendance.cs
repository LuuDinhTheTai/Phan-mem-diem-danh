namespace Phan_mem_diem_danh.Database.Entities;

public class Attendance
{
    public int Id { get; set; }
    public int AccountId { get; set; }
    public int ClassId { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public string Status { get; set; } = Absent;
    
    public Account Account { get; set; }
    public Class Class { get; set; }
    
    public static readonly string Absent = "Absent";   // Vắng
    public static readonly string Present = "Present"; // Có mặt
    public static readonly string Late = "Late";       // Muộn
    public static readonly string Excused = "Excused"; // Có phép
}