using System;

namespace ejercicio4
{
    class Paciente
    {
        private string name;

        private string surname;

        private string gender;

        private string document;

        private string blood;

        private int age;

        private string eps;

        private string codigoPaciente;

        // Constructores
        public Paciente()
        {
            Console.WriteLine("Ingrese los datos del Paciente");
            KeyUser();
        }

        public Paciente(string name, string surname, string gender, string document, int age)
        {
            this.name = name;
            this.gender = gender;
            this.document = document;
            this.age = age;
            this.surname = surname;
            KeyUser();
        }
        
        public Paciente(
            string name,
            string surname, 
            string gender,
            string document,
            string blood,
            int age,
            string eps
        ){
            this.name = name;
            this.surname = surname;
            this.gender = gender;
            this.document = document;
            this.blood = blood;
            this.age = age;
            this.eps = eps;
            KeyUser();
        }

        // Get & Set 

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Surname
        {
            get { return this.surname; }
            set { this.surname = value; }
        }

        public string Gender
        {
            get { return this.gender; }
            set { this.gender = value;}
        }

        public string Document
        {
            get { return this.document; }
            set { this.document = value; }
        }

        public string Blood
        {
            get { return this.blood; }
            set { this.blood = value; }
        } 

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Eps
        {
            get { return this.eps; }
            set { this.eps = value; }
        }

        public string getCodigo()
        {
            return this.codigoPaciente;
        }

        // Metodos
        public bool IsMen()
        {
            if(this.gender == "hombre" && this.age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void KeyUser()
        {
            Random random = new Random();
            int valorAzar = random.Next(1000, 10000);
            valorAzar.ToString();
            this.codigoPaciente = this.Document + " - " + valorAzar;

        }
    }
}