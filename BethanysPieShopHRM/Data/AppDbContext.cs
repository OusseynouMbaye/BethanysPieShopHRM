using BethanysPieShopHRM.Shared.Domain;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShopHRM.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<TimeRegistration> TimeRegistrations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Employee table  
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                CountryId = 1,
                MaritalStatus = MaritalStatus.Single,
                BirthDate = new DateTime(1979, 1, 16),
                City = "Brussels",
                Email = "bethany@bethanyspieshop.com",
                FirstName = "Bethany",
                LastName = "Smith",
                Gender = Gender.Female,
                PhoneNumber = "324777888773",
                Smoker = false,
                Street = "Grote Markt 1",
                Zip = "1000",
                JobCategoryId = 1,
                Comment = "Lorem Ipsum",
                ExitDate = null,
                JoinedDate = new DateTime(2015, 3, 1),
                Latitude = 50.8503,
                Longitude = 4.3517
            });
            // version for .net 8
            var random = new Random();
            for (int i = 2; i <= 100; i++)
            {
                modelBuilder.Entity<TimeRegistration>().HasData(new TimeRegistration
                {
                    TimeRegistrationId = i,
                    EmployeeId = 1,
                    StartTime = new DateTime(2024, 1, 1).AddDays(random.Next(365)).AddHours(random.Next(0, 24)).AddMinutes(random.Next(0, 60)).AddSeconds(random.Next(0, 60)),
                    EndTime = new DateTime(2024, 1, 1).AddDays(random.Next(365)).AddHours(random.Next(0, 24)).AddMinutes(random.Next(0, 60)).AddSeconds(random.Next(0, 60)),
                    PerformedTaskDescription = $"Task {i}"
                });
            }

            // version for .net 9
            /*  modelBuilder.Entity<TimeRegistration>().HasData(new TimeRegistration()
              {
                  TimeRegistrationId = 1,
                  EmployeeId = 1,
                  StartTime = new DateTime(2024, 11, 8,5,44,59),
                  EndTime = new DateTime(2024, 1, 1,8,44,59),
                  PerformedTaskDescription = "Performed Task 1"
              });

              modelBuilder.Entity<TimeRegistration>().HasData(new TimeRegistration()
              {
                  TimeRegistrationId = 2,
                  EmployeeId = 1,
                  StartTime = new DateTime(2024, 11, 22,22, 21, 39),
                  EndTime = new DateTime(2024, 11, 23, 3, 7, 26),
                  PerformedTaskDescription = "Performed Task 2"
              });
            */

            // sedd JobCategory Table
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory { JobCategoryId = 1, JobCategoryName = "Pie research" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory { JobCategoryId = 2, JobCategoryName = "Sales" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory { JobCategoryId = 3, JobCategoryName = "Management" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory { JobCategoryId = 4, JobCategoryName = "Store staff" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory { JobCategoryId = 5, JobCategoryName = "Finance" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory { JobCategoryId = 6, JobCategoryName = "QA" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory { JobCategoryId = 7, JobCategoryName = "IT" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory { JobCategoryId = 8, JobCategoryName = "Cleaning" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory { JobCategoryId = 9, JobCategoryName = "Bakery" });


            // Seed Country Table         
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 1, Name = "Belgium" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 2, Name = "Netherlands" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 3, Name = "USA" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 4, Name = "Japan" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 5, Name = "China" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 6, Name = "UK" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 7, Name = "France" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 8, Name = "Brazil" });
        }
    }
}
