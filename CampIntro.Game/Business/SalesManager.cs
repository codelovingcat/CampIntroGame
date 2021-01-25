using Game.DataAccess;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Business
{
    class SalesManager : ISalesService
    {
        private ISalesDal _salesDal;

        public SalesManager(ISalesDal salesDal)
        {
            _salesDal = salesDal;
        }

        public void Add(Sales sales)
        {
            Console.WriteLine("Sepete ekleme işleme.");
        }

        public void Delete(Sales sales)
        {
            Console.WriteLine("Sepeten silme işleme.");
        }

        public void Update(Sales sales)
        {
            Console.WriteLine("Sepeti güncelleme işleme.");
        }
    }
}
