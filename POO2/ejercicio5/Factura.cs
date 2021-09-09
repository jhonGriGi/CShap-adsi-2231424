using System;

namespace ejercicio5
{
    class Factura
    {
        public string Documento { get; set; }

        public int Year { get; set; }

        public string Month { get; set; }

        public int Stratum { get; set; }

        public int Kwh_consumed { get; set; }

        public double facturaUsuario;

        public double[] facturas;

        public Factura()
        {   
            Console.WriteLine("Estos son los datos de la Factura");
        }

        public double FacturaUsuario()
        {
            return this.facturaUsuario;
        }

        public void calcularValorFactura()
        {
            int valorKwh = 580;
            double valorFactura = valorKwh * Kwh_consumed;
            double descuento1 = (valorFactura * 60) / 100;
            double descuento2 = (valorFactura * 40) / 100;
            double contribucion = (valorFactura * 20) / 100;
            
            if(Stratum == 1 || Stratum == 2 )
            {
                facturaUsuario = valorFactura - descuento1;
            }
            else if(Stratum == 3 || Stratum == 4)
            {
                facturaUsuario = valorFactura - descuento2;
            }
            else
            {
                facturaUsuario = valorFactura + contribucion;
            }
        }

        public void facturasAntiguas()
        {
            facturas = new double[5];

            for(int i = 0; i < facturas.Length; i++)
            {
                Console.WriteLine("Ingrese el valor de la factura " + (i + 1));
                _ = double.TryParse(Console.ReadLine(), out facturas[i]);
            }
        }

        public double ultimosMeses()
        {
            double sumaPromedio = 0;
            double penalizacion = (facturaUsuario * 10) / 100;
            double descuento = (facturaUsuario * 10) / 100;

            for(int i = 0; i < 4; i++)
            {
                sumaPromedio += facturas[i];
            }

            double totalPromedio = sumaPromedio / 4;

            if(facturas[4] > totalPromedio)
            {
                return facturaUsuario + penalizacion;
            }
            else if(facturas[4] <= totalPromedio)
            {
                return facturaUsuario - descuento;
            }
            else
            {
                return facturaUsuario;
            }
        }
    }
}