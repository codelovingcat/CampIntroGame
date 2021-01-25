using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.DataAccess
{
    class CustomerDal : Repository<Customer, Context>, ICustomerDal
    {
    }
}
