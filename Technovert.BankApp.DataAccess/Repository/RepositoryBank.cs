using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Technovert.BankApp.DataAccess.Interface;
using Technovert.BankApp.DataAccess.Models;
using Technovert.BankApp.DataAccess.Data;
using System.Linq;

namespace Technovert.BankApp.DataAccess.Repository
{
    public class RepositoryBank : IBank<Bank>
    {
        private readonly ApplicationDbContext _dbContext;
        public RepositoryBank(ApplicationDbContext applicationDbContext)
        {
            this._dbContext = applicationDbContext;
        }
        async Task<Bank> IBank<Bank>.Create(Bank _object)
        {
            var obj = await _dbContext.Banks.AddAsync(_object);
            _dbContext.SaveChanges();
            return obj.Entity;
        }

        public void Delete(Bank _object)
        {
            _dbContext.Remove(_object);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Bank> GetAll()
        {
            try
            {
                return _dbContext.Banks.Where(x => x.IsDeleted == false).ToList();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public Bank GetById(string Id)
        {
            return _dbContext.Banks.Where(x => x.IsDeleted == false && x.Id == Id).FirstOrDefault();
        }

        public void Update(Bank _object)
        {
            _dbContext.Banks.Update(_object);
            _dbContext.SaveChanges();
        }

        
    }
}
