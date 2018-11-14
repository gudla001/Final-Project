using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace FinalProject
{
    public class MessageDatabase
    {
        readonly SQLiteAsyncConnection database;


        public MessageDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<MessageModel>().Wait();
        }


        public Task<int> SaveItemAsync(MessageModel item)
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

        public Task<List<MessageModel>> GetAllItems()
        {
            return database.QueryAsync<MessageModel>("SELECT * FROM [StudentModel]");
        }
    }
}
