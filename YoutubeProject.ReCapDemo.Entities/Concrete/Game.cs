using System;
using System.Collections.Generic;
using System.Text;
using YoutubeProject.ReCapDemo.Entities.Abstract;

namespace YoutubeProject.ReCapDemo.Entities.Concrete
{
    public class Game : IEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
