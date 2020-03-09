using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.API.Data;
using Web.API.Entities;
using Web.API.Models;
using Web.API.Services;

namespace Web.API.Controllers
{
    [ApiController]
    [Route("api/Storage")]
    public class StorageController : ControllerBase
    {
        private readonly InterfaceStorageRepository _storageRepository;
        public StorageController(InterfaceStorageRepository storageRepository)
        {
            _storageRepository = storageRepository ?? throw new ArgumentException(nameof(storageRepository));
        }
        [HttpGet]
        public async Task<IActionResult> GetStorages()
        {
            var storages = await _storageRepository.GetStoragesAsync();
            return Ok(storages);
        }
        [HttpGet(template: "{Pru}", Name = nameof(GetStorage))]
        public async Task<IActionResult> GetStorage(string Pru)
        {
            var storages = await _storageRepository.GetStorageAsync(Pru);
            if (storages == null)
            {
                return NotFound();
            }
            return Ok(storages);
        }
        [HttpPost]
        public async Task<ActionResult<Storage>> AddStorage([FromBody]Storage storage)
        {
            var test = await _storageRepository.GetStorageAsync(storage.Pru);
            if (test != null)
            {
                return NotFound();
            }
            _storageRepository.AddStorage(storage);
            await _storageRepository.SaveAsync();
            return CreatedAtRoute(nameof(GetStorage), new { pru = storage.Pru }, storage);
        }
        [HttpDelete("{Pru}")]
        public async Task<IActionResult> DeleteStorage(string pru)
        {
            var storages = await _storageRepository.GetStorageAsync(pru);
            if (storages == null)
            {
                return NotFound();
            }
            _storageRepository.DeleteStorage(storages);
            await _storageRepository.SaveAsync();
            return NoContent();
        }
        [HttpPatch("{Pru}")]
        public async Task<IActionResult> UpdateStorage(string pru,ForDeleteStorage forDelete)
        {
            var storages = await _storageRepository.GetStorageAsync(pru);
            if (storages == null)
            {
                return NotFound();
            }
            _storageRepository.UpdateStorage(storages,forDelete);
            return NoContent();
        }
    }
}
