# Database first, Model first & Code first

Cuando trabajamos con Entity Framework tenemos la posibilidad de utilizar _workflows_ diferentes. Si bien cualquiera de los tres nos permite manejar la totalidad del framework, es decir, no hay un workflow "más poderoso" que otro, generalmente siempre hay uno que se ajusta más a nuestras necesidades.

Dependiendo del contexto de nuestra aplicación puede llegar a servirnos mas utilizar _Database first_, _Model first_ o _Code first_.

## Database first

Permite generar nuestro modelo a partir de una base de datos ya existente. Escogemos la base de datos a utilizar, y Entity Framework se encarga de generar el modelo y las clases POCO (Plain Old CLR Objects) a partir de las tablas escogidas de dicha base.

Generalmente este _workflow_ está mas orientado a cuando ya tenemos una base de datos con datos que no queremos perder.

## Model first

Permite generar nuestro modelo de forma gráfica, con un diseñador, guardarlo en un archivo `EMDX` y generar las clases necesarias a partir de dicho archivo.

Generalmente este _workflow_ está mas orientado a cuando aún no tenemos una base de datos pero queremos arrancar con un diseño de la base up front.

## Code first

Finalmente Code first, el mecanismo que utilizaremos nosotros, permite definir el modelo a partir de clases de C# ya existentes. Tenemos la posibilidad de seguir las [convenciones](https://en.wikipedia.org/wiki/Convention_over_configuration) para crear la base de datos o proveerle al framework de configuración adicional mediante la utilización de [Data Annotations](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations?view=netframework-4.8) o [Fluent API](https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/fluent/types-and-properties)
