using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace FinalProject
{
    public class StudentDatabase
    {
        readonly SQLiteAsyncConnection database;


        public StudentDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<StudentModel>().Wait();
        }


        public Task<int> SaveItemAsync(StudentModel item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<List<StudentModel>> GetAllItems()
        {
            return database.QueryAsync<StudentModel>("SELECT * FROM [StudentModel]");
        }
    }
}
