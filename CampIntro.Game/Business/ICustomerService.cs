using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Business
{
    interface ICustomerService
    {
        public void Add( Customer customer);
        public void Update(Customer customer);
        public void Delete(Customer customer);
    }
}
