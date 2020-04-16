# Code first

## Introducción

Como fue explicado con anterioridad, con `Code First` podemos escribir clases que luego serán mapeadas al modelo que queremos persistir.

Code first es _convention over configuration_, es decir, si no definimos explícitamente la configuración que queremos Entity Framework asume un conjunto de convenciones que se utilizan para definir el modelo.

Por ejemplo, en lugar de explícitamente definir una clave primaria, Entity Framework asume que el atributo llamado `Id` o finalizado con `Id` se mapea automáticamente a una clave primaria.

## Definiendo entidades

En este ejemplo definiremos dos clases `Dispositivo` y `Lectura`, tal que un `Dispositivo` tiene varias `Lectura` y `Lectura` es de un `Dispositivo`.

Siendo `Dispositivo`

```cs
public class Dispositivo
{
  public int Id { get; set; }
  public string Nombre { get; set; }
  public List<Lectura> Lecturas { get; set; }
}
```

y `Lectura`

```cs
public class Lectura
{
  public int Id { get; set; }
  public int Temperatura { get; set; }
  public Dispositivo Dispositivo { get; set; }
}
```

## Creando el contexto

El `contexto` es nuestro "puente" que se ubica en el medio de nuestra lógica y Entity Framework. Se encarga de

* Consultar los datos de la base de datos
* Trackear el estado de los objetos
* Persistir los datos
* Manejar las relaciones entre nuestros objetos

Finalmente creamos el contexto, que es simplemente una clase

```cs
public class MyContext : DbContext
{
  public DbSet<Dispositivo> Dispositivos { get; set; }
  public DbSet<Lectura> Lecturas { get; set; }
}
```

Simplemente por _convención_ suceden algunas cosas interesantes
* `Dispositivo` tiene un `Id` que automáticamente se convierte en su _clave primaria_ y es autogenerado por la base.
* Sucede lo mismo para `Lectura` y su atributo `Id`.
* Dado que Dispositivo tiene una relación de `1 a n` con Lectura se crea una _clave foránea_ `DispositivoId` en la tabla `Lectura`

## Guardando datos

```cs
using (var context = new MyContext())
{
  var dispositivo = new Dispositivo() { Nombre = "Mi dispositivo" };
  
  // Establecemos la relación de lectura con dispositivo
  var lectura = new Lectura() { Temperatura = 20, Dispositivo = dispositivo };
  
  // Establecemos la relación de dispositivo con lectura
  dispositivo.Lecturas.Add(lectura);
  
  // Agregamos el dispositivo al contexto, en este momento su estado es Added
  context.Dispositivos.Add(dispositivo);
  
  // Se evalúa el estado de los objetos en el contexto, como el estado del objeto es Added, se performa un INSERT en la base
  // Se detecta que la lectura es un nuevo objeto por lo que también se persiste
  context.SaveChanges();
}
```

**Notar la importancia del [using](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement) al momento de crear el contexto.**

## Consultando datos de la base

Para consultar datos de la base Entity Framework utiliza lo que se conoce como _Linq to Entities_. Para escribir una consulta utilizando _Linq to Entites_ tenemos dos sintaxis: [Query based o Method based](https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/ef/language-reference/queries-in-linq-to-entities)

**Spoiler**: Ambas formas son análogas, no existe mejora de performance de una sobre la otra, de hecho la _Query based_ es [Syntactic sugar](https://en.wikipedia.org/wiki/Syntactic_sugar) de la otra y es transformada en tiempo de compilación.

### Query based

```cs
using (var context = new MyContext())
{
  var dispositivo = (
    from d 
    in context.Dispositivos.Include("Lecturas")
    where d.Nombre == "Mi Dispositivo"
    select d).FirstOrDefault();
}
```

### Method based

```cs
using (var context = new MyContext())
{
  var dispositivo = context.Dispositivos.Include("Lecturas").Where(x => x.Nombre == "Mi Dispositivo").FirstOrDefault();
}
```

**Notar el Include, que será explicado mas adelante**
