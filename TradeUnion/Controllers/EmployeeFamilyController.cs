using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TradeUnion.Models;

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


        #region --子女信息
        public ActionResult AddCil(ZiNV model)
        {
            SQLHelper sqlh = new SQLHelper();
            const string AddCilsql = @"INSERT INTO dbo.TB_ZiNV
                                       ( BianHao,XingMing,Age,GuanXi,XingMing2,XueLi,XueXiao)
                                        VALUES  ( @BianHao, 
                                                  @XingMing,
			                                      @Age,
                                                  @GuanXi,
                                                  @XingMing2,
                                                  @XueLi,
                                                  @XueXiao
            ) ";
            SqlParameter[] para = new SqlParameter[]
            {
              new SqlParameter("BianHao",model.BianHao),
              new SqlParameter("XingMing", model.XingMing),
              new SqlParameter("Age", model.Age),
              new SqlParameter("GuanXi", model.GuanXi),
              new SqlParameter("XingMing2", model.XingMing2),
              new SqlParameter("XueLi", model.XueLi),
              new SqlParameter("XueXiao", model.XueXiao)
             };
            sqlh.ExecData(AddCilsql, para);
            return RedirectToAction("ScanChildIndex", "EmployeeFamily");
        }
        #endregion

        #region --子女特殊情况
        public ActionResult AddZiNvStatus(FTeShu model)
        {
            SQLHelper sqlh = new SQLHelper();
            const string AddZiNvStatussql = @"INSERT INTO dbo.TB_FTeShu
                                       ( BianHao,XingMing,TeShu)
                                        VALUES  ( @BianHao, 
                                                  @XingMing,
			                                      @TeShu
            ) ";
            SqlParameter[] para = new SqlParameter[]
            {
              new SqlParameter("BianHao",model.BianHao),
              new SqlParameter("XingMing", model.XingMing),
              new SqlParameter("TeShu", model.TeShu)
             };
            sqlh.ExecData(AddZiNvStatussql, para);
            return RedirectToAction("ScanChildStatusIndex", "EmployeeFamily");
        }
        #endregion
    }
}