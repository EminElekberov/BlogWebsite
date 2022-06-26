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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void CommentAdd(Comment comment)
        {
            _commentDal.Insert(comment);
        }

        public List<Comment> GetCommentwithBlog()
        {
            return _commentDal.GetListComment();
        }

        public List<Comment> GetList(int id)
        {
            return _commentDal.GetAllList(x => x.BlogId == id);
        }
    }
}
