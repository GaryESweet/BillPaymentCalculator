﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BillPaymentCalculator.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BillPaymentCalculatorEntities : DbContext
    {
        public BillPaymentCalculatorEntities()
            : base("name=BillPaymentCalculatorEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual int insBuisnessNames(string buisnessName)
        {
            var buisnessNameParameter = buisnessName != null ?
                new ObjectParameter("BuisnessName", buisnessName) :
                new ObjectParameter("BuisnessName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insBuisnessNames", buisnessNameParameter);
        }
    }
}
