# Git

**Git** es un sistema de control de versiones **descentralizado**. Git nos permite guardar una copia **completa** del repositorio remoto, con información sobre su historia, dentro de un directorio denominado `.git`.

## Características

### Git guarda `snapshots`

Tradicionalmente los SCV almacenan la información de nuestros archivos como un conjunto de versiones, donde la primera describe el contenido de nuevos archivos y las siguientes los distintos cambios realizados sobre ellos. Es decir guardan la **diferencia** en el tiempo.

<p align="center">
  <img src="../images/diferencias.png" />
</p>

En cambio, Git no piensa nuestra información como un conjunto de diferencias en el tiempo, sino que Git guarda nuestra información como una lista de **snapshots** en el tiempo, donde cada snapshot es el estado en el que estaban nuestros archivos en ese momento.

Si el archivo no cambió de un snapshot a otro, en lugar de guardar el archivo nuevamente Git guarda una referencia al estado anterior del archivo.

<p align="center">
  <img src="../images/snapshots.png" />
</p>

### La mayoría de las operaciones se realiza de forma local

Al tener la copia completa del repositorio en nuestra máquina local, Git realiza la mayor parte de las operaciones sobre la misma, permitiéndonos continuar nuestro trabajo sin conexión a internet o cuando el repositorio remoto no se encuentra disponible.

### Integridad de nuestra información

Cada vez que almacenamos nueva información dentro de Git, commit mediante, Git genera un string basado en dicha información conocido como SHA-1 hash.

Es imposible alterar la información almacenada sin que Git se de cuenta de lo mismo, es decir, es imposible alterar dicha información y dejar el hash intacto.
