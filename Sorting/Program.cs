using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            ChooseSorting();
        }

        static void ChooseSorting()
        {           
            Console.WriteLine("Escolha o tipo de ordenacao:");
            Console.WriteLine("\t1 - Ordenacao binaria");
            Console.WriteLine("\t2 - Ordenacao por selecao");
            Console.WriteLine("\t3 - Soma com recursividade");
            Console.WriteLine("\t4 - Quantidade com recursividade");
            Console.WriteLine("\t5 - Maior numero com recursividade");
            EscolherMetodoDeOrdenacao(Convert.ToInt32(Console.ReadLine()));
        }        

        static void EscolherMetodoDeOrdenacao(int escolha)
        {
            switch (escolha)
            {
                case 1:
                    MostrarOrdenacaoBinaria();
                    break;

                case 2:
                    MostrarOrdenacaoPorSelecao();
                    break;

                case 3:
                    MostrarSomaComRecursividade();
                    break;

                case 4:
                    MostrarQuantidadeComRecursividade();
                    break;

                case 5:
                    MostrarMaiorNumeroPorRecursividade();
                    break;

                default:
                    Console.WriteLine("Opcao invalida");
                    break;
            }
        }

        private static void MostrarMaiorNumeroPorRecursividade()
        {
            int[] arr = new int[] { 2, 5, 27, 3, 14 };
            Console.WriteLine($"Array do exemplo {ApresentarArray(arr)}");
            int result = Recursividade.MaiorNumeroPorRecursividade(arr, 0, arr.Length - 1);
            Console.WriteLine($"Maior numero do array eh o {result}");
            Console.ReadKey();
        }

        private static void MostrarSomaComRecursividade()
        {
            int[] arr = new int[] { 2, 5, 6 };
            Console.WriteLine($"Array do exemplo {ApresentarArray(arr)}");
            int result = Recursividade.SomaComRecursividade(arr, arr.Length);
            Console.WriteLine($"Soma dos numeros do array eh igual a {result}");
            Console.ReadKey();
        }

        private static void MostrarQuantidadeComRecursividade()
        {
            int[] arr = new int[] { 2, 5, 6, 10, 14, 23, 33 };
            Console.WriteLine($"Array do exemplo {ApresentarArray(arr)}");
            int count = Recursividade.QuantidadeArrayPorRecursividade(arr, arr.Length);
            Console.WriteLine($"Quantidade de itens no array eh igual a {count}");
            Console.ReadKey();
        }

        private static void MostrarOrdenacaoPorSelecao()
        {
            int[] arr = new int[] { 5, 3, 6, 2, 10 };
            Console.WriteLine($"Array original {ApresentarArray(arr)}");
            Ordenacao.SelectionSort(arr);
            Console.WriteLine($"Array ordenado {ApresentarArray(arr)}");
            Console.ReadKey();
        }

        private static void MostrarOrdenacaoBinaria()
        {
            int[] arrOrder = new int[] { 1, 3, 5, 7, 9 };
            Console.WriteLine($"Escolha um item do array {ApresentarArray(arrOrder)}");
            int item = Convert.ToInt32(Console.ReadLine());

            var ret = Ordenacao.BinarySort(arrOrder, item);
            string response = ret.HasValue ?
                $"O item escolhido esta no indice {ret.Value} do array" :
                "O item escolhido nao esta no array";

            Console.WriteLine(response);
            Console.ReadKey();
        }

        private static string ApresentarArray(int[] arr)
        {
            return string.Join(",", arr);
        }        

        //TODO: estudar seguintes tipos de ordenacao
        void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], 
                // that are greater than key, 
                // to one position ahead of 
                // their current position 
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        // swap temp and arr[i] 
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }        
    }
}
