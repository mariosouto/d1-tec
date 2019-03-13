# CTS y CLS

El CTS (_Common Type System_) y el CLS (_Common Language Specification_) son parte del runtime de .NET (CLR) y son responsables del chequeo de tipos dentro del código.

## Common Type System

El _Common Type System_ es una especificación que describe como se deben definir los _tipos_ para ejecutarse dentro del CLR.

## Common Language Specification

El _Common Language Specification_ es un conjunto de reglas que describe en detalle el conjunto de mínimo de funcionalidades que un compilador debe soportar para producir código que pueda ser ejecutado por el CLR y que al mismo tiempo pueda ser accedido por todos los lenguajes que apuntan a .NET.

El CLS puede ser visto como un subset del CTS.

Programáticamente podemos verificar que nuestro codigo sea _CLS compliant_ (accessible por todos los lenguajes de .NET) agregando la siguiente notación en el assembly

```cs
[assembly: CLSCompliant(true)]
```
Con esta notación el compilador de C# buscará que nuestro código cumpla con todas las reglas del CLS.
