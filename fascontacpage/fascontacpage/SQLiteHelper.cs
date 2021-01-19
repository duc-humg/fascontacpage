using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace fascontacpage
{
    public class SQLiteHelper
    {
        SQLiteAsyncConnection db;
        public SQLiteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Product>().Wait();
        }
        public Task<List<Product>> GetItemsAsync()
        {
            return db.Table<Product>().ToListAsync();
        }
        public Task<int> SaveItemAsync(Product product)
        {


            return db.InsertAsync(product);

        }
    }
}
