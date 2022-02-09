using System;
using System.Collections.Generic;
using System.Text;
using Technovert.BankApp.DataAccess.Models;
using Technovert.BankApp.DataAccess.Interface;
using System.Linq;
using System.Threading.Tasks;

namespace Technovert.BankApp.BAL.Service
{
    public class BankService
    {
        private readonly IBank<Bank> _person;

        public BankService(IBank<Bank> perosn)
        {
            _person = perosn;
        }
        //Get Person Details By Person Id  
        public IEnumerable<Bank> GetPersonByUserId(string UserId)
        {
            return _person.GetAll().Where(x => x.BankName == UserId).ToList();
        }
        //GET All Perso Details   
        public IEnumerable<Bank> GetAllPersons()
        {
            try
            {
                return _person.GetAll().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
        //Get Person by Person Name  
        public Bank GetPersonByUserName(string UserName)
        {
            return _person.GetAll().Where(x => x.BankName == UserName).FirstOrDefault();
        }
        //Add Person  
        public async Task<Bank> AddBank(Bank Person)
        {
            return await _person.Create(Person);
        }
        //Delete Person   
        public bool DeleteBank(string UserEmail)
        {

            try
            {
                var DataList = _person.GetAll().Where(x => x.BankName == UserEmail).ToList();
                foreach (var item in DataList)
                {
                    _person.Delete(item);
                }
                return true;
            }
            catch (Exception)
            {
                return true;
            }

        }
        //Update Person Details  
        public bool UpdatePerson(Bank person)
        {
            try
            {
                var DataList = _person.GetAll().Where(x => x.IsDeleted != true).ToList();
                foreach (var item in DataList)
                {
                    _person.Update(item);
                }
                return true;
            }
            catch (Exception)
            {
                return true;
            }
        }
    }
}
