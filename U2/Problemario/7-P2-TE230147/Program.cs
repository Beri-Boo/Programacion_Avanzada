/* -------------------------------------------------------------------------
 * INSTITUTO TECNOLÓGICO SUPERIOR DE COMALCALCO
 * Asignatura: Programación Avanzada
 * Ejercicio 07: SISTEMA DE PRODUCCIÓN - BRAZO ROBÓTICO PICK & PLACE
 * Creador: De La Fuente Chapuz Enrique
 --------------------------------------------------------------------------*/
using System;

Console.WriteLine("EJERCICIO 07: SISTEMA DE PRODUCCIÓN - BRAZO ROBÓTICO PICK & PLACE");
Console.WriteLine("===================================================");
Console.WriteLine();

// 1. Instanciación del objeto BrazoRobotico
BrazoRobotico robot1 = new BrazoRobotico();

// 2. Captura de tiempos por etapa en segundos
Console.Write("Ingrese el tiempo de tomar la pieza (s): ");
robot1.TiempoTomar = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el tiempo de trasladar la pieza (s): ");
robot1.TiempoTrasladar = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el tiempo de soltar la pieza (s): ");
robot1.TiempoSoltar = Convert.ToDouble(Console.ReadLine());

// 3. Captura y validación de número de ciclos
int ciclos;
do
{
    Console.Write("Ingrese el número de ciclos a simular (> 0): ");
    ciclos = Convert.ToInt32(Console.ReadLine());

    if (ciclos <= 0)
    {
        Console.WriteLine("[ERROR] El número de ciclos debe ser un entero mayor a cero.");
    }
} while (ciclos <= 0);

robot1.NumeroCiclos = ciclos;

// 4. Cálculo del ciclo unitario
double tiempoPorCiclo = robot1.CalcularTiempoCiclo();

Console.WriteLine();
Console.WriteLine($"Duración de un ciclo completo: {tiempoPorCiclo:F2} s");
Console.WriteLine();
Console.WriteLine("--- SIMULACIÓN DE PROGRESO DE PRODUCCIÓN ---");

// 5. Ciclo for para mostrar el tiempo acumulado en cada ciclo
for (int i = 1; i <= robot1.NumeroCiclos; i++)
{
    double acumulado = i * tiempoPorCiclo;
    Console.WriteLine($"Ciclo #{i} finalizado -> Tiempo Acumulado: {acumulado:F2} s");
}

// 6. Resumen de tiempo total de producción
double tiempoTotal = robot1.CalcularTiempoTotal();

Console.WriteLine();
Console.WriteLine("--- REPORTE FINAL ---");
Console.WriteLine($"Tiempo Total de Producción: {tiempoTotal:F2} s  ({(tiempoTotal / 60.0):F2} min)");
// Definición de la Clase BrazoRobotico
class BrazoRobotico
{
    // Propiedades
    public double TiempoTomar { get; set; }
    public double TiempoTrasladar { get; set; }
    public double TiempoSoltar { get; set; }
    public int NumeroCiclos { get; set; }

    // Método para calcular el tiempo que tarda un ciclo unitario
    public double CalcularTiempoCiclo()
    {
        return TiempoTomar + TiempoTrasladar + TiempoSoltar;
    }

    // Método para calcular el tiempo total acumulado de la producción
    public double CalcularTiempoTotal()
    {
        return NumeroCiclos * CalcularTiempoCiclo();
    }
}