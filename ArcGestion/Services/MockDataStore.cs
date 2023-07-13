using ArcGestion.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcGestion.Services
{
    public class MockDataStore
    {
        readonly SQLiteAsyncConnection database;

        public MockDataStore(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Produit>().Wait();
        }

        public async Task<int> AddProduitAsync(Produit Produit)
        {
            if (Produit.Id != 0)
            {
                return await database.UpdateAsync(Produit);
            }
            else
            {
                return await database.InsertAsync(Produit);
            }
        }

        public async Task<int> DeleteProduitAsync(Produit Produit)
        {
            return await database.DeleteAsync(Produit);
        }

        public async Task<Produit> GetProduitAsync(int id)
        {
            return await database.Table<Produit>()
                .Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Produit>> GetProduitsAsync()
        {
            return await database.Table<Produit>().ToListAsync();
        }
    }
}
