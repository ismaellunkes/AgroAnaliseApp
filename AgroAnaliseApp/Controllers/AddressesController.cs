using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AgroAnaliseApp.Models;
using AgroAnaliseApp.Models.ViewModels;
using AgroAnaliseApp.Services;

namespace AgroAnaliseApp.Controllers
{
    public class AddressesController : Controller
    {
        private readonly CityService _cityService;
        private readonly AddressService _addressService;
        public AddressesController(CityService cityService, AddressService addressService)
        {
            _cityService = cityService;
            _addressService = addressService;
        }

        // GET: Addresses
        public async Task<IActionResult> Index()
        {        
            var list = await _addressService.FindAllAsync();
            return View(list);
        }

        // GET: Addresses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = await _addressService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);

        }

        // GET: Addresses/Create
        public async Task<IActionResult> Create()
        {
            var citys = await _cityService.FindAllAsync();
            var viewModel = new AddressFormViewModel { Citys = citys };
            return View(viewModel);
        }

        // POST: Addresses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Address address)
        {
            if (!ModelState.IsValid)
            {
                var citys = await _cityService.FindAllAsync();
                var viewModel = new AddressFormViewModel { Address = address, Citys = citys };
                return View(viewModel);
            }
            await _addressService.InsertAsync(address);
            return RedirectToAction(nameof(Index));
        }

        // GET: Addresses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var address = await _addressService.FindByIdAsync(id);
            if (address == null)
            {
                return NotFound();
            }
            List<City> Citys = await _cityService.FindAllAsync();
            AddressFormViewModel viewModel = new AddressFormViewModel { Address = address, Citys = Citys };

            return View(viewModel);
        }

        // POST: Addresses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Line1,Line2,ZipCode,Coordinates,CityId")] Address address)
        {
            if (id != address.Id)
            {
                return NotFound();
            }

            ///Serve para habilitar as validações se o JavScript tiver desabilitado no navegador do user
            if (!ModelState.IsValid)
            {
                var cities = await _cityService.FindAllAsync();
                var viewModel = new AddressFormViewModel { Address = address, Citys = cities };
                return View(viewModel);
            }

            if (id != address.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id mismatch." });
            }
            try
            {
                await _addressService.UpdateAsync(address);
            }
            catch (ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }

            return RedirectToAction(nameof(Index));

        }

        private object Error()
        {
            throw new NotImplementedException();
        }

        // GET: Addresses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided." });
            }

            var obj = await _addressService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not Found." });
            }

            return View(obj);
        }

        // POST: Addresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                await _addressService.RemoveAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (IntegrityException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }

        public async Task<bool> AddressExists(int id)
        {
            return await _addressService.AddressExists(id);
        }
    }
}
