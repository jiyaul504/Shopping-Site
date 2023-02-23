using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shopping_Site.Data;
using Shopping_Site.Interfaces;
using Shopping_Site.Models;

namespace Shopping_Site.Controllers
{
    
    public class UnitController : Controller
    {
        public IActionResult Index(string sortExpression="")// read method of crud operations. it lists all data from the Units table.
        {
            ViewData["SortParamName"] = "name";
            ViewData["SortParamDesc"] = "description";

            SortOrder sortOrder;
            string sortproperty;

            switch (sortExpression.ToLower())
            {
                case "name_desc":
                    sortOrder = SortOrder.Descending;
                    sortproperty = "name";
                    ViewData["SortParamName"] = "name";
                    break;

                case "description":
                    sortOrder = SortOrder.Ascending;
                    sortproperty = "description";
                    ViewData["SortParamDesc"] = "description_desc";
                    break;

                case "description_desc":
                    sortOrder = SortOrder.Descending;
                    sortproperty = "description";
                    ViewData["SortParamDesc"] = "description";
                    break;

                default:
                    sortOrder = SortOrder.Ascending; 
                    sortproperty = "name";
                    ViewData["SortParamName"] = "name_desc";
                    break;
            }

            List<Unit> units = _unitRepo.GetItems(sortproperty,sortOrder);//_context .units.Tolist();
            return View(units);
        }
        

        private readonly IUnit _unitRepo;

        public UnitController(IUnit unitrepo)// here the repository will be passed by the dependencey injection
        {
            
            _unitRepo= unitrepo;
        }
        public IActionResult Create()
        {
            Unit unit = new Unit();
            return View(unit);
        }
        [HttpPost]
        public IActionResult Create(Unit unit)
        {
            try
            {
                unit= _unitRepo.Create(unit);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Details(int id)
        {
            Unit unit=_unitRepo.GetUnit(id);
            return View(unit);
        }

        public IActionResult Edit(int id)
        {
            Unit unit = _unitRepo.GetUnit(id);
            return View(unit);
        }

        [HttpPost]
        public IActionResult Edit(Unit unit)
        {
            try
            {
                unit = _unitRepo.Edit(unit);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            Unit unit =_unitRepo.GetUnit(id);
            return View(unit);
        }

        [HttpPost]
        public IActionResult Delete(Unit unit)
        {
            try
            {
                unit= _unitRepo.Delete(unit);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        

    }
}
