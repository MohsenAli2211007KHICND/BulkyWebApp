using Bulky.DataAccess.Repository;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models.Models;
using Bulky.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace BulkyWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class CompanyController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CompanyController(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<Company> companyList = _unitOfWork.Company.GetAll();
            return View(companyList);
        }

        public IActionResult Upsert(int id)
        {
            if(id == 0 || id == null)
            {
                return View(new Company());
            }
            else
            {
                Company  company = _unitOfWork.Company.Get(u  => u.Id == id);
                return View(company);
            }
        }

        [HttpPost]
        public IActionResult Upsert(Company company)
        {
            if (ModelState.IsValid)
            {
                if(company.Id == 0)
                {
                    _unitOfWork.Company.Add(company);
                    TempData["success"] = "Company Created successfully!";
                }
                else
                {
                    _unitOfWork.Company.Update(company);
                    TempData["success"] = "Company Updated successfully!";

                }
                _unitOfWork.Save();
                return RedirectToAction("Index", "Company");
            }
            else
            {
                return View(company);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            Company? company = _unitOfWork.Company.Get(u => u.Id == id);
            if (company == null)
            {
                return Json(new { success = false, message = "Error while Deleting!" });
            }

            _unitOfWork.Company.Remove(company);
            _unitOfWork.Save();
            TempData["success"] = "Company Deleted successfully!";
            return Json(new { success = true, message = "Company deleted" });
        }












        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<Company> companyList = _unitOfWork.Company.GetAll();
            return Json(new { data = companyList });
        }
    }
}
