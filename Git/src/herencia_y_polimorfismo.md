# Herencia y Polimorfismo

## Herencia

**Herencia** en programación orientada objetos es una forma que tenemos de reutilizar código cuando la relación que queremos representar es del tipo _es-un_. La otra forma de reutilizar código es **Composición-Delegación** que representa relaciones del tipo _tiene-un_.

En C# la herencia la representamos en código de la siguiente forma

```cs
class Dog : Animal
{
}
```

Donde leemos _Dog es-un Animal_.

C# no soporta _herencia múltiple_, por lo que

```cs
class Doberman : Dog, Animal
{
}
```

es inválido para el lenguaje.

## `sealed`

C# provee la palabra reservada `sealed` que se utiliza cuando queremos establecer que una clase **NO** puede ser extendida.

Por ejemplo

```cs
sealed class Animal
{
}

class Dog : Animal
{
}
```

es inválido, ya que Animal no puede ser extendida.

## `base`

Así como en Java teníamos `super`, en C# tenemos `base` cuando queremos invocar al constructor de la clase padre desde el constructor de la clase hija.

Por ejemplo

```cs
class Animal
{
  private string name;
  
  public Animal(string name)
  {
    this.name = name;
  }
}

class Dog : Animal
{
  public Dog(string name) : base(name)
  {
  }
}
```

## Polimorfismo

En programación orientada a objetos _Polimorfismo_ es la habilidad que tiene una interfaz de tomar múltiples formas. Dicho de otra forma, es la habilidad que disponemos de enviar un mensaje a un objeto sin conocer su tipo y permitiéndole al objeto implementar la forma de dicho mensaje.

En C# podemos implementar Polimorfismo utilizando herencia o interfaces.

## `virtual` y `override`

En C#, al contrario de Java donde el polimorfismo es por defecto, si queremos implementar una operación polimórfica en una jerarquía de herencias tenemos que hacer uso de `virtual` y `override`.

```cs
class Parent
{
  public virtual void PolymorphicOperation()
  {
   // Default implementation
  }
}
```

En la clase padre definimos una operación polimórfica utilizando `virtual`. Esta operacion _puede_ (no _debe_) ser sobreescrita por una clase hija.

```cs
class Child : Parent
{
  public override void PolymorphicOperation()
  {
    // Custom implementation
  }
}
```

La clase hija sobreescribe el método utilizando la palabra clave `override`.

## `abstract`

Podemos tener casos en los que nos interesa definir una clase pero no que la misma sea instanciada. Para definir clases de este tipo utilizamos la palabra clave `abstract`

```cs
abstract class MyAbstractClass
{
}
```

Una clase abstracta también tiene la posibilidad de definir métodos abstractos, que no provean una implementación por defecto.

```cs
abstract class MyAbstractClass
{
  public abstract void AbstractOperation();
}
```

Los métodos abstractos por defecto son **polimórficos** ya que obligan a las clases hijas a implementarlos.

## `new`

La utilización de la palabra clave `new` introduce una técnica conocida como `shadowing`. En una jerarquía de clases, si la clase hija define un método con la misma firma que uno de la clase padre, acompañado por `new`, el método de la clase hija "tapa" al de la padre.

```cs
class Parent
{
  public void Operation()
  {
  }
}

class Child : Parent
{
  // Se "tapa" la version del padre
  public new void Operation()
  {
  }
}
```

