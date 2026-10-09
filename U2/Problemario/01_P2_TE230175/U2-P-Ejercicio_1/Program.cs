//Ejercicio 1: Una estación de prueba necesita evaluar el consumo eléctrico de un motor de corriente directa. El usuario introducirá el identificador del motor,
//el voltaje de alimentación y la corriente consumida. El programa calculará la potencia eléctrica mediante P = V*I. Para este ejercicio, una potencia menor o igual que 120 W
//se considera consumo normal; una potencia mayor se considera consumo elevado
Console.WriteLine("EJERCICIO 1 - CONSUMO ELÉCTRICO DE UN MOTOR (CREADOR POR FUENTES DE LA CRUZ BERNARDO)");
Console.WriteLine();

// Crear un objeto de la clase Motor
Motor motor1 = new Motor();

// Capturar la información 
Console.Write("Ingrese el identificador del motor: ");
motor1.Identificador = Console.ReadLine() ?? "Sin identificador";

Console.Write("Ingrese el Voltaje de alimentación (en voltios): ");
motor1.Voltaje = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la Corriente consumida (en amperios): ");
motor1.Corriente = Convert.ToDouble(Console.ReadLine());

// Calcular la potencia
double Potencia = motor1.CalcularPotencia();

// Mostrar los datos del motor
Console.WriteLine();
Console.WriteLine("DATOS DEL MOTOR");
Console.WriteLine($"Identificador: {motor1.Identificador}");
Console.WriteLine($"Voltaje: {motor1.Voltaje} V");
Console.WriteLine($"Corriente: {motor1.Corriente} A");
Console.WriteLine($"Potencia: {Potencia} W");
motor1.ConsumoM();

// Definición de la clase
class Motor
{
    // Propiedades
    public string Identificador { get; set; } = "";
    public double Corriente { get; set; }
    public double Voltaje { get; set; }

    // Calcular la potencia eléctrica
    public double CalcularPotencia()
    {
        double Potencia;
        Potencia = Voltaje * Corriente;
        return Potencia;
    }

    // Determinar el consumo eléctrico del motor
    public void ConsumoM()
    {
        double Potencia = CalcularPotencia();
        if (Potencia <= 120)
        {
            Console.WriteLine("El consumo es normal.");
        }
        else
        {
            Console.WriteLine("El consumo es elevado.");
        }
    }
}