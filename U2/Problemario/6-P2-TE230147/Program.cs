/* -------------------------------------------------------------------------
 * INSTITUTO TECNOLÓGICO SUPERIOR DE COMALCALCO
 * Asignatura: Programación Avanzada
 * Ejercicio 06: CELDA AUTOMATIZADA - INSPECCIÓN DE CALIDAD DE LOTE
 * Creador: De La Fuente Chapuz Enrique
 --------------------------------------------------------------------------*/
using System;

Console.WriteLine("EJERCICIO 06: CELDA AUTOMATIZADA - INSPECCIÓN DE CALIDAD DE LOTE");
Console.WriteLine("=================================================");
Console.WriteLine();

// 1. Instanciación del objeto LotePiezas
LotePiezas lote1 = new LotePiezas();

// 2. Registro iterativo de las 10 piezas con ciclo for
for (int i = 1; i <= lote1.TotalPiezas; i++)
{
    int lectura;
    do
    {
        Console.Write($"Pieza [{i}/{lote1.TotalPiezas}] - Ingrese estado (1 = Correcta, 0 = Defectuosa): ");
        lectura = Convert.ToInt32(Console.ReadLine());

        if (lectura != 0 && lectura != 1)
        {
            Console.WriteLine("[ERROR] Valor inválido. Únicamente se permite ingresar 1 (Correcta) o 0 (Defectuosa).");
        }
    } while (lectura != 0 && lectura != 1);

    // Registro dentro del objeto
    lote1.RegistrarPieza(lectura);
}

// 3. Obtención de métricas mediante los métodos del objeto
double porcentajeEfectividad = lote1.CalcularPorcentajeCorrectas();
string dictamen = lote1.DeterminarEstadoLote();

// 4. Salida de resultados con unidades correspondientes
Console.WriteLine();
Console.WriteLine("--- REPORTE FINAL DE INSPECCIÓN ---");
Console.WriteLine($"Total inspeccionado: {lote1.TotalPiezas} piezas");
Console.WriteLine($"Piezas Correctas:    {lote1.PiezasCorrectas} piezas");
Console.WriteLine($"Piezas Defectuosas:  {lote1.PiezasDefectuosas} piezas");
Console.WriteLine($"Porcentaje Conforme: {porcentajeEfectividad:F2} %");
Console.WriteLine($"Dictamen del Lote:   {dictamen}");


// Definición de la Clase LotePiezas
class LotePiezas
{
    // Propiedades
    public int TotalPiezas { get; } = 10;
    public int PiezasCorrectas { get; private set; } = 0;
    public int PiezasDefectuosas { get; private set; } = 0;

    // Método para registrar la inspección de cada pieza
    public void RegistrarPieza(int estado)
    {
        if (estado == 1)
        {
            PiezasCorrectas++;
        }
        else if (estado == 0)
        {
            PiezasDefectuosas++;
        }
    }

    // Método para calcular el porcentaje de piezas conformes
    public double CalcularPorcentajeCorrectas()
    {
        if (TotalPiezas == 0) return 0.0; // Prevención de división entre cero
        return ((double)PiezasCorrectas / TotalPiezas) * 100.0;
    }

    // Método para emitir el dictamen del lote
    public string DeterminarEstadoLote()
    {
        if (CalcularPorcentajeCorrectas() >= 90.0)
        {
            return "LOTE ACEPTADO";
        }
        else
        {
            return "LOTE RECHAZADO";
        }
    }
}