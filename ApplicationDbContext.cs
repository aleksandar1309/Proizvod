using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ZadatakProizvod.Models;

namespace ZadatakProizvod.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            

        }

        public DbSet<Proizvod> Proizvodi { get; set; }

        public DbSet<ZadatakProizvod.Models.ProizvodJson> ProizvodJson { get; set; }
    }
}
