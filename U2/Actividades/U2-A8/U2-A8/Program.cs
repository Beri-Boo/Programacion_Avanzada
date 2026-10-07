Console.WriteLine("SISTEMA DE CALIFICACIONES");
Console.WriteLine();

// Crear un objeto de la clase Estudiante
Estudiante alumno1 = new Estudiante(); //new es para declarar un objeto de la clase Estudiante

// Capturar la información del objeto 
Console.Write("Ingrese el nombre del estudiante: ");
alumno1.Nombre = Console.ReadLine() ?? "Sin nombre"; //los ?? "Sin nombre" es para que si el usuario no ingresa nada, se le asigne un valor por defecto

Console.Write("Ingrese la primera calificación: ");
alumno1.Calificacion1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la segunda calificación: ");
alumno1.Calificacion2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la tercera calificación: ");
alumno1.Calificacion3 = Convert.ToDouble(Console.ReadLine());

// Solicitar al objeto que calcule su promedio
double promedio = alumno1.CalcularPromedio();

// Mostrar resultados
Console.WriteLine();
Console.WriteLine($"Estudiante: {alumno1.Nombre}");
Console.WriteLine($"Promedio: {promedio:F2}");
Console.WriteLine($"Estado: {alumno1.ObtenerEstado()}");


// Definición de la clase
class Estudiante
{
    // Propiedades
    public string Nombre { get; set; } = "";

    public double Calificacion1 { get; set; }

    public double Calificacion2 { get; set; }

    public double Calificacion3 { get; set; }


    // Método para calcular el promedio
    public double CalcularPromedio()
    {
        double promedio;

        promedio = (Calificacion1 + Calificacion2 + Calificacion3) / 3.0;

        return promedio;
    }


    // Método para determinar el estado
    public string ObtenerEstado()
    {
        double promedio = CalcularPromedio();

        if (promedio >= 70)
        {
            return "APROBADO";
        }
        else
        {
            return "REPROBADO";
        }
    }
}
//Ejercicio 1:
//Un sistema registra el identificar, la temperatura, corriente y la velocidad de varios motores. El sistema debe mostrar los datos y determinar
//si la temperatura en mayor que 70 grados celsius, si el motor se encuentra detenido o en marcha. Determianar las clases, objetos, propiedades y métodos
//que se deben de utilizar para realizar el código por medio de la POO.
