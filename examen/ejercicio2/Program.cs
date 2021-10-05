using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Realizar las siguientes funcionalidades que deberá  permitir la aplicación: 
a. Permitir buscar una mascota por el nombre y  mostrar toda la información de dicha mascota 
b. Mostrar cuantos perros están esterilizados c. Mostrar cuantas mascotas tienen más de 5 años
*/

            int tipoMascota, edad, esterilizado, cantMascota, numCitas, numCoincidencias = 0;
            int numPerrosEsterilizados = 0, numMascotasMayores5 = 0, formaInfo;
            double peso;
            bool esterilizadoB;
            string nombre, raza, color, buscarNombre;
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

                    if ( edad > 5 )
                    {
                        numMascotasMayores5++;
                    }

                    do
                    {
                        Console.Write("Ingrese (1) si esta esterilizada o Ingrese (2) si no lo esta: ");
                        _ = int.TryParse(Console.ReadLine(), out esterilizado);
                    } while ( esterilizado <= 0 );

                    if ( esterilizado == 1 && tipoMascota == 1) 
                    {
                        numPerrosEsterilizados++;
                    }

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

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("La cantidad de mascotas mayores a 5 anios es: " + numMascotasMayores5);
            Console.WriteLine("La cantidad de perros esterilizados es: " + numPerrosEsterilizados);
            Console.WriteLine("--------------------------------------------------------------");

            Console.Write("Ingrese (1) si quiere buscar por nombre o Ingrese (2) si quiere ver toda la info: ");
            _ = int.TryParse(Console.ReadLine(), out formaInfo);

            if ( formaInfo == 1 )
            {
                do 
                {
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.Write("Ingrese el nombre a buscar: ");
                    buscarNombre = Console.ReadLine();
                    Console.WriteLine("--------------------------------------------------------------");

                    for ( int i = 0; i < vectorVeter.Length; i++ )
                    {
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine("Se buscara las coincidencias");

                        for ( int j = 0; j < vectorVeter[i].getListaMascota().Count; j++ )
                        {
                            if ( buscarNombre.Equals(vectorVeter[i].getListaMascota()[j].Nombre) )
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

                                numCoincidencias++;
                            }

                            if ( numCoincidencias == 0 )
                            {
                                buscarNombre = "";
                                Console.Write("No se han encontrado Coincidencias \nPor favor ingrese otro nombre: ");
                            }
                            
                        }
                    }
                } while ( numCoincidencias <= 0 );
            }
            else if ( formaInfo == 2 )
            {
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
            else 
            {
                Console.WriteLine("Opcion incorrecta!!! ");
            }
        }
    }
}
