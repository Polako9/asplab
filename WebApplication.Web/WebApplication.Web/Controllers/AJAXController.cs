using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Web.Database;
using WebApplication.Web.Entities;
using WebApplication.Web.Models;

namespace WebApplication.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AjaxController : ControllerBase
    {
        private readonly ExchangesDbContext _dbContext;
        public AjaxController(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        [Route("AddItem")]
        public IActionResult AddItem(ExchangesModel exchange)
        {

            var entity = new ItemEntity
            {
                Name = exchange.Name,
                Description = exchange.Description,
                IsVisible = exchange.IsVisible,
            };

            _dbContext.Items.Add(entity);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}