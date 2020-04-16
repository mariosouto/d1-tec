# Namespaces

Un _namespace_ es un grupo de tipos semánticamente relacionados que están contenidos en un assembly o en un grupo de assemblys relacionados.

_Es decir que un solo Assembly puede contener cualquier número de namespaces y asi mismo un namespace puede contener distintos tipos._

## Ejemplo

`mscorlib.dll` contiene multiples _namespaces_ como por ejemplo `System.IO` (relacionado con operaciones de entrada y salida) y `System.Collections` (que contiene Listas).

Así mismo `System.IO` contiene tipos relacionados, por ejemplo, `BinaryReader` y `BinaryWriter` que se utilizan para manipular archivos.

## Agnosticidad de la plataforma

Como la BCL (Base Class Library) no es específica de ningún lenguaje, cualquier lenguaje que corra sobre el runtime de .NET hace uso de los mismos _namespaces_ y _tipos_.

```cs
using System;

public class Prueba
{
  static void Main()
  {
    Console.WriteLine("Hello World from C#");
  }
}
```

```cpp
#include "stdafx.h"
using namespace System;

int main(array<System::String ^> ^args)
{
  Console::WriteLine("Hello World from C++");
  return 0;
}
```

Tanto el ejemplo en C# como en C++ hacen uso del namespace `System` y del tipo `Console` de la BCL
