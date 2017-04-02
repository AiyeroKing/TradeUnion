using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TradeUnion.Controllers
{
    public class UnionFunctionController : Controller
    {
        #region  --返回视图
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        // GET: UnionFunction
        public ActionResult UnionFunctionIndex()
        {
            return View();
        }
        #endregion
    }
}