# Gitflow

Gitflow es un flujo de trabajo definido para Git que nos especifica que tipo de branches tener y que propósito cumplen las mismas.

En resumidas cuentas Gitflow establece lo siguiente:
* Dos branches base `develop` y `master`. `develop` contiene la historia completa del proyecto, mientras que `master` contiene la historia sobre los releases del proyecto. Es decir, trabajamos siempre sobre `develop` y cuando liberamos una nueva versión sacamos una `release` branch desde `develop` que se mergea a `master`.
* Para trabajar en una funcionalidad creamos lo que se conoce como una `feature` branch, que tiene como branch base a `develop`. Cuando terminamos la funcionalidad la branch se mergea a `develop`. Las `feature` branch nunca interactúan con `master`.


[Mas sobre Gitflow](https://www.atlassian.com/git/tutorials/comparing-workflows/gitflow-workflow)
