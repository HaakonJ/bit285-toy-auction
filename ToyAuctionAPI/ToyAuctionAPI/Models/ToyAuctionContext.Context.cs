﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToyAuctionAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Toy_AuctionEntities : DbContext
    {
        public Toy_AuctionEntities()
            : base("name=Toy_AuctionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Toy> Toys { get; set; }
        public virtual DbSet<Auction> Auctions { get; set; }
        public virtual DbSet<CurrentBid> CurrentBids { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
