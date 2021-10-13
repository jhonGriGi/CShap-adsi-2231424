// using System;
// using System.Collections.Generic;
//
// namespace recuperacion
// {
//     public class Training
//     {
//         ControlBattle controlBattle = new ControlBattle();
//         private Entrenador entrenador1 = new Entrenador();            
//         Start start = new Start();
//         
//         public Training()
//         {
//             DoYouWantTrain();
//         }
//
//         public void Entrenamiento() {}
//
//         public Array TrainingHealth(int entrenador, int opcion)
//         {
//             Entrenador _entrenador = start.vectEntrenador[entrenador];
//             int eleccion = opcion - 1;
//             int mejorado = _entrenador.GetVectSenamon()[eleccion].Health + 20;
//             int menosEXP = _entrenador.Experience - 200;
//             int[] acciones = {mejorado, menosEXP};
//
//             return acciones;
//         }
//
//         public Array TrainingAttack(int entrenador, int opcion)
//         {
//             Entrenador _entrenador = start.vectEntrenador[entrenador];
//             int eleccion = opcion - 1;
//             int mejorado = _entrenador.GetVectSenamon()[eleccion].Attack + 20;
//             int menosEXP = _entrenador.Experience - 200;
//             int[] acciones = {mejorado, menosEXP};
//
//             return acciones;
//         }
//
//         public  void DoYouWantTrain()
//         {
//             int opcion, mejora, entrenador;
//
//             do
//             {
//                 Console.Write("Ingrese el numero del entrenador que va a entrenar: ");
//                 _ = int.TryParse(Console.ReadLine(), out opcion);
//                 
//                 if (opcion < 0 || opcion > start.vectEntrenador.Length)
//                     Console.WriteLine("Error, vuelva a ingresar el valor");
//                 
//             } while (opcion < 0 || opcion > start.vectEntrenador.Length);
//             
//             int experience = start.vectEntrenador[opcion].Experience;
//
//             if (experience >= 200)
//             {
//                 Console.WriteLine("Puedes Entrenar a un pokemon!!!");
//                 
//                 do
//                 {
//                     Console.Write("Digite 1 si quiere mejorar la salud o Digite 2 si quiere mejorar el ataque");
//                     _ = int.TryParse(Console.ReadLine(), out mejora);
//                     
//                     if (mejora < 0 || mejora > 2)
//                         Console.WriteLine("Error, vuelva a digitar la opcion");
//                     
//                 } while (mejora < 0 || mejora > 2);
//             }
//
//
//             TrainingAttack(entrenador, mejora);
//         }
//
//     }
// }