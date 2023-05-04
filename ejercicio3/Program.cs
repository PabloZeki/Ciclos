using System;
//3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas 
//personas mayores a 18 años.

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Edades,i;
            float cont=0,acu=0,Promedio;
            const int VUELTAS = 20;

            for ( i = 0; i < VUELTAS; i++)
            {
                 Console.WriteLine("Ingrese las edades por favor: ");
                 Edades = int.Parse(Console.ReadLine());

                if(Edades > 18){

                    cont ++;
                    acu+=Edades;
                }


            }
            Promedio = acu/cont;
            
            Console.WriteLine("El promedio de las edades mayores a 18 años es: " + Promedio);
        }
    }
}
