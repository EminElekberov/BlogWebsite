using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Entity.Concencrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NotoficationManager : INOtificationService
    {
        INotificationDal _notification;

        public NotoficationManager(INotificationDal notification)
        {
            _notification = notification;
        }

        public Notification GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Notification> GetList()
        {
            return _notification.GetAllList();
        }

        public void TAdd(Notification t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Notification t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Notification t)
        {
            throw new NotImplementedException();
        }
    }
}
