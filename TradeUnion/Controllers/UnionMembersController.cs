using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TradeUnion.Controllers
{
    public class UnionMembersController : Controller
    {
        #region --返回视图
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        // GET: UnionMembers
        public ActionResult UnionMembersIndex()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult AddUnionMembersIndex()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult ScanUnionMembersIndex()
        {
            return View();
        }
        #endregion
    }
}