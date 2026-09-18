//Ejercicio 2
//Un sensor mide diez veces la temperatura de un motor. Diseñe un programa en el que se escriba una sola vez las
//instrucciones para solicitar las diez mediciones, sumarlas y calcular la temperatura promedio. El programa deberá indicar:
//a) TEMPERATURA NORMAL, si el promedio es menor o igual que 70 °C.  
//b) ALERTA DE TEMPERATURA, si el promedio es mayor que 70 °C.  
using System.Timers;

Console.WriteLine("Ejercicio 2"); // Título.
Console.WriteLine("Mediciones de 10 temperaturas de un motor y determine si la temperatura es normal o hay alerta de sobrecalentamiento."); // Descripción.
Console.WriteLine(); // Espacio.
Console.WriteLine("Ingrese las 10 mediciones de temperatura del motor:"); // Instrucción.
double suma = 0; // Acumulador en cero.

for (int t = 1; t <= 10; t++)
{ // Se repite 10 veces.
    Console.Write($"Ingrese la mediciones {t}: "); // Pide el dato.
    double medicion = Convert.ToDouble(Console.ReadLine()); // Lee y convierte a decimal.
    suma = suma + medicion; // Suma la medición al acumulador.
}

double promedio = suma / 10; // Calcula el promedio.
Console.WriteLine($"El promedio de las mediciones es: {promedio}"); // Muestra el resultado.
Console.WriteLine(); // Espacio.

if (promedio <= 70)
{ // Verifica si no supera los 70°C.
    Console.WriteLine("TEMPERATURA NORMAL"); // Estado normal.
}
else
{
    Console.WriteLine("ALERTA DE TEMPERATURA"); // Alerta de sobrecalentamiento.
}