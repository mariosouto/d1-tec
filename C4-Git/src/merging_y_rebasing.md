# Merging y Rebasing

Cuando trabajamos con múltiples branches en Git muchas veces queremos integrar el trabajo de una branch en otra. O simplemente queremos que la branch que contiene nuestra funcionalidad esté incluída en `master`.

Tenemos dos formas para integrar los commits de una branch en otra:
* Mergear ambas branches
* Aplicar los commits de una branch encima de otra (Rebase)

## `git merge <branch>`

Suponiendo el caso en el que HEAD se encuentre apuntando a `master`, cuando ejecutemos el comando

```
git merge testing
```

Git tratará de mergear **testing** en **master**. Es decir que luego de ejecutar el comando, si todo salió exitosamente, **master** tendrá incluidos los commits de **testing**.

## `git rebase <branch>`

Suponiendo el caso en el que HEAD se encuentre apuntando a una branch `testing`, cuando ejecutemos el comando

```
git rebase master
```

Git rebobinará la branch **testing** hasta llegar al primer ancestro en común que tenga con **master**. Luego aplicará los commits restantes de **testing** encima de los cambios generados en **master**.

Al finalizar la ejecución **testing** tendrá incluídos los cambios de **master**.
