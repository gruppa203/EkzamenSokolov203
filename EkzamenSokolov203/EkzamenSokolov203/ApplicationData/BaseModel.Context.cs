﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EkzamenSokolov203.ApplicationData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class BDSokolovEntities : DbContext
    {
        private static BDSokolovEntities _context;
        public BDSokolovEntities()
            : base("name=BDSokolovEntities")
        {
        }
        public static BDSokolovEntities GetContext()
        {
            if (_context == null)
                _context = new BDSokolovEntities();
            return _context;

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Kategorii> Kategorii { get; set; }
        public virtual DbSet<Polzovateli> Polzovateli { get; set; }
        public virtual DbSet<Postavchiki> Postavchiki { get; set; }
        public virtual DbSet<Proizvoditeli> Proizvoditeli { get; set; }
        public virtual DbSet<Roli> Roli { get; set; }
        public virtual DbSet<Tovari> Tovari { get; set; }
    }
}
