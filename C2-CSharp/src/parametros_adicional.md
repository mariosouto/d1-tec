# Material adicional sobre pasaje de parámetros

## Parámetros opcionales

```cs
static void MyMethod(string a, int b, int c = 2)
{
}

MyMethod("First Argument", 2, 3);
MyMethod("First Argument", 2);
```

## Parámetros nombrados

```cs
static int Substract(int firstNumber, int secondNumber)
{
  return firstNumber - secondNumber;
}

Substract(firstNumber: 6, secondNumber: 4); // 2
Substract(secondNumber: 6, firstNumber: 6); // 0
```
