# Diseño de software

Lo que un sistema debe realizar está determinado por sus requerimientos y a su vez cada requerimiento determina un conjunto de _responsabilidades_ que las entidades de ese sistema deben realizar.

La forma en la que asignamos esas _responsabilidades_ determina la calidad de nuestro diseño.

Considerando el _costo del cambio_ y las distintas _responsabilidades_ surgen dos conceptos conocidos como **Cohesión** y **Acoplamiento**.

## Acoplamiento

Generalmente un cambio que afecta únicamente a una clase o módulo es más sencillo de realizar que un cambio que afecta a varias clases o módulos.

Si un cambio afecta a varias clases o módulos decimos que sus responsabilidades se solapan de alguna forma y que ambos están **acoplados** entre sí. En ese caso el **acoplamiento** es alto. Un alto acoplamiento hace que el software sea más difícil de modificar, ya que un cambio se propaga de un módulo a otro, y por ende hace que el costo de cambiarlo aumente.

## Cohesión

La **Cohesión** mide qué tan relacionadas están entre sí las responsabilidades de una clase o módulo. Que tanto ayudan a la clase a realizar su propósito. Esto podemos verlo ante un cambio en el sistema, si un cambio produce que se modifiquen algunas responsabilidades de un módulo, pero no otras, es posible que dichas responsabilidades no estén relacionadas entre sí.

**Siempre vamos a querer que la cohesión sea alta y el acoplamiento bajo**.

Una forma de aumentar la cohesión de una clase es remover responsabilidades de ella que no estén alineadas con su propósito y asignarlas a otra clase.

Una forma de bajar el acoplamiento podría ser minimizar las dependencias que existen entre los módulos.

El acoplamiento cero es imposible, dado que las entidades del sistema deben colaborar entre sí. Al enviarle una entidad un mensaje a otra se genera un dependencia dado que una tiene que conocer a la otra. La clave es poder manejar estas dependencias de forma de no generar más de las necesarias, ya que las dependencias dificultan los cambios.
