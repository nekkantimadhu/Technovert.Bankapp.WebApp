using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Technovert.BankApp.BAL.Service;
using Technovert.BankApp.DataAccess.Interface;
using Technovert.BankApp.DataAccess.Models;

namespace Technovert.Bankapp.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly BankService _personService;

        private readonly IBank<Bank> _Person;

        public BankController(IBank<Bank> Person, BankService ProductService)
        {
            _personService = ProductService;
            _Person = Person;

        }
        //Add Person  
        [HttpPost("AddBank")]
        public async Task<Object> AddBank([FromBody] Bank person)
        {
            try
            {
                await _personService.AddBank(person);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        //Delete Person  
        [HttpDelete("DeletePerson")]
        public bool DeleteBank(string UserEmail)
        {
            try
            {
                _personService.DeleteBank(UserEmail);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Delete Person  
        [HttpPut("UpdatePerson")]
        public bool UpdatePerson(Bank Object)
        {
            try
            {
                _personService.UpdatePerson(Object);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //GET All Person by Name  
        [HttpGet("GetAllPersonByName")]
        public Object GetAllPersonByName(string UserEmail)
        {
            var data = _personService.GetPersonByUserName(UserEmail);
            var json = JsonConvert.SerializeObject(data, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            );
            return json;
        }

        //GET All Person  
        [HttpGet("GetAllPersons")]
        public Object GetAllPersons()
        {
            var data = _personService.GetAllPersons();
            var json = JsonConvert.SerializeObject(data, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            );
            return json;
        }
    }
}