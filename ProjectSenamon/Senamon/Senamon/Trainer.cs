using System;

namespace Senamon
{
    public class Trainer
    {
        // Atributos
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public int Experience { get; set; }
        public int WonBattles { get; set; }
        public Senamon[] VectSenamon = new Senamon[5];
        
        // Importaciones de clases
        private AsignamentSenamon _asignamentSenamon = new AsignamentSenamon();

        // Constructor

        // Metodos 
        public Senamon[] GetVectSenamon()
        {
            return this.VectSenamon;
        }

        public void SetVectSenamon()
        {
            int option;

            for (int i = 0; i < 5; i++)
            {
                do
                {
                    Console.Write("Ingresa el numero del senamon para tu equipo: ");
                    _ = int.TryParse(Console.ReadLine(), out option);

                    if (option < 0 || option > _asignamentSenamon.GetListSenamon().Count -1)
                        Console.WriteLine("Error, vuelve a introducir el valor");
                    
                } while (option < 0 || option > _asignamentSenamon.GetListSenamon().Count -1);

                this.VectSenamon[i] = _asignamentSenamon.GetListSenamon()[option];
            }
        }

        public void ChangeSenamon()
        {
            int option, change, answerChangeSenamon, changeSenamon;
            
            do
            {
                Console.Write("Ingrese 1 si quiere cambiar un Senamon\nIngrese 2 si no quiere cambiar un Senamon: ");
                _ = int.TryParse(Console.ReadLine(), out answerChangeSenamon);

                if (answerChangeSenamon < 0 && answerChangeSenamon > 2)
                    Console.WriteLine("Error, vuelve a introducir el valor");
            } while (answerChangeSenamon < 0 && answerChangeSenamon > 2);

            if (answerChangeSenamon == 1)
            {
                do
                {
                    Console.WriteLine("Selecciona el Senamon de tu equipo que quieres intercambiar");

                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("\n------------------------------------------");
                        Console.WriteLine($"Senamon #{i}: {this.VectSenamon[i].Name}");
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine($"   >>>Name: {this.VectSenamon[i].Name}");
                        Console.WriteLine($"   >>>Level: {this.VectSenamon[i].Level}");
                        Console.WriteLine($"   >>>Health: {this.VectSenamon[i].Health}");
                        Console.WriteLine($"   >>>Attack: {this.VectSenamon[i].Attack}");
                        Console.WriteLine($"   >>>Description: {this.VectSenamon[i].Description}");
                        Console.WriteLine("------------------------------------------");
                    }

                    do
                    {
                        Console.Write("Ingresa el numero del senamon que quieres cambiar: ");
                        _ = int.TryParse(Console.ReadLine(), out change);

                        if (change < 0 || change > this.VectSenamon.Length)
                            Console.WriteLine("Error, vuelve a introducir el valor");
                        
                    } while (change < 0 || change > this.VectSenamon.Length);
                    
                    _asignamentSenamon.ShowAsignamentSenamon();

                    do
                    {
                        Console.Write("Ingresa el numero del nuevo senamon para tu equipo: ");
                        _ = int.TryParse(Console.ReadLine(), out option);

                        if (option < 0 || option > _asignamentSenamon.GetListSenamon().Count - 1)
                            Console.WriteLine("Error, vuelve a introducir el valor");
                        
                    } while (option < 0 || option > _asignamentSenamon.GetListSenamon().Count - 1);
                    
                    this.VectSenamon[change] = _asignamentSenamon.GetListSenamon()[option];
                    
                    Console.Write("Ingresa 1 si quieres cambiar otro senamon, de lo contrario ingresa 2: ");
                    _ = int.TryParse(Console.ReadLine(), out changeSenamon);

                    if (changeSenamon < 0 && changeSenamon > 2)
                        Console.WriteLine("Error, vuelve a ingresar el valor");
                } while (changeSenamon < 0 && changeSenamon > 2);
            }
        }

        public void ShowTeamSenamon()
        {
            for(int i = 0; i < this.VectSenamon.Length; i++)
            {
                if(this.GetVectSenamon()[i].Health > 0)
                    Console.WriteLine($"   >>>>Senamon {i}: Nombre: {this.VectSenamon[i].Name}");
            }
        }
    }
}