using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:IdentityDbContext<AppUser,AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=HP_PAVILION; database=MarinaMS2; integrated security=true; TrustServerCertificate=True ");
        }
        DbSet<Tekne> teknes {  get; set; }
        DbSet<Jurnal> jurnals {  get; set; }
        DbSet<JurnalSelect> Jurnal_Selects { get; set; }



    }
}
