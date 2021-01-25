using System;
using System.Collections.Generic;
using System.Text;
using YoutubeProject.ReCapDemo.Entities.Abstract;

namespace YoutubeProject.ReCapDemo.DataAccess.Abstract
{
    public interface ILoggerService
    {
        void Add(IEntity entity);
        void Delete(IEntity entity);
        void Update(IEntity entity);
    }
}
