using System;
using System.Collections.Generic;
using System.Reflection;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dominio.Data;

public partial class WebApiContext : DbContext
{
    public WebApiContext()
    {
    }

    public WebApiContext(DbContextOptions<WebApiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categoriapersona> Categoriapersonas { get; set; }

    public virtual DbSet<Ciudad> Ciudads { get; set; }

    public virtual DbSet<Contactopersona> Contactopersonas { get; set; }

    public virtual DbSet<Contrato> Contratos { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<Direccionpersona> Direccionpersonas { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<Pai> Pais { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Programacion> Programacions { get; set; }

    public virtual DbSet<Tipocontacto> Tipocontactos { get; set; }

    public virtual DbSet<Tipodireccion> Tipodireccions { get; set; }

    public virtual DbSet<Tipopersona> Tipopersonas { get; set; }

    public virtual DbSet<Turno> Turnos { get; set; }

   /*  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;user=root;password=campus2024;database=claydatabase", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.34-mysql")); */

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
