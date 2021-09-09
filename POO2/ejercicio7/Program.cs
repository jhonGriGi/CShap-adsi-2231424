using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente paciente;

            int cantUsuarios;
            string nombre;
            int edad, fracturaInfante, estetica, colsanitas, genero;
            int contFractura = 0, contEstetica = 0, contColsanitas = 0, contMujer = 0, contHombre = 0;

            Console.WriteLine("Ingrese la cantidad de usuarios");
            _ = int.TryParse(Console.ReadLine(), out cantUsuarios);

            for (int i = 0; i < cantUsuarios; i++)
            {
                paciente = new Paciente();

                Console.WriteLine("Ingrese el nombre del paciente " + (i+1));
                nombre = Console.ReadLine();

                paciente.setName(nombre);

                Console.WriteLine("Ingrese la edad del paciente " + (i+1));
                _ = int.TryParse(Console.ReadLine(), out edad);

                paciente.setAge(edad);

                paciente.personaMayor(nombre, edad);

                Console.WriteLine("Ingrese (1) si es hombre, o ingrese (2) si es Mujer");
                _ = int.TryParse(Console.ReadLine(), out genero);

                if(edad < 18)
                {
                    Console.WriteLine("Ingrese (1) si el infante ingreso por fractura, de lo contrario ingrese (2)");
                    _ = int.TryParse(Console.ReadLine(), out fracturaInfante);

                    paciente.fractura(fracturaInfante);

                    if(fracturaInfante == 1)
                    {
                        contFractura++;
                    }
                }
                
                if(edad >= 18)
                {
                    Console.WriteLine("Ingrese (1) si la mujer ingreso por cirugia estetica, Ingrese (2) si el hombre ingreso por cirugia estetica, ingrese (3) si no");
                    _ = int.TryParse(Console.ReadLine(), out estetica);

                    paciente.estetica(estetica, genero);

                    contEstetica++;

                    if(estetica == 1)
                    {
                        contMujer++;
                    }
                    else if(estetica == 2)
                    {
                        contHombre++;
                    }
                }

                Console.WriteLine("Ingrese (1) si el paciente fue atendido por Colsanitas de lo contrario ingrese (2)");
                _ = int.TryParse(Console.ReadLine(), out colsanitas);

                paciente.colsanitas(colsanitas);

                if(colsanitas == 1)
                {
                    contColsanitas++;
                }

                Console.WriteLine("Estos son los datos del paciente registrado.");
                Console.WriteLine($"    >>>>Nombre : {paciente.getName()}");
                Console.WriteLine($"    >>>>Edad : {paciente.getAge()}");

                while(i == (cantUsuarios - 1))
                {
                    // Console.WriteLine($"    >>>>La cantidad de infantes con fracturas son: {paciente.getFractura()}");
                    // Console.WriteLine($"    >>>>La cantidad de personas por cirugia estetica fue: {paciente.getEstetica()}");

                    // Console.WriteLine($"    >>>>La cantidad de personas atendidas por Colsanitas es: {paciente.getColsanitas()}");

                    // Console.WriteLine($"    >>>>{paciente.getPersonaMayor()}");

                    Console.WriteLine($"    >>>>La cantidad de infantes con fracturas son: {contFractura}");

                    Console.WriteLine($"    >>>>La cantidad de personas por cirugia estetica fue: {contEstetica}");

                    Console.WriteLine($"    >>>>La cantidad de mujeres por estetica fueron: {contMujer}");
                    Console.WriteLine($"    >>>>La cantidad de hombres por estetica fueron: {contHombre}");

                    Console.WriteLine($"    >>>>La cantidad de personas atentidas por Colsanitas es: {contColsanitas}");

                    Console.WriteLine($"    >>>>{paciente.getPersonaMayor()}");

                    break;
                }
            }
        }
    }
}