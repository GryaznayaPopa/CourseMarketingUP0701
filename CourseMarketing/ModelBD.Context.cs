﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourseMarketing
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities2 : DbContext
    {
        public Entities2()
            : base("name=Entities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ClientM> ClientM { get; set; }
        public virtual DbSet<ContractMar> ContractMar { get; set; }
        public virtual DbSet<ServiceMar> ServiceMar { get; set; }
        public virtual DbSet<StatusContractMar> StatusContractMar { get; set; }
        public virtual DbSet<StatusPaymentMar> StatusPaymentMar { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}