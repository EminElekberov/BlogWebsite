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
    public class MessageManager : ImessageService
    {
        Imessaagedal _Imessaagedal;

        public MessageManager(Imessaagedal imessaagedal)
        {
            _Imessaagedal = imessaagedal;
        }

        public Message GetById(int id)
        {
            return _Imessaagedal.GetById(id);
        }

        public List<Message> GetList()
        {
            return _Imessaagedal.GetAllList();
        }

        public List<Message> getListWriter(string p)
        {
            return _Imessaagedal.GetAllList(x => x.Receiver == p); 
        }

        public void TAdd(Message t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Message t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
