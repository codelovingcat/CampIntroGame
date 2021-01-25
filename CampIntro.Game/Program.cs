using Game.Business;
using Game.DataAccess;
using Game.Entities;
using System;
using System.Collections.Generic;

namespace Game
{
    class Program
    {
        private static ICustomerDal _customerDal;
        private static IGamesDal _gamesDal;
        private static ICampaignDal _campaignDal;
        private static ISalesDal _salesDal;
        static void Main(string[] args)
        {

            Customer customer = new Customer { Id = 1, Name = "Ürem", SaleId = 2, TcNo = "12365478953", DateTime = DateTime.Now };
            Customer customer2 = new Customer { Id = 1, Name = "Batuhan", SaleId = 2, TcNo = "12365478934", DateTime = DateTime.Now };
            Customer customer3 = new Customer { Id = 1, Name = "Bedirhan", SaleId = 2, TcNo = "12365478963", DateTime = DateTime.Now };
            Customer customer4 = new Customer { Id = 1, Name = "Hasan", SaleId = 2, TcNo = "12365478973", DateTime = DateTime.Now };
            Customer customer5 = new Customer { Id = 1, Name = "Berna", SaleId = 2, TcNo = "12365478993", DateTime = DateTime.Now };
            Customer customer6 = new Customer { Id = 1, Name = "Meryem", SaleId = 2, TcNo = "12365478950", DateTime = DateTime.Now };

            Campaign campaign = new Campaign { Id = 2, Name = "%20 indirim." };
            Campaign campaign2 = new Campaign { Id = 1, Name = "%50 indirim." };
            Campaign campaign3 = new Campaign { Id = 3, Name = "%10 indirim." };

            Games games = new Games { Id = 1, Name = "Fortnite", Fiyat = Convert.ToDecimal(89.99) };
            Games games2 = new Games { Id = 2, Name = "League of Legends", Fiyat = Convert.ToDecimal(89.99) };
            Games games3 = new Games { Id = 3, Name = "PES 2020", Fiyat = Convert.ToDecimal(89.99) };
            Games games4 = new Games { Id = 4, Name = "Counter - Strike : Global Offensive", Fiyat = Convert.ToDecimal(89.99) };
            Games games5 = new Games { Id = 5, Name = "Resident Evil 3 Remake", Fiyat = Convert.ToDecimal(89.99) };

            Sales sales = new Sales { Id = 5, Name = "Satış", CampaignId = 3};
            Sales sales2 = new Sales { Id = 2, Name = "Satış2", CampaignId = 2};
            Sales sales3 = new Sales { Id = 1, Name = "Satış3", CampaignId = 1};


            CustomerManager customerManager = new CustomerManager(_customerDal);
            customerManager.Add(customer);
            customerManager.Delete(customer);
            customerManager.Update(customer);

            Console.WriteLine("************************************************************\n"+"Eklenen müşteri : " + customer2.Name);
            Console.WriteLine("************************************************************\n"+"Silinen müşteri : " + customer.Name);
            Console.WriteLine("************************************************************\n"+"Update müşteri : " + customer3.Name);
            Console.WriteLine("************************************************************");

            CampaignManager campaignManager=new CampaignManager(_campaignDal);
            campaignManager.Add(campaign);
            campaignManager.Delete(campaign);
            campaignManager.Update(campaign);
            Console.WriteLine("*************************************************************");

            GamesManager gamesManager = new GamesManager(_gamesDal);
            gamesManager.Add(games);
            gamesManager.Delete(games);
            gamesManager.Update(games);
            Console.WriteLine("**************************************************************");

            SalesManager salesManager = new SalesManager(_salesDal);
            salesManager.Add(sales);
            salesManager.Delete(sales);
            salesManager.Update(sales);
            Console.WriteLine("\n************************************************************");

            Console.WriteLine("\n Sayın : " + customer2.Name + 
                             "\n Kampanya :" + campaign.Name + 
                             "\n Satın alınan oyun : " + games.Name + 
                             "\n Sonuç : " + sales.Name);

            Console.ReadLine();
        }
    }
}
