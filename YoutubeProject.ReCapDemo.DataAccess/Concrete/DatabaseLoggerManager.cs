using System;
using System.Collections.Generic;
using System.Text;
using YoutubeProject.ReCapDemo.DataAccess.Abstract;
using YoutubeProject.ReCapDemo.Entities.Abstract;

namespace YoutubeProject.ReCapDemo.DataAccess.Concrete
{
    public class DatabaseLoggerManager : ILoggerService
    {
        public void Add(IEntity entity)
        {
            Console.WriteLine($"{entity.Name} Database'e eklendi.");
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine($"{entity.Name} Database'den silindi.");
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine($"{entity.Name} güncellendi.");
        }
    }
}
