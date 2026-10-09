/* -----------------------------------------------------------------------------------
 * INSTITUTO TECNOLÓGICO SUPERIOR DE COMALCALCO
 * Asignatura: Programación Avanzada
 * Ejercicio 09: Comparativa de Rendimiento de Bombas Eléctricas
 * Creador:Hernández Domínguez Bryan
 * ----------------------------------------------------------------------------------- */
Console.WriteLine("=== COMPARATIVA DE RENDIMIENTO DE BOMBAS ELÉCTRICAS ===");
Console.WriteLine();
// Objetos: Instanciación de dos equipos de la clase BombaElectrica
BombaElectrica bomba1 = new BombaElectrica();
BombaElectrica bomba2 = new BombaElectrica();
// Asignación de Propiedades para Bomba 1
Console.WriteLine("--- DATOS BOMBA 1 ---");
Console.Write("Identificador del equipo: ");
bomba1.Id = Console.ReadLine() ?? "Sin ID";
Console.Write("Voltaje de alimentación (V): ");
bomba1.Voltaje = Convert.ToDouble(Console.ReadLine());
Console.Write("Corriente consumida (A): ");
bomba1.Corriente = Convert.ToDouble(Console.ReadLine());
Console.Write("Caudal entregado (L/min): ");
bomba1.Caudal = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
// Asignación de Propiedades para Bomba 2
Console.WriteLine("--- DATOS BOMBA 2 ---");
Console.Write("Identificador del equipo: ");
bomba2.Id = Console.ReadLine() ?? "Sin ID";
Console.Write("Voltaje de alimentación (V): ");
bomba2.Voltaje = Convert.ToDouble(Console.ReadLine());
Console.Write("Corriente consumida (A): ");
bomba2.Corriente = Convert.ToDouble(Console.ReadLine());
Console.Write("Caudal entregado (L/min): ");
bomba2.Caudal = Convert.ToDouble(Console.ReadLine());
// Salida con Métodos calculadores y unidades explícitas (W, L/min/W)
Console.WriteLine();
Console.WriteLine("================ RESULTADOS ================");
Console.WriteLine($"Bomba [{bomba1.Id}]: Potencia = {bomba1.CalcularPotencia():F2} W | Desempeño = {bomba1.CalcularDesempeno():F4} L/min/W");
Console.WriteLine($"Bomba [{bomba2.Id}]: Potencia = {bomba2.CalcularPotencia():F2} W | Desempeño = {bomba2.CalcularDesempeno():F4} L/min/W");
Console.WriteLine();
// Evaluación de resultados evitando inconsistencias
if (bomba1.CalcularPotencia() == 0 && bomba2.CalcularPotencia() == 0)
{
    Console.WriteLine("CONCLUSIÓN: Ambos equipos presentan potencia de 0.00 W (inoperativos).");
}
else if (bomba1.CalcularDesempeno() > bomba2.CalcularDesempeno())
{
    Console.WriteLine($"CONCLUSIÓN: La bomba '{bomba1.Id}' entrega MÁS caudal por watt.");
}
else if (bomba2.CalcularDesempeno() > bomba1.CalcularDesempeno())
{
    Console.WriteLine($"CONCLUSIÓN: La bomba '{bomba2.Id}' entrega MÁS caudal por watt.");
}
else
{
    Console.WriteLine("CONCLUSIÓN: Ambos equipos presentan exactamente el mismo desempeño.");
}
// Clase: Estructura base para los objetos de bomba eléctrica
class BombaElectrica
{
    // Propiedades: Parámetros eléctricos e hidráulicos
    public string Id { get; set; } = "";
    public double Voltaje { get; set; }
    public double Corriente { get; set; }
    public double Caudal { get; set; } // En L/min
    // Método: Calcula la potencia eléctrica (P = V * I)
    public double CalcularPotencia()
    {
        return Voltaje * Corriente;
    }
    // Método: Calcula el desempeño (Caudal / Potencia) evitando división entre cero
    public double CalcularDesempeno()
    {
        double potencia = CalcularPotencia();

        // Control estricto contra división entre cero cuando voltaje o corriente son 0
        if (potencia <= 0)
        {
            return 0.0;
        }
        return Caudal / potencia;
    }
}