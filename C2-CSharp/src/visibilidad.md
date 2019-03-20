 # Visibilidad
 
 La vibilidad de una clase está directamente relacionada con el concepto de la programación orientada a objetos conocido como _Encapsulación_. La encapsulación nos ayuda a determinar que nivel de detalle queremos mostrar fuera de una clase, es decir que tan "visible" es una clase.
 
 Cuanto mas detalle y complejidad una clase revele mas difícil será utilizarla.
 
 ## `public`
 
 No tiene ningún tipo de restricción. Puede ser accedido desde cualquier objeto, clase y assembly.
 
 ## `private`
 
 Solamente puede ser accedido dentro de la clase que lo define.
 
 ## `protected`
 
 Puede ser accedido desde la clase que lo define y desde cualquier otra clase que lo herede.
 
 ## `internal`
 
 Solamente puede ser accedido dentro del assembly en el que se encuentre.
 
**Por defecto las clases tienen visibilidad `internal` y los métodos `private`**
