using Entity.Concencrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface Imessage2Service: IGenericService<Message2>
    {
        public List<Message2> getListWriter(int id);

    }
}
