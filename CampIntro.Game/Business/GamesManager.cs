using Game.DataAccess;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Business
{
    class GamesManager : IGamesService
    {
        private IGamesDal _gamesDal;
        public GamesManager(IGamesDal gamesDal)
        {
            _gamesDal = gamesDal;
        }
        public void Add(Games games)
        {
            // _gamesDal.Add(games);
            Console.WriteLine("Oyun ekleme işlemi.");
        }

        public void Delete(Games games)
        {
            // _gamesDal.Delete(games);
            Console.WriteLine("Oyun silme işlemi.");
        }

        public void Update(Games games)
        {
            // _gamesDal.Update(games);
            Console.WriteLine("Oyun güncelleme işlemi.");
        }
    }
}
