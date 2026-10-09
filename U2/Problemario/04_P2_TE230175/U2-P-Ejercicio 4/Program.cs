//Ejercicio 4: 
//Una batería debe cargarse hasta alcanzar 12.6 V. El usuario introducirá el voltaje inicial y el incremento de voltaje producido en cada ciclo. Mientras el voltaje sea menor que 12.6 V,
//el programa aumentará el valor, mostrará el número de ciclo y el voltaje actualizado. Si el último incremento supera el límite, el valor final deberá ajustarse a 12.6 V.

Console.WriteLine("EJERCICIO 4 - CARGA DE UNA BATERÍA (CREADOR BERNARDO FUENTES DE LA CRUZ)");
Console.WriteLine();

// Crear un objeto de la clase 
Bateria BatNue = new Bateria();

// Capturar la información 
Console.Write("¿Cual es el voltaje inicial de la batería (en V)? ");
BatNue.VoltajeInicial = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese el incremento de voltaje por ciclo (en V): ");
BatNue.Incremento = Convert.ToDouble(Console.ReadLine());
BatNue.CargarBateria(); // Llama al método para cargar la batería.

//Definición de la clase Bateria
class Bateria
{
    public double VoltajeInicial { get; set; } // Propiedad para el voltaje inicial.
    public double Incremento { get; set; } // Propiedad para el incremento de voltaje.

    // Método para cargar la batería.
    public void CargarBateria()
    {
        if (Incremento <= 0)
        { // Valida entrada positiva.
            Console.WriteLine("Error: El incremento debe ser mayor que cero."); // Mensaje de error.
        }
        else
        {
            int ciclo = 0; // Inicia contador.
            while (VoltajeInicial < 12.6) // Repite hasta llegar a 12.6 V.
            {
                ciclo++; // Suma 1 al ciclo.
                VoltajeInicial += Incremento; // Aumenta el voltaje.
                if (VoltajeInicial > 12.6) // Verifica límite.
                {
                    VoltajeInicial = 12.6; // Restringe al máximo permitido.
                }
                Console.WriteLine($"Ciclo {ciclo}: Voltaje actual = {VoltajeInicial:F2} V"); // Imprime progreso.
            }
            Console.WriteLine("La batería ha alcanzado su voltaje máximo de 12.6 V."); // Aviso final.
        }
    }
}