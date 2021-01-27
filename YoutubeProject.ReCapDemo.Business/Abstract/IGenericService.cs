using System;
using System.Collections.Generic;
using System.Text;
using YoutubeProject.ReCapDemo.Entities.Abstract;

namespace YoutubeProject.ReCapDemo.Business.Abstract
{
    public interface IGenericService<Entity> where Entity : class, IEntity, new() 
    {
        void Add(Entity entity);
        void Delete(Entity entity);
        void Update(Entity entity);
    }
}
