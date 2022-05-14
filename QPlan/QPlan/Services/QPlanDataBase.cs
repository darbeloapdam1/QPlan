using QPlan.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QPlan.Services
{
    public class QPlanDataBase
    {
        static SQLiteAsyncConnection DataBase;
        public static readonly AsyncLazy<QPlanDataBase> InstanceUser = new AsyncLazy<QPlanDataBase>(async () =>
        {
            var instance = new QPlanDataBase();
            CreateTableResult result = await DataBase.CreateTableAsync<User>();
            return instance;
        });

        public QPlanDataBase()
        {
            DataBase = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        }

        public Task<List<User>> CheckUserAsync(string name, string pass)
        {
            return DataBase.QueryAsync<User>("SELECT * FROM [User] WHERE name LIKE('" + name +"') and password LIKE('" + pass + "')");
        }

        public Task<int> SaveUserAsync(User user)
        {
            if(user.Id != 0)
            {
                return DataBase.UpdateAsync(user);
            }
            else
            {
                return DataBase.InsertAsync(user);
            }
        }
    }
}
