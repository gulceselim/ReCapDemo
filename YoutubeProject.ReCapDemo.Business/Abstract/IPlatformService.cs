using System;
using System.Collections.Generic;
using System.Text;
using YoutubeProject.ReCapDemo.Entities.Abstract;

namespace YoutubeProject.ReCapDemo.Business.Abstract
{
    public interface IPlatformService
    {
        void BuyGameFromPlayer(IEntity player, IEntity game);
        void RefundGameFromPlayer(IEntity player, IEntity game);
    }
}
