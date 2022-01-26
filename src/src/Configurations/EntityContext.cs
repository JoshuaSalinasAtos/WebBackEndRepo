using Microsoft.EntityFrameworkCore;
using WebCourseRepo.Models;

namespace WebCourseRepo.Configurations
{
    public class EntityContext : DbContext
    {
        public DbSet<Course> Course { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<CoursesTags> CourseTags { get; set; }
        public DbSet<Sections> Sections { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<Topics> Topics { get; set; }
        public DbSet<TopicFeedbacks> TopicFeedbacks { get; set; }
        public DbSet<TopicTypes> TopicTypes { get; set; }

        public EntityContext(DbContextOptions options) : base(options)
        {

        }
        public void Traceable(ModelBuilder builder, Type type)
        {
            builder.Entity(type).Property("CreatedDate").HasDefaultValueSql("getdate()");
            builder.Entity(type).Property("UpdatedDate").HasDefaultValueSql("getdate()");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedStatus(modelBuilder);


        }
        

        private void SeedStatus(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Status>().HasData(
                new Status(1, "Activo"),
                new Status(2, "Deactivo"),
                new Status(3, "Cancelado"),
                new Status(4, "In Progress"),
                new Status(5, "Paused"),
                new Status(6, "Completed"),
                new Status(7, "Asigned"),
                new Status(8, "Pending")
            );
            */
        }
    }
}
