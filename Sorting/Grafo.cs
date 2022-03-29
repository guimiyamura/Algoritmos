using System;
using System.Collections;
using System.Collections.Generic;

namespace Sorting
{
    public static class Grafo
    {
        public static bool PesquisaEmLarguraVendedor(string nome)
        {
            Dictionary<string, IEnumerable<string>> grafo = GerarGrafo();
            var verificadas = new List<string>();

            var fila = new Queue();
            fila.Enqueue(grafo[nome]);

            while(fila.Count > 0)
            {
                var pessoas = (string[])fila.Peek();
                for(int i = 0; i < pessoas.Length; i++)
                {
                    if(!verificadas.Contains(pessoas[i]))
                    {
                        if (EhVendedor(pessoas[i]))
                        {
                            Console.WriteLine($"{pessoas[i]} eh um(a) vendedor(a)");
                            return true;
                        }
                        else
                        {
                            if(grafo.ContainsKey(pessoas[i]))
                                fila.Enqueue(grafo[pessoas[i]]);

                            verificadas.Add(pessoas[i]);
                        }
                    }
                }
                fila.Dequeue();
            }
            return false;
        }

        private static Dictionary<string, IEnumerable<string>> GerarGrafo()
        {
            Dictionary<string, IEnumerable<string>> grafo = new Dictionary<string, IEnumerable<string>>();
            grafo.Add("Guilherme", new string[] { "Roberto", "Luiza", "Catharine" });
            grafo.Add("Catharine", new string[] { "Gabi", "Gislaine" });
            grafo.Add("Gabi", new string[] { "Zoe" });
            return grafo;
        }

        private static bool EhVendedor(string nome)
        {
            if (nome.StartsWith("Z"))
                return true;

            return false;
        }
    }
}
