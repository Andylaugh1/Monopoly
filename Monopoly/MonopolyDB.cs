using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly.NewDb
{
    public class MonopolyDB : DbContext
    {
        public DbSet<Piece> Pieces { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Space> Spaces { get; set; }
        public DbSet<MiddleCard> MiddleCards { get; set; }        
        public DbSet<Property> Properties { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<RailwayStation> Stations { get; set; }
        public DbSet<NonBuyableSpace> NonBuyableSpaces { get; set; }
        public DbSet<Board> Board { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\sqlexpress;Database=Monopoly.NewDb;Trusted_Connection=True;");
        }

    }
}
