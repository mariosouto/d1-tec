# Extrayendo configuración de Fluent API

Cuando nuestra customización del modelo se vuelve demasiado compleja se puede volver dificil de mantener en el método `OnModelCreating`.

Para ello podemos separar nuestra configuración de forma conveniente creando clases que hereden de `EntityTypeConfiguration` y luego agregando instancias de dicha clase en la configuración del modelo.

Resumiendo

```cs
public class MyContext : DbContext
{
  public DbSet<Dispositivo> Dispositivos { get; set; }
  public DbSet<Lectura> Lecturas { get; set; }
  
  public override void OnModelCreating(DbModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Dispositivo>().HasKey(x => x.Identificador);
    modelBuilder.Entity<Dispositivo>().Property(x => x.Nombre).HasMaxLength(30);
    modelBuilder.Entity<Dispositivo>().Property(x => x.Descripcion).IsRequired();
  }
}
```

Esta configuración podemos moverla a la siguiente clase

```cs
public class DispositivoTypeConfiguration : EntityTypeConfiguration<Dispositivo>
{
  public DispositivoTypeConfiguration()
  {
    this.Entity<Dispositivo>().HasKey(x => x.Identificador);
    this.Entity<Dispositivo>().Property(x => x.Nombre).HasMaxLength(30);
    this.Entity<Dispositivo>().Property(x => x.Descripcion).IsRequired();
  }
}
```

En lugar de tener la especificación de nuestro modelo conglomerada en el `onModelCreating` tenemos clases de configuración para cada clase particular.

Y luego simplemente actualizamos el contexto

```cs
public class MyContext : DbContext
{
  public DbSet<Dispositivo> Dispositivos { get; set; }
  public DbSet<Lectura> Lecturas { get; set; }
  
  public override void OnModelCreating(DbModelBuilder modelBuilder)
  {
    modelBuilder.Configurations.Add(new DispositivoTypeConfiguration());
  }
}
```
