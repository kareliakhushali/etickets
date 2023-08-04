using etickets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace etickets.Data
{
    //we need to add dbcontext configurations in startup file
    public class AppDbContext:DbContext
    {
      public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cinema>().HasData(
            new Cinema()
            {
                Id = 1,
                Name = "Cinema 1",
                Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                Description = "This is the description of first cinema"
            },
             new Cinema()
             {
                 Id = 2,
                 Name = "Cinema 2",
                 Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                 Description = "This is the description of second cinema"

             },
             new Cinema()
             {
                 Id = 3,
                 Name = "Cinema 3",
                 Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                 Description = "This is the description of third cinema"

             },
             new Cinema()
             {
                 Id = 4,
                 Name = "Cinema 4",
                 Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                 Description = "This is the description of fourth cinema"

             },
              new Cinema()
              {
                  Id = 5,
                  Name = "Cinema 5",
                  Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                  Description = "This is the description of fifth cinema"
              });



            modelBuilder.Entity<Actor>().HasData(
            new Actor()
            {
                Id = 1,
                FullName = "Actor 1",
                Bio = "This is the Bio of the first actor",
                ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"

            },
                     new Actor()
                        {
                         Id = 2,
                            FullName = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            Id = 3,
                            FullName = "Actor 3",
                            Bio = "This is the Bio of the third actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            Id = 4,
                            FullName = "Actor 4",
                            Bio = "This is the Bio of the fourth actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            Id = 5,
                            FullName = "Actor 5",
                            Bio = "This is the Bio of the fifth actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        });

            modelBuilder.Entity<Producer>().HasData(
                new Producer()
                {
                    Id = 1,
                    FullName = "Producer 1",
                    Bio = "This is the description of first producer",
                    ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"
                    

                },
                        new Producer()
                        {
                            Id = 2,
                            FullName = "Producer 2",
                            Bio = "This is the description of second producer",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg",

                        },
                        new Producer()
                        {
                            Id =3,
                            FullName = "Producer 3",
                            Bio = "This is the description of third producer",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"

                        },
                        new Producer()
                        {
                            Id = 4,
                            FullName = "Producer 4",
                            Bio = "This is the description of fourth producer",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"


                        },
                        new Producer()
                        {
                            Id = 5,
                            FullName = "Producer 4",
                            Bio = "This is the description of fourth producer",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"

                        }
                );
            modelBuilder.Entity<Movie>().HasData(
                new Movie()
                {
                    Id = 1,
                    Name = "Life",
                    Description = "This is the Life movie description",
                    Price = 39.50,
                    ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                    StartDate = DateTime.Now.AddDays(-10),
                    EndDate = DateTime.Now.AddDays(10),
                    CinemaId = 3,
                    ProducerId = 3,
                    MovieCategory = MovieCategory.Documentary
                },
                        new Movie()
                        {
                            Id = 2,
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Id = 3,
                            Name = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Id = 4,
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Id = 5,
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Id = 6,
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama
                        });
            modelBuilder.Entity<Actor_Movie>().HasData(
                new Actor_Movie()
                {
                    ActorId = 1,
                    MovieId = 1
                },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actor_Movie()
                         {
                             ActorId = 1,
                             MovieId = 2
                         },
                         new Actor_Movie()
                         {
                             ActorId = 4,
                             MovieId = 2
                         },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        });




            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actor_Movies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actor_Movies).HasForeignKey(m => m.ActorId);

            base.OnModelCreating(modelBuilder);
        }
        //here actors is the name of column name of database
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movie { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }

        //Order related tables
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; } 

    }
}
