using System;
using System.Collections.Generic;
using System.Text;
using Aula2FSNET.Modelo;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Aula2FSNET.Data
{
  public class ApplicationDbContext : IdentityDbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

    }

    public DbSet<Empresa> Empresa { get; set; }
    public DbSet<Comercio> Comercio { get; set; }
    public DbSet<Servico> Servico { get; set; }
    public DbSet<Disco> Disco { get; set; } 
  }
}
