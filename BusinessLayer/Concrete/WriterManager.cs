﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Entity.Concencrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public Writer GetById(int id)
        {
            return _writerDal.GetById(id);
        }

        public List<Writer> GetList()
        {
            return _writerDal.GetAllList();
        }

        public List<Writer> GetWriterById(int id)
        {
            return _writerDal.GetAllList(x => x.Id == id);
        }


        public void TAdd(Writer t)
        {
            _writerDal.Insert(t);
        }

        public void TDelete(Writer t)
        {
            _writerDal.Delete(t);
        }

        public void TUpdate(Writer t)
        {
            _writerDal.Update(t);
        }

        #region
        public void WriterAdd(Writer writer)
        {
            _writerDal.Insert(writer);
        }
        #endregion
    }
}
