using Microsoft.EntityFrameworkCore;   namespace portfolio.Model {     public class DbBuilder : DbContext     {
        // DB-RELATED: ADD THESE CONTRUCTORS!
        public DbBuilder() { }         public DbBuilder(DbContextOptions<DbBuilder> options) : base(options) { }

        // DB-RELATED: CREATE A DB FOR EACH EXISTING MODEL(S)
        //public DbSet<MyContact> Friends { get; set; }
        //public DbSet<MyContact> Frenemies { get; set; }
        //public DbSet<MyContact> Enemies { get; set; }
        public DbSet<MyContact> MyContact { get; set; }        } }  