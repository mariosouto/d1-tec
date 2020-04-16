# Ejercicio

## Introducción

Usted trabaja para una empresa de _Internet de las Cosas_ y un cliente le plantea la siguiente situación.

El cliente se dedica a la venta de refrescos al por mayor y dispone de un gran número de refrigeradores (del orden de los cientos) para almacenar las bebidas.

Para monitorear el estado de los mismos se plantea importar una serie de sensores de temperatura que emitan alertas cuando el refrigerador ha bajado su temperatura por debajo de un determinado límite.

Los sensores emiten lecturas con la temperatura del refrigerador cada 1 segundo.

## Requerimientos

Se pide construir una aplicación por consola que permita:

* Dar de alta dispositivos, de los mismos se conoce **nombre**, **identificador** (su dirección MAC) y **temperatura mínima** (que se utilizará
 para las alertas)
* Simular el ingreso de lecturas en el sistema, la lectura se ingresa con el **identificador** y temperatura
* Generar una alerta automática cuando se ingresa una lectura por debajo del límite de temperatura del dispositivo
* Ver los dispositivos
* Ver las lecturas de un dispositivo
* Ver las alertas de un dispositivo
