using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Web.API.Data;
using Web.API.Entities;
using Web.API.Models;

namespace Web.API.Services
{
    public class StorageRepository : InterfaceStorageRepository
    {
        private readonly WebAPIDbContext _context;

        public StorageRepository(WebAPIDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void AddStorage(Storage storage)
        {
            //throw new NotImplementedException();
            if (storage == null) 
            {
                throw new ArgumentNullException(nameof(Storage));
            }
            _context.Storages.Add(storage);
        }

        public void DeleteStorage(Storage storage)
        {
            if (storage == null)
            {
                throw new ArgumentNullException(nameof(Storage));
            }
            _context.Storages.Remove(storage);
        }

        public async Task<Storage> GetStorageAsync(string Pru)
        {
            //throw new NotImplementedException();
            if (Pru == null)
            {
                throw new ArgumentNullException(nameof(Pru));
            }
            return await _context.Storages.FirstOrDefaultAsync(x => x.Pru.Equals(Pru));
            
        }

        public async Task<IEnumerable<Storage>> GetStoragesAsync()
        {
            return await _context.Storages.ToListAsync();
        }

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() >= 0;
        }

        public void UpdateStorage(Storage storage, ForDeleteStorage forDelete )
        {
            if (forDelete == null)
            {
                throw new ArgumentNullException(nameof(forDelete));
            }
            var dele = storage;
            storage.Prunum += forDelete.Prunum;
            if (storage.Prunum < 0)
            {
                throw new Exception("库存不能小于0");
            }
            else
            {
                _context.Storages.Remove(dele);
                _context.SaveChangesAsync();
                _context.Storages.Add(storage);
                _context.SaveChangesAsync();
            }
        }
    }
}
