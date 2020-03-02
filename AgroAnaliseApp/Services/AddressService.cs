using System.Collections.Generic;
using System.Threading.Tasks;
using AgroAnaliseApp.Data;
using AgroAnaliseApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AgroAnaliseApp.Services
{
    public class AddressService
    {

        private readonly AgroAnaliseAppContext _context;

        public AddressService(AgroAnaliseAppContext context)
        {
            _context = context;
        }

        public async Task<List<Address>> FindAllAsync()
        {            
            return await _context.Addresses.Include(a => a.City).ToListAsync();
        }

        public async Task InsertAsync(Address obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Address> FindByIdAsync(int? id)
        {
            return await _context.Addresses.Include(obj => obj.City).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Addresses.FindAsync(id);
                _context.Addresses.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("DDDDDDDDDD. ");
            }
        }

        public async Task UpdateAsync(Address obj)
        {
            bool hasAny = await _context.Addresses.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id not found.");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }

        public async Task<bool> AddressExists(int id)
        {
            return await _context.Addresses.AnyAsync(e => e.Id == id);
        }
    }
}

