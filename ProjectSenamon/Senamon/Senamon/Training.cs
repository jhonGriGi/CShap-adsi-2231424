using System;
using System.Collections.Generic;

namespace Senamon
{
    class Training
    {
        public Start start = new Start();

        public Training() {}

        public void TrainingStart() 
        {
            int EXPentrenador1 = start.GetListTrainer()[0].Experience;
            int EXPentrenador2 = start.GetListTrainer()[1].Experience;
            int entrenamiento1, entrenamiento2, opcion, pokemon;

            if(EXPentrenador1 >= 200)
            {
                start.GetListTrainer()[0].ShowTeamSenamon();
                Console.WriteLine("Tienes experiencia suficiente para entrenar!!!");

                Console.WriteLine("\nIngresa el pokemon a entrenar");

                do
                {
                    Console.Write("   >>>Eleccion: ");
                    _ = int.TryParse(Console.ReadLine(), out pokemon);

                    if(pokemon < 0 || pokemon > start.GetListTrainer()[0].GetVectSenamon().Length)
                        Console.WriteLine("Error, vuelva a ingresar el valor");
                } while (pokemon < 0 || pokemon > start.GetListTrainer()[0].GetVectSenamon().Length);

                
                do
                {
                    Console.Write("Ingresa (1) si deseas entrenar o (2) para no: ");
                    _ = int.TryParse(Console.ReadLine(), out entrenamiento1);

                    if (entrenamiento1 <= 0 || entrenamiento1 > 2)
                        Console.WriteLine("Error, vuelve a introducir el valor");
                } while (entrenamiento1 <= 0 || entrenamiento1 > 2);

                if (entrenamiento1 == 1)
                {
                    Console.WriteLine("Que quieres entrenar?");

                    do
                    {
                        Console.Write("Ingresa (1) si quieres entrenar la salud o (2) para el ataque: ");
                        _ = int.TryParse(Console.ReadLine(), out opcion);

                        if (opcion <= 0 || opcion > 2)
                            Console.WriteLine("Error, ingrese nuevamente el valor");
                    } while (opcion <= 0 || opcion > 2);

                    if (opcion == 1)
                    {
                        EXPentrenador1 -= 200;
                        start.GetListTrainer()[0].GetVectSenamon()[pokemon].Health += 20;
                        Console.WriteLine("Senamon entrenado!!!");
                    }
                    else
                    {
                        EXPentrenador1 -= 200;
                        start.GetListTrainer()[0].GetVectSenamon()[pokemon].Attack += 20;
                        Console.WriteLine("Senamon entrenado!!!");
                    }
                }
            }
            else 
            {
                Console.WriteLine($"Entrenador {start.GetListTrainer()[0].Name}, No tienes suficiente experiencia para entrenar");
            }

            if(EXPentrenador2 >= 200)
            {
                start.GetListTrainer()[1].ShowTeamSenamon();
                Console.WriteLine("Tienes experiencia suficiente para entrenar!!!");


                Console.WriteLine("\nIngresa el pokemon a entrenar");

                do
                {
                    Console.Write("   >>>Eleccion: ");
                    _ = int.TryParse(Console.ReadLine(), out pokemon);

                    if(pokemon < 0 || pokemon > start.GetListTrainer()[1].GetVectSenamon().Length)
                        Console.WriteLine("Error, vuelva a ingresar el valor");
                } while (pokemon < 0 || pokemon > start.GetListTrainer()[1].GetVectSenamon().Length);

                
                do
                {
                    Console.Write("Ingresa (1) si deseas entrenar o (2) para no: ");
                    _ = int.TryParse(Console.ReadLine(), out entrenamiento2);

                    if (entrenamiento2 <= 0 || entrenamiento2 > 2)
                        Console.WriteLine("Error, vuelve a introducir el valor");
                } while (entrenamiento2 <= 0 || entrenamiento2 > 2);

                if (entrenamiento2 == 1)
                {
                    Console.WriteLine("Que quieres entrenar?");

                    do
                    {
                        Console.Write("Ingresa (1) si quieres entrenar la salud o (2) para el ataque: ");
                        _ = int.TryParse(Console.ReadLine(), out opcion);

                        if (opcion <= 0 || opcion > 2)
                            Console.WriteLine("Error, ingrese nuevamente el valor");
                    } while (opcion <= 0 || opcion > 2);

                    if (opcion == 1)
                    {
                        EXPentrenador2 -= 200;
                        start.GetListTrainer()[1].GetVectSenamon()[pokemon].Health += 20;
                        Console.WriteLine("Senamon entrenado!!!");
                    }
                    else
                    {

                        EXPentrenador2 -= 200;
                        start.GetListTrainer()[1].GetVectSenamon()[pokemon].Attack += 20;
                        Console.WriteLine("Senamon entrenado!!!");
                    }
                }
            }
            else 
            {
                Console.WriteLine($"Entrenador {start.GetListTrainer()[1].Name}, No tienes suficiente experiencia para entrenar");
            }
        }
    }
}