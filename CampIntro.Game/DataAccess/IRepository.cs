using System;
using System.Collections.Generic;
using System.Text;

namespace Game.DataAccess
{
    interface IRepository<T>
    {
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(T entity);
    }
}
