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
    public class JurnalSelectManager : IJurnalSelectService
    {

        private readonly ISelect_JurnalDal _select_JurnalDal;

        public JurnalSelectManager(ISelect_JurnalDal select_JurnalDal)
        {
            _select_JurnalDal = select_JurnalDal;
        }

        public void Delete(JurnalSelect t)
        {
           _select_JurnalDal.Delete(t); 
        }

        public JurnalSelect GetById(int id)
        {
            return _select_JurnalDal.GetById(id);
        }

        public List<JurnalSelect> GetListAll()
        {
            return _select_JurnalDal.GetListAll();
        }

        public void Insert(JurnalSelect t)
        {
            _select_JurnalDal.Insert(t);
        }

        public void Update(JurnalSelect t)
        {
            _select_JurnalDal.Update(t);
        }
    }
}
