using Entity.Concencrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ImessageService:IGenericService<Message>
    {
        public List<Message> getListWriter(string p);
    }
}
