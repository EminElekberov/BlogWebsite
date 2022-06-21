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
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetAllWithCategory()
        {
            using (var c=new MyContext())
            {
                return c.Blogs.Include(x => x.Category).ToList();
            }
        }

        public List<Blog> GetWithCategoryByWriter(int id)
        {

            using (var c = new MyContext())
            {
                return c.Blogs.Include(x => x.Category).Where(x=>x.WriterId==id).ToList();
            }
        }
    }
}
