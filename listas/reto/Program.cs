using System;
using System.Collections;

namespace reto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de lista de estudiantes
            ArrayList estudiantes = new ArrayList();

            estudiantes.Add("ALEJANDRO CARDONA LOPEZ");
            estudiantes.Add("ALEJANDRO GIL GARCIA");
            estudiantes.Add("ANDRES FELIPE VALENCIA LOPEZ");
            estudiantes.Add("ANDRES FELIPE ALZATE ALARCON");
            estudiantes.Add("ANDRES MAURICIO CIFUENTES SILVA");
            estudiantes.Add("ANGIE TATIANA MAYORGA MAYORGA");
            estudiantes.Add("DAHIANA OROZCO OROZCO");
            estudiantes.Add("DANIEL HOLGUIN GARCIA");
            estudiantes.Add("DANIEL GONZALEZ CEBALLOS");
            estudiantes.Add("DANIEL EDUARDO BELTRAN GRISALES");
            estudiantes.Add("DAVID SANTIAGO LEGUIZAMON GUERRA");
            estudiantes.Add("FEDERICO KRASTZ ROMAN");
            estudiantes.Add("JHON DARWIN GRISALES GIRALDO");
            estudiantes.Add("JUAN DIEGO YEPES ARANGO");
            estudiantes.Add("JUAN MANUEL ALZATE GALVEZ");
            estudiantes.Add("LUIS FELIPE CASTAÑEDA GALVIS");
            estudiantes.Add("LUISA FERNANDA YAQUIVE HOYOS");
            estudiantes.Add("MANUEL SABOGAL ARDILA");
            estudiantes.Add("MARIA PAULINA CASTRO LOPEZ");
            estudiantes.Add("MICHAEL JARAMILLO HENAO");
            estudiantes.Add("NICOL DAHIANNA QUIJANO LADINO");
            estudiantes.Add("SEBASTIAN SANCHEZ TABORDA");
            estudiantes.Add("SIMON TORO CUERVO");
            estudiantes.Add("WESNER DAMIAN GARCES LORA");
            estudiantes.Add("YESICA ANDREA GUTIERREZ ESCOBAR");

            ArrayList tema1 = new ArrayList();
            ArrayList tema2 = new ArrayList();
            ArrayList tema3 = new ArrayList();
            ArrayList tema4 = new ArrayList();
            ArrayList tema5 = new ArrayList();
            ArrayList tema6 = new ArrayList();
            ArrayList tema7 = new ArrayList();

            Random rnd = new Random();
            int numero = 0;

            foreach(string persona in estudiantes) {
                bool asignacion = false;
                do {
                    numero = rnd.Next(1, 8);
                    if(numero == 1) {
                        if(tema1.Count < 3) {
                            tema1.Add(persona);
                            asignacion = true;
                        }
                        else {
                            asignacion = false;
                        }
                    }
                    else if(numero == 2) {
                        if(tema2.Count < 3) {
                            tema2.Add(persona);
                            asignacion = true;
                        }
                        else {
                            asignacion = false;
                        }
                    }
                    else if(numero == 3) {
                        if(tema3.Count < 3) {
                            tema3.Add(persona);
                            asignacion = true;
                        }
                        else {
                            asignacion = false;
                        }
                    }
                    else if(numero == 4) {
                        if(tema4.Count < 4) {
                            tema4.Add(persona);
                            asignacion = true;
                        }
                        else {
                            asignacion = false;
                        }
                    }
                    else if(numero == 5) {
                        if(tema5.Count < 4) {
                            tema5.Add(persona);
                            asignacion = true;
                        }
                        else {
                            asignacion = false;
                        }
                    }
                    else if(numero == 6) {
                        if(tema6.Count < 4) {
                            tema6.Add(persona);
                            asignacion = true;
                        }
                        else {
                            asignacion = false;
                        }
                    }
                    else if(numero == 7) {
                        if(tema7.Count < 4) {
                            tema7.Add(persona);
                            asignacion = true;
                        }
                        else {
                            asignacion = false;
                        }
                    }
                }while(asignacion == false);
            }

            Console.WriteLine("Los grupos resultantes son: ");
            Console.WriteLine("************************************\n");
            Console.WriteLine("Que es la Programación Orientada a Objetos POO");
            foreach (string estudiante in tema1)
            {
                Console.WriteLine($"integrante: {estudiante}");
            }
            //
            Console.WriteLine("************************************\n");
            Console.WriteLine("Diferencias entre la programación estructurada y la Programación");
            foreach (string estudiante in tema2)
            {
                Console.WriteLine($"integrante: {estudiante}");
            }
            //
            Console.WriteLine("************************************\n");
            Console.WriteLine("Abstracción en POO");
            foreach (string estudiante in tema3)
            {
                Console.WriteLine($"integrante: {estudiante}");
            }
            //
            Console.WriteLine("************************************\n");
            Console.WriteLine("Encapsulación en POO");
            foreach (string estudiante in tema4)
            {
                Console.WriteLine($"integrante: {estudiante}");
            }
            //
            Console.WriteLine("************************************\n");
            Console.WriteLine("Herencia en POO");
            foreach (string estudiante in tema5)
            {
                Console.WriteLine($"integrante: {estudiante}");
            }
            //
            Console.WriteLine("************************************\n");
            Console.WriteLine("Polimorfismo en POO");
            foreach (string estudiante in tema6)
            {
                Console.WriteLine($"integrante: {estudiante}");
            }
            //
            Console.WriteLine("************************************\n");
            Console.WriteLine("Que es un diagrama de Clases");
            foreach (string estudiante in tema7)
            {
                Console.WriteLine($"integrante: {estudiante}");
            }
        }
    }
}