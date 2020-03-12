# Excepciones

Una excepción es un evento que ocurre durante la ejecución de un programa e interrumpe el flujo normal de operación.

## Tipos de excepciones

- Definidas por C#
- Definidas por el programador

## Manejo de excepciones

```cs
try
{
  // Código que puede causar errores
}
catch()
{
  // Qué hacer si sucede un error
}
finally
{
  // De cualquier manera, hacer lo siguiente...
}
```

Una vez que se produce una excepción en el bloque `try`, el flujo de control salta al primer controlador de excepciones asociado que está presente en cualquier parte de la pila de llamadas. En C#, la palabra clave `catch` se utiliza para definir un controlador de excepciones.

Si no hay ningún `catch`, el programa deja de ejecutarse con un mensaje de error.

## Excepciones propias

```cs
class CustomException : Exception
{
    public CustomException(string message): base(message) { }
}
```

```cs
private static void TestThrow()
{
    CustomException ex = new CustomException("Oops! An error happened!");
    throw ex;
}
```

**Nota:** Las excepciones derivan en última instancia de `System.Exception`.
