using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Entity.Concencrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogDal.GetAllList(x => x.WriterId == id);
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> GetCategoryList()
        {
            return _blogDal.GetAllWithCategory();
        }
        public List<Blog> GetListWIthCategoryByWriterBm(int id)
        {
            return _blogDal.GetWithCategoryByWriter(id);
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetAllList();
        }

        public void TAdd(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void TDelete(Blog t)
        {
            _blogDal.Delete(t);
        }

        public void TUpdate(Blog t)
        {
            _blogDal.Update(t);
        }

        //public void Add(Blog item)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Delete(Blog item)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Blog> GetAllList()
        //{
        //    return _blogDal.GetAllList();
        //}

        //public Blog GetById(int id)
        //{
        //    throw new NotImplementedException();
        //}
        //public List<Blog> GetBloById(int id)
        //{
        //    return _blogDal.GetAllList(x => x.Id == id); 
        //}
        public List<Blog> GetLastBlog()
        {
            return _blogDal.GetAllList().Take(3).ToList();
        }
        //public List<Blog> GetCategoryList()
        //{
        //    return _blogDal.GetAllWithCategory();
        //}

        //public void Update(Blog item)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Blog> GetBlogListByWriter(int id)
        //{
        //    return _blogDal.GetAllList(x => x.WriterId == id);
        //}

    }
}
