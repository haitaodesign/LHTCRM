using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LHT.CRM.BLL.SystemManagement;
using LHT.CRM.Model;

namespace LHT.CRM.App
{
    public class frmFuncLib
    {
        #region “定义系统全局字段”
        //主界面显示用户名
        public static string userName;
        //获取该用户的数据权限
        public static int userId;
        //判断该用户的角色拥有的模块功能权限
        public static string roleName;
        //检索该角色拥有的模块权限
        public static int roleId;
        #endregion

        

        #region "登陆密码验证"
        /// <summary>
        /// 登陆密码验证
        /// </summary>
        /// <param name="password">输入的密码</param>
        /// <returns></returns>
        public static ErrorInfo IsValidPassword(string password)
        {
            ErrorInfo error = new ErrorInfo();
            error.HasError = false;
            if (string.IsNullOrEmpty(password))
            {
                error.HasError = true;
                error.ErrorCode = 1;
                error.ErrorMessage = "密码不能为空";
            }
            else if (password.Length < 8)
            {
                error.HasError = true;
                error.ErrorCode = 2;
                error.ErrorMessage = "密码长度不能小于8";
            }
            else if (Regex.IsMatch(password, @"^\d*$"))
            {
                error.HasError = true;
                error.ErrorCode = 3;
                error.ErrorMessage = "密码不能为纯数字";
            }
            else if (Regex.IsMatch(password, @"^[a-zA-Z]*$"))
            {
                error.HasError = true;
                error.ErrorCode = 4;
                error.ErrorMessage = "密码不能是纯字母";
            }
            return error;
        }

        /// <summary>
        /// 判断用户是否具某个模块的权限
        /// </summary>
        /// <returns></returns>
        public bool IsOpenModules(string modulename)
        {
            //通过RoleId获取授权的模块列表,返回的应该是一个数组
            //通过modulename遍历数据是否与模块名匹配，不配返回false
            SystemRoleAuthorityLogic sral = new SystemRoleAuthorityLogic();
            List<SystemRoleAuthority> modulelist = sral.GetAuthList(roleId);
            bool isTrue = false; ;
            foreach (var item in modulelist)
            {
                string module=item.ModuleName;
                if (module == modulename)
                {
                    isTrue = true;
                }
                else
                {
                }
            }
            return isTrue;
        }


        #endregion
    }
}
