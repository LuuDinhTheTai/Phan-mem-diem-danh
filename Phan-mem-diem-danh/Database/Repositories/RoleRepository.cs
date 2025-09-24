using Phan_mem_diem_danh.Database.Entities;
using Phan_mem_diem_danh.Database.Repositories.Base;

namespace Phan_mem_diem_danh.Database.Repositories;

public class RoleRepository : BaseRepository<Role, int>
{
    public override Role Create(Role t)
    {
        throw new NotImplementedException();
    }

    public override Role? Find(int id)
    {
        throw new NotImplementedException();
    }

    public override List<Role> List()
    {
        throw new NotImplementedException();
    }

    public override Role Update(Role t)
    {
        throw new NotImplementedException();
    }

    public override bool Delete(int id)
    {
        throw new NotImplementedException();
    }
}