using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry
                {
                    id = 1,
                    Title = ".Net Project",
                    Content = "Working on .Net Project",
                    CreatedOn = Convert.ToDateTime("2024-11-29 01:04:52.537")
                },
                new DiaryEntry
                {
                    id = 2,
                    Title = "Kellton SAP Project",
                    Content = "Working on Lakshya SAP Project",
                    CreatedOn = Convert.ToDateTime("2024-11-29 01:04:52.537")
                },
                 new DiaryEntry
                 {
                     id = 3,
                     Title = "Kellton S4 Project",
                     Content = "Working on Lakshya S4 Project",
                     CreatedOn = Convert.ToDateTime("2024-11-29 01:04:52.537")
                 }
            );
        }
    }
}
