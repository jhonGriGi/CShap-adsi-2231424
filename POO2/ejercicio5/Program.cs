using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura factura = new Factura();

            factura.Documento = "231312312";
            factura.Month = "Enero";
            factura.Year = 2021;
            factura.Stratum = 2;
            factura.Kwh_consumed = 2300;

            Console.WriteLine("Ingrese el valor de las facturas de los ultimos 5 meses");
            factura.facturasAntiguas();
            
            factura.calcularValorFactura();
            factura.ultimosMeses();

            Console.WriteLine("Estos son los datos");
            Console.WriteLine($"    >>>>Documento: {factura.Documento}");
            Console.WriteLine($"    >>>>Year: {factura.Year}");
            Console.WriteLine($"    >>>>Month: {factura.Month}");
            Console.WriteLine($"    >>>>Stratum: {factura.Stratum}");
            Console.WriteLine("********************************");
            Console.WriteLine("El total a pagar es: ");
            Console.WriteLine($"    >>>>Factura: {factura.FacturaUsuario()}");
            Console.WriteLine("********************************");
        }
    }
}
