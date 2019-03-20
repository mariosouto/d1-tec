# Enums

Enums o _Enumeration_ es un tipo de dato de pareja de clave/valor.

Por defecto el valor del _enum_, si no está declarado, se inicializa en 0 y se incrementa de 1 en 1.

```cs
enum Cars
{
  Renault, // 0
  BMW,     // 1
  Ferrari  // 2
}
```

Pero podemos especificar a partir de que valor queremos que el enum comience.

```cs
enum Cars
{
  Renault = 100,
  BMW,     // 101
  Ferrari  // 102
}
```

O asignarle valores sin la necesidad de seguir una secuencia

```cs
enum Cars
{
  Renault = 100,
  BMW = 116,
  Ferrari = 150
}
```
