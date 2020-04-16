# Customizando el modelo: Data Annotations & Fluent API

Como fuera dicho anteriormente, Entity Framework es _Convention over configuration_. Sin embargo, se puede realizar customizaciones al momento de generar la base de datos y tenemos dos formas de hacerlo: Data Annotations y Fluent API.

## Data Annotations

El namespace [System.ComponentModel.DataAnnotations](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations?view=netframework-4.8) nos provee de cierta sintaxis para "pisar" la configuración de nuestros atributos

```cs
public class Dispositivo
{
  [Key]
  public int Identificador { get; set; } // Identificador es clave primaria e identifica a la entidad
  
  [MaxLength(30)]
  public string Nombre { get; set; } // Nombre tiene un largo máximo de 30 caracteres
  
  [Required]
  public string Descripcion { get; set; } // Descripcion es requerida
}
```

## Fluent API

[Fluent API](https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/fluent/types-and-properties) nos da acceso al _model builer_ por lo que contiene algunos elementos de configuración que las Data Annotations no. Además, nos da la posibilidad de mantener nuestras clases "limpias" como POCO (Plain Old CLR Objects), sin agregarle notación particular de Entity Framework.

**Nos da la posibilidad de separar el dominio de la configuración de la persistencia**

Para declarar las mismas configuraciones anteriores con Fluent API tenemos que sobreescribir el método `onModelCreating` en nuestro contexto.

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
