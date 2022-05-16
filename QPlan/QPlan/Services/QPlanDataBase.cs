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
        public static SQLiteAsyncConnection DataBase;
        public static readonly AsyncLazy<QPlanDataBase> InstanceUser = new AsyncLazy<QPlanDataBase>(async () =>
        {
            var instance = new QPlanDataBase();
            CreateTableResult result = await DataBase.CreateTableAsync<User>();
            return instance;
        });

        public QPlanDataBase()
        {
            DataBase = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            //InitializeDb();
        }

        private async void InitializeDb()
        {
            try
            {
                var tableInfoUser = DataBase.GetConnection().GetTableInfo("User");
                if (tableInfoUser.Count <= 0)
                {
                    await DataBase.CreateTableAsync<User>();
                }
                //await DataBase.DropTableAsync<User>();
                var tableInfoEstablecimiento = DataBase.GetConnection().GetTableInfo("Establecimiento");
                if(tableInfoEstablecimiento.Count <= 0)
                {
                    await DataBase.CreateTableAsync<Establecimiento>();
                }
                //await DataBase.DropTableAsync<Establecimiento>();
                var tableInfoEvento = DataBase.GetConnection().GetTableInfo("Evento");
                if(tableInfoEvento.Count <= 0)
                {
                    await DataBase.CreateTableAsync<Evento>();
                }
                //await DataBase.DropTableAsync<Evento>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public async Task<List<User>> GetUserAsync(string name, string pass)
        {
            try
            {
                return await DataBase.QueryAsync<User>("SELECT * FROM [User] WHERE name LIKE('" + name + "') and password LIKE('" + pass + "')");
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return null;
        }

        public async Task<int> SaveUserAsync(User user)
        {
            if(user.Id != 0)
            {
                return await DataBase.UpdateAsync(user);
            }
            else
            {
                return await DataBase .InsertAsync(user);
            }
        }

        public async Task<bool> CheckUserAsync(string name, string pass)
        {
            if((await GetUserAsync(name, pass)).Count != 0)
            {
                return true;
            }
            return false;
        }

        public async Task<List<Establecimiento>> GetEstablecimientoAsync(int userId)
        {
            try
            {
                return await DataBase.QueryAsync<Establecimiento>("SELECT * FROM [Establecimiento] WHERE userId = " + userId + ";");
            }
            catch(Exception ex)
            {
                Console.WriteLine("==>Error<==" + ex);
            }
            return null;
        }

        public async Task<int> SaveEstablecimientoAsync(Establecimiento establecimiento)
        {
            if(establecimiento.Id != 0)
            {
                return await DataBase.UpdateAsync(establecimiento);
            }
            else
            {
                return await DataBase.InsertAsync(establecimiento);
            }
        }
    }
}
