﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace LHT.CRM.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using LHT.CRM.Model;
    
    public partial class LHTCRMEntities : DbContext
    {
        public LHTCRMEntities()
            : base("name=LHTCRMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<SystemLogin> SystemLogins { get; set; }
        public virtual DbSet<SystemModule> SystemModules { get; set; }
        public virtual DbSet<SystemRole> SystemRoles { get; set; }
        public virtual DbSet<SystemRoleAuthority> SystemRoleAuthorities { get; set; }
        public virtual DbSet<SystemUser> SystemUsers { get; set; }
        public virtual DbSet<CRM_Customer> CRM_Customer { get; set; }
        public virtual DbSet<CRM_Contact> CRM_Contact { get; set; }
        public virtual DbSet<CRM_Visit> CRM_Visit { get; set; }
    }
}
