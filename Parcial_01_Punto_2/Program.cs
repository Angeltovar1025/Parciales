

using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //Datos primer tren
        // Hora de salida del primer tren en formato de 24 horas
        double horaSalidaTren1 = 10;
        // Velocidad del tren #1 km/h
        double velocidadTren1 = 80;

        //Datos primer tren
        // Velocidad del tren #2 km/h
        int velocidadTren2 = 100;
         // Hora de salida del segundo tren en formato de 24 horas
        int horaSalidaTren2 = 11;

        // Calcula la hora en que el segundo tren alcanzará al primer tren
        double  tiempoAlcance = (horaSalidaTren2 - horaSalidaTren1) * 60; // en minutos
        double distanciaAlcance = velocidadTren1 * tiempoAlcance / (velocidadTren2 - velocidadTren1);
        double horaAlcance = horaSalidaTren1 + distanciaAlcance / 60;
        double minutosAlcance = distanciaAlcance % 60;

        // Comprueba si el segundo tren alcanza al primer tren en el mismo día
        if (horaAlcance >= 24)
        {
            Console.WriteLine("El segundo tren no alcanzará al primer tren el mismo día.");
        }
        else
        {
            // Muestra la hora en pantalla
            Console.WriteLine("El segundo tren alcanzará al primer tren a las " + horaAlcance.ToString("00") + ":" + minutosAlcance.ToString("00") + " horas.");
        }
    }
}