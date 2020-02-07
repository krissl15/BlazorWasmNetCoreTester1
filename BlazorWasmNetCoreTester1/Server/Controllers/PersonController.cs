using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorWasmNetCoreTester1.Shared;

namespace BlazorWasmNetCoreTester1.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        [Route("all")]
        public IEnumerable<PersonModel> GetPeople()
        {
            var output = new List<PersonModel>
            {
                new PersonModel { FirstName = "Tim", LastName = "Curry", AccountBalance = 19.45M},
                new PersonModel { FirstName = "Marry", LastName = "Smith", AccountBalance = 105.87M},
                new PersonModel { FirstName = "John", LastName = "Jones", AccountBalance = 115.32M}

            };

            return output;
        }

        [HttpPost]
        public void Post(PersonModel person)
        {

        }
    }
}