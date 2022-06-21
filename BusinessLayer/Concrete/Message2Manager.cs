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
    public class Message2Manager : Imessage2Service
    {
        IMessage2Dal _Imessaagedal;

        public Message2Manager(IMessage2Dal imessaagedal)
        {
            _Imessaagedal = imessaagedal;
        }

        public Message2 GetById(int id)
        {
            return _Imessaagedal.GetById(id);
        }

        public List<Message2> GetList()
        {
            return _Imessaagedal.GetAllList();
        }

        public List<Message2> getListWriter(int id)
        {
            return _Imessaagedal.GetListWithMessageByWriter(id);
        }

        public void TAdd(Message2 t)
        {
            _Imessaagedal.Insert(t);
        }

        public void TDelete(Message2 t)
        {
            _Imessaagedal.Delete(t);
        }

        public void TUpdate(Message2 t)
        {
            _Imessaagedal.Update(t);
        }
    }
}
