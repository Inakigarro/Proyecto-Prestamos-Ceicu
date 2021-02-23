# Prestamos CEICU.

Bienvenidos a mi primer repositorio público de *Git Hub*. Aquí estaré subiendo todos los archivos relacionados al proyecto de desarrollo
de una aplicación para el Centro de Estudiantes de Ingeniería de Concepción del Uruguay (CEICU) de la Universidad Tecnológica Nacional (UTN) Facultad Regional Concepción del Uruguay(FRCU).

Este proyecto no esta impulsado por CEICU ni por la FRCU. El nombre es provisorio y puede cambiar en el futuro.

## Introducción.
El CEICU cuenta con un servicio de préstamos de objetos para que los alumnos utilicen. Al día de hoy el formato utilizado para registrar los prestamos es en planillas impresas en papel y almacenadas en carpetas. Hay una serie de planillas para cada tipo de objeto que se puede prestar. Las que son completadas se guardan en folios comunes y estos a su vez en una única carpeta. Cuando una planilla se llena, se revisa si hay prestamos registrados que todavía no hayan sido devueltos y en tal caso, ésta no se archiva hasta que todos los prestamos registrados estén devueltos. Este proceso no siempre se cumple, ya que muchas veces en el apuro de registrar un nuevo préstamo, se guardan las planillas sin revisar. Lo que dificulta el seguimiento de los préstamos y de los objetos prestados. 

Una vez cada 6 meses se realiza un inventario de los objetos para comprobar cuales están y cuales no en el CEICU. Es recién en este momento en donde se detectan los faltantes de algunos objetos por la no devolución o el robo de estos, así como también los objetos rotos y que no pueden ser prestados. Esto termina con un inventario incompleto por falta de información.

Este problema deriva en:
- Disminución de la cantidad de objetos que se pueden prestar a lo largo del tiempo, lo que empeora el servicio a los alumnos.
- Gastos innecesarios por la recompra los objetos extraviados o robados para mantener el servicio de préstamos lo más completo posible.

## Objetivos.
El objetivo principal del proyecto es desarrollar una aplicación que brinde las siguientes funcionalidades básicas para la administración del servicio de préstamos del CEICU:
1. Permitir la emisión de nuevos préstamos, la búsqueda de préstamos activos y devueltos, la devolución y la anulación de los prestamos activos.
2. Permitir el registro de los objetos que se pueden prestar, modificar el estado de estos, buscarlos y eliminarlos. 
3. Permitir el registro, la búsqueda y la modificación de las personas que interactúen con el sistema. Estas serán los **Secretarios** que emitirán los préstamos y los **Estudiantes** o **Profesores** que los recibirán.

## Preguntas guias del Proyecto.

### ¿Quienes van a usar el sistema?
    El sistema podra ser utilizado por:
        * Secretarios del Centro de Estudiantes de Ingenieria de Concepcion del Uruguay. Ellos seran los que prestaran los objetos.
        * Alumnos de la Facultad Regional de Concepcion del Uruguay. Ellos seran los que recibiran los objetos prestados.
        * Profesores de la Facultad Regional de Concepcion del Uruguay. Ellos seran los que recibiran los objetos prestados.

### ¿Que cosas se van a prestar?
    Los objetos que se van a prestar son aquellos que se encuentran dentro del sistema de prestamos del CEICU.
    Los objetos mas comunes son:
        * Calculadoras.
        * Cargadores.
        * Zapatillas.
        * Mates. 
        * Bombillas. 
        * Termos.
        * Cascos.
        * Paraguas.
    
    Los demas objetos estaran especificados en los requisitos funcionales.
### ¿Por cuanto tiempo se van a prestar?
    Los objetos se prestaran por plazo maximo de 1 semana. 
    Para prestamos mas largos, se debera avisar con anticipacion para reservar el o los objeto/os prestado/os 

### ¿Que pasa si no se devuelven a tiempo?
    Si no se devuelven a tiempo, el alumno/profesor no podra recibir ningun prestamo por el plazo de 1 semana. 
    Si un alumno/profesor solicita un nuevo prestamo teniendo uno activo y en falta, el prestamo quedara anulado instantaneamente. 
    Si se detecta que un alumno/profesor no ha devuelto un prestamo en mucho tiempo, quedara deshabilitado hasta que devuelva todos los objetos prestados.

### ¿Que pasa si el objeto se devuelve roto?
    Si el objeto se duelve roto, el alumno/profesor no podra recibir ningun prestamo por el plazo de 1 semana.

### ¿Se podran reservar los objetos? ¿Con Cuanto tiempo de anticipacion?
    Si. Se podra reservar los objetos con un maximo de 4 horas de anticipacion. Si el objeto no es retirado a tiempo, la reserva se cancela.
    Para prestamos especiales, la reserva debera ser personal en la oficina del ceicu.
