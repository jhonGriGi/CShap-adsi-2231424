using System;

namespace ejercicio7
{
  class Program
  {
    static void Main(string[] args)
    {
      /* Una agencia de seguros desea obtener un reporte al final del día de sus n empleados para determinar
         cuál fue el empleado que obtuvo el mayor sueldo en base a sus ventas y comisiones, se registrará el
         nombre del empleado la edad y el sueldo que obtuvo al final del día. Desarrollar un programa que
         pida al usuario el nombre de los n empleados, su edad y el sueldo para generar un reporte que lo
         muestre en pantalla de la siguiente manera: el nombre del empleado, edad, sueldo, el empleado con
         mayor sueldo, el sueldo del empleado que gana más y su edad.
         Debe declarar un arreglo de enteros para la edad.
         Debe declarar un arreglo de reales para el sueldo.
         Debe declarar un arreglo de cadena para el nombre*/
      Console.WriteLine("Ingrese la cantidad de empleados: ");
      _ = int.TryParse(Console.ReadLine(), out int cantidadEmpleados);

      int[] edadEmpleados = new int[cantidadEmpleados];
      double[] sueldoEmpleados = new double[cantidadEmpleados];
      string[] nombreEmpleados = new string[cantidadEmpleados];

      for(int i = 0; i < cantidadEmpleados; i++){
        Console.WriteLine("Ingrese el nombre del empleado: " + (i+1));
        nombreEmpleados[i] = Console.ReadLine();

        Console.WriteLine("Ingrese la edad del empleado: "+ (i+1));
        _ = int.TryParse(Console.ReadLine(), out edadEmpleados[i]);

        Console.WriteLine("Ingrese el sueldo del empleado: " + (i+1));
        _ = double.TryParse(Console.ReadLine(), out sueldoEmpleados[i]);
      }

      int posicion = 0;
      double mayorSueldo = 0;
      for(int i = 0; i < sueldoEmpleados.Length; i++){
        if(sueldoEmpleados[i] > mayorSueldo){
          mayorSueldo = sueldoEmpleados[i];
          posicion = i;
        }
      }
      Console.WriteLine("El empleado: " + nombreEmpleados[posicion]);
      Console.WriteLine("con la edad de: " + edadEmpleados[posicion]);
      Console.WriteLine("tiene un sueldo de: " + sueldoEmpleados[posicion]);
    }
  }
}
