﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectManagement.DLL.ORM
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class ProjectManagementEntities : DbContext
    {
        public ProjectManagementEntities()
            : base("name=ProjectManagementEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AccountGroup> AccountGroups { get; set; }
        public DbSet<CreditLimit> CreditLimits { get; set; }
        public DbSet<del_Mat_AccountTwo> del_Mat_AccountTwo { get; set; }
        public DbSet<GroupByItem> GroupByItems { get; set; }
        public DbSet<GroupBySupplier> GroupBySuppliers { get; set; }
        public DbSet<history_store> history_store { get; set; }
        public DbSet<Mat_AccountTwo> Mat_AccountTwo { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<QtyMaterial> QtyMaterials { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<user> users { get; set; }
    
        public virtual int Add_Data()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Add_Data");
        }
    
        public virtual int Add_Field()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Add_Field");
        }
    
        public virtual int Add_Field_supplier()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Add_Field_supplier");
        }
    
        public virtual int CashBankUpdateSupplier()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CashBankUpdateSupplier");
        }
    
        public virtual int UpdateSupplier()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateSupplier");
        }
    }
}
