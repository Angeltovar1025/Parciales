internal class Program
{
    public static void Main(string[] args)
    {

        //Punto 1: Un vendedor recibe un sueldo base de $X. Además, recibe una comisión del 10 % sobre el valor total de cada venta
        Double sueldo = 1300000, comision1, comision2, comision3, venta1, venta2, venta3;

        //Se declara el valor de las 3 ventas
        Console.Write("Digite el valor de la primera venta: ");
        venta1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite el valor de la segunda venta: ");
        venta2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite el valor de la tercera venta: ");
        venta3 = Convert.ToInt32(Console.ReadLine()); Console.WriteLine();

        //Comision del 10% por cada una de las ventas 
        comision1 = venta1 * 10 / 100; comision2 = venta2 * 10 / 100; comision3 = venta3 * 10 / 100;
        //Total de comisiones x las 3 ventas realizadas

        Console.WriteLine($"El salario básico del vendedor es de *********** " + sueldo.ToString("##,#0"));
        double TotalComisiones = comision1 + comision2 + comision3;
        Console.WriteLine($"El total por comisiones por las tres ventas es de " + TotalComisiones.ToString("##,#0"));

        // Total al final del mes
        Double TotalDevengado = sueldo + TotalComisiones;
        Console.WriteLine($"El total devengado al final de mes es ********** " + TotalDevengado.ToString("##,#0"));

        //Venta que generó mayor comisión
        //Validacion
        if ((venta1 > venta2) && (venta2 > venta3))
            Console.WriteLine("La venta mayor que generó mayor comisión es: " + venta1);
        else if ((venta2 > venta1) && (venta1 > venta3))
            Console.WriteLine("La venta mayor que generó mayor comisión es: " + venta2);
        else if
            ((venta3 > venta2) && (venta2 > venta1))
            Console.WriteLine("La venta mayor que generó mayor comisión es: " + venta3);
        Console.WriteLine();

        //Promedio de ventas
        Double TotalVentas = venta1 + venta2 + venta3;
        double promediodeventas = TotalVentas / 3;
         Console.Write("El promedio por las tres ventas fue de " + promediodeventas.ToString("##,#0"));Console.WriteLine();
        
        // Verifica si el vendedor supera el objetivo para recibir el beneficio extra
        Boolean superaObjetivo = (venta1 + venta2 + venta3) > 1000000;
        double beneficioExtra = superaObjetivo ? 100000 : 0;

        
    }

}