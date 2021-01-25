using System;
using System.Collections.Generic;
using System.Text;
using YoutubeProject.ReCapDemo.Entities.Abstract;

namespace YoutubeProject.ReCapDemo.Business.Abstract
{
    public interface IPlayerService
    {
        void Add(IEntity player);
        void Delete(IEntity player);
        void Update(IEntity player);

    }
}
