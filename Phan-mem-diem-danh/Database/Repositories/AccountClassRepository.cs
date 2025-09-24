using Phan_mem_diem_danh.Database.Entities;
using Phan_mem_diem_danh.Database.Repositories.Base;

namespace Phan_mem_diem_danh.Database.Repositories;

public class AccountClassRepository : BaseRepository<AccountClass, int>
{
    public override AccountClass Create(AccountClass t)
    {
        throw new NotImplementedException();
    }

    public override AccountClass? Find(int id)
    {
        throw new NotImplementedException();
    }

    public override List<AccountClass> List()
    {
        throw new NotImplementedException();
    }

    public override AccountClass Update(AccountClass t)
    {
        throw new NotImplementedException();
    }

    public override bool Delete(int id)
    {
        throw new NotImplementedException();
    }
}