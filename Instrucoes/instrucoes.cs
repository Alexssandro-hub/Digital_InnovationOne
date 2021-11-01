using System;

namespace Digital_InnovationOne.Instrucoes
{
    public class Program
    {
        static void Declaracoes ()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            const int d = 4;
            
            Console.WriteLine(a + b + c + d);
        }

        static void InstrucaoIF(string[] args)
        {
            if(args.Length == 0)
                Console.WriteLine("Nenhum argumento!");
            

            else if(args.Length == 1)
                Console.WriteLine("Um argumento!");

            else
                Console.WriteLine($"{args.Length} argumentos!");
        }

        static void InstrucaoSwitch(string[] args)
        {
            int numArgs = args.Length;
            
            switch (numArgs)
            {
                case 0:
                    Console.WriteLine("Nenhum Argumento");
                    break;

                case 1:   
                    Console.WriteLine("Um argumento!");
                    break;

                default:
                    Console.WriteLine($"{numArgs} argumentos!");
                    break;    
            }
        }

        static void InstrucaoWhile(string[] args)
        {
            int i = 0;
            while( i < args.Length)
            {
                Console.WriteLine(args[i]);
                i++;
            }
        }

        static void InstrucaoDoWhile(string[] args)
        {
            string texto;
            do
            {
                texto = Console.ReadLine();
                Console.WriteLine(texto);
            } while(!string.IsNullOrEmpty(texto));
        }

        static void InstrucaoFor(string[] args)
        {
            for(int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[1]);
            }
        }

        static void InstrucaoForEach(string[] args)
        {
            foreach(string s in args)
            {
                Console.WriteLine(s);
            }
        }
        
        static void InstrucaoBreak(string[] args)
        {
            while(true)
            {
                string str = Console.ReadLine();

                if(string.IsNullOrEmpty(str))
                    break;
                
                Console.WriteLine(str);
            }
        }

        static void InstrucaoContinue(string[] args)
        {
            for(int i = 0; i< args.Length; i++)
            {
                if(args[i].StartsWith("/"))
                    continue;

                Console.WriteLine(args[i]);
            }
        }

        static void InstrucaoReturn()
        {
            int Somar(int a, int b)
            {
                return a + b;
            }

            Console.WriteLine(Somar(1,2));
            Console.WriteLine(Somar(3,5));
            Console.WriteLine(Somar(2,10));
            return;
        }

        static void InstrucaoTryCatchFinallyThrow(string[] args)
        {
            double Dividir(double x, double y)
            {
                    if(y == 0)
                        throw new DivideByZeroException();
                        
                    return x/y;
            }

            try
            {
                if(args.Length !=2)
                    throw new InvalidOperationException("informe 2 numeros!");

                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);
                Console.WriteLine(Dividir(x,y));
            }

            catch(InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch(Exception ex)
            {
                Console.WriteLine($"Erro Genérico: {ex.Message}");
            }

            finally
            {
                Console.WriteLine("Até breve!");
            }
        }

        static void InstrucaoUsing(string[] args)
        {
            using(System.IO.TextWriter write = System.IO.File.CreateText("teste.txt"))
            {
                write.WriteLine("Linha1");
                write.WriteLine("Linha2");
                write.WriteLine("Linha3");
            }
        }
   }
}