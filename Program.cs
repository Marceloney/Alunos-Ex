using System;
using System.Globalization;
namespace Resolvendo004
{
    class Program
    {
        static void Main(String[] args)
        {
            Alunos al = new Alunos();

            Console.Write("Nome do aluno: ");
            al.Aluno = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            al.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            al.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            al.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            Console.WriteLine("Nota Final = " + al.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (al.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram "
                    + al.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                    + " PONTOS");


            }
        }
    }
}