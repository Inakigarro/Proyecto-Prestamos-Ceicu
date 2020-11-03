# Prestamos CEICU.

Bienvenidos a mi primer repositorio publico de *Git Hub*. Aqui estaré subiendo todos los archivos relacionados al proyecto de desarrollo
de una aplicación para el Centro de Estudiantes de Ingeniería de Concepción del Uruguay (CEICU) de la Facultad Regional de Concepción del Uruguay (FRCU)
de la Universidad Tecnologica Nacional (UTN).

## Introducción.
El CEICU cuenta con un sistema de prestamos de objetos para que los alumnos los utilicen. Al dia de hoy el formato utilizado para registrar estos prestamos es en planillas impresas en papel y almacenadas en carpetas. Hay una serie de planillas para cada tipo de objeto que se puede prestar. Las planillas que son completadas son guardadas en folios comunes y estos a su vez guardados en carpetas comunes. Una vez que una planilla esta llena, se revisa si hay prestamos registrados que todavia no hayan sido devueltos y en tal caso, la planilla no se guarda hasta que todos los prestamos registrados esten devueltos. Este proceso no siempre se cumple, ya que muchas veces en el apuro de registrar un nuevo prestamo, se guardan las planillas sin revisar. Esto dificulta el seguimiento de los prestamos y de los objetos prestados. 

Una vez cada 6 meses se realiza un inventario de los objetos para comprobar cuales estan en el CEICU, cuales todavia estan prestados y en tal caso buscar a quien se lo presto para pedirle la devolucion lo mas pronto posible. Es recien en este momento en donde se detectan los faltantes de algunos objetos por la no devolucion o el robo de estos, asi como tambien los objetos rotos y que no pueden ser prestados. Esto termina con un inventario incompleto por falta de información.

Este problema deriva en:
- Disminución de la cantidad de objetos que se pueden prestar a lo largo del tiempo, lo que empeora el servicio a los alumnos.
- Gastos innecesarios por la obligación de recomprar los objetos extraviados o robados para mantener el servicio de prestamos lo más completo posible.

## Objetivos.
El objetivo principal del proyecto es desarrollar una aplicación que brinde las siguientes funcionalidades basicas para la administracion del servicio de prestamos del CEICU:
1. Permitir la emision de nuevos prestamos, la busqueda de prestamos activos y devueltos, la devolución y la anulacion de los prestamos activos.
2. Permitir el registro de los objetos que se pueden prestar, modificar el estado de estos, buscarlos y eliminarlos. 
3. Permitir el registro, la busqueda y la modificacion de las personas que interactuen con el sistema. Estas seran los **Secretarios** que emitiran los prestamos y los **Alumnos** o **Profesores** que los recibiran.

    