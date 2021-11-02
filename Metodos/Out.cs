using System;

namespace Digital_InnovationOne.Metodos
{
    public class Out
    {
        static void Dividir(int x, int y, out int resultado, out int resto)
        {
            resultado = x/y;
            resto = x % y;
        }

        public static void Dividir()
        {
            Dividir(10, 3, out int restultado, out int resto);
            Console.WriteLine("{0}{1}", restultado, resto); //Escreve "3 1" 
        }
    }
}