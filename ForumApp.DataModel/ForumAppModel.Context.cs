﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ForumApp.DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ForumAppEntities : DbContext
    {
        public ForumAppEntities()
            : base("name=ForumAppEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Forum> Fora { get; set; }
        public virtual DbSet<ForumThread> ForumThreads { get; set; }
        public virtual DbSet<InstantMessage> InstantMessages { get; set; }
        public virtual DbSet<LoginAttempt> LoginAttempts { get; set; }
        public virtual DbSet<Password> Passwords { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<ThreadReply> ThreadReplies { get; set; }
        public virtual DbSet<Token> Tokens { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserSubscription> UserSubscriptions { get; set; }
    }
}
