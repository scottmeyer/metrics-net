using System.Web.Mvc;
using metrics;
using metrics.Util;

namespace Flot.Controllers
{
    public class HomeController : Controller
    {
        private readonly Metrics _metrics = new Metrics();
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult GetSample()
        {
            var content = Serializer.Serialize(_metrics.AllSorted);
            return Content(content);
        }
    }
}
