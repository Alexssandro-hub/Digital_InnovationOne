using System;

namespace DigitalInnovationOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realiza o empilhamento de dados, "primeiro a entrar e último ao sair"
           var s = new Pilha();
           s.Empilha(1);
           s.Empilha(10);
           s.Empilha(1000);
           Console.WriteLine(s.Desempilha());
           Console.WriteLine(s.Desempilha());
           Console.WriteLine(s.Desempilha());
        }
    }
}
