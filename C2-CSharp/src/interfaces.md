# Interfaces

Una _interfaz_ es un contrato que define un conjunto de operaciones abstractas, es decir operaciones que tienen una definición pero no proveen comportamiento alguno.

Una _interfaz_ expresa un comportamiento que si una clase decide soportar deberá hacerlo implementando las respectivas operaciones.

## Sintaxis de una Interfaz

Por convención las interfaces comienzan con la letra I mayúscula, por ejemplo `IDBConnection`, `ICloneable`, etc.

```cs
public interface IReanimation
{
  void DoReanimation();
}
```

## Implementación de una Interfaz

```cs
public class Person : IReanimation
{
  public override void DoReanimation()
  {
  }
}
```

* La palabra clave `override` indica que el método se está sobreescribiendo.
* `Person : IReanimation` indica que la clase Person realiza la interfaz `IReanimation`
