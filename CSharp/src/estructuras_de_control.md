# Estructuras de control

Las estructuras de control en C# operan de forma similar a las de Java. Señalaremos algunas particularidades

# One line if

```cs
// Before

if (condition)
{
  Console.WriteLine("Inside if statement");
}

// After

if (condition)
  Console.WriteLine("Inside if statement");
```

# Operador ternario

```cs

// Before

if (condition)
{
  return 2;
}
else
{
  return 1;
}

// After

int someValue = condition ? 2 : 1;
```
