using System;
using System.Collections.Generic;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* EJERCICIO 6: Modificar el punto anterior para que se pueda ingresar la información de 4 usuarios
            diferentes. (Utilizar un vector de vectores). */

            Console.WriteLine("Digite la cantidad de usuarios que ingresará:");
            _ = int.TryParse(Console.ReadLine(), out int cantUsuarios);            

            Usuario[] listaUsuarios = new Usuario[cantUsuarios];
            List<Factura> listaFacturas;
            Usuario usuario;
            Factura factura;
            string nombre = "", mes = "";
            int documento = 0, año = 0, estrato;
            double cont = 0, prom, kwh;


            // Ciclo que recorre según la cantidad de usuarios:
            for (int i = 0; i < cantUsuarios; i++)
            {
                listaFacturas = new List<Factura>();
                usuario = new Usuario();

                Console.WriteLine("\nDigite la cantidad de facturas que ingresará:");
                _ = int.TryParse(Console.ReadLine(), out int cantFacturas);

                Console.WriteLine($"\nDigite el nombre del usuario {i + 1}:");
                nombre = Console.ReadLine();
                do
                {
                    Console.WriteLine($"\nDigite el número de documento del usuario {i + 1}:");
                    _ = int.TryParse(Console.ReadLine(), out documento);
                } while (documento < 1);
                do
                {
                    Console.WriteLine($"\nDigite el año de radicación de las facturas:");
                    año = int.Parse(Console.ReadLine());
                } while (año < 1 || año > 2021);

                usuario.nombre = nombre;
                usuario.cedula = documento;

                // Ciclo que recorre según la cantidad de facturas dependiendo del valor que ingrese el usuario:
                for (int f = 0; f < cantFacturas; f++)
                {
                    do
                    {
                        Console.WriteLine($"\nDigite el estrato del usuario {i + 1}:");
                        estrato = int.Parse(Console.ReadLine());
                    } while (estrato < 1 || estrato > 6);

                    Console.WriteLine($"\nDigite el mes la factura:");
                    mes = Console.ReadLine();

                    do
                    {
                        Console.WriteLine("\nDigite la cantidad de 'kwh':");
                        kwh = double.Parse(Console.ReadLine());
                    } while (kwh < 1);
                    factura = new Factura(año, mes, estrato, kwh);// Se rellenan los parámetros del objeto.
                    usuario.asignarFactura(factura);// Se envía las facturas directamente a la clase usuario al átributo tipo lista.
                }// Fin del ciclo para el ingreso de las facturas.
                listaUsuarios[i] = usuario;
            }// Fin del ciclo para el ingreso de los usuarios.


            // Cilo para mostrar la información ingresada previamente.
            foreach (Usuario user in listaUsuarios)
            {
                cont = 0;
                for (int f = 0; f < user.getListaFacturas().Count; f++)
                {
                    if (f < user.getListaFacturas().Count-1)
                    {
                        cont += user.getListaFacturas()[f].Kwh_Consumidos;
                    }

                    prom = cont / user.getListaFacturas().Count - 1;

                    Console.WriteLine($"\nUsuario: {user.nombre}\nDocumento: {user.cedula}\nEstrato: {user.getListaFacturas()[f].Estrato}\nAño: {user.getListaFacturas()[f].Año}\nMes: {user.getListaFacturas()[f].Mes}\nKwh en el mes: {user.getListaFacturas()[f].Kwh_Consumidos}");

                    if (f < user.getListaFacturas().Count - 1)
                    {
                        Console.WriteLine($"\nEl total a pagar de la factura es: {user.getListaFacturas()[f].calcularValorFactura()}");
                    }

                    if (f == user.getListaFacturas().Count-1)
                    {
                        double aux = user.getListaFacturas()[f].calcularValorFactura() * 0.1;

                        if (user.getListaFacturas()[f].Kwh_Consumidos > prom)
                        {
                            Console.WriteLine($"\nEl total a pagar de la factura del último mes es mayor que el promedio de los últimos 4 meses\nes decir que el valor a pagar del mismo es: {user.getListaFacturas()[f].calcularValorFactura() + aux}");
                        }
                        else
                        {
                            Console.WriteLine($"El total a pagar de la factura del último mes es menor que el promedio de los últimos 4 meses\nes decir que el valor a pagar del mismo es: {user.getListaFacturas()[f].calcularValorFactura() - aux}");
                        }
                    }
                }
            }
        }
    }
}