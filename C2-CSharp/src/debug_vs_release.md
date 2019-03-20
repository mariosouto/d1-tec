# Debug vs Release

Cuando trabajemos en Visual Studio vamos a ver que nuestra aplicación puede ser compilada en dos modos diferentes: `debug` y `release`, ¿cuál es la diferencia entre ellos?

Cuando la compilación está en modo `debug` no se realizan optimizaciones de performance, la compilación está apuntada al programador y el resultado de la compilación contiene información que le facilita al IDE debuggear nuestra aplicación.

Cuando la compilación está en modo `release` el _jitter_ realiza optimizaciones de performance importantes y generalmente esta compilación apunta a ser ejecutada por el usuario final.
