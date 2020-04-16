# Properties

Como se dijo anteriormente el rol de las clases en la POO (Programación Orientada a Objetos) es el de manejar complejidad. Uno de los pilares de la POO es la encapsulación, es decir, la técnica de ocultar los secretos del funcionamiento interno de una clase y "esconder" complejidad.

Los atributos de una clase conforman el estado interno de la misma. En la mayoría de los casos el estado interno de una clase solamente le interesa a la clase propia y no se debe modificar desde otra. Pero dado el caso, si es necesario, se accede a los atributos de una clase mediante `getters` y `setters`, con el objetivo de controlar desde dónde esos atributos son accedidos y como son manipulados.

## Caso tradicional con `get` y `set`

```cs
public class Employee
{
  private int salary;
  
  public int getSalary()
  {
    return this.salary;
  }
  
  public void setSalary(int salary)
  {
    // Puede agregarse lógica adicional si es necesaria
    this.salary = salary;
  }
}
```

## Introducción de properties

Las _properties_ son una simplificación del uso de `get` y `set` que nos provee C# para el manejo de la encapsulación.

```cs
public class Employee
{
  public int Salary { get; set; }
}

Employee employee = new Employee();
employee.Salary = 20;
employee.Salary; // 20

Employee employee = new Employee() { Salary = 20 };
```

**En tiempo de compilacion C# nos genera un correspondiente atributo `private` con sus respectivos `get` y `set`**.

Notar que por convención las properties se inician en mayúscula.
