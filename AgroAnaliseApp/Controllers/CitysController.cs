using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AgroAnaliseApp.Models;
using AgroAnaliseApp.Services;

namespace AgroAnaliseApp.Controllers
{
    public class CitysController : Controller
    {
        private readonly CityService _cityService;

        public CitysController(CityService cityService)
        {
            _cityService = cityService;
        }

        // GET: Citys
        public async Task<IActionResult> Index()
        {
            return View(await _cityService.FindAllAsync());
        }

        // GET: Citys/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = await _cityService.FindAllAsync();
            if (city == null)
            {
                return NotFound();
            }

            return View(city);
        }

        // GET: Citys/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Citys/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(City city)
        {
            if (ModelState.IsValid)
            {
                
                await _cityService.InsertAsync(city);
                return RedirectToAction(nameof(Index));
            }
            return View(city);
        }

        // GET: Citys/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = await _cityService.FindByIdAsync(id);
            if (city == null)
            {
                return NotFound();
            }
            return View(city);
        }

        // POST: Citys/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] City city)
        {
            if (id != city.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    
                    await _cityService.UpdateAsync(city);
                }
                catch (DbUpdateConcurrencyException)
                {
                    bool exist = await _cityService.CityExists(city.Id);
                    if (!exist)
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
            return View(city);
        }

        // GET: Citys/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = await _cityService.FindByIdAsync(id);
            if (city == null)
            {
                return NotFound();
            }

            return View(city);
        }

        // POST: Citys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            
            await _cityService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> CityExists(int id)
        {
            return await _cityService.CityExists(id);
        }
    }
}
