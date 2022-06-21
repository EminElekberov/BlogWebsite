using Entity.Concencrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService:IGenericService<Blog>
    {
        //void Add(Blog item);
        //void Delete(Blog item);
        //void Update(Blog item);
        //List<Blog> GetAllList();
        //Blog GetById(int id);
        List<Blog> GetCategoryList();
        List<Blog> GetBlogListByWriter(int id);
    }
}
