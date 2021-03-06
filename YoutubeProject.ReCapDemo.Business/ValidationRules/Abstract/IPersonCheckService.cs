﻿using System;
using System.Collections.Generic;
using System.Text;
using YoutubeProject.ReCapDemo.Entities.Abstract;
using YoutubeProject.ReCapDemo.Entities.Concrete;

namespace YoutubeProject.ReCapDemo.Business.ValidationRules.Abstract
{
    public interface IPersonCheckService
    {
        bool CheckIfRealPerson(Person person);
    }
}
