using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TradeUnion.Controllers
{
    public class UnionInforController : Controller
    {
        #region --返回视图
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        // GET: UnionInfor
        public ActionResult UnionInforIndex()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult AddUnionArchiIndex()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult AddUnionPolicyIndex()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult AddUnionAnnounIndex()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult ScanUnionArchiIndex()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult ScanUnionPolicyIndex()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult ScanUnionAnnounIndex()
        {
            return View();
        }
        #endregion
    }
}