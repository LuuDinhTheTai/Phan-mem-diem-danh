using Phan_mem_diem_danh.Database.Entities;
using Phan_mem_diem_danh.Database.Repositories.Base;

namespace Phan_mem_diem_danh.Database.Repositories;

public class AttendanceRepository : BaseRepository<Attendance, int>
{
    public override Attendance Create(Attendance t)
    {
        throw new NotImplementedException();
    }

    public override Attendance? Find(int id)
    {
        throw new NotImplementedException();
    }

    public override List<Attendance> List()
    {
        throw new NotImplementedException();
    }

    public override Attendance Update(Attendance t)
    {
        throw new NotImplementedException();
    }

    public override bool Delete(int id)
    {
        throw new NotImplementedException();
    }
}