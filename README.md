# InterfacesInteligentesCardBoard

Para esta práctica se nos ha pedido añadir la configuración a la escena necesaria para poder utilizar las google Card Boards. 

## Configuracion. 
En primer lugar lo que hemos hecho ha sido descargar el paquete Google Gvr y añadir a la Main Camera el prefab GVrReticlePointer con el que se simulará hacia donde esta mirando el jugador cuando se ponga las gafas. 

## Objetos de la escena. 
Una vez configurada la cámara lo único que habría que hacer es sustituir los componentes PhysicsRayCaster por GvrPointerPhysicsRayCaster además de añadir al componente un eventTrigger y declarar las funciones PointerEnter, PointerClick y PointerExit. Nosotros hemos declarado unicamente la función PointerClick como se verá a continuación. 

## Puerta. 
En este caso hemos hecho que al clickar mirnado hacia una puerta esta se abra y se cierre dependiendo de la posición que ocupe. 
![](img/door.gif)
## Cubo. 
Para el cubo lo que hemos hecho ha sido que este cambie de color al pulsar sobre él. 
![](img/color.gif)
