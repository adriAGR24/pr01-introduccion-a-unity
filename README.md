# Introducción a Unity

* **Alumno:** Adrián García Rodríguez
* **Correo:** alu0101557977@ull.edu.es

## Adición de objetos 3D básicos

Creamos un cubo 3D seleccionando la pestaña `GameObject > 3D Object > Cube`.

<video src="media/crear-cubo.mp4" title="Crear cubo" loop="true" muted autoplay></video>

Creamos una esfera 3D seleccionando la pestaña `GameObject > 3D Object > Sphere`.

<video src="media/crear-esfera.mp4" title="Crear esfera" loop="true" muted autoplay></video>

Creamos una cápsula 3D seleccionando la pestaña `GameObject > 3D Object > Capsule`.

<video src="media/crear-cápsula.mp4" title="Crear cápsula" loop="true" muted autoplay></video>

Creamos un cilindro 3D seleccionando la pestaña `GameObject > 3D Object > Cylinder`.

<video src="media/crear-cilindro.mp4" title="Crear cilindro" loop="true" muted autoplay></video>

## Adición en el proyecto del paquete Starter Assets

Primeramente, buscamos en el navegador la `Asset Store` y ponemos en la barra de búsqueda de la misma: *Starter Assets*.

![visualización del paquete 'Starter Assets' en la Asset Store](media/starter-assets-store.png)

Seleccionamos el paquete `Starter Assets - ThirdPerson`, y pinchamos en *Add to My Assets*.

![adición del paquete 'Starter Assets'](media/añadir-starter-assets.png)

Todavía en la `Asset Store` vamos a la ventana de `My Assets`, donde confirmaremos la adición del paquete anterior.

![visualización de 'My Assets'](media/ver-my-assets.png)

Ahora, entramos a `Unity` nuevamente, donde seleccionaremos la pestaña `Window > Package Management > My Assets`. En ese momento, se nos desplegará una ventana emergente, en la que tendremos que buscar el asset que deseamos incluir en nuestro proyecto.

![visualización 'Starter Asset' en Unity](media/starter-asset-unity.png)

Finalmente lo descargaremos y lo importaremos a nuestro proyecto.

!['Starter Asset' importado en el proyecto](media/starter-assets-importado.png)

En la parte inferior de la interfaz de `Unity`, podremos observar el paquete importado.

![visualización del paquete importado](media/ver-starter-assets-importado.png)

## Adición de un objeto libre de la Asset Store que no sea de los Starter Assets

En este caso, importaremos a nuestro proyecto 3 paquetes distintos de la `Asset Store`: `ZIL 130 Military truck`, `Zombie` y `Rock and Boulders 2`.

![paquete 'ZIL 130 Military truck'](media/zil-military-truck-asset.png)

![paquete 'Zombie'](media/zombie-asset.png)

![paquete 'Rock and Boulders 2'](media/rock-boulders-asset.png)

Para importar estos paquetes, seguiremos los pasos realizados en el apartado anterior. Una vez con los paquetes en nuestro proyecto, introduciremos en la escena un objeto de cada asset. Comenzaremos introduciendo un camión del paquete `ZIL 130 Military truck`, concretamente uno de los `prefabs`.

<video src="media/introducir-camión.mp4" title="Introducir camión" loop="true" muted autoplay></video>

Continuamos con el asset `Zombie`, donde introduciremos un `prefab` de zombie.

<video src="media/introducir-zombie.mp4" title="Introducir zombie" loop="true" muted autoplay></video>

Finalmente añadimos a la escena una roca del paquete `Rock and Boulders 2`, igualmente utilizando un `prefab`.

<video src="media/introducir-roca.mp4" title="Introducir roca" loop="true" muted autoplay></video>

## Creación de terreno

Para crear un terreno 3D seleccionando la pestaña `GameObject > 3D Object > Terrain`.

<video src="https://youtu.be/KN5LRlxzB1c" title="Crear terreno" loop="true" muted autoplay></video>

A continuación, le damos relieve al terreno con la herramienta `Paint Terrain`.

![relieve del terreno](media/relieve-terreno.png)

Agregamos algunas texturas naturales a fin de añadirle realismo al terreno con la herramienta `Paint Terrain` y la opción `Paint Texture`.

![texturas del terreno](media/texturas-terreno.png)

Por último, esparcimos algunos árboles a lo largo del terreno para darle más ambiente. Para ello, utilizamos la herramienta `Paint Trees`.

![árboles del terreno](media/árboles-terreno.png)

## Asignación de etiquetas a los objetos

Crearemos una etiqueta para cada objeto de la escena. Para conseguirlo, seleccionaremos cualquier objeto, y en el `Inspector`, pinchamos sobre el campo `Tag > Add Tag`. Entonces, se nos abrirá el `Tag Manager`, desde el que crearemos una etriqueta para cada objeto.

<video src="https://youtu.be/zw9-N0vqHsk" title="Crear etiquetas" loop="true" muted autoplay></video>

Posteriormente, agregaremos la etiqueta correspondiente a cada objeto desde el `Inspector`.

<video src="https://youtu.be/W7Z_GUZt6Uc" title="Añadir etiquetas" loop="true" muted autoplay></video>

## Utilización del prefab del paquete Starter Assets - ThirdPerson

Primero, localizaremos el prefab deseado. En este caso, lo encontraremos en `Assets > StarterAssets > ThirdPersonController > Prefabs > NestedParentArmature_Unpack`. Una vez localizado, arrastraremos el prefab a la escena.

<video src="https://youtu.be/JU43QikPzr8" title="Añadir prefab del Starter Assets" loop="true" muted autoplay></video>

Por defecto, el prefab incluye un panel de controles para móviles. Como en nuestro caso controlaremos al personaje mediante el teclado, desactivaremos este elemento: `UI_Canvas_StarterAssetsInputs_Joysticks`.

<video src="https://youtu.be/AcErZlJEmCQ" title="Quitar controles del prefab del Starter Assets" loop="true" muted autoplay></video>

## Adición de un script que escriba en la consola la etiqueta y posición de cada objeto que hayas utilizado. 

Creamos un script vacío en C# en la carpeta `Assets`, seleccionando la pestaña `Create > Scripting > Empty C# Script`.

<video src="https://youtu.be/HCnmz3nUitE" title="Crear script vacío" loop="true" muted autoplay></video>

Programamos el script para que al inicio del juego se imprima por consola la etiqueta del objeto y su posición.

![visualización del script etiqueta-posición](media/script-etiqueta-posición.png)

Asignamos el script creado a cada objeto: en el `Inspector` seleccionamos `Add Component` y escribimos el nombre del script.

<video src="https://youtu.be/iGfUyCPJkhs" title="Asignar script etiqueta-posición" loop="true" muted autoplay></video>

Ejecutamos el juego a fin de comprobar si el script funciona.

<video src="https://youtu.be/v37VyPfYtcI" title="Funcionamiento script etiqueta-posición" loop="true" muted autoplay></video>

Asimismo, incluiremos un script específicamente para el personaje. Este script mostrará al inicio del juego la etiqueta y la posición del jugador. Además, cada vez que se mueva, se imprimirá nuevamente por consola la etiqueta y la nueva posición del mismo.

![visualización del script etiqueta-posición-movimiento](media/script-etiqueta-posición-movimiento.png)

Ejecutamos el juego con el objetivo de comprobar si el nuevo script funciona.

<video src="https://youtu.be/fAdRpqfWfHs" title="Funcionamiento script etiqueta-posición-movimiento" loop="true" muted autoplay></video>

## Ejecución del juego

<video src="https://youtu.be/odVaqTvgGlM" title="Ejecución del juego" loop="true" muted autoplay></video>