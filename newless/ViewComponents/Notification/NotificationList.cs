using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newless.ViewComponents.Notification
{
    public class NotificationList: ViewComponent
    {
        NotoficationManager writerManager = new NotoficationManager(new EfNotificationRepository());
        public IViewComponentResult Invoke()
        {
            var value = writerManager.GetList();
            return View(value);
        }
    }
}
