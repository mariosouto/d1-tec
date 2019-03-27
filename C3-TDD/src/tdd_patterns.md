# TDD patterns

## Fake It ('Til you make it)

Una vez que tenemos un test que falla la primera implementación debe ser devolver una constante. Empezar con un ejemplo concreto y generalizar a partir de el nos permite prevenir confusiones sobre la implementación y quedarnos "colgados" en casos borde o extraños.

## Triangulation

Extraer una abstracción solamente cuando se tienen dos o más casos de prueba sobre los que podemos generalizar.
