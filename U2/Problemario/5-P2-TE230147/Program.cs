using System;
/* -------------------------------------------------------------------------
 * INSTITUTO TECNOLÓGICO SUPERIOR DE COMALCALCO
 * Asignatura: Programación Avanzada
 * Ejercicio 05: SISTEMA DE CONTROL DE POSICIÓN DE SERVOMOTOR
 * Creador: De La Fuente Chapuz Enrique
 --------------------------------------------------------------------------*/
Console.WriteLine("PROBLEMARIO 2, EJERCICO 5: SISTEMA DE CONTROL DE POSICIÓN DE SERVOMOTOR");
Console.WriteLine();
// Creación del objeto de la clase Servomotor
Servomotor servo1 = new Servomotor();
// Captura y validación de la Posición Actual (Rango de 0° a 180°)
double entradaActual;
do
{
    Console.Write("Ingrese la posición actual (0° a 180°): ");
    entradaActual = Convert.ToDouble(Console.ReadLine());

    if (entradaActual < 0 || entradaActual > 180)
    {
        Console.WriteLine("ERROR: Posición fuera de rango. Ingrese un valor entre 0 y 180 grados.");
    }
} while (entradaActual < 0 || entradaActual > 180);
servo1.PosicionActual = entradaActual;
// Captura y validación de la Posición Objetivo (Rango de 0° a 180°)
double entradaObjetivo;
do
{
    Console.Write("Ingrese la posición objetivo (0° a 180°): ");
    entradaObjetivo = Convert.ToDouble(Console.ReadLine());
    if (entradaObjetivo < 0 || entradaObjetivo > 180)
    {
        Console.WriteLine("ERROR: Posición fuera de rango. Ingrese un valor entre 0 y 180 grados.");
    }
} while (entradaObjetivo < 0 || entradaObjetivo > 180);

servo1.PosicionObjetivo = entradaObjetivo;
// Invocación de métodos y cálculo de resultados
double desplazamiento = servo1.CalcularDesplazamiento();
string sentido = servo1.DeterminarSentido();
// Despliegue de resultados con unidades correspondientes
Console.WriteLine();
Console.WriteLine("--- REPORTE DE MOVIMIENTO DEL SERVOMOTOR ---");
Console.WriteLine($"Posición Actual:        {servo1.PosicionActual:F2} °");
Console.WriteLine($"Posición Objetivo:      {servo1.PosicionObjetivo:F2} °");
Console.WriteLine($"Desplazamiento Angular: {desplazamiento:F2} °");
Console.WriteLine($"Sentido del Movimiento: {sentido}");
// Definición de la Clase Servomotor
class Servomotor
{
    // Propiedades
    public double PosicionActual { get; set; }
    public double PosicionObjetivo { get; set; }
    // Método para calcular el desplazamiento angular absoluto
    public double CalcularDesplazamiento()
    {
        return Math.Abs(PosicionObjetivo - PosicionActual);
    }
    // Método para determinar la dirección o sentido de movimiento
    public string DeterminarSentido()
    {
        if (PosicionObjetivo > PosicionActual)
        {
            return "HACIA UNA POSICIÓN MAYOR (Avance)";
        }
        else if (PosicionObjetivo < PosicionActual)
        {
            return "HACIA UNA POSICIÓN MENOR (Retroceso)";
        }
        else
        {
            return "SIN MOVIMIENTO (Posición alcanzada)";
        }
    }
}