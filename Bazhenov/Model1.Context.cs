﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bazhenov
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DmitriiEntities : DbContext
    {
        public DmitriiEntities()
            : base("name=DmitriiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Batch> Batch { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Employer> Employer { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<Toy> Toy { get; set; }
        public virtual DbSet<ToyInOrder> ToyInOrder { get; set; }
        public virtual DbSet<ToyMaterial> ToyMaterial { get; set; }
    }
}