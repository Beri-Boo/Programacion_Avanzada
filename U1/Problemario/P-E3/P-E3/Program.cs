//Ejercicio 3
//Diseñe un programa que simule la carga de una batería de 12.6 V. El usuario deberá ingresar:  
//a) El voltaje inicial de la batería.
//b) El incremento de voltaje producido en cada ciclo de carga.  
//Mediante un ciclo while, el programa aumentará el voltaje hasta alcanzar 12.6 V. En cada repetición deberá mostrar el número de ciclo y el voltaje actual.
//Si el incremento introducido es igual o menor que cero, el programa deberá mostrar un mensaje de error y no ejecutar la simulación
using System.Timers;
Console.WriteLine("Ejercicio 3"); // Título.
Console.WriteLine("Simulación de una batería de 12.6 V"); // Descripción.
Console.WriteLine(); // Salto de línea.
Console.WriteLine("Ingrese el voltaje inicial de la batería (>=0 hasta 12.6V):"); // Instrucción.
double Vini = Convert.ToDouble(Console.ReadLine()); // Lee el voltaje inicial.
Console.WriteLine("Ingrese el voltaje producido por cada ciclo de carga (>0):"); // Instrucción.
double incremento = Convert.ToDouble(Console.ReadLine()); // Lee el incremento.

if (incremento <= 0)
{ // Valida entrada positiva.
    Console.WriteLine("Error: El incremento debe ser mayor que cero."); // Mensaje de error.
}
else
{
    int ciclo = 0; // Inicia contador.
    while (Vini < 12.6) // Repite hasta llegar a 12.6 V.
    {
        ciclo++; // Suma 1 al ciclo.
        Vini += incremento; // Aumenta el voltaje.
        if (Vini > 12.6) // Verifica límite.
        {
            Vini = 12.6; // Restringe al máximo permitido.
        }
        Console.WriteLine($"Ciclo {ciclo}: Voltaje actual = {Vini:F2} V"); // Imprime progreso.
    }
    Console.WriteLine("La batería ha alcanzado su voltaje máximo de 12.6 V."); // Aviso final.
}