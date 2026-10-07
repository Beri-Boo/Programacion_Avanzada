//Ejercicio 1:
//Un sistema registra el identificar, la temperatura, corriente y la velocidad de varios motores. El sistema debe mostrar los datos y determinar
//si la temperatura en mayor que 70 grados celsius, si el motor se encuentra detenido o en marcha. Determianar las clases, objetos, propiedades y métodos
//que se deben de utilizar para realizar el código por medio de la POO.

Console.WriteLine("REGISTRADOR DE MOTORES");
Console.WriteLine();

// Crear un objeto de la clase Motor
Motor motor1 = new Motor();

// Capturar la información 
Console.Write("Ingrese el identificador del motor: ");
motor1.Identificador = Console.ReadLine() ?? "Sin identificador";

Console.Write("Ingrese la temperatura del motor (en grados Celsius): ");
motor1.Temperatura = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la corriente del motor (en amperios): ");
motor1.Corriente = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la velocidad del motor (en RPM): ");
motor1.Velocidad = Convert.ToDouble(Console.ReadLine());

// Mostrar los datos del motor
Console.WriteLine();
Console.WriteLine("DATOS DEL MOTOR");
Console.WriteLine($"Identificador: {motor1.Identificador}");
Console.WriteLine($"Temperatura: {motor1.Temperatura} °C");
Console.WriteLine($"Corriente: {motor1.Corriente} A");
Console.WriteLine($"Velocidad: {motor1.Velocidad} RPM");
motor1.ObtenerEstado();
motor1.TemperaturaAlta();

// Definición de la clase
class Motor
{
    // Propiedades
    public string Identificador { get; set; } = "";
    public double Temperatura { get; set; }
    public double Corriente { get; set; }
    public double Velocidad { get; set; }


    // Método para determinar el Temperatura >=70
    public void TemperaturaAlta()
    {

        if (Temperatura >= 70)
        {
            Console.WriteLine("La temperatura >=70 grados Celsius. Cuidado");
        }
        else
        {
            Console.WriteLine("La temperatura <70 grados Celsius. Todo bien");
        }
    }

    // Determinar si el motor se encuentra detenido o en marcha
    public void ObtenerEstado()
    {
        if (Velocidad == 0)
        {
            Console.WriteLine("El motor se encuentra detenido.");
        }
        else
        {
            Console.WriteLine("El motor se encuentra en marcha.");
        }
    }
}