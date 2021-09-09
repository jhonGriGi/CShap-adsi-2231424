using System;

namespace ejercicio7
{
    class Paciente
    {
        private string nombre;

        private int edad;

        public int fracturaInfante = 0;

        public int esteticaPaciente = 0;

        public int cantHombres = 0;

        public int cantMujeres = 0;

        public int cantColsanitas = 0;

        public int mayorEdad = 0;

        public string nombreMayor;

        public Paciente()
        {
            Console.WriteLine("Por favor ingresar los datos del paciente");
        }

        public void setName(string value)
        {
            this.nombre = value;
        }

        public string getName()
        {
            return this.nombre;
        }

        public void setAge(int value)
        {
            this.edad = value;
        }

        public int getAge()
        {
            return this.edad;
        }

        public void fractura(int value)
        {
            if(value == 1)
            {
                fracturaInfante++;
            }
        }

        // public int getFractura()
        // {
        //     return this.fracturaInfante;
        // }

        public void estetica(int value, int genero)
        {
            if(value == 1)
            {
                esteticaPaciente++;
            }

            if(genero == 1)
            {
                cantHombres++;
            }
            else
            {
                cantMujeres++;
            }
        }

        // public int getEstetica()
        // {
        //     return this.esteticaPaciente;
        // }

        public void personaMayor(string _nombre, int _edad)
        {
            if(_edad > mayorEdad)
            {
                mayorEdad = _edad;
                nombreMayor = _nombre;
            }
        }

        public string getPersonaMayor()
        {
            return $"La persona con la mayor edad es: {this.nombreMayor} y su edad es: {this.edad}";
        }

        public void colsanitas(int value)
        {
            if(value == 1)
            {
                cantColsanitas++;
            }
        }

        // public int getColsanitas()
        // {
        //     return this.cantColsanitas;
        // }
    }
}