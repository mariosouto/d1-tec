# Mentalidad TDD

* Pensar en términos de _qué tests necesito tener en green para poder verificar que tengo implementado el comportamiento que especifican mis requerimientos?_

**Sugerencia:** Mantener una lista de los requerimientos que necesito y escribir los tests que los verifiquen

* No pensar en _cómo lo voy a implementar_ si no en _que interfaz necesito_ para ejecutar mi test. Inventar la interfaz que me gustaría tener.

* Escribir tests para todos los posibles comportamientos. No pensar solamente en el _happy path_ si no considerar que puede salir mal.

* Si encontramos un bug, escribir el test que efectivamente verifique la presencia del bug (es decir, un test que falle). Luego escribir el mínimo código necesario para que el test pase.
