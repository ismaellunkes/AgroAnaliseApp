using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgroAnaliseApp.Data;
using AgroAnaliseApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AgroAnaliseApp.Services
{
    public class FarmService
    {
        private readonly AgroAnaliseAppContext _context;

        public FarmService(AgroAnaliseAppContext context)
        {
            _context = context;
        }


        public async Task<List<Farm>> FindAllAsync()
        {
            var agroAnaliseAppContext = _context.Farms.Include(f => f.Address).Include(f => f.Farmer);
            return await agroAnaliseAppContext.ToListAsync();
        }

        public void Insert(Farm obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }


        public async Task InsertAsync(Farm obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }


        public async Task<Farm> FindByIdAsync(int? id)
        {      
            // return await _context.Farms.FirstOrDefaultAsync(obj => obj.Id == id);

            return await _context.Farms.Include(f => f.Address).Include(f => f.Farmer).FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task UpdateAsync(Farm obj)
        {
            bool hasAny = await _context.Farms.AnyAsync(x => x.Id == obj.Id);
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

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Farms.FindAsync(id);
                _context.Farms.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Integrity error. ");
            }
        }

        public async Task<bool> FarmExists(int id)
        {
            return await _context.Farms.AnyAsync(e => e.Id == id);
        }
    }
}
