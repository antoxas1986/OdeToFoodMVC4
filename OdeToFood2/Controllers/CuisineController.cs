
using OdeToFood2.Filter;
using System.Web.Mvc;

namespace OdeToFood2.Controllers
{
    [Log]
    public class CuisineController : Controller
    {
        [Authorize]
        public ActionResult Search(string name = "French")
        {
            throw new System.Exception("bs;kd;asdkf");
            var mes = Server.HtmlEncode(name);
            return Content(mes);
        }
    }
}
