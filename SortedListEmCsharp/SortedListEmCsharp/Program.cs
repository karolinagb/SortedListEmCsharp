using A1._1_SortedList;
using System;
using System.Collections.Generic;

namespace SortedListEmCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //vamos criar um dicionários de alunos
            IDictionary<string, Aluno> alunos
               = new Dictionary<string, Aluno>();

            alunos.Add("VT", new Aluno("Vanessa", 34672));
            alunos.Add("AL", new Aluno("Ana", 5617));
            alunos.Add("RN", new Aluno("Rafael", 17645));
            alunos.Add("WM", new Aluno("Wanderson", 11287));

            //imprimindo...
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            //Com IDictionary nao conseguimos ter uma ordem especifica, por isso vamos usar o SortedList
            //vamos remover: AL
            alunos.Remove("AL");
            //vamos adicionar: MO
            alunos.Add("MO", new Aluno("Marcelo", 12345));
            Console.WriteLine();
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            //apresentando nova coleção...SortedList
            //SortedList implementa a interface IDictionary
            IDictionary<string, Aluno> sorted = new SortedList<string, Aluno>();

            sorted.Add("VT", new Aluno("Vanessa", 34672));
            sorted.Add("AL", new Aluno("Ana", 5617));
            sorted.Add("RN", new Aluno("Rafael", 17645));
            sorted.Add("WM", new Aluno("Wanderson", 11287));
            sorted.Add("BM", new Aluno("BM", 11287));

            Console.WriteLine();
            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
        }
    }
}
