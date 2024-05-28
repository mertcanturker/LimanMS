using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TekneManager:ITekneService
    {
        private readonly ITekneDal _tekneDal;

        public TekneManager(ITekneDal tekneDal)
        {
            _tekneDal = tekneDal;
        }

        public void Delete(Tekne t)
        {
            _tekneDal.Delete(t);
        }

        public Tekne GetById(int id)
        {
            return _tekneDal.GetById(id);
        }

        public List<Tekne> GetListAll()
        {
            return _tekneDal.GetListAll();
        }

        public void Insert(Tekne t)
        {
           _tekneDal.Insert(t);
        }

        public void Update(Tekne t)
        {
            _tekneDal.Update(t);
        }
    }
}
