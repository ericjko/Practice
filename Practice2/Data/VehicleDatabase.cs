using System;
using SQLite;
using Practice2.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Practice2.Data
{
    public class VehicleDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public VehicleDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Vehicle>().Wait();
        }

        public Task<List<Vehicle>> GetNotesAsync()
        {
            return _database.Table<Vehicle>().ToListAsync();
        }

        public Task<Vehicle> GetNoteAsync(int id)
        {
            return _database.Table<Vehicle>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveNoteAsync(Vehicle vehicle)
        {
            if (vehicle.ID != 0)
            {
                return _database.UpdateAsync(vehicle);
            }
            else
            {
                return _database.InsertAsync(vehicle);
            }
        }

        public Task<int> DeleteNoteAsync(Vehicle vehicle)
        {
            return _database.DeleteAsync(vehicle);
        }
    }
}
