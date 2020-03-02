using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgroAnaliseApp.Data;
using AgroAnaliseApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AgroAnaliseApp.Services
{
    public class CityService
    {
        private readonly AgroAnaliseAppContext _context;

        public CityService(AgroAnaliseAppContext context)
        {
            _context = context;
        }


        public async Task<List<City>> FindAllAsync()
        {
            return await _context.Citys.OrderBy(x => x.Name).ToListAsync();
        }

        public void Insert(City obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }


        public async Task InsertAsync(City obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }


        public async Task<City> FindByIdAsync(int? id)
        {
            return await _context.Citys.FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task UpdateAsync(City obj)
        {
            bool hasAny = await _context.Citys.AnyAsync(x => x.Id == obj.Id);
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
                var obj = await _context.Citys.FindAsync(id);
                _context.Citys.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("DDDDDDDDDD. ");
            }
        }

        public async Task<bool> CityExists(int id)
        {
            return await _context.Citys.AnyAsync(e => e.Id == id);
        }
    }
}
