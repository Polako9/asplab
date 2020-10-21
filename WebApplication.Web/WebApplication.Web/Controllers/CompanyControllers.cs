using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Application.Web.Controllers
{
    public class CompanyController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CompanyModel company)
        {

            var viewModel = new CompanyAddedViewModel
            {

                NumberOfCharsInName = company.Name.Length,
                NumberOfCharsInDescription = company.Description.Lenght,
                IsHidden = !company.IsVisible
            };
            return View("CompanyAdded", viewModel);
        }
    }
}
