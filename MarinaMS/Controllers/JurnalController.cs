using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MarinaMS.Controllers
{
    public class JurnalController : Controller
    {
        Context context = new Context();
        

        JurnalManager jurnalManager=new JurnalManager(new EfJurnalDal());
        JurnalSelectManager jurnalSelectManager = new JurnalSelectManager(new EfJurnal_SelectDal());
       

        public IActionResult Index()
        {
            var values=jurnalManager.GetListAll();  
            return View(values);
        }
        [HttpGet]

        public IActionResult AddJurnal(int TekneId, string tekneIsmi) {

            List<SelectListItem> jurnalSelectList = (from x in jurnalSelectManager.GetListAll()
                                           select new SelectListItem
                                           {
                                               Text = x.JurnalSelectName,
                                               Value = x.JurnalSelectName


                                           }).ToList();
            ViewBag.jurnalSelectList=jurnalSelectList;

            List<SelectListItem> hareketSelectList = (from x in jurnalSelectManager.GetListAll()
                                           select new SelectListItem
                                           {
                                               Text = x.HareketSelectName,
                                               Value = x.HareketSelectName


                                           }).ToList();
            ViewBag.hareketSelectList=hareketSelectList;

            var model = new Jurnal
            {
                TekneId = TekneId,
                TekneIsmi = tekneIsmi
            };

            return View(model); }

        [HttpPost]
        public IActionResult AddJurnal(Jurnal jurnal) { 
       
        jurnalManager.Insert(jurnal);
        return RedirectToAction("Index");
        
        }

        public IActionResult DeleteJurnal(int id)
        {
            var value = jurnalManager.GetById(id);
            jurnalManager.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult UpdateJurnal(int id)
        {

            var value = jurnalManager.GetById(id);
            return View(value);


        }
        [HttpPost]

        public IActionResult UpdateTekne(Jurnal jurnal)
        {

            jurnalManager.Update(jurnal);
            return RedirectToAction("Index");
        }
    }
}
