using System;
//2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por 
//pantalla. Solo se debe emitir UN valor por pantalla.

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,Numeros,Mayor = 0;
            bool Ban=false;
            const int VUELTAS = 5;

            for ( i = 0; i < VUELTAS; i++)
            {
                 Console.WriteLine("Ingrese 10 numeros por favor:");
                 Numeros = int.Parse(Console.ReadLine());

                 if(Ban){
                    Mayor = Numeros;
                    Ban = true;
                    
                 }else if(Numeros>Mayor){
                    Mayor = Numeros;
                 }

            }

            Console.WriteLine("El numero mayor es:" + Mayor);
        }
    }
}
