# Private Assemblies, Shared Assemblies y GAC

## Private Assemblies

Por defecto todo proyecto que creamos en Visual Studio (libreria de clases o ejecutables) son liberados como _private assemblies_. Los assemblies privados se tienen que ubicar en el mismo directorio o subdirectorio de la aplicación que los está utilizando.

Cada vez que compilamos nuestro proyecto se crea una _copia privada_ assembly y Visual Studio la ubica por defecto en el mismo directorio en el que se encuentra nuestra aplicación.

## Shared Assemblies

También conocidos como _public assemblies_, un _shared assembly_ se comporta igual que un assembly en el sentido de que es la agrupación de un conjunto de tipos cuya intención es ser reutilizados.

La diferencia es que una sola copia de un _shared assembly_ puede ser utilizada por múltiples aplicaciones dentro de la misma máquina.

## Global Assembly Cache

Como se puede intuir, un _shared assembly_ no se libera copiándolo en el mismo directorio de nuestra aplicación. Por el contrario, los _shared assembly_ se instalan en el GAC (Global Assembly Cache), que es un directorio en el que se encuentran todos los assemblies que tenemos instalados de todos los softwares que use la PC.

_En el GAC no se puede instalar assemblies ejecutables (.exe), solamente assemblies con la extensión .dll pueden liberarse como shared assemblies_
