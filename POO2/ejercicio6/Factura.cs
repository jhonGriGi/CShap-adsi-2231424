using System;
using System.Collections;

namespace ejercicio6
{
    class Factura
    {
        public string Nombre { get; set; }
        public string Documento { get; set; }

        public int Year { get; set; }

        public string Month { get; set; }

        public int Stratum { get; set; }

        public int Kwh_consumed { get; set; }

        public double facturaUsuario;

        public double[] facturas;

        public string[] infoUsuario;

        public ArrayList Facturas = new ArrayList();

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

        public void listasUsuario()
        {
            foreach(string info in infoUsuario)
            {
                this.Facturas.Add(info);
            }
        }

        public void getLista()
        {
            foreach(string usuario in Facturas)
                for(int i = 0; i < 3; i++)
                {
                    Console.WriteLine(usuario[i]);
                }
        }

        public void asignarArray(string _documento, string _estrato, string _valorFacturaUsuario)
        {
            string documento = _documento;
            string estrato = _estrato;
            string valorFacturaUsuario = _valorFacturaUsuario;
            
            infoUsuario = new string[3];

            infoUsuario[0] = documento;
            infoUsuario[1] = estrato;
            infoUsuario[2] = _valorFacturaUsuario;
        }
    }
}