# TDD best practices

## ¿Qué testear?

* Escribir tests de los requerimientos que queremos verificar una vez terminada la implementación. Tanto de los casos "felices" como de los otros.
* Escribir tests de los refactors que surjan en la etapa de refactor de TDD.

## Tests aislados

* La ejecución de un test no debe afectar la ejecución de otro.
* Los tests deben correrse de forma aleatoria, es decir, el resultado de los mismos no puede depender del orden en el que se ejecuten.

## Tests claros

* **Los tests también son parte del código fuente**
* Para testear usar datos que sean fáciles de leer.
* Usar datos cuya intención en el test sea clara.
* Escribir _Asserts_ que comparen el resultado esperado con el obtenido.

## Tests de regresión

* Cuando un bug es reportado escribir un test que falle y al reparar el bug, verificar que el test pase.
