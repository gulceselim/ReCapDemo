using System;
using System.Collections.Generic;
using System.Text;
using YoutubeProject.ReCapDemo.Entities.Abstract;

namespace YoutubeProject.ReCapDemo.Business.Abstract
{
    public interface IGameService
    {
        void Add(IEntity game);
        void Delete(IEntity game);
        void Update(IEntity game);

    }
}
