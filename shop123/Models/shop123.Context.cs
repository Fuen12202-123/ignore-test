﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace shop123.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class shop123Entities : DbContext
    {
        public shop123Entities()
            : base("name=shop123Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<carousel> carousel { get; set; }
        public virtual DbSet<catalogA> catalogA { get; set; }
        public virtual DbSet<catalogB> catalogB { get; set; }
        public virtual DbSet<comment> comment { get; set; }
        public virtual DbSet<delivery> delivery { get; set; }
        public virtual DbSet<refund> refund { get; set; }
        public virtual DbSet<sku> sku { get; set; }
        public virtual DbSet<spu> spu { get; set; }
        public virtual DbSet<favorite> favorite { get; set; }
        public virtual DbSet<orders> orders { get; set; }
        public virtual DbSet<ordersDetail> ordersDetail { get; set; }
        public virtual DbSet<member> member { get; set; }
    }
}
