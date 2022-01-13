using System;
using System.Collections.Generic;

namespace SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conjunto de alunos:
            ISet<string> alunos
                = new SortedSet<string>(new ComparadorMinusculo())
                {
                    "Vanessa Tonini",
                    "Ana Losnak",
                    "Rafael Nercessian",
                    "Priscila Stuani"
                };

            //adicionar: Rafael Rollo
            alunos.Add("Rafael Rollo");
            //adicionar: Fabio Gushiken
            alunos.Add("Fabio Gushiken");
            //adicionar: Fabio Gushiken
            alunos.Add("Fabio Gushiken");
            //adicionar: FABIO GUSHIKEN
            alunos.Add("FABIO GUSHIKEN");

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            ISet<string> outroConjunto = new HashSet<string>();

            //Se todos os elementos de aluno pertece ao outro conjunto
            //este conjunto é subconjunto do outro? IsSubsetOf
            alunos.IsSubsetOf(outroConjunto);

            //Se o outro conjunto está contido dentro de aluno
            //este conjunto é superconjunto do outro? IsSupersetOf
            alunos.IsSupersetOf(outroConjunto);

            //os conjuntos contêm os mesmos elementos? SetEquals
            alunos.SetEquals(outroConjunto);

            //subtrai os elementos da outra coleção que também estão neste conjunto - ExceptWith
            alunos.ExceptWith(outroConjunto);

            //intersecção dos conjuntos - IntersectWith
            alunos.IntersectWith(outroConjunto);

            //somente em um ou outro conjunto - SymmetricExceptWith
            alunos.SymmetricExceptWith(outroConjunto);

            //união de conjuntos - UnionWith
            alunos.UnionWith(outroConjunto);
        }
    }

    internal class ComparadorMinusculo : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
