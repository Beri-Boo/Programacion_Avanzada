using System.Timers;

Console.WriteLine("EJERCICIO_1");                                    //Numero de la practica
Console.WriteLine("CÁLCULO DEL PROMEDIO DE TRES CALIFICACIONES");    //Nombre del ejercicio
Console.WriteLine();                                                 //Instruccion para dejar un espacio en blanco en la consola
//writeline solo nos sirve para escribir un conjunto de palabras, y se puede escribir lo que sea, todo lo cobtrario cuando es
//una varibale, que no lleva ni acentos, caracteres, etc...

Console.Write("Ingrese la primera calificación: "); //se utiliza el console.write() para escribir y que el usuario pueda ingresar un valor
double calificacion1 = Convert.ToDouble(Console.ReadLine());         //Declaramos la variable 1
//el Double es un tipo de dato que nos permite almacenar numeros con decimales, 
//y el convert.toDouble() nos sirve para convertir el valor ingresado por el usuario a un tipo de dato double. osea que convierte el 
//numero entero como decimal, de 95 a 95.00
//el console.readline() nos sirve para leer el valor ingresado por el usuario, y lo que hace es esperar a que el usuario ingrese un valor y presione enter

Console.Write("Ingrese la segunda calificación: ");
double calificacion2 = Convert.ToDouble(Console.ReadLine());         //Declaramos la variable 2

Console.Write("Ingrese la tercera calificación: ");
double calificacion3 = Convert.ToDouble(Console.ReadLine());         //Declaramos la variable 3 

double promedio = (calificacion1 + calificacion2 + calificacion3) / 3.0; //aqui ya declaramos una nueva variable, que sera lo que andamos buscando
//osea, es la operación

Console.WriteLine(); //para dejar un espacio en blanco en la consola
Console.WriteLine($"El promedio de las tres calificaciones es: {promedio:F2}"); //imprimimos el resultado en la consola, y el {promedio:F2} nos sirve para mostrar el promedio con 2 decimales
                                                                                //el simbolo de peso, es una interpolacion de cadenas, que nos permite insertar el valor de una variable dentro de una cadena de texto, y el :F2 nos sirve para mostrar el promedio con 2 decimales
                                                                                //el F2 es un formato de cadena que nos permite mostrar el valor de una variable con 2 decimales, y el :F2 nos sirve para mostrar el promedio con 2 decimales
