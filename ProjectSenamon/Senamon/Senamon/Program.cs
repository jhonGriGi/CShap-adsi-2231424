using System;

namespace Senamon
{
    class Program
    {

        static void Main(string[] args)
        {
            int isTourment;

            do
            {
                Console.Write("Ingrese 1 si quiere luchar con otro entrenador,\nIngrese 2 si quiere tener un torneo de 4 entrenadores: ");
                _ = int.TryParse(Console.ReadLine(), out isTourment);

                if(isTourment < 0)
                    Console.WriteLine("Error, vuelve a ingresar el valor");
            } while (isTourment < 0);

            Logic logic = new Logic();

            if(isTourment == 1)
            {
                logic.SetListTrainer(2);

                for(int i = 0; i < 2; i++)
                    logic.TrainingSenamon(i);
                
            }
            else
            {
                logic.SetListTrainer(4);

                for(int i = 0; i < 4; i++)
                    logic.TrainingSenamon(i);
            }

        }
    }
}