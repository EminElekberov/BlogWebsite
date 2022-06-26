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
    public class EfCommentyRepository : GenericRepository<Comment>, ICommentDal
    {
        public List<Comment> GetListComment()
        {
            using (var c = new MyContext())
            {
                return c.Comments.Include(x => x.Blog).ToList();
            };
        }
    }
}
