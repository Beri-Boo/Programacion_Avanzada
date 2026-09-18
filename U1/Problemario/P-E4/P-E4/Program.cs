//Ejercicio 4
//Durante una prueba se realizan ocho mediciones de corriente de un actuador eléctrico.
//Diseñe un programa que utilice un ciclo para introducir las ocho mediciones. Cada medición deberá clasificarse de la siguiente manera
//a)  Si la corriente es menor o igual que 5 A, mostrar: MEDICIÓN NORMAL. 
//b)  Si es mayor que 5 A, mostrar: SOBRECORRIENTE DETECTADA. 

//Al finalizar el programa deberá mostrar: 
//Corriente promedio.
//Cantidad de mediciones normales.
//Cantidad de sobrecorrientes.
//Resultado general del actuador.
//El resultado general será:
//a)  ACTUADOR APROBADO, si no se detectó ninguna sobrecorriente
//b)  EL ACTUADOR REQUIERE REVISIÓN, si se detectó una o más sobrecorrientes
using System.Timers;

Console.WriteLine("Ejercicio 4"); // Título.
Console.WriteLine("Simulación de medición de corriente de un actuador eléctrico."); // Descripción.
Console.WriteLine(); // Espacio.
Console.WriteLine("Ingrese las ocho mediciones de corriente (A):"); // Instrucción.
double suma = 0; // Acumulador total.
int conteoNormales = 0; // Contador de mediciones normales.
int conteoSobrecorrientes = 0; // Contador de fallas.

for(int MC = 1; MC <= 8; MC++){ // Ciclo de 8 repeticiones.
    Console.Write($"Medición {MC}: "); // Pide el dato.
    double corriente = Convert.ToDouble(Console.ReadLine()); // Lee y convierte a decimal.
    suma += corriente; // Suma la medición al acumulador.

    if(corriente <= 5) // Evalúa si está dentro del límite.
    {
        Console.WriteLine("MEDICIÓN NORMAL."); // Mensaje de estado.
        conteoNormales++; // Incrementa contador normal.
    }
    else // Si supera los 5 A.
    {
        Console.WriteLine("SOBRECORRIENTE DETECTADA."); // Alerta.
        conteoSobrecorrientes++; // Incrementa contador de fallas.
    }
}

double promedio = suma/8; // Calcula el promedio final.
Console.WriteLine();
Console.WriteLine($"Corriente promedio: {promedio:F2} A"); // Muestra promedio con 2 decimales.
Console.WriteLine($"Cantidad de mediciones normales: {conteoNormales}"); // Muestra conteo.
Console.WriteLine($"Cantidad de sobrecorrientes: {conteoSobrecorrientes}"); // Muestra conteo.
Console.WriteLine();

if (conteoSobrecorrientes == 0){ // Si no hubo ninguna falla.
    Console.WriteLine("RESULTADO GENERAL: ACTUADOR APROBADO."); // Dictamen positivo.
}else{ // Si hubo al menos una falla.
    Console.WriteLine("RESULTADO GENERAL: EL ACTUADOR REQUIERE REVISIÓN."); // Dictamen negativo.
}