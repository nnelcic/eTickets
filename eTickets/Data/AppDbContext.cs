﻿using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(actor_movie => new
            {
                actor_movie.ActorId,
                actor_movie.MovieId
            });

            modelBuilder.Entity<Actor_Movie>()
                .HasOne(movie => movie.Movie)
                .WithMany(actor_movie => actor_movie.Actors_Movies)
                .HasForeignKey(movie => movie.MovieId);

            modelBuilder.Entity<Actor_Movie>()
                .HasOne(movie => movie.Actor)
                .WithMany(actor_movie => actor_movie.Actors_Movies)
                .HasForeignKey(movie => movie.ActorId);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Actor_Movie> Actor_Movies { get; set; }
        public DbSet<Cinema> Cinema { get; set; }
    }
}