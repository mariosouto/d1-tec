# DLL Hell

El problema de _DLL Hell_ ocurre cuando instalamos una aplicación A que instala en el GAC un `.dll` con versión `1.0.0`. Luego instalamos una aplicación B que utiliza el mismo Assembly pero con una versión superior, `1.0.1`. B instala su `.dll` y elimina la versión `1.0.0`. Debido a esto, pese a ser una diferencia mínima, A deja de funcionar correctamente.

La solución a este problema es que cada `.dll` especifique su versión al ser liberada, de esta forma se previene la sobreescritura del Assembly y el funcionamiento incorrecto de las aplicaciones.
