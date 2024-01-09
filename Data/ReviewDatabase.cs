using Proiect_hotel_app.Models;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Proiect_hotel_app.Data
{
    public class ReviewDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public ReviewDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Reviews>().Wait();
        }

        public Task<List<Reviews>> GetReviewsAsync()
        {
            return _database.Table<Reviews>().ToListAsync();
        }

        public Task<Reviews> GetReviewAsync(int id)
        {
            return _database.Table<Reviews>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveReviewAsync(Reviews review)
        {
            if (review.ID != 0)
            {
                return _database.UpdateAsync(review);
            }
            else
            {
                return _database.InsertAsync(review);
            }
        }

        public Task<int> DeleteReviewAsync(Reviews review)
        {
            return _database.DeleteAsync(review);
        }
    }
}
