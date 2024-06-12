
using Microsoft.EntityFrameworkCore;
using apiDolar.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace apiDolar.Data

{

    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<apiDolar.Models.Exportacion> exportacion { get; set; } = default!;
        


    }

}

