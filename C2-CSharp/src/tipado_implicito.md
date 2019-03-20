# Tipado implícito

Tipado implícito o _implicit typing_ es una funcionalidad que provee C# mediante la cual no es necesario proveer el tipo de la variable que se está definiendo si no que el mismo es inferido por el compilador, en función del valor que se le asigne.

```cs
// Before

int myInt = 0;

// After

var myInt = 0;

// Ambas son equivalentes
```

## Restricciones

:x: Variable sin asignar

```cs
var myData;
```

:x: Variable asignada luego de declaración

```cs
var myInt;
myInt = 0;
```

:x: Variable asignada a `null`

```cs
var myObject = null;
```

:x: Variable a la que asigna un valor de distinto tipo

```cs
var myString = "Hello";
myString = 22;
```

:x: Variable utilizada en un atributo de clase

```cs
public var MyAttribute { get; set; }
```
