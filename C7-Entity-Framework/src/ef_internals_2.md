# Entity Framework Internals: `ObjectTracking`

## Recapitulando

Hasta ahora vimos que Entity Framework maneja el concepto de `DataContext` como una base de datos virtual, de objetos, que representa una abstracción de la base de datos real que almacenamos en SQL Server.

## ¿Cómo se trackean dichos objetos?

Todos los registros que traemos de la base de datos son mapeados a objetos por Entity Framework. Dichos objetos, por defecto, son trackeados por el `DataContext`, que "escucha" ante los cambios en los atributos de los mismos y actualiza sus **estados** de forma conveniente.

Si un mismo objeto es cargado por dos consultas a la base de datos diferentes, el contexto es lo suficientemente inteligente para percatarse de eso y no generar un objeto adicional.

Por ejemplo, si tenemos una tabla de la siguiente forma

```
| ID | NOMBRE | APELLIDO |
--------------------------
| 1  | JUAN   | PEREZ    |
```

y queremos traer el primer, y único, registro

```cs
using (var context = new MyContext()) 
{
  var persona1 = context.Personas.Where(x => x.Nombre == "Juan").First();
  
  var persona2 = context.Personas.Where(x => x.Apellido == "Perez").First();
}
```

El contexto sabe que `persona1` y `persona2` son el mismo objeto, por lo que no crea un objeto adicional. Ambos punteros referencian a la misma instancia.

## Estados de un objeto

Todos los objetos que son trackeados por el contexto tienen un estado interno. En función del estado interno que tengan, al momento de ejecutar el método `SaveChanges`, Entity Framework tomará distintas acciones que veremos a continuación.

| Estado del objeto  | Significado | Sentencia SQL que se ejecuta en `SaveChanges` |
| ------------- | ------------- | -----|
| Unchanged  | El objeto existe en la base, está siendo trackeado por el contexto y sus atributos mantienen el valor original  | Ninguna |
| Modified  | El objeto existe en la base, está siendo trackeado por el contexto y algunos de sus atributos cambiaron  | `UPDATE` |
| Added  | El objeto no existe en la base, está siendo trackeado por el contexto y será insertado en el próximo `SaveChanges`  | `INSERT` |
| Deleted  | El objeto existe en la base, fue marcado para borrar en el contexto y será borrado en el próximo `SaveChanges`  | `DELETE` |
| Detached  | Es un estado especial, que indica que el objeto no está siendo trackeado por el contexto | Ninguna |

En el caso en el que el estado sea `Modified`, Entity Framework también almacena los [OriginalValues](https://docs.microsoft.com/en-us/dotnet/api/system.data.entity.infrastructure.dbentityentry.originalvalues?view=entity-framework-6.2.0) y [CurrentValues](https://docs.microsoft.com/en-us/dotnet/api/system.data.entity.infrastructure.dbentityentry.currentvalues?view=entity-framework-6.2.0) de los objetos que trackea. Esto le permite saber que atributos fueron los que cambiaron y solamente actualizar las columnas correspondientes de la tabla, en lugar de actualizar todas.

