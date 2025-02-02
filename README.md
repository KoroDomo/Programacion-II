# Programacion-II
Repositorio para cargar todas las practicas de Programacion II || 2025 Q1


**Enunciado de ejercicios para la Practica I:**

  Práctica OOP Herencia
  Se requiere realizar los siguientes ejercicios:
  
  1.  Nos dan una escuela. La escuela tiene clases de estudiantes. Cada clase tiene un conjunto de profesores. Cada profesor imparte un conjunto de cursos. Los estudiantes tienen un nombre y un número único en la clase. Las clases tienen un identificador de texto único. Los profesores tienen nombres. Los cursos tienen nombre, recuento de clases y recuento de ejercicios. Tanto los profesores como los estudiantes son personas.
  
  Su tarea es desarrollar las clases (en términos de programación orientada a objetos) junto con sus atributos y operaciones/
  
          - Definir la jerarquía de clases
          - Crear un diagrama de clases.
  2.  Defina una clase abstracta Shape con el método abstracto CalculateSurface() y el ancho y alto de los campos. Defina dos clases adicionales para un triangle y un rectangle, que implementan CalculateSurface(). Este método tiene que devolver las áreas del rectángulo (alto*ancho) y del triángulo (alto*ancho/2).  Defina una clase para un Circle con un constructor apropiado, que inicialice los dos campos (alto y ancho) con el mismo valor (el radio) e implemente el método abstracto para calcular el área. Crea una matriz de diferentes Shapes y calcula el área de cada forma en otra matriz.
  
         Nota: Debe crear un repositorio en github y subir el codigo fuente al mismo, como también un documento conel diagrama de clase del primer enunciado.

**Enunciado de ejercicios para la practica 1.1:**

  Práctica OOP Polimorfismo
  Se debe crear una aplicación que realice el cálculo del salario mensual de los docentes por hora, los docentes de contrato fijo y los empleados administrativos. En el caso de los docentes por hora, se asignará una tarifa de 800 por cada hora trabajada. Asimismo, la aplicación deberá contemplar el cálculo de bonificaciones para los empleados administrativos y los docentes de contrato fijo, tomando en cuenta que si empleado o docente alcanzo la meta entonces se le paga un salario en caso contrario se le paga la mitad.
  
  Nota: Debe subir el código fuente a github para su revisión 

**Enunciado de ejercicios KISS, DRY, YAGNI y SOLID**

Se requiere resolver los ejercicios del documento adjunto, subirlo a github y luego compartir el enlace del repositorio en un archivo de notepad.
Ejercicios de Principios de Diseño (KISS, DRY, YAGNI, SOLID) 

Instrucciones Generales 

1. Crea una solución que contenga una aplicación de consola en C# por cada uno de los 
principios a implementar. 
2. Cada ejercicio debe estar en su propio archivo y namespace. 
3. Refactoriza el código para cumplir con el principio correspondiente. 
4. Sube tu solución a GitHub y organiza el código en carpetas.

**Ejercicio 1: Aplicando KISS (Keep It Simple, Stupid) **
Enunciado: 
Un restaurante necesita calcular el total a pagar por los clientes. Se deben sumar los precios de los 
platos y agregar una propina opcional. Actualmente, el código es innecesariamente complicado y 
difícil de entender. 
Objetivo: 
Refactoriza el código para aplicar KISS, eliminando la complejidad innecesaria y haciéndolo más 
claro y fácil de entender.

Requerimientos: 
• El usuario ingresará los precios de los platos (separados por comas). 
• Se preguntará si desea agregar una propina personalizada o usar la predeterminada del 
10%. 
• El sistema debe calcular y mostrar el total a pagar. 
Ejemplo de ejecución: 
Ingrese los precios de los platos (separados por comas): 200,150,300   
¿Desea agregar una propina personalizada? (s/n): n   
Total a pagar (con propina del 10%): 715   


**Ejercicio 2: Aplicando DRY (Don't Repeat Yourself) **
Enunciado: 
Una empresa necesita calcular el salario de sus empleados de manera eficiente. Actualmente, hay 
código duplicado en los cálculos de impuestos y bonificaciones para empleados de tiempo 
completo y medio tiempo. 
Objetivo: 
Refactoriza el código para aplicar DRY, eliminando la duplicación y reutilizando la lógica común en 
un método.

Requerimientos: 
• El usuario ingresará el tipo de empleado ("1" para tiempo completo, "2" para medio 
tiempo). 
• Para empleados de tiempo completo, se ingresará el salario base. 
• Para empleados de medio tiempo, se ingresará el sueldo por hora y las horas trabajadas. 
• Se calculará el salario neto aplicando un 18% de impuestos y un 5% de bono. 
Ejemplo de ejecución: 
Seleccione el tipo de empleado (1: Tiempo completo, 2: Medio tiempo): 1   
Ingrese el salario base: 50000   
Salario neto después de impuestos y bono: 43250  

**Ejercicio 3: Aplicando YAGNI (You Aren't Gonna Need It) **
Enunciado: 
Un sistema de gestión de productos permite agregar y eliminar productos. Sin embargo, el código 
contiene un método para generar reportes que aún no es necesario. 
Objetivo: 
Refactoriza el código para eliminar la funcionalidad innecesaria y aplicar YAGNI.

Requerimientos: 
• El usuario podrá agregar productos ingresando su nombre y precio. 
• Podrá eliminar productos ingresando el ID. 
• El método innecesario GenerateProductReport() debe ser eliminado. 
Ejemplo de ejecución: 
Seleccione una opción:   
1. Agregar producto   
2. Eliminar producto   
Ingrese el nombre del producto: Laptop   
Ingrese el precio: 750   
Producto 'Laptop' agregado con éxito.

**Ejercicio 4: Aplicando SOLID **
Enunciado: 
Una empresa necesita un sistema de notificaciones que pueda enviar correos electrónicos y SMS, 
pero la clase actual viola el Principio de Responsabilidad Única (SRP) porque también maneja el 
registro de logs. 
Objetivo: 
Refactoriza el código dividiendo responsabilidades en diferentes clases para cumplir con SRP 
(Single Responsibility Principle) dentro del marco de SOLID. 

Ejemplo de ejecución: 
Seleccione el tipo de notificación:   
1. Email   
2. SMS   
Ingrese el mensaje: Bienvenido a nuestro servicio.   
Enviando Email: Bienvenido a nuestro servicio.   
Notificación registrada en logs.  


