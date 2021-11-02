using System;
using Digital_InnovationOne.Heranca;

namespace DigitalInnovationOne
{
    class Program
    {
        static void Main(string[] args)
        {
        //Realiza o empilhamento de dados, "primeiro a entrar e último ao sair"
        //    var s = new Pilha();
        //    s.Empilha(1);
        //    s.Empilha(10);
        //    s.Empilha(1000);
        //    Console.WriteLine(s.Desempilha());
        //    Console.WriteLine(s.Desempilha());
        //    Console.WriteLine(s.Desempilha());

                Ponto p1 = new Ponto(15, 25);
                Ponto3D p2 = new Ponto3D(15, 25, 35);

                Ponto3D.Calcular(); //Chamando um método estático
        }
    }
}
