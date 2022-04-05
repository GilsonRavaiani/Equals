using System;

namespace Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Este texto é um teste";
           
            Console.WriteLine(texto.Equals("Este texto é um teste")); //Outra forma de comparar textos
            Console.WriteLine(texto.Equals("Esse texto é um teste"));//Neste caso compara todo texto entre "aspas"
            Console.WriteLine(texto.Equals("Este texto É um teste"));//*Lembrando que para comparar objetos tem que ser do mesmo tipo
                                                                     //double==double 
                                                                     // Int==Int
                                                                     //String==String
        }
    }
}
