using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indexAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario(); 

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno: ");
                        
                        if(decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.nota = nota;  
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal!");
                        }

                        alunos[indexAluno] = aluno;
                        indexAluno++;

                        break;

                    case "2":
                        foreach(var a in alunos)
                        {
                            if(!string.IsNullOrEmpty(a.nome))
                            Console.WriteLine($"ALUNO:{a.nome} - NOTA: {a.nota}");
                        }
                        break;

                    case "3":
                        decimal notaTotal = 0;
                        var numAlunos = 0;

                        for(int i = 0; i<alunos.Length; i++)
                        {
                            if(!string.IsNullOrEmpty(alunos[i].nome))
                            {
                                notaTotal = notaTotal + alunos[i].nota;
                                numAlunos++; 
                            }
                        }

                        var mediaGeral = notaTotal/numAlunos;
                        Console.WriteLine($"Media Geral: {mediaGeral}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();

            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada.");
            Console.WriteLine("1 - Inserir um novo aluno.");
            Console.WriteLine("2 - Lista alunos.");
            Console.WriteLine("3 - Calcular média geral.");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
