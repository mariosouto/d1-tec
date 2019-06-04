# Lazy, Explicit & Eager Loading

Recordando el ejemplo anterior

```cs
using (var context = new MyContext())
{
  var dispositivo = context.Dispositivos.Include("Lecturas").Where(x => x.Nombre == "Mi Dispositivo").FirstOrDefault();
}
```

Para entender el rol del `Include` debemos hablar de la forma en la que Entity Framework [carga las relaciones de los objetos](https://docs.microsoft.com/en-us/ef/ef6/querying/related-data).

## Lazy loading

En _lazy loading_ las relaciones se cargan _a demanda_ la primera vez que la property es accedida. Si no lo especificamos, como en el ejemplo anterior, Entity Framework solo trae de la base de datos los datos de `Dispositivo`.

## Eager loading

_Eager loading_ es el comportamiento que vemos en el ejemplo anterior. Sucede cuando la relación (en este caso `Lecturas`) se carga al mismo tiempo que traemos el objeto "padre" de la base de datos mediante el uso de **Include**.

## Explicit loading

_Explicit loading_ funciona de forma similar a _Lazy loading_, es decir traemos información a demanda, pero de forma explícita mediante el método **Load**.


