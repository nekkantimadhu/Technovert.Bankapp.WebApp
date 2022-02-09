using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Technovert.BankApp.DataAccess.Interface
{
    public interface IBank<T>
    {
        public Task<T> Create(T _object);

        public void Update(T _object);

        public IEnumerable<T> GetAll();

        public T GetById(string Id);

        public void Delete(T _object);
    }
}
