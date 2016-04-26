namespace dummyOuSite.Controllers
{
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult TMA01()
        {
            return this.View();
        }

        public ActionResult TMA02()
        {
            return this.View();
        }

        public ActionResult TMA03()
        {
            return this.View();
        }

        public ActionResult TMA04()
        {
            return this.View();
        }

        public ActionResult EMA()
        {
            return this.View();
        }

        public ActionResult About()
        {
            this.ViewBag.Message = "Your application description page.";

            return this.View();
        }

        public ActionResult Contact()
        {
            this.ViewBag.Message = "Your contact page.";

            return this.View();
        }
    }
}