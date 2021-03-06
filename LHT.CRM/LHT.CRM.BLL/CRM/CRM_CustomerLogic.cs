﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.Model;
using LHT.CRM.DAL.ServiceRespository.CRM;

namespace LHT.CRM.BLL.CRM
{
    public class CRM_CustomerLogic
    {
        CRM_CustomerService ccs = new CRM_CustomerService();

        /// <summary>
        /// 返回所有的客户信息
        /// </summary>
        /// <returns></returns>
        public List<CRM_Customer> GetAll()
        {
            return ccs.GetAll();
        }

        /// <summary>
        /// 根据客户名称返回客户Id
        /// </summary>
        /// <param name="cusname"></param>
        /// <returns></returns>
        public int GetCusId(string cusname)
        {
            try
            {
                int cusId = ccs.GetAll().Find(c => c.CusName == cusname).Id;
                return cusId;
            }
            catch
            {
                return 0;
            }
            
        }

        /// <summary>
        /// 根据Id返回客户名称
        /// </summary>
        /// <param name="cusId"></param>
        /// <returns></returns>
        public string GetCusName(int cusId)
        {
            string cusname = ccs.GetAll().Find(c => c.Id == cusId).CusName;
            if (cusname != null)
            {
                return cusname;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 根据业务员id返回客户信息
        /// </summary>
        /// <param name="saleid"></param>
        /// <returns></returns>
        public List<CRM_Customer> GetAll(int saleid)
        {
            return ccs.GetAll(saleid);
        }

        /// <summary>
        /// 添加一个客户
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public int AddCustomer(CRM_Customer customer)
        {
            ccs.Add(customer);
            int result = ccs.SaveChanges();
            if (result > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 修改客户信息
        /// </summary>
        /// <param name="custoemr"></param>
        /// <returns></returns>
        public int UpdateCustomer(CRM_Customer custoemr)
        {
            ccs.Update(custoemr);
            int result = ccs.SaveChanges();
            if (result > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 删除一条客户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteCustomer(int id)
        {
            ccs.Delete(id);
            int result = ccs.SaveChanges();
            if (result > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


    }
}
