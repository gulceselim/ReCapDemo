using System;
using System.Collections.Generic;
using System.Text;
using YoutubeProject.ReCapDemo.Business.Abstract;
using YoutubeProject.ReCapDemo.Business.ValidationRules.Abstract;
using YoutubeProject.ReCapDemo.DataAccess.Abstract;
using YoutubeProject.ReCapDemo.Entities.Abstract;
using YoutubeProject.ReCapDemo.Entities.Concrete;

namespace YoutubeProject.ReCapDemo.Business.Concrete
{
    public class PlayerManager : IPlayerService
    {
        private IPersonCheckService _personCheckService;
        private List<ILoggerService> _loggerServices;

        public PlayerManager(IPersonCheckService personCheckService, List<ILoggerService> loggerServices)
        {
            _personCheckService = personCheckService;
            _loggerServices = loggerServices;
        }

        public void Add(Player player)
        {
            if (_personCheckService.CheckIfRealPerson(player))
            {
                foreach (var logger in _loggerServices)
                {
                    logger.Add(player);
                }
            }
            else
            {
                throw new Exception($"{player.Name} doğrulamadan geçemedi.");
            }
        }
        
        public void Delete(Player player)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Delete(player);
            }
        }

        public void Update(Player player)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Update(player);
            }
        }

       
    }
}
