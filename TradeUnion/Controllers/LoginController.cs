using Models;
using System.Data;
using System.Data.SqlClient;
using System.Web.Mvc;


namespace TradeUnion.Controllers
{
    public class LoginController : Controller
    {
        #region  ---返回该控制器的视图
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        // GET: Login
        public ActionResult LoginIndex()
        {
            return View();
        }
        #endregion

        #region  ---账号密码检查
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult LoginAction(Login model)
        {
            string name = model.UserName;  //name 为 视图中获取的 输入框中  name为UserName 值
            string pwd = model.PassWord; //pwd 为 视图中获取的 输入框中 name为PassWord 值

            SQLHelper sqlCheck = new SQLHelper(); //创建数据库工具类的对象
            string Adminsql = "select * from TB_Admin where UserName='{0}' and Password='{1}' "; //SQL查询语句
            string Admin = string.Format(Adminsql, name, pwd); //把SQL语句 和参数整合在一个字符串里
            DataTable dt = SQLHelper.GetDataSet(Admin).Tables[0]; //调用工厂类的方法进行查询并获取返回值

            if (dt.Rows.Count > 0) //如果获取到数据，行高>0 ; 如果没有获取到数据，行高=0；
            {
                return RedirectToAction("HomeIndex", "Home"); //重定向到控制器Home 中的HomeIndex方法
            }
            else
            {
                return Redirect("LoginIndex");//重定向到本控制器中的LoginIndex方法
            }
        }
        #endregion

    }
}