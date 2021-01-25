using System;
using System.Collections.Generic;
using System.Text;

namespace Game.DataAccess
{
    class Repository<T, TContext> : IRepository<T>
    {
        public void Add(T entity)
        {
            Console.WriteLine(" Added!");
        }

        public void Delete(T entity)
        {
            Console.WriteLine(" Updated!");
        }

        public void Update(T entity)
        {
            Console.WriteLine(" Deleted!");
        }
    }
}
