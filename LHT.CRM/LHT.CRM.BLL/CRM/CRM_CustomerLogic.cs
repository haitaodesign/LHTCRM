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
        /// 根据业务员id返回客户信息
        /// </summary>
        /// <param name="saleid"></param>
        /// <returns></returns>
        public List<CRM_Customer> GetAll(int saleid)
        {
            return ccs.GetAll(saleid);
        }



    }
}