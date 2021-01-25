using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Business
{
    interface IGamesService
    {
        public void Add(Games games);
        public void Update(Games games);
        public void Delete(Games games);
    }
}
