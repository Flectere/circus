﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace circus.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CircusEntities1 : DbContext
    {
        public CircusEntities1()
            : base("name=CircusEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AnimalCell> AnimalCell { get; set; }
        public virtual DbSet<Application> Application { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<ListPerformance> ListPerformance { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<Training> Training { get; set; }
        public virtual DbSet<TrainingSchedule> TrainingSchedule { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
