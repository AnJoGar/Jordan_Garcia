using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace JORDAN_GARCIA.Models
{
  public class JORDAN_GARCIADbContext:DbContext
  {

    public JORDAN_GARCIADbContext()
    {
    }

    public JORDAN_GARCIADbContext(DbContextOptions<JORDAN_GARCIADbContext> options) : base(options)
    {
    }


    public DbSet<Usuario> Usuario { get; set; }
    public DbSet<Genero> Genero { get; set; }

  }
}
