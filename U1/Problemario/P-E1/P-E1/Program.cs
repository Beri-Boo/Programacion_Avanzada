//Diseñe un programa que solicite al usuario el voltaje y la corriente consumida por un motor de corriente directa. El programa deberá calcular la potencia eléctrica mediante:
//P=VI
//Después deberá clasificar el funcionamiento del motor de acuerdo con lo siguiente:  
//a) Si la potencia es menor o igual a 120 W, mostrar: CONSUMO NORMAL. 
//b) Si la potencia es mayor que 120 W, mostrar: ADVERTENCIA: CONSUMO ELEVADO.  
using System.Timers; 

Console.WriteLine("Ejercicio 1"); // Muestra el título del ejercicio en la consola.
Console.WriteLine("Este programa calcula la potencia eléctrica de un motor de corriente directa y clasifica su funcionamiento."); // Muestra la descripción del programa.
Console.WriteLine(); // Imprime un salto de línea en blanco para separar el texto.

Console.WriteLine("Ingrese el voltaje (V) del motor de corriente directa:"); // Pide al usuario que ingrese el voltaje.
double voltaje = Convert.ToDouble(Console.ReadLine()); // Lee el texto ingresado, lo convierte a decimal (double) y lo guarda en la variable 'voltaje'.

Console.WriteLine("Ingrese la corriente (A) del motor de corriente directa:"); // Pide al usuario que ingrese la corriente.
double corriente = Convert.ToDouble(Console.ReadLine()); // Lee el texto ingresado, lo convierte a decimal y lo guarda en la variable 'corriente'.
double potencia = voltaje * corriente; // Calcula la potencia multiplicando las dos variables.
Console.WriteLine($"La potencia eléctrica del motor es: {potencia} W"); // Imprime en pantalla el resultado de la operación.
Console.WriteLine(); // Imprime otro salto de línea.

if (potencia <= 120) // Evalúa si la potencia es menor o igual a 120 W.
{
    Console.WriteLine("CONSUMO NORMAL."); // Imprime este mensaje si la condición de arriba es verdadera.
}
else // Entra aquí si la condición fue falsa (potencia mayor a 120 W).
{
    Console.WriteLine("ADVERTENCIA: CONSUMO ELEVADO."); // Imprime este mensaje de alerta.
}