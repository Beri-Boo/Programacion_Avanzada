//Ejercicio 5: 
//Diseñe un programa que permita analizar la vibración de varios motores. Para cada motor, el programa deberá:
//a)  Solicitar el nombre o identificador del motor.
//b)  Pedir cuatro mediciones de vibración mediante un ciclo for.
//c)  Calcular la vibración promedio.
//d)  Clasificar el estado del motor.
//e)  Preguntar si se desea analizar otro motor.
//La  repetición  de  motores  se  controlará  mediante  un  ciclo  while.  Utilizar  la  siguiente clasificación:
//  Promedio menor o igual que 4.5 mm/s: FUNCIONAMIENTO NORMAL DEL MOTOR.
//  Promedio mayor que 4.5 mm/s: EL MOTOR REQUIERE MANTENIMIENTO.
//Al finalizar completamente el programa, deberá mostrar:
//a)  Total de motores evaluados.
//b)  Cantidad de motores con funcionamiento normal.
//c)  Cantidad de motores que requieren mantenimiento
using System.Timers;
Console.WriteLine("Ejercicio 5"); // Título.
Console.WriteLine("Simulación de medición de vibración de varios motores."); // Descripción.
Console.WriteLine(); // Espacio.
int Tmotores = 0; // Contador global de motores evaluados.
int Mnormal = 0; // Contador de motores en buen estado.
int Mmantenimiento = 0; // Contador de motores que requieren revisión.
string continuar = "s"; // Variable de control del ciclo principal.

while (continuar == "s" || continuar == "S")
{ // Repite mientras el usuario decida continuar.
    Tmotores++; // Incrementa el número del motor actual.
    Console.WriteLine($"Motor {Tmotores}.");
    Console.Write("Ingrese el nombre o identificador del motor: "); // Pide ID.
    string Nmotor = Console.ReadLine(); // Lee el ID ingresado.
    double Svibracion = 0; // Acumulador local (se reinicia a 0 para cada motor).

    for (int TM = 1; TM <= 4; TM++) // Ciclo interno para 4 mediciones exactas.
    {
        Console.Write($"Ingrese la medición de vibración {TM} (mm/s): "); // Pide medición.
        double medicion = Convert.ToDouble(Console.ReadLine()); // Lee y convierte a decimal.
        Svibracion += medicion; // Suma la lectura al acumulador local.
    }

    double ProVibracion = Svibracion / 4; // Calcula el promedio del motor actual.
    Console.WriteLine($"Promedio de vibración del motor {Nmotor}: {ProVibracion:F2} mm/s"); // Imprime resultado con 2 decimales.

    if (ProVibracion <= 4.5) // Evalúa si la vibración está dentro del límite.
    {
        Console.WriteLine("FUNCIONAMIENTO NORMAL DEL MOTOR."); // Dictamen positivo.
        Mnormal++; // Incrementa el contador global de motores normales.
    }
    else // Si supera el límite de 4.5.
    {
        Console.WriteLine("EL MOTOR REQUIERE MANTENIMIENTO."); // Dictamen negativo.
        Mmantenimiento++; // Incrementa el contador global de fallas.
    }

    Console.Write("¿Desea analizar otro motor? (s/n): "); // Pregunta clave para continuar.
    continuar = Console.ReadLine(); // Actualiza la variable del while.
}

Console.WriteLine();
Console.WriteLine($"Total de motores evaluados: {Tmotores}"); // Muestra el consolidado final.
Console.WriteLine($"Motores con funcionamiento normal: {Mnormal}"); // Muestra totales normales.
Console.WriteLine($"Motores que requieren mantenimiento: {Mmantenimiento}"); // Muestra totales de falla.