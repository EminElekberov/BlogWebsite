using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Entity.Concencrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewsLaterManager : INewsLetterService
    {
        INewsLetterDal _newsLetterDal;

        public NewsLaterManager(INewsLetterDal newsLetterDal)
        {
            _newsLetterDal = newsLetterDal;
        }

        public void AddNewsLetter(NewsLater newsLater)
        {
            _newsLetterDal.Insert(newsLater);
        }
    }
}
