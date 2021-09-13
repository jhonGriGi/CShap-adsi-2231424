using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_6
{
    class Factura
    {
        
        private int año;
        private string mes;
        private int estrato;
        private double kwh_consumidos;
        private int kwh_val = 580;

        public Factura(int _año, string _mes, int _est, double _kwhC)
        {
            
            this.año = _año;
            this.mes = _mes;
            this.estrato = _est;
            this.kwh_consumidos = _kwhC;
        }


        
        public int Año
        {
            get { return this.año; }
            set { this.año = value; }
        }
        public string Mes
        {
            get { return this.mes; }
            set { this.mes = value; }
        }
        public int Estrato
        {
            get { return this.estrato; }
            set { this.estrato = value; }
        }
        public double Kwh_Consumidos
        {
            get { return this.kwh_consumidos; }
            set { this.kwh_consumidos = value; }
        }
        public double calcularValorFactura()
        {
            double val = this.kwh_val * kwh_consumidos;
            double dcto;

            if (this.estrato == 1 || this.estrato == 2)
            {
                dcto = val * 0.6;
                val -= dcto;
            }
            else if (this.estrato == 3 || this.estrato == 4)
            {
                dcto = val * 0.4;
                val -= dcto;
            }
            else if (this.estrato == 5 || this.estrato == 6)
            {
                dcto = val * 0.2;
                val += dcto;
            }
            return val;
        }
    }
}