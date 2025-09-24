using Phan_mem_diem_danh.Database.Entities;
using Phan_mem_diem_danh.Database.Repositories.Base;

namespace Phan_mem_diem_danh.Database.Repositories;

public class AccountRepository : BaseRepository<Account, int>
{
    public override Account Create(Account t)
    {
        throw new NotImplementedException();
    }

    public override Account? Find(int id)
    {
        throw new NotImplementedException();
    }

    public override List<Account> List()
    {
        throw new NotImplementedException();
    }

    public override Account Update(Account t)
    {
        throw new NotImplementedException();
    }

    public override bool Delete(int id)
    {
        throw new NotImplementedException();
    }
}