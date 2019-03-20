# Iteradores

## for loop

```cs
for (int i = 0; i < 4; i++)
{
// Do something
}
```

También puede utilizarse con inferencia de tipos

```cs
for (var i = 0; i < 4; i++)
{
// Do something
}
```

## foreach loop

```cs
// Before

string[] tvShows = { "Game of Thrones", "Brooklyn 99", "Russian Doll" };

for (var i = 0; i < tvShows.Length; i++)
{
  Console.WriteLine(tvShows[i]);
}
```

```cs
// After

string[] tvShows = { "Game of Thrones", "Brooklyn 99", "Russian Doll" };

foreach (var tvShow in tvShows)
{
  Console.WriteLine(tvShow);
}
```

## while

```cs
while (condition)
{
}
```

## do/while

```cs
do
{
} while (condition);
```
