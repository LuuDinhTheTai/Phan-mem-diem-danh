using Microsoft.Data.SqlClient;

namespace Phan_mem_diem_danh.Database.Repositories.Base;

public abstract class BaseRepository<T, ID>
{
    private static readonly string ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=PMDDDB;Trusted_Connection=True;";
    protected readonly SqlConnection SqlConnection = new SqlConnection(ConnectionString);

    public abstract T Create(T t);
    public abstract T? Find(ID id);
    public abstract List<T> List();
    public abstract T Update(T t);
    public abstract bool Delete(ID id);
}