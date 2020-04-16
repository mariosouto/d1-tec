# C# 6.0

## Using static

```cs
// Before

using System;

class Program
{
 static void Main(string [] args)
 {
   Console.WriteLine("Hello World!");
 }
}
```

```cs
// After

using static System.Console;

class Program
{
 static void Main(string [] args)
 {
   WriteLine("Hello World!");
 }
}
```

## Property initializers

```cs
// Before

class Employee
{
 public string Name { get; set; }
}
```

```cs
// After

class Employee
{
 public string Name { get; set; } = "John Doe";
}
```

## String interpolation

```cs
// Before

string name = "John";
string lastName = "Doe";

string message = "Hello my name is " + name + " " + lastName;
```

```cs
// After

string name = "John";
string lastName = "Doe";

string message = $"Hello my name is {name} {lastName}";
```

## Expression function members

```cs
// Before

class Calculator
{
  public int MakeCalculation(int a, int b)
  {
    return a + b;
  }
}
```

```cs
// After

class Calculator
{
  public int MakeCalculation(int a, int b) => a + b;
}
```

## Null conditional operators

```cs
// Before

var name = person.Name;

// El código tira NullPointerException si person es null
```

```cs
// After

var name = person?.Name;

// Si person es null, name toma null como valor y el código no falla
```
