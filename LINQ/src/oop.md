# Paradigma de Orientación a Objetos

La programación orientada a objetos nos hace modelar la realidad como una serie de **mensajes** que son intercambiados por una red o conjunto de **objetos**. Un objeto tiene **identidad, comportamiento y estado**.

El diseño orientado a objetos hace más foco en la comunicación entre los objetos que en cómo están construidos. Un objeto se comunica con otro mediante el envío de mensajes.

De esta forma, un sistema es construido creando objetos y obteniendo su comportamiento, de manera emergente, en base a la **colaboración y composición** de los mismos. Esto nos permite modificar el comportamiento del sistema cambiando la forma en la que los objetos se comunican.

Los objetos entonces son vistos como unidades que proveen servicios, con dependencias explícitas y que funcionan entre sí de forma “pluggable”.

## Encapsulación

El comportamiento de un objeto solamente puede ser afectado por medio de su API.

## Ocultamiento de Información

Nos permite ignorar los detalles de bajo nivel de una implementación, que no son relevantes al servicio que el objeto quiere brindar, y entender lo esencial trabajando a niveles de abstracción altos.

Nos permite reducir el **acoplamiento**, cuando un objeto conoce demasiado sobre los detalles de otro se vuelven acoplados entre sí y los cambios pueden llegar a propagarse.

Cuanto menos conozco sobre los detalles internos de un objeto más flexible es el mismo y mayor libertad me da de cambiar su implementación más adelante.

## Dependencia

Son los servicios que un objeto requiere de otro para llevar a cabo sus responsabilidades.

## Inversión de dependencias

El verdadero poder del paradigma de orientación a objetos es tener control absoluto sobre la dirección de las dependencias de nuestro sistema. Es decir, no estamos obligados a que nuestras dependencias sigan el flujo de ejecución de nuestro programa.

Mediante **polimorfismo** podemos controlar el flujo de dependencias de la forma que nos sea más conveniente. (Principio de inversión de dependencias).
