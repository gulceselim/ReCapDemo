using System;
using System.Collections.Generic;
using System.Text;
using YoutubeProject.ReCapDemo.Business.Abstract;
using YoutubeProject.ReCapDemo.DataAccess.Abstract;
using YoutubeProject.ReCapDemo.Entities.Abstract;
using YoutubeProject.ReCapDemo.Entities.Concrete;

namespace YoutubeProject.ReCapDemo.Business.Concrete
{
    public class GameManager : IGameService
    {
        private List<ILoggerService> _loggerServices;

        public GameManager(List<ILoggerService> loggerServices)
        {
            this._loggerServices = loggerServices;
        }

        public void Add(IEntity game)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Add(game);
            }
        }

        public void Delete(IEntity game)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Add(game);
            }
        }       

        public void Update(IEntity game)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Add(game);
            }
        }
    }
}
