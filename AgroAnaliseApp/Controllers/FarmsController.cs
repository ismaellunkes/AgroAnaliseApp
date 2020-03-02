using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AgroAnaliseApp.Data;
using AgroAnaliseApp.Models;
using AgroAnaliseApp.Services;

namespace AgroAnaliseApp.Controllers
{
    public class FarmsController : Controller
    {
        private readonly FarmService _farmService;
        private readonly AddressService _addressService;

        public FarmsController(FarmService farmService)
        {
            _farmService = farmService;
        }

        // GET: Farms
        public async Task<IActionResult> Index()
        {
            var list = await _farmService.FindAllAsync();
            return View(list);
            /*var agroAnaliseAppContext = _context.Farm.Include(f => f.Address).Include(f => f.Farmer);
            return View(await agroAnaliseAppContext.ToListAsync());*/
        }

        // GET: Farms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            /* var farm = await _context.Farm
                 .Include(f => f.Address)
                 .Include(f => f.Farmer)
                 .FirstOrDefaultAsync(m => m.Id == id);*/
            var obj = await _farmService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        // GET: Farms/Create
        public IActionResult Create()
        {
            //ViewData["AddressId"] = new SelectList(_context.Addresses, "Id", "Id");
            // ViewData["FarmerId"] = new SelectList(_context.Farmers, "Id", "Discriminator");
            return View();
        }

        // POST: Farms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AddressId,RegistryDate,FarmerId")] Farm farm)
        {
            /* if (ModelState.IsValid)
             {
                 _context.Add(farm);
                 await _context.SaveChangesAsync();
                 return RedirectToAction(nameof(Index));
             }
             ViewData["AddressId"] = new SelectList(_context.Addresses, "Id", "Id", farm.AddressId);
             ViewData["FarmerId"] = new SelectList(_context.Farmers, "Id", "Discriminator", farm.FarmerId);
             return View(farm);*/
            return View();
        }

        // GET: Farms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            /* if (id == null)
             {
                 return NotFound();
             }

             var farm = await _context.Farm.FindAsync(id);
             if (farm == null)
             {
                 return NotFound();
             }
             ViewData["AddressId"] = new SelectList(_context.Addresses, "Id", "Id", farm.AddressId);
             ViewData["FarmerId"] = new SelectList(_context.Farmers, "Id", "Discriminator", farm.FarmerId);
             return View(farm);*/

            return View();
        }

        // POST: Farms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AddressId,RegistryDate,FarmerId")] Farm farm)
        {
            /*  if (id != farm.Id)
              {
                  return NotFound();
              }

              if (ModelState.IsValid)
              {
                  try
                  {
                      _context.Update(farm);
                      await _context.SaveChangesAsync();
                  }
                  catch (DbUpdateConcurrencyException)
                  {
                      if (!FarmExists(farm.Id))
                      {
                          return NotFound();
                      }
                      else
                      {
                          throw;
                      }
                  }
                  return RedirectToAction(nameof(Index));
              }
              ViewData["AddressId"] = new SelectList(_context.Addresses, "Id", "Id", farm.AddressId);
              ViewData["FarmerId"] = new SelectList(_context.Farmers, "Id", "Discriminator", farm.FarmerId);
              return View(farm);*/

            return View();
        }

        // GET: Farms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            /*    if (id == null)
                {
                    return NotFound();
                }

                var farm = await _context.Farm
                    .Include(f => f.Address)
                    .Include(f => f.Farmer)
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (farm == null)
                {
                    return NotFound();
                }

                return View(farm);*/
            return View();
        }

        // POST: Farms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            /*var farm = await _context.Farm.FindAsync(id);
            _context.Farm.Remove(farm);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));*/

            return RedirectToAction(nameof(Index));
        }

        /*private bool FarmExists(int id)
        {
            return _context.Farm.Any(e => e.Id == id);
        }*/
    }
}
