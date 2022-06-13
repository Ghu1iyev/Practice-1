using Microsoft.EntityFrameworkCore;
using Practice_1.Models;

namespace Practice_1.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<HeaderSocialMedia> HeaderSocialMedias { get; set; }
        public DbSet<FooterSocialMedia> footerSocialMedias { get; set; }


    }
}
