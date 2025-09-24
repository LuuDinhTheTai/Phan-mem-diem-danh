using Phan_mem_diem_danh.Database.Entities;
using Phan_mem_diem_danh.Database.Repositories.Base;

namespace Phan_mem_diem_danh.Database.Repositories;

public class ClassRepository : BaseRepository<Class, int>
{
    public override Class Create(Class t)
    {
        throw new NotImplementedException();
    }

    public override Class? Find(int id)
    {
        throw new NotImplementedException();
    }

    public override List<Class> List()
    {
        throw new NotImplementedException();
    }

    public override Class Update(Class t)
    {
        throw new NotImplementedException();
    }

    public override bool Delete(int id)
    {
        throw new NotImplementedException();
    }
}