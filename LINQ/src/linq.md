# LINQ (Language Integrated Query)

## `.Any`

Devuelve `true` si hay al menos un elemento de la colección que cumple con la condición.

### Antes (Imperativo)

```cs
int[] numbers = { 1, 2, 3, 4, 5 };
bool greaterThanFour = false;

for (int i = 0; i < numbers.Length; i++)
{
  if (numbers[i] > 4)
  {
    greaterThanFour = true;
    break;
  }
}

```

### Después (Funcional)

```cs
int[] numbers = { 1, 2, 3, 4, 5 };
bool greaterThanFour = numbers.Any(n => n > 4);
```

## `.All`

Devuelve `true` si todos los elementos de la colección cumplen la condición.

### Antes (Imperativo)

```cs
int[] numbers = { 1, 2, 3, 4, 5 };
bool greaterThanFour = true;

for (int i = 0; i < numbers.Length; i++)
{
  if (numbers[i] <= 4)
  {
    greaterThanFour = false;
    break;
  }
}

```

### Después (Funcional)

```cs
int[] numbers = { 1, 2, 3, 4, 5 };
bool greaterThanFour = numbers.All(n => n > 4);
```

## `.Take`

Extrae los primeros `n` elementos de una colección

```cs
int[] numbers = { 1, 2, 3, 4, 5 };
int[] firstTwo = numbers.Take(2).ToArray();
```

## `.Skip`

Saltea los primeros `n` elementos de una colección

```cs
int[] numbers = { 1, 2, 3, 4, 5 };
int[] exceptTheFirstTwo = numbers.Skip(2).ToArray();
```

## `.Where`

Devuelve los elementos de la colección que cumplan la condición

```cs
int[] numbers = { 1, 2, 3, 4, 5 };
int[] greaterThanFour = numbers.Where(n => n > 4);
```

## `.OrderBy` & `.OrderByDescending`

Ordena los elementos de la colección de forma ascendente o descendente

```cs
string[] codes  = { "abc", "bc", "a", "d", "abcd" };
List<string> sortedCodes = codes.OrderBy(item => item.Length).ToList();
```

## Ver mas

[Mas funciones de LINQ](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable?view=netframework-4.8)
