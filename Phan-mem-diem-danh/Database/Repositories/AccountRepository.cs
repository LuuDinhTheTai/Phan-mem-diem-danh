using Microsoft.Data.SqlClient;
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

    public Account? Login(string msv, string password)
    {
        Account? account = null;
        string query = @"
            SELECT a.id, a.MSV, a.password, r.id, r.name
            FROM account a
            JOIN account_role ar ON a.id = ar.account_id
            JOIN Role r ON ar.role_id = r.id
            WHERE a.MSV = @msv AND a.password = @password";

        using (SqlCommand cmd = new SqlCommand(query, SqlConnection))
        {
            cmd.Parameters.AddWithValue("@msv", msv);
            cmd.Parameters.AddWithValue("@password", password);

            SqlConnection.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (account == null)
                    {
                        account = new Account
                        {
                            Id = reader.GetInt32(0),
                            MSV = reader.GetString(1),                          
                            Password = reader.GetString(2),
                            AccountRoles = new List<Role>()
                        };
                    }
                    Role role = new Role
                    {
                        Id = reader.GetInt32(3),
                        Name = reader.GetString(4)
                    };
                    account.AccountRoles.Add(role);
                }
            }
            SqlConnection.Close();
        }
        return account;
    }
}
