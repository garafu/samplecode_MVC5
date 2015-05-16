namespace WebApplication.Controllers
{
    using System.Web.Mvc;
    using WebApplication.Models;

    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = new Greeting();
            
            model.Message = "Hello World !";

            return this.View(model);
        }
    }
}