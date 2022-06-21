using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using Entity.Concencrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfMessage2Repository : GenericRepository<Message2>, IMessage2Dal
    {
        public List<Message2> GetListWithMessageByWriter(int id)
        {
            using (var c = new MyContext())
            {
                return c.Message2s.Include(x => x.ReceiverUser).Where(x => x.ReceiverId == id).Include(x=>x.SenderUser).ToList();
            }
        }
    }
}
