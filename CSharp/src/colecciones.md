# Colecciones

## Definiendo una Lista

```cs
List<Person> persons = new List<Person>();
```

```cs
List<Person> persons = new List<Person>
 {
   new Person(),
   new Person()
 }
```

## Agregando elementos

```cs
List<Person> persons = new List<Person>();

persons.Add(new Person());
```

## Iterando la lista

```cs
List<Person> persons = new List<Person>();

foreach (var person in persons)
{
}
```

## Eliminando elementos de la lista

```cs
List<Person> persons = new List<Person>();

persons.Remove(aPerson);
```
