using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Una veterinaria desea tener un control de las  
mascotas que ingresan al establecimiento (solo  perros y gatos). De cada mascota, se desea saber su  nombre, edad (a partir de su fecha de nacimiento),  tipo de mascota, raza, peso, color y un atributo para  saber si está esterilizado. Se deberá preguntar al  usuario del sistema, cuantas mascotas se desean  agregar a la aplicación y se podrá ir generando la  información de cada mascota (que se almacenará en  un vector o lista). Se deberán tener los métodos SET  y GET de cada atributo y se deberán respetar los  características de la P.O.O. En el momento que se  genere una mascota se generará automáticamente un código que será la unión de la inicial del tipo de  mascota seguido de un guion y por último un código  de 5 cifras (Por ejemplo G-32145)
*/

            int tipoMascota, edad, esterilizado, cantMascota, numCitas;
            double peso;
            bool esterilizadoB;
            string nombre, raza, color;
            Veterinaria[] vectorVeter;
            Veterinaria veter;

            do 
            {
                Console.Write("Ingrese la cantidad de citas: ");
                _ = int.TryParse(Console.ReadLine(), out numCitas);
            } while ( numCitas <= 0 );

            vectorVeter = new Veterinaria[numCitas];

            for ( int i = 0; i < vectorVeter.Length; i++) 
            {
                Console.WriteLine("---------------------------------------------");
                veter = new Veterinaria();
                do 
                {
                    Console.Write("Ingrese la cantidad de mascotas: ");
                    _ = int.TryParse(Console.ReadLine(), out cantMascota);
                } while ( cantMascota <= 0 );

                for ( int j = 0; j < cantMascota; j++ ) 
                {
                    Console.Write("\nIngrese el nombre de la mascota: ");
                    nombre = Console.ReadLine();

                    Console.Write("Ingrese la raza de la mascota: ");
                    raza = Console.ReadLine();

                    Console.Write("Ingrese el color de la mascota: ");
                    color = Console.ReadLine();
                    
                    do 
                    {
                        Console.Write("Ingrese (1) si es Perro o Ingrese (2) si es Gato: ");
                        _ = int.TryParse(Console.ReadLine(), out tipoMascota);
                    } while ( tipoMascota <= 0 );

                    do
                    {
                        Console.Write("Ingrese la edad de la mascota: ");
                        _ = int.TryParse(Console.ReadLine(), out edad);
                    } while ( edad <= 0 );

                    do
                    {
                        Console.Write("Ingrese (1) si esta esterilizada o Ingrese (2) si no lo esta: ");
                        _ = int.TryParse(Console.ReadLine(), out esterilizado);
                    } while ( esterilizado <= 0 );

                    do 
                    {
                        Console.Write("Ingrese el peso de la mascota: ");
                        _ = double.TryParse(Console.ReadLine(), out peso);
                    } while ( peso <= 0 );

                    Mascota mascota = new Mascota();
                    mascota.Nombre = nombre;
                    mascota.Edad = edad;
                    mascota.Raza = raza;
                    mascota.Color = color;
                    mascota.Peso = peso;
                    mascota.CodigoMascota(tipoMascota);

                    if ( esterilizado == 1 ) 
                    {
                        esterilizadoB = true;
                        mascota.Esterilizado = esterilizadoB;
                    }
                    else if ( esterilizado == 2 )
                    {
                        esterilizadoB = false;
                        mascota.Esterilizado = esterilizadoB;
                    }


                    veter.setListaMacota(mascota);
                }

                vectorVeter[i] = veter;
            }

            for ( int i = 0; i < vectorVeter.Length; i++ )
            {
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("Las citas totales tienen las siguientes mascotas: ");

                for ( int j = 0; j < vectorVeter[i].getListaMascota().Count; j++ )
                {
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine($"\n Nombre: {vectorVeter[i].getListaMascota()[j].Nombre}");
                    Console.WriteLine($"\n Edad: {vectorVeter[i].getListaMascota()[j].Edad}");
                    Console.WriteLine($"\n Tipo Mascota: {vectorVeter[i].getListaMascota()[j].TipoMascota}");
                    Console.WriteLine($"\n Raza: {vectorVeter[i].getListaMascota()[j].Raza}");
                    Console.WriteLine($"\n Color: {vectorVeter[i].getListaMascota()[j].Color}");
                    Console.WriteLine($"\n Peso: {vectorVeter[i].getListaMascota()[j].Peso}");
                    Console.WriteLine($"\n Esterilizada: {vectorVeter[i].getListaMascota()[j].Esterilizado}");
                    Console.WriteLine($"\n Codigo: {vectorVeter[i].getListaMascota()[j].getCodigoMastoca}");
                    Console.WriteLine("--------------------------------------------------------------");
                }
            }
        }
    }
}
