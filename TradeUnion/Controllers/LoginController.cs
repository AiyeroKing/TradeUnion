using Models;
using System.Data.SqlClient;
using System.Web.Mvc;




namespace TradeUnion.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult LoginIndex()
        {
            return View();
        }


           
      public ActionResult LoginAction(Login model)
        {
            string name = model.UserName;
            string pa = model.PassWord;







            return RedirectToAction("HomeIndex", "Home");
        }



    }
}