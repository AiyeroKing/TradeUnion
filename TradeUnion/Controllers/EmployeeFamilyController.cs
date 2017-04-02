using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TradeUnion.Controllers
{
    public class EmployeeFamilyController : Controller
    {
        #region   --返回视图
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        // GET: EmployeeFamily
        public ActionResult EmployeeFamilyIndex()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult AddChildIndex()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult AddChildStatusIndex()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult ScanChildIndex()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult ScanChildStatusIndex()
        {
            return View();
        }
        #endregion
    }
}