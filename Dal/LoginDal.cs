﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class LoginDal
    {
        
        DBHelper sqlogin = new DBHelper();
        #region --对数据进行增加操作的Dal语句--
        SQLHelper sqlh = new SQLHelper();
        public bool AddUserMSG(UserInfo model)
        {
            var result = false;
            const string adduserMSGSql = @"
                                INSERT INTO dbo.UserInfo
                                        ( UserName, PassWord) 
                                VALUES  ( @UserName, 
                                          @PassWord 
                                    ) ";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("UserName",model.UserName),
                new SqlParameter("PassWord", model.PassWord)
                };
            sqlh.ExecData(adduserMSGSql, para);

            return result;

        }
        #endregion
    }
}
