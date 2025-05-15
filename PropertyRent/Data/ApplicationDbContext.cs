using Microsoft.EntityFrameworkCore;
using PropertyRent.Models;

namespace PropertyRent.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Property> Properties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the Property entity
            modelBuilder.Entity<Property>().ToTable("Properties");

            // Add more configurations as needed
        }
    }

    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Check if the database already has data
            if (context.Properties.Any())
            {
                return; // Database has been seeded
            }

            // Seed data
            var properties = new Property[]
            {
                new Property
                {
                    Title = "Modern Studio in IT Park",
                    Description = "A cozy studio apartment located near IT Park, perfect for young professionals working in tech companies.",
                    Address = "123 IT Park Avenue",
                    Location = "Cebu City",
                    PropertyType = "Studio",
                    RentalPrice = 15000,
                    Bedrooms = 1,
                    Bathrooms = 1,
                    HasParking = true,
                    IsFurnished = true,
                    ContactNumber = "+63 912 345 6789",
                    ContactEmail = "studio@ceburent.com",
                    ImageUrl = "/images/property1.jpg"
                },
                new Property
                {
                    Title = "3BR Family Home in Lahug",
                    Description = "Spacious family home with garden in the quiet neighborhood of Lahug, close to schools and amenities.",
                    Address = "45 Lahug Street",
                    Location = "Cebu City",
                    PropertyType = "House",
                    RentalPrice = 35000,
                    Bedrooms = 3,
                    Bathrooms = 2,
                    HasParking = true,
                    IsFurnished = false,
                    ContactNumber = "+63 932 456 7890",
                    ContactEmail = "house@ceburent.com",
                    ImageUrl = "/images/property2.jpg"
                },
                new Property
                {
                    Title = "Luxury Condo in Cebu Business Park",
                    Description = "High-end condo with amazing views of the city, located in the heart of Cebu Business Park.",
                    Address = "78 Business Park Tower",
                    Location = "Cebu City",
                    PropertyType = "Condominium",
                    RentalPrice = 45000,
                    Bedrooms = 2,
                    Bathrooms = 2,
                    HasParking = true,
                    IsFurnished = true,
                    ContactNumber = "+63 945 678 9012",
                    ContactEmail = "condo@ceburent.com",
                    ImageUrl = "/images/property3.jpg"
                },
                new Property
                {
                    Title = "Budget Studio in Mabolo",
                    Description = "Affordable studio apartment in Mabolo area, close to transportation and shopping centers.",
                    Address = "12 Mabolo Road",
                    Location = "Cebu City",
                    PropertyType = "Studio",
                    RentalPrice = 8000,
                    Bedrooms = 1,
                    Bathrooms = 1,
                    HasParking = false,
                    IsFurnished = true,
                    ContactNumber = "+63 956 789 0123",
                    ContactEmail = "budget@ceburent.com",
                    ImageUrl = "/images/property4.jpg"
                },
                new Property
                {
                    Title = "Traditional Filipino Home in Guadalupe",
                    Description = "Charming traditional home with spacious yard in the quiet neighborhood of Guadalupe.",
                    Address = "34 Guadalupe Street",
                    Location = "Cebu City",
                    PropertyType = "House",
                    RentalPrice = 25000,
                    Bedrooms = 4,
                    Bathrooms = 2,
                    HasParking = true,
                    IsFurnished = false,
                    ContactNumber = "+63 967 890 1234",
                    ContactEmail = "traditional@ceburent.com",
                    ImageUrl = "/images/property5.jpg"
                }
            };

            context.Properties.AddRange(properties);
            context.SaveChanges();
        }
    }
}