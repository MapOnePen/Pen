using EFDataAuth.Test.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace EFDataAuth.Test.Controllers
{

    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly MyTestDbContext _db;
        public ValuesController(MyTestDbContext myTestDbContext)
        {
            _db = myTestDbContext;
        }
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var result= _db.Users.ToList();
            return Ok(result);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _db.Users.AsQueryable().Join(_db.Adress.AsQueryable(),
                user => user.Id,
                adress => adress.UserId,
                (user, adress) => new {
                   UserName=user.Name,
                   Adress=adress.Name,
                   Phone=user.Phone,
                   CreateTime=user.CreateTime
                }).ToList();

            return Ok(result);
        }
    }
}
