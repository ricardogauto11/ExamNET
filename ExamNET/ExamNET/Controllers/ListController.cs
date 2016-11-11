using System.Linq;
using System.Web.Mvc;

namespace ExamNET.Controllers
{
    public class ListController : Controller
    {
        // GET: List
        public ActionResult Index()
        {
            var context = db.Pet;
            var list = context.Where(m => m.State.Equals("For"));
            return View();
        }
    }
}
