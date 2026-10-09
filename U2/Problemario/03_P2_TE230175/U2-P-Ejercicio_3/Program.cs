//Ejercicio 3: 
//Durante una prueba se toman cinco mediciones de temperatura de un motor. El programa solicitará las cinco lecturas mediante un ciclo for y calculará el promedio.
//Si el promedio es menor o igual que 70 grados Celsius, el estado será NORMAL; si es mayor, mostrará ALERTA DE TEMPERATURA.

Console.WriteLine("EJERCICIO 3 - MEDICIONES DE TEMPERATURA (CREADOR POR: FUENTES DE LA CRUZ BERNARDO)");
Console.WriteLine();

// Crear un objeto de la clase 
Temperatura Temp = new Temperatura();

// Capturar la información 
Console.Write("Ingrese las 5 mediciones de temperatura (en grados Celsius): ");
Console.WriteLine();

for (int t = 0; t < 5; t++)
{ // Se repite  5 veces.
    Console.Write($"Ingrese la mediciones {t + 1}: "); // Pide el dato.
    //i guardante de las mediciones
    Temp.mediciones[t] = Convert.ToDouble(Console.ReadLine()); // Convierte la entrada a double y la almacena en el arreglo.
}

// Calcular el promedio
double Promedio = Temp.calcularPromedio();

// Mostrar los datos 
Console.WriteLine();
Console.WriteLine("DATOS DE LAS TOMAS DE TEMPERATIRAS");
Console.WriteLine($"Promedio: {Promedio} °C");
Temp.ObtenerTemperatura();

//Definición de la clase Temperatura
class Temperatura
{
    //Propiedades
    public double[] mediciones { get; set; } = new double[5]; // Arreglo para almacenar las 5 mediciones de temperatura.

    //calcular promedio
    public double calcularPromedio()
    {
        double suma = 0; // Variable para almacenar la suma de las mediciones. 
        for (int t = 0; t < 5; t++)
        {
            suma = suma + mediciones[t]; // Suma las mediciones.
        }
        return suma / 5; // Retorna el promedio.
    }
    // Determinar temperatura
    public void ObtenerTemperatura()
    {
        double Promedio = calcularPromedio(); // Llama al método calcularPromedio para obtener el promedio de las mediciones.

        if (Promedio <= 70)
        {
            Console.WriteLine("Estado: NORMAL");
        }
        else
        {
            Console.WriteLine("ALERTA DE TEMPERATURA");
        }
    }
}