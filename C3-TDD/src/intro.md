# Introducción

Previamente introduciremos algunos conceptos que serán necesarios para entender el funcionamiento de TDD. 

## Self Testing Code

El código "auto testeado" es código que nos permite corroborar su correcto funcionamiento mediante un set de tests automatizados que ejecuten contra el código fuente de nuestra aplicación.

El código "auto testeado" nos permite trabajar con **confianza** en nuestro sistema sabiendo que cualquier potencial fallo introducido por un cambio puede ser detectado en etapas tempranas del desarrollo mediante la ejecución de tests automatizados.

## Refactoring

Refactoring es una técnica cuyo objetivo es el de mejorar la estructura interna de nuestro código sin modificar el comportamiento visible del mismo.

Es decir, Refactoring **no** agrega funcionalidad, si no que mejora nuestro sistema haciendo nuestro código mas entendible, mantenible y modificable.

## ¿Por qué testear?

Es necesario entender que el software se degrada. Desde el momento en el que ponemos nuestro sistema en funcionamiento el diseño del mismo se enfrenta a distintas fuerzas que lo harán cambiar:

* Cambios en los requerimientos
* Cambios en las dependencias
* Cambios en las librerías, producto de la liberación de nuevas versiones
* O simplemente comprendemos más sobre el dominio de nuestra aplicación y esto nos permite tomar mejores decisiones

Estas distintas fuerzas se traducen en tiempo de mantenimiento que debemos dedicarle a nuestra aplicación para preservar el diseño lo más flexible posible.

Tener un buen set de tests que nos respalde nos permitirá trabajar con *coraje* y *confianza* cuanto tomemos las decisiones necesarias (por ejemplo aplicar Refactoring) para mantener nuestra aplicación.
