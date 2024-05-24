using Eflyer.Business.Exceptions;
using Eflyer.Business.Services.Abstracts;
using Eflyer.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eflyer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ElectronicController : Controller
    {
        private readonly IElectronicService _electronicService;

        public ElectronicController(IElectronicService electronicService)
        {
            _electronicService = electronicService;
        }
        public IActionResult Index()
        {
            var electronics = _electronicService.GetAllElectronics();
            return View(electronics);
        }

        public IActionResult Create ()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult Create(Electronic electronic)
        {
            if (!ModelState.IsValid)
                return View();

            try
            {
                  _electronicService.AddElectronic(electronic);
            }
            catch(ImageFileRequiredException ex) 
            { 
                ModelState.AddModelError(ex.PropertyName, ex.Message);
                return View();
            }
            catch(FileContentTypeException ex)
            {
                ModelState.AddModelError(ex.PropertyName, ex.Message);
                return View();
            }
            catch(FileSizeException ex)
            {
                ModelState.AddModelError(ex.PropertyName, ex.Message);
                return View();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
