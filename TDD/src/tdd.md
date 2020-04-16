# TDD

**Test Driven Development** es una técnica de desarrollo de software que produce _Self Testing Code_ pero no es la única forma de obtener _Self Testing Code._

La otra forma de producir _Self Testing Code_, es la que comúnmente realizamos de escribir el código fuente y luego escribir los tests para ese código.

**Hacer TDD implica escribir pruebas unitarias pero hacer pruebas unitarias NO significa que estemos haciendo TDD.**

## Objetivos

* Promover un diseño simple con un conjunto de pruebas que inspiren confianza.
* Promover código limpio cuyo funcionamiento se pueda verificar con pruebas automatizadas.

## En qué consiste TDD

<p align="center">
  <img src="../images/fases_tdd.jpg" />
 </p>
 
 Test Driven Development consiste en 3 fases tal como están indicadas en el diagrama anterior
 
 1. **RED** Antes que escribir ni una sola línea de código fuente escribimos un test, que no va a funcionar, y que incluso puede que ni siquiera compile.
 
 2. **GREEN** Escribir el mínimo código necesario para que el test pase (sin "romper" los demás tests).
 
 3. **REFACTOR** Eliminar todo el código duplicado que pueda haberse generado en el paso anterior y dejar el diseño lo más simple posible.
 
 Por último, repetir el ciclo hasta que no hayan más casos de pruebas que agregar.
 
 ## Beneficios
 
* Pensar primero en escribir el test nos obliga a pensar primero en la interfaz necesaria que debe tener nuestro código para que el test pase en lugar de pensar en términos de la implementación. Pensar en términos de _cómo_ vamos a usar nuestra clase nos facilita separar interfaz de implementación.
* Escribir el código más simple posible para que nuestro test pase, y refactorear constantemente, nos lleva a un diseño simple y minimalista en lugar de llevarnos a un diseño que contenga complejidad innecesaria.

## ¿Qué es un diseño simple? Por [Kent Beck](https://en.wikipedia.org/wiki/Kent_Beck)

* Todos sus tests pasan
* No contiene código duplicado
* Revela su intención claramente
* Mínimo número de clases y métodos

## Lectura recomendada

[Is Design Dead?](https://martinfowler.com/articles/designDead.html)
 
