using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.API.Entities;
using Web.API.Models;

namespace Web.API.Services
{
    public interface InterfaceStorageRepository
    {
        Task<IEnumerable<Storage>> GetStoragesAsync();
        Task<Storage> GetStorageAsync(string Pru);
        void AddStorage(Storage storage);
        void UpdateStorage(Storage storage,ForDeleteStorage forDeleteStorage);
        void DeleteStorage(Storage storage);

        Task<bool> SaveAsync();
    }
}
