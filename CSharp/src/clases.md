# Clases

Las `Clases` son la forma que tenemos en la programación orientada a objetos de modelar la realidad. Creamos clases para _instanciar_ objetos que interactúen entre si enviándose mensajes para llevar a cabo el propósito del sistema.

**Creamos clases con el objetivo de manejar y reducir la complejidad de un sistema.**

## Sintaxis

```cs
class NombreDeClase
{
}
```

## Atributos

Elegimos los atributos que consideramos necesarios para representar el estado interno de la clase.

### Sintaxis

```cs
class Person
{
  public int age;
  // visibilidad tipo nombre
}
```

Lo anterior es a modo de ejemplo, los atributos representan el funcionamiento interno de una clase y no deerían poder manipularse fuera de la misma, en los casos en los que sea necesario hay que hacerlo por medio de _properties_.

## Constructores

### Sintaxis

```cs

class Person
{
  public int age;
  
  public Person(int myAge)
  {
    this.age = myAge;
  }
}

Person aPerson = new Person(20);
```

### El rol de `this`

C# provee la palabra clave `this` cuyo rol es obtener acceso a la instancia actual de la clase.

### Cadena de constructores utilizando `this`

```cs
class Person
{
  public int age;
  public string name;
  
  public Person(string name, int age) 
  {
   // Some behaviour
  }
  
  public Person(int age) : this("", age) 
  {
    // Some behaviour
  }
}
```

En estos casos el orden de la llamada a los constructores comienza por el constructor ubicado a la derecha y finaliza con el constructor llamado originalmente.

En el ejemplo anterior primero se ejecuta `Person("", age)` y luego `Person(age)`

## Clases `static`

Muchas veces nos podemos encontrar con el caso en el que tenemos una clase que no tiene estado interno y solamente realiza un conjunto de operaciones relacionadas. En este caso "no tiene sentido" instanciar una clase de este tipo ya que la instancia en si misma no contiene información relevante.

Para estos casos podemos utilizar la palabra reservada `static` y definir una clase que nos provea un conjunto de operaciones.

```cs
public static class MyStaticClass
{
  public static void FirstOperation()
  {
  }
  
  public static void SecondOperation()
  {
  }
}
```
