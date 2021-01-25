using Game.DataAccess;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Business
{
    class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add(Customer customer)
        {
            //_customerDal.Add(customer);
            Console.WriteLine("Müşteri ekleme işlemi tamamlandı.");

        }

        public void Delete(Customer customer)
        {
           // _customerDal.Delete(customer);
            Console.WriteLine("Müşteri silme işlemi tamamlandı.");
        }

        public void Update(Customer customer)
        {
            //_customerDal.Update(customer);
            Console.WriteLine("Müşteri güncelleme işlemi tamamlandı.");
        }

    }
}
