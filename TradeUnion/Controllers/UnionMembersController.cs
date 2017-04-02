using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TradeUnion.Models;

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

        #region --工会成员信息
        /// <summary>
        /// 添加工会成员信息
        /// </summary>
        /// <returns></returns>
        public ActionResult AddMbs(KeHu model)
        {

            SQLHelper sqlh = new SQLHelper();
            const string AddMbssql = @"INSERT INTO dbo.TB_KeHu
                                       ( Address, BianHao,IDCard,LeiXing,LianXIFangShi,PassWord,ShengRi,XingMing) 
                                        VALUES  ( @Address, 
                                                  @BianHao,
			                                      @IDCard,
                                                  @LeiXing,
                                                  @LianXIFangShi,
                                                  @PassWord,
                                                  @ShengRi,
                                                  @XingMing
                                         ) ";
            SqlParameter[] para = new SqlParameter[]
            {
              new SqlParameter("Address",model.Address),
              new SqlParameter("BianHao", model.BianHao),
              new SqlParameter("IDCard", model.IDCard),
              new SqlParameter("LeiXing", model.LeiXing),
              new SqlParameter("LianXIFangShi", model.LianXIFangShi),
              new SqlParameter("PassWord", model.PassWord),
              new SqlParameter("ShengRi", model.ShengRi),
              new SqlParameter("XingMing", model.XingMing)
              
             };
            sqlh.ExecData(AddMbssql, para);
            return RedirectToAction("ScanUnionMembersIndex", "UnionMembers");
        }



        #endregion

    }
}