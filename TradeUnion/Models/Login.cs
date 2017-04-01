using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// TB_Admin 表实体类
/// </summary>
namespace Models
{
    public class Login
    {
        public int ID
        {
            get;
            set;
        }
        public string UserName
        {
            get;
            set;
        }
        public string PassWord
        {
            get;
            set;
        }
    }
}