using System;
//5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números
 //pares y el mínimo de los números impares.

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numeros,MaximoPar=0,MinimoImpar=0,i;
            bool BanPares=false,BanImpares=false;
            const int VUELTAS = 5;

            for ( i = 0; i < VUELTAS; i++)
            {
                  Console.WriteLine("Ingrese 20 numeros por favor: ");
                  Numeros = int.Parse(Console.ReadLine());
                  if(Numeros%2==0){

                    if(BanPares){
                    MaximoPar = Numeros;
                    BanPares = true;
                    }else if(Numeros > MaximoPar){
                        MaximoPar = Numeros;
                    }
                  }else if( BanImpares){
                    MinimoImpar = Numeros;
                    BanImpares = true;
                  }else if(Numeros<MinimoImpar ){
                    MinimoImpar = Numeros;
                  }
                  
            }
               Console.WriteLine("El maximo de los pares es: " +MaximoPar);
               Console.WriteLine( "El minimo de los impares es: " +MinimoImpar);
          
        }
    }
}
