# Modificadores de Parámetros

En C# al definir un método tenemos permitido pasarle una lista de parámetros. En el lenguaje tenemos una lista de keywords que permiten alterar la forma en la que dichos argumentos son pasados.

## Comportamiento por defecto (Sin modificador)

Por defecto en C# los parámetros son pasados a los métodos _por valor_. Es decir que el método recibe _una copia_ de los datos que se le pasa. Exactamente qué se copia depende de si el parámetro es de tipo **valor** o de tipo **referencia**.

### Caso 1: Tipo Valor

Una estructura o un dato se dice que es de tipo valor si la información que almacena está en su propia dirección de memoria.

En el caso de que un parámetro sea de tipo valor el método recibe una copia del mismo en _otra dirección de memoria_ y la variable original permanece inalterada.

```cs

static void ModifyVariable(int x)
{
  x = 20;
  Console.WriteLine(x);
}

static void Main(string[] args)
{
  int x = 100;
  Console.WriteLine(x);
  
  ModifyVariable(x);
  
  Console.WriteLine(x);
}

// 100
// 20
// 100

```

### Caso 2: Tipo Referencia

Por el contrario los tipo referencia no almacenan su valor directamente si no que almacenan la dirección de memoria en donde se encuentra dicho valor.

Cuando pasamos un tipo referencia como parámetro no se crea una nueva copia de los datos si no que se pasa una nueva referencia a la dirección de memoria de la variable original. Si esta variable la modificamos en el método entonces se modifica el valor original, dado que ambas referencias apuntan a la misma dirección de memoria.

```cs
static void CelebrateBirthday(Person aPerson)
{
  aPerson.Age++;
}

static void Main(string[] args)
{
  Person p = new Person(20);
  
  Console.WriteLine(p.Age);
  
  CelebrateBirthday(p);
  
  Console.WriteLine(p.Age);
}

// 20
// 21
```

Sin embargo, con el comportamiento por defecto, no es posible manipular la referencia original para que apunte a una nueva dirección de memoria, como se ve en el ejemplo siguiente.

```cs
static void ChangeAgeAndTryToChangeReference(Person aPerson)
{
  aPerson.Age = 99;
  aPerson = new Person(55);
}


static void Main(string[] args)
{
  Person p = new Person(20);
  
  Console.WriteLine(p.Age);
  
  ChangeAgeAndTryToChangeReference(p);
  
  Console.WriteLine(p.Age);
}

// 20
// 99
```

**Tipo Valor** `int` `float` `bool` `struct` `double`
**Tipo Referencia** `class` `string` `array` `delegate`

## Modificador `out`

Los métodos que reciben parámetros precedidos por `out` están obligados a asignarle a los mismos un valor antes de que termine la ejecución del método. De lo contrario se reciben errores de compilación.

:white_check_mark:

```cs
static void AssignMe(out int myVariable)
{
  myVariable = 20;
}

static void Main(string[] args)
{
  int myVariable;
  
  AssignMe(out myVariable);
}
```

:x:

```cs
static void AssignMe(out int myVariable)
{
  // myVariable sin asignar
}

static void Main(string[] args)
{
  int myVariable;
  
  AssignMe(out myVariable);
}
```

## Modificador `ref`

El modificador `ref` se utiliza para indicarle al compilador que queremos pasarle a un método un parámetro por referencia, es decir, no queremos que se cree una copia si no que queremos recibir el valor original.

En el caso de _Value Types_

```cs
static void ChangeMyInt(ref int myInt)
{
  myInt++;
}

int myInt = 20;
Console.WriteLine(myInt); // 20
ChangeMyInt(ref myInt);
Console.WriteLine(myInt); // 21
```

En el caso de _Reference Types_

```cs
static void ChangeAgeAndTryToChangeReference(ref Person aPerson)
{
  aPerson.Age = 99;
  aPerson = new Person(55);
}


static void Main(string[] args)
{
  Person p = new Person(20);
  
  Console.WriteLine(p.Age);
  
  ChangeAgeAndTryToChangeReference(ref p);
  
  Console.WriteLine(p.Age);
}

// 20
// 55
```

## Modificador `params`

El modificador `params` se utiliza en el caso en el que se le desee pasar a un método una lista indeterminada de parámetros de igual tipo.

En dicho caso esa lista de parámetros es considerada como un array dentro del cuerpo del método.

**Solamente se permite un único parametro precedido por params y de haber mas de un parámetro params debe ser el último**

```cs
static int SumNumbers(params int[] numbers)
{
  int sum = 0;
  
  for (var i = 0; i < numbers.Length; i++)
    sum += numbers[i];
    
  return sum;
}

SumNumbers(1, 2, 3, 4, 5, 6, 7, 8)

// 36
```
