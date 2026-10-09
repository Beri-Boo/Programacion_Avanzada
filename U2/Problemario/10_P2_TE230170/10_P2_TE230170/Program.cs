/* -----------------------------------------------------------------------------------
 * INSTITUTO TECNOLÓGICO SUPERIOR DE COMALCALCO
 * Asignatura: Programación Avanzada
 * Ejercicio 10: Diagnóstico Múltiple de Motores Eléctricos
 * Creador: Hernández Domínguez Bryan
 ----------------------------------------------------------------------------------- */
Console.WriteLine("=== DIAGNÓSTICO MÚLTIPLE DE MOTORES ===");
Console.WriteLine();
// Variable de control inicializada para permitir la primera iteración del ciclo while
string respuesta = "s";
while (respuesta == "s")
{
    // Crear un objeto de la clase DiagnosticoMotor
    DiagnosticoMotor motor = new DiagnosticoMotor();
    // Capturar el identificador del motor
    Console.Write("Ingrese el identificador del motor: ");
    motor.IdMotor = Console.ReadLine() ?? "Sin ID";
    double sumaCorrientes = 0;
    // Captura de las 4 mediciones mediante un ciclo for
    for (int i = 1; i <= 4; i++)
    {
        Console.Write($"Ingrese la medición de corriente #{i} (A): ");
        double corriente = Convert.ToDouble(Console.ReadLine());
        sumaCorrientes = sumaCorrientes + corriente;
    }
    // Llama al método para procesar la información y calcular el promedio
    motor.ProcesarDiagnostico(sumaCorrientes);
    // Lectura de control al final del ciclo para preguntar si desea registrar otro motor
    Console.WriteLine();
    Console.Write("¿Desea registrar otro motor? (s/n): ");
    respuesta = Console.ReadLine() ?? "n";
    Console.WriteLine();
}
Console.WriteLine("Proceso de diagnóstico finalizado exitosamente.");
// -----------------------------------------------------------------------------------
// DEFINICIÓN DE LA CLASE
// -----------------------------------------------------------------------------------
class DiagnosticoMotor
{
    public string IdMotor { get; set; } = ""; // Propiedad para el identificador
    public double Promedio { get; set; }     // Propiedad para el promedio de corriente
    // Método para determinar la clasificación según el promedio
    public string ObtenerDiagnostico()
    {
        if (Promedio <= 5.0)
        {
            return "NORMAL";
        }
        else
        {
            return "REQUIERE MANTENIMIENTO";
        }
    }
    // Método para procesar los datos del motor
    public void ProcesarDiagnostico(double sumaCorrientes)
    {
        Promedio = sumaCorrientes / 4.0; // Cálculo del promedio (4.0 evita división entera)
        Console.WriteLine();
        Console.WriteLine($"--- RESULTADOS DEL MOTOR: {IdMotor} ---");
        Console.WriteLine($"Corriente Promedio: {Promedio:F2} A");
        Console.WriteLine($"Diagnóstico Final: {ObtenerDiagnostico()}");
    }
}