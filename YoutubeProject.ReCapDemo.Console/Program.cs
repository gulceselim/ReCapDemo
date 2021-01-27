using System;
using System.Collections.Generic;
using YoutubeProject.ReCapDemo.Business.Abstract;
using YoutubeProject.ReCapDemo.Business.Concrete;
using YoutubeProject.ReCapDemo.Business.ValidationRules.Abstract;
using YoutubeProject.ReCapDemo.Business.ValidationRules.Concrete;
using YoutubeProject.ReCapDemo.DataAccess.Abstract;
using YoutubeProject.ReCapDemo.DataAccess.Concrete;
using YoutubeProject.ReCapDemo.Entities.Abstract;
using YoutubeProject.ReCapDemo.Entities.Concrete;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonCheckService personCheck = new PersonCheckManager();
            ILoggerService databaseLogger = new DatabaseLoggerManager();
            ILoggerService fileLogger = new FileLoggerManager();

            List<ILoggerService> loggerServices = new List<ILoggerService>() { fileLogger };

            IPlayerService playerManager = new PlayerManager(personCheck, loggerServices);

            Player selim = new Player() { Name = "Selim", LastName = "Gülce", UserName = "selimg", Password = "1234567890", DateOfBirth = new DateTime(1999, 11, 20), NationalityId = "11112222333" };
            Player emre = new Player() { Name = "Emre", LastName = "Gülce", UserName = "emreg", Password = "1234567890", DateOfBirth = new DateTime(1999, 11, 20), NationalityId = "11112222333" };
            Player mehmet = new Player() { Name = "Mehmet", LastName = "Gülce", UserName = "mehmetg", Password = "1234567890", DateOfBirth = new DateTime(2007, 01, 6), NationalityId = "11112222333" };

            playerManager.Add(selim);
            playerManager.Add(emre);
            playerManager.Add(mehmet);



            Game hitman2 = new Game() { Name = "Hitman 2", Price = (double)59.90 };
            Game pubg = new Game() { Name = "PUBG", Price = (double)79.90 };
            Game rocketLeague = new Game() { Name = "Rocket League", Price = (double)29.90 };

            IGameService gameManager = new GameManager(loggerServices);

            gameManager.Add(pubg);
            gameManager.Add(hitman2);
            gameManager.Add(rocketLeague);




            ISalesService winterSales = new WinterSalesManager(loggerServices);


            IPlatformService platformManager = new SteamPlatformManager(new List<ISalesService> { winterSales });
            platformManager.BuyGameFromPlayer(selim, pubg);
            platformManager.BuyGameFromPlayer(emre, hitman2);
            platformManager.BuyGameFromPlayer(mehmet, rocketLeague);
            platformManager.RefundGameFromPlayer(selim, pubg);


            Console.ReadLine();
        }
    }
}
