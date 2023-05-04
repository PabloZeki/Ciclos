using System;
//4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si 
//el mismo es primo o no es primo.  Nota: un numero es primo cuando es divisible únicamente por 1 
//y por sí mismo.

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero;
            float cont=0,j=1;

            Console.WriteLine("Ingrese un numero por favor: ");
            Numero = int.Parse (Console.ReadLine());

            while (j<=Numero)
            {
               if(Numero%j==0) {
                cont++;
               }
               j++;
            }
            if(cont==2){
                Console.WriteLine("El numero es primo");
            } else
            {
                Console.WriteLine("No es primo ");
            }
        }
    }
}
