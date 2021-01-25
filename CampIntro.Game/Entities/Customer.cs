using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Entities
{
    class Customer
    {
        public int Id { get; set; }
        public int SaleId { get; set; }
        public string TcNo{ get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
    }
}
