using EFDataAuth.Test.Domain.Data;
using Microsoft.EntityFrameworkCore;

namespace EFDataAuth.Test.Domain
{
    public class MyTestDbContext:DbContext
    {
        public MyTestDbContext(DbContextOptions<MyTestDbContext> dbContextOptions)
            : base(dbContextOptions)
        {

        }
        public DbSet<Users> Users { get; set; }
        public  DbSet<Adress> Adress { get; set; }
    }
}
