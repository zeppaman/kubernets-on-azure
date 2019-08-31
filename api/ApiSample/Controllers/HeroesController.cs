using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiSample.DAL;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiSample.Controllers
{
    [Route("api/[controller]")]
    public class HeroesController : Controller
    {
        HeroDatabase db;
        public HeroesController(HeroDatabase db)
        {
            this.db = db;
        }
     
        [HttpGet]
        public IEnumerable<Hero> Get(string name)
        {
            return this.db.Heroes.Where(x=> string.IsNullOrEmpty(name) || x.name.Contains(name)) .ToList();
        }

       
        [HttpGet("{id}")]
        public Hero Get(int id)
        {
            return this.db.Heroes.FirstOrDefault(x => x.Id==id);
        }

      
        [HttpPost]
        public Hero Post([FromBody]Hero value)
       {
            this.db.Heroes.Add(value);
            this.db.SaveChanges();
            return value;
        }

        
        [HttpPut()]
        public Hero Put( [FromBody]Hero value)
        {
            var hero = Get(value.Id);
            hero.name = value.name;
            this.db.SaveChanges();
            return hero;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.db.Heroes.Remove(Get(id));
            this.db.SaveChanges();
        }
    }
}
