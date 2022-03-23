using System;

namespace Sorting
{
    public static class Recursividade
    {
        public static int MaiorNumeroPorRecursividade(int[] arr, int from, int to)
        {
            if (to <= from + 1)
                return Math.Max(arr[from], arr[to]); //caso-base

            return Math.Max(MaiorNumeroPorRecursividade(arr, from, (from + to) / 2),
                MaiorNumeroPorRecursividade(arr, (from + to) / 2 + 1, to)); // caso-recursivo
        }

        public static int QuantidadeArrayPorRecursividade(int[] arr, int tamanho)
        {
            if (tamanho == 0)
                return 0; //caso-base
            else
                return 1 + QuantidadeArrayPorRecursividade(arr, tamanho - 1); //caso-recursivo
        }

        public static int SomaComRecursividade(int[] arr, int tamanho)
        {
            if (tamanho == 0)
                return 0; //caso-base
            else
                return arr[tamanho - 1] + SomaComRecursividade(arr, tamanho - 1); //caso-recursivo
        }
    }
}
