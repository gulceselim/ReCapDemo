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

        public void Add(Game game)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Add(game);
            }
        }

        public void Delete(Game game)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Delete(game);
            }
        }       

        public void Update(Game game)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Update(game);
            }
        }
    }
}
