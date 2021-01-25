using System;
using System.Collections.Generic;
using System.Text;
using YoutubeProject.ReCapDemo.Business.Abstract;
using YoutubeProject.ReCapDemo.DataAccess.Abstract;
using YoutubeProject.ReCapDemo.Entities.Abstract;
using YoutubeProject.ReCapDemo.Entities.Concrete;

namespace YoutubeProject.ReCapDemo.Business.Concrete
{
    public class WinterSalesManager : ISalesService
    {
        private List<ILoggerService> _loggerServices;

        public WinterSalesManager(List<ILoggerService> loggerServices)
        {
            _loggerServices = loggerServices;
        }
        public void Discount(Game game)
        {
            game.Price *= (double) 0.90;
        }

    }
}
