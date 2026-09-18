//Ciclos de Repetición
//se usa para repetir un bloque de código mientras se cumpla una condición, para un numero determinado de veces o hasta que se cumpla una condición, y tambien hay indeterminado de veces
//Tipos de ciclos de repetición

//1. Ciclo finito: es el ciclo for, nos sirve para repetir un bloque de código un numero determinado de veces
//Repite un numero determiando de veces

//2. Ciclo infinito: es el ciclo while, nos sirve para repetir un bloque de código mientras se cumpla una condición, y si no se cumple la condición el ciclo termina
//funciona con condiciones booleanas, es decir, que solo puede ser verdadero o falso
//hasta que la condición deje de ser verdadera

//Primero con Ciclo finito, ejercicio 5: Circlo for con el promedio
//Variable acumulador, lo trabajaremos con variables numericas, que nos servira para ir sumando las calificaciones y luego dividirlas entre el numero de calificaciones para obtener el promedio
//for (variable de control;condición;incremento) [no lleva punto y coma]
//      inicializador; limite al que llegare el cilo for; cual sera el incremento de la variable de control
//{
//  Bloque de código que se repetirá (instrucciones);
//Variable acumulador -> sumador; [los vamos a guardar en la variable acumulador]
//}

using System.Timers;

Console.WriteLine("EJERCICIO_5");                                    //Numero de la practica
Console.WriteLine("CÁLCULO DEL PROMEDIO DE CINCO CALIFICACIONES, USANDO CICLO FOR");    //Nombre del ejercicio
Console.WriteLine();                                                 //Instruccion para dejar un espacio en blanco en la consola


double suma = 0; //suma, porque es la suma de las variables
for (int numero=1; numero<=5; numero++) //el ++ es par aque vaya incrementando de uno en uno.
{
    Console.Write($"Ingrese la calificación {numero}: "); //se utiliza el console.write() para escribir y que el usuario pueda ingresar un valor, el signo $ sirve para que se pueda concatenar la variable numero con el texto que se esta escribiendo
    double calificacion = Convert.ToDouble(Console.ReadLine()); //se utiliza el console.readline() para leer lo que el usuario ingresa y convertirlo a double
    suma = suma + calificacion; //se va sumando la calificacion ingresada por el usuario a la variable suma
}

double promedio = suma / 5; //se calcula el promedio dividiendo la suma entre el número de calificaciones
Console.WriteLine();
Console.WriteLine($"El promedio de las cinco calificaciones es: {promedio:F2}");

//determinar su el alumno con estas calificaciones: 0-50= alumno deficiente, 51-69= alumno requiere apoyo, 70-79 = alumno regular, 80-89 = alumno bueno, 90-100= alumno excelente
if (promedio <= 50)
{
    Console.WriteLine("Alumno deficiente.");
}
else if (promedio >= 51 && promedio < 70)
{
    Console.WriteLine("Alumno requiere apoyo.");
}
else if (promedio >= 70 && promedio < 80)
{
    Console.WriteLine("Alumno regular.");
}
else if (promedio >= 80 && promedio < 90)
{
    Console.WriteLine("Alumno es bueno.");
}
else if (promedio >= 90 && promedio <= 100)
{
    Console.WriteLine("Alumno es excelente.");
}

