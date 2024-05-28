using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MarinaMS.Controllers
{
    public class TakipController : Controller
    {


        TekneManager tekneManager = new TekneManager(new EfTekneDal());

        public TakipController(TekneManager tekneManager)
        {
            this.tekneManager = tekneManager;
        }

        public IActionResult Index()
        {
            var values=tekneManager.GetListAll();
            
            return View(values);
        }
    }
}
