using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TradeUnion.Controllers
{
    public class EmployeeBenefitsController : Controller
    {
        #region ---返回视图
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        // GET: EmployeeBenefits
        public ActionResult EmployeeBenefitsIndex()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult AddBodyExamIndex()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult AddBirthdayIndex()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult AddInsuranceIndex()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult AddSpecialIndex()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult ScanBodyExamIndex()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult ScanBirthdayIndex()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult ScanInsuranceIndex()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult ScanSpecialIndex()
        {
            return View();
        }
        #endregion
    }
}