# Entity Framework Internals: `DataContext`

Nuestro `Context` es una clase que representa una base de datos "virtual" de objetos. Cada vez que queremos interactuar con la base de datos lo hacemos a través del `Context` y luego Entity Framework se encarga de realizar el "mapeo" y modificar la base de datos real.

El `Context` define como se hará ese mapeo y no es mas que una clase que hereda de `DbContext`.

```cs
public class MyContext : DbContext {
}
```

y se inicializa de la siguiente forma

```cs
using (var myContext = new MyContext())
{
  // Podemos interactuar con la base de datos
}
```

Por defecto cuando instanciamos el `myContext` se abre una conexión a la base de datos especificada en el `connectionString`.

En el caso de tener que manejar múltiples `connectionString` podemos indicar en el constructor cuál es el nombre del `connectionString` que queremos utilizar.

```cs
public class MyContext : DbContext {
  public MyContext() : base("name=defaultConnection") {
  }
}
```

```xml
<connectionStrings>
  <add name="defaultConnection" connectionString="Server=local/sqlexpress;Database=MyDB;IntegratedSecurity=True" providerName="System.Data.SqlClient" />                                                                           
  <add name="anotherConnection" connectionString="Server=local/sqlexpress;Database=AnotherDB;IntegratedSecurity=True" providerName="System.Data.SqlClient" />
</connectionStrings>
```

El `DataContext` nos permite

* Trackear los objetos que son extraídos de la base de datos
* Mantener el **estado** de dichos objetos (más sobre los estados a continuación)
* Actualizar la base de datos real mediante el método `SaveChanges()`
