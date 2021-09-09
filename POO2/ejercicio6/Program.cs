using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura factura; //= new Factura();

            int cantUsuarios;
            string valorFactura, documento, mes;
            int estrato, year, consumo;
            string estratos;

            Console.WriteLine("Ingrese la cantidad de usuarios");
            _ = int.TryParse(Console.ReadLine(), out cantUsuarios);

            for(int i = 0; i < cantUsuarios; i++)
            {
                factura = new Factura();

                Console.WriteLine("Ingrese el nombre del cliente: " + (i + 1));
                documento = Console.ReadLine();

                factura.Documento = documento;

                Console.WriteLine("Ingrese el estrato del cliente: " + (i + 1));
                _ = int.TryParse(Console.ReadLine(), out estrato);

                factura.Stratum = estrato;
                estratos = estrato.ToString();

                Console.WriteLine("Ingrese el mes");
                mes = Console.ReadLine();

                factura.Month = mes;

                Console.WriteLine("Ingrese el anio");
                _ = int.TryParse(Console.ReadLine(), out year);

                factura.Year = year;

                Console.WriteLine("Ingrese el consumo de kwh");
                _ = int.TryParse(Console.ReadLine(), out consumo);

                factura.Kwh_consumed = consumo;

                Console.WriteLine("Ingrese el valor de las facturas de los ultimos 5 meses");
                factura.facturasAntiguas();

                valorFactura = factura.ultimosMeses().ToString();

                factura.asignarArray(documento, estratos, valorFactura);

                factura.getLista();

                /*factura.Documento = "231312312";
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
            Console.WriteLine("********************************"); */
            }
            
        }
    }
}
