using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Business
{
    interface ISalesService
    {
        public void Add(Sales sales);
        public void Update(Sales sales);
        public void Delete(Sales sales);
    }
}
