//Ejercicio 2: 
//Un cilindro  neumático  produce  una  fuerza  aproximada  mediante  F  =  P*A.  El  usuario proporcionará la presión en kPa y el área efectiva del pistón en cm2.
//El programa convertirá la presión a Pa y el área a metros cuadrados. Después calculará la fuerza. La aplicación deberá indicar si la fuerza cumple un requerimiento
//mínimo introducido por el usuario
Console.WriteLine("EJERCICIO 2 - FUERZA DE UN CILINDRO NEUMÁTICO (CREADOR POR: FUENTES DE LA CRUZ BERNARDO)");
Console.WriteLine();

// Crear un objeto de la clase 
Cilindro CiNue = new Cilindro();

// Capturar la información 
Console.Write("¿Cual es la fuerza minima que requiere su cilindro (en Newtons)? ");
CiNue.FuerzaMin = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la Presión (en kPa): ");
CiNue.Presionkpa = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese el Area efectiva del pistón (en cm2): ");
CiNue.Areacm = Convert.ToDouble(Console.ReadLine());

// Calcular la Area en m2 y la Presión en Pa
double AreaM2 = CiNue.calcularM2(); // Convertir cm2 a m2
double PresionPa = CiNue.calcularPa(); // Convertir kPa a Pa

// Calcular la fuerza
double Fuerza = CiNue.calcularFu();

// Mostrar los datos del cilindro neumático
Console.WriteLine();
Console.WriteLine("DATOS DEL CILINDRO NEUMÁTICO");
Console.WriteLine($"Presión: {PresionPa} Pa");
Console.WriteLine($"Área: {AreaM2} m2");
Console.WriteLine($"Fuerza: {Fuerza} N");
Console.WriteLine($"Fuerza mínima requerida: {CiNue.FuerzaMin} N");
CiNue.Fuerzarequerida();

// Definición de la clase
class Cilindro
{
    // Propiedades
    public double FuerzaMin { get; set; }
    public double Presionkpa { get; set; }
    public double Areacm { get; set; }

    public double calcularM2()
    {
        double AreaM2;
        AreaM2 = Areacm / 10000;
        return AreaM2;
    }

    public double calcularPa()
    {
        double PresionPa;
        PresionPa = Presionkpa * 1000;
        return PresionPa;
    }

    public double calcularFu()
    {
        double Fuerza;
        Fuerza = calcularPa() * calcularM2();
        return Fuerza;
    }

    // Determinar la fuerza requerida
    public void Fuerzarequerida()
    {
        if (calcularFu() >= FuerzaMin)
        {
            Console.WriteLine("La fuerza del cilindro cumple con el requerimiento mínimo.");
        }
        else
        {
            Console.WriteLine("La fuerza del cilindro no cumple con el requerimiento mínimo.");
        }
    }
}