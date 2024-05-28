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
    public class JurnalManager:IJurnalService
    {
        private readonly IJurnalDal _jurnalDal;
public JurnalManager(IJurnalDal jurnalDal)
        {
            _jurnalDal = jurnalDal;
        }

        public void Delete(Jurnal t)
        {
            _jurnalDal.Delete(t);   
        }

        public Jurnal GetById(int id)
        {
            return _jurnalDal.GetById(id);
        }

        public List<Jurnal> GetListAll()
        {
            return _jurnalDal.GetListAll();
        }

        public void Insert(Jurnal t)
        {
            _jurnalDal.Insert(t);
        }

        public void Update(Jurnal t)
        {
            _jurnalDal.Update(t);
        }
    }
}
