﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using Entity.Concencrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfNotificationRepository:GenericRepository<Notification>,INotificationDal
    {
    }
}
