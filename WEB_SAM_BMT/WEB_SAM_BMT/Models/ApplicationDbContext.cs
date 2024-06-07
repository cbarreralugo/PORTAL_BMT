using System.Data.Entity;

namespace WEB_SAM_BMT.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {
        }

        public DbSet<Publicacion> Publicacion { get; set; }
    }
}
