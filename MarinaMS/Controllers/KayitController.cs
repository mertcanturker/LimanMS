using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MarinaMS.Controllers
{
    public class KayitController : Controller
    {

        TekneManager tekneManager = new TekneManager(new EfTekneDal());
        public IActionResult Index()
        {

            var values=tekneManager.GetListAll();
            return View(values);
        }

        public IActionResult Harita() { return View(); }
        [HttpGet]

        public IActionResult AddTekne() {
            List<SelectListItem> tekneList = (from x in tekneManager.GetListAll()
                                                     select new SelectListItem
                                                     {
                                                         Text = x.TekneTipi,
                                                         Value = x.TekneId.ToString(),


                                                     }).ToList();
            ViewBag.tekneList = tekneList;

            return View();
        }

        [HttpPost]

        public IActionResult AddTekne(Tekne tekne)
        {
            tekneManager.Insert(tekne);

            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult UpdateTekne(int id) {

            var value = tekneManager.GetById(id);
            return View(value);
        
        
        }
        [HttpPost]

        public IActionResult UpdateTekne(Tekne tekne)
        {
            
            tekneManager.Update(tekne);
            return RedirectToAction("Index");
        }

       public IActionResult DeleteTekne(int id)
        {
            var value = tekneManager.GetById(id);
            tekneManager.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult JurnalTekne(int id)
        {

            var value = tekneManager.GetById(id);
            return View(value);


        }
        [HttpPost]

        public IActionResult JurnalTekne(Tekne tekne)
        {

            tekneManager.Update(tekne);
            return RedirectToAction("Index");
        }





    }
}
