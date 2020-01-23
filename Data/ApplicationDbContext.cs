using System;
using Leo.ResumeProfile.Entities;
using Microsoft.EntityFrameworkCore;

namespace Leo.ResumeProfile.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<ResumeUser> ResumeUsers { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            Database.Migrate(); // Migrate method needs Microsoft.EntityFrameworkCore.Design
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seed the database with dummy data
            modelBuilder.Entity<ResumeUser>().HasData(
                new ResumeUser()
                {
                    Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                    DateOfBirth = new DateTime(1650, 7, 23),
                    PlaceOfBirth = "Griffin Beak Eldritch",
                    Passport = "Berry",
                    MobileNo = "Ships",
                    NameChn = "林佳伟",
                    NameEng = "Leo Lin",
                    NameJpn = "林佳偉"
                },
                new ResumeUser()
                {
                    Id = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                    DateOfBirth = new DateTime(1668, 5, 21),
                    PlaceOfBirth = "Swashbuckler Rye",
                    Passport = "Nancy",
                    MobileNo = "Rum",
                    NameChn = "林佳伟2",
                    NameEng = "Leo Lin2",
                    NameJpn = "林佳偉2"
                },
                new ResumeUser()
                {
                    Id = Guid.Parse("2902b665-1190-4c70-9915-b9c2d7680450"),
                    DateOfBirth = new DateTime(1701, 12, 16),
                    PlaceOfBirth = "Ivory Bones Sweet",
                    Passport = "Eli",
                    MobileNo = "Singing",
                    NameChn = "林佳伟3",
                    NameEng = "Leo Lin3",
                    NameJpn = "林佳偉3"
                },
                new ResumeUser()
                {
                    Id = Guid.Parse("102b566b-ba1f-404c-b2df-e2cde39ade09"),
                    DateOfBirth = new DateTime(1702, 3, 6),
                    PlaceOfBirth = "The Unseen Stafford",
                    Passport = "Arnold",
                    MobileNo = "Singing",
                    NameChn = "林佳伟4",
                    NameEng = "Leo Lin4",
                    NameJpn = "林佳偉4"
                },
                new ResumeUser()
                {
                    Id = Guid.Parse("5b3621c0-7b12-4e80-9c8b-3398cba7ee05"),
                    DateOfBirth = new DateTime(1690, 11, 23),
                    PlaceOfBirth = "Toxic Reyson",
                    Passport = "Seabury",
                    MobileNo = "Maps",
                    NameChn = "林佳伟5",
                    NameEng = "Leo Lin5",
                    NameJpn = "林佳偉5"
                },
                new ResumeUser()
                {
                    Id = Guid.Parse("2aadd2df-7caf-45ab-9355-7f6332985a87"),
                    DateOfBirth = new DateTime(1723, 4, 5),
                    PlaceOfBirth = "Fearless Cloven",
                    Passport = "Rutherford",
                    MobileNo = "General debauchery",
                    NameChn = "林佳伟6",
                    NameEng = "Leo Lin6",
                    NameJpn = "林佳偉6"
                },
                new ResumeUser()
                {
                    Id = Guid.Parse("2ee49fe3-edf2-4f91-8409-3eb25ce6ca51"),
                    DateOfBirth = new DateTime(1721, 10, 11),
                    PlaceOfBirth = "Crow Ridley",
                    Passport = "Atherton",
                    MobileNo = "Rum",
                    NameChn = "林佳伟7",
                    NameEng = "Leo Lin7",
                    NameJpn = "林佳偉7"
                }
                );

            modelBuilder.Entity<Resume>().HasData(
               new Resume
               {
                   Id = Guid.Parse("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                   ResumeUserId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                   Title = "Commandeering a Ship Without Getting Caught",
                   Description = "Commandeering a ship in rough waters isn't easy.  Commandeering it without getting caught is even harder.  In this course you'll learn how to sail away and avoid those pesky musketeers."
               },
               new Resume
               {
                   Id = Guid.Parse("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                   ResumeUserId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                   Title = "Overthrowing Mutiny",
                   Description = "In this course, the ResumeUser provides tips to avoid, or, if needed, overthrow pirate mutiny."
               },
               new Resume
               {
                   Id = Guid.Parse("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                   ResumeUserId = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                   Title = "Avoiding Brawls While Drinking as Much Rum as You Desire",
                   Description = "Every good pirate loves rum, but it also has a tendency to get you into trouble.  In this course you'll learn how to avoid that.  This new exclusive edition includes an additional chapter on how to run fast without falling while drunk."
               },
               new Resume
               {
                   Id = Guid.Parse("40ff5488-fdab-45b5-bc3a-14302d59869a"),
                   ResumeUserId = Guid.Parse("2902b665-1190-4c70-9915-b9c2d7680450"),
                   Title = "Singalong Pirate Hits",
                   Description = "In this course you'll learn how to sing all-time favourite pirate songs without sounding like you actually know the words or how to hold a note."
               }
               );

            base.OnModelCreating(modelBuilder);
        }
    }
}