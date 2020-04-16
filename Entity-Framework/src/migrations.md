# Migrations

## ¿Qué son y para qué sirven las migrations?

Cuando nuestro modelo cambia, por ejemplo agregamos un nuevo atributo en una clase, o quizás lo modificamos mediante _Data Annotations_ o _Fluent API_, podemos no llegar a querer borrar y crear la base de datos nuevamente. Esto se da mas que nada en ambientes donde los datos son sensibles y no queremos perderlos.

Es en estos casos en los que surgen las _migrations_, que son archivos que indican la forma en la que nuestra base de datos debe cambiar.

## Cómo utilizar migrations en Entity Framework

Primero debemos habilitar las migrations, desde la consola del administrador de paquetes corremos

```
Enable-Migrations
```

Luego, para crear una migration corremos el comando

```
Add-Migration ElNombreDeMiMigration
```

Esto genera un archivo dentro de la carpeta `Migrations` con el _timestamp_ de la migration creada y el nombre indicado.

Por último actualizamos la base de datos

```
Update-Database
```

Si no queremos trabajar con migrations de forma manual podemos habilitar [automatic migrations](https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/migrations/automatic)
