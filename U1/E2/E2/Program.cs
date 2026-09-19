using System.Timers;

Console.WriteLine("EJERCICIO_2");                                    //Numero de la practica
Console.WriteLine("CÁLCULO DEL PROMEDIO DE TRES CALIFICACIONES");    //Nombre del ejercicio
Console.WriteLine();                                                 //Instruccion para dejar un espacio en blanco en la consola
//writeline solo nos sirve para escribir un conjunto de palabras, y se puede escribir lo que sea, todo lo cobtrario cuando es
//una varibale, que no lleva ni acentos, caracteres, etc...

Console.Write("Ingrese la primera calificación: "); //se utiliza el console.write() para escribir y que el usuario pueda ingresar un valor
double calificacion1 = Convert.ToDouble(Console.ReadLine());         //Declaramos la variable 1

Console.Write("Ingrese la segunda calificación: ");
double calificacion2 = Convert.ToDouble(Console.ReadLine());         //Declaramos la variable 2

Console.Write("Ingrese la tercera calificación: ");
double calificacion3 = Convert.ToDouble(Console.ReadLine());         //Declaramos la variable 3 

double promedio = (calificacion1 + calificacion2 + calificacion3) / 3.0; //aqui ya declaramos una nueva variable, que sera lo que andamos buscando
//osea, es la operación

Console.WriteLine(); 
Console.WriteLine($"El promedio de las tres calificaciones es: {promedio:F2}"); 

//determinar su el alumno aprobo o no
if(promedio >= 70)
{
    Console.WriteLine("El alumno ha aprobado, Felicidades!");
}
else
{
    Console.WriteLine("El alumno no ha aprobado, Sigue esforzándote!");
}
