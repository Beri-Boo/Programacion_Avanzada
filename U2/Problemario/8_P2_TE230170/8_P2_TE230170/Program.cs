/* -----------------------------------------------------------------------------------
 * INSTITUTO TECNOLÓGICO SUPERIOR DE COMALCALCO
 * Asignatura: Programación Avanzada
 * Ejercicio 08: Control de Llenado de Tanque de Líquido
 * Creador: Hernández Domínguez Bryan
 ----------------------------------------------------------------------------------- */
Console.WriteLine("=== CONTROL DE LLENADO DE TANQUE ===");
Console.WriteLine();
// Crear un objeto de la clase 
TanqueLiquido tanque = new TanqueLiquido();
// Capturar la información 
Console.Write("Capacidad máxima del tanque (en L): ");
tanque.Capacidad = Convert.ToDouble(Console.ReadLine());
Console.Write("Volumen inicial (en L): ");
tanque.VolumenActual = Convert.ToDouble(Console.ReadLine());
Console.Write("Volumen a agregar por ciclo (en L): ");
tanque.VolumenAgregar = Convert.ToDouble(Console.ReadLine());
tanque.SimularLlenado(); // Llama al método para simular el llenado
// Definición de la clase TanqueLiquido
class TanqueLiquido
{
    public double Capacidad { get; set; } // Propiedad para la capacidad máxima
    public double VolumenActual { get; set; } // Propiedad para el volumen actual
    public double VolumenAgregar { get; set; } // Propiedad para el incremento de volumen

    // Método para calcular el porcentaje de llenado actual
    public double CalcularPorcentaje()
    {
        if (Capacidad <=0)
        {
            return 0.0;
        }
        return (VolumenActual / Capacidad) * 100.0;
    }
    // Método para simular el llenado progresivo
    public void SimularLlenado()
    {
        if (VolumenAgregar <= 0)
        { // Valida entrada positiva
            Console.WriteLine("Error: El volumen a agregar debe ser mayor que cero.");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("--- INICIANDO PROCESO DE LLENADO ---");
            int ciclo = 0; // Inicia contador
            // Muestra el estado inicial (Ciclo 0) antes de sumar el primer incremento
            Console.WriteLine($"Ciclo {ciclo}: Volumen actual = {VolumenActual:F2} L | Llenado = {CalcularPorcentaje():F2}%");

            while (VolumenActual < Capacidad) // Repite hasta alcanzar la capacidad
            {
                ciclo++; // Suma 1 al ciclo
                VolumenActual += VolumenAgregar; // Aumenta el volumenS
                if (VolumenActual > Capacidad) // Verifica límite
                {
                    VolumenActual = Capacidad; // Restringe al máximo permitido
                }
                Console.WriteLine($"Ciclo {ciclo}: Volumen actual = {VolumenActual:F2} L | Llenado = {CalcularPorcentaje():F2}%"); // Imprime progreso
            }

            Console.WriteLine("¡El tanque ha alcanzado su capacidad máxima!"); // Aviso final
        }
    }
}
