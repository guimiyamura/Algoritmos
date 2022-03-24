namespace Sorting
{
    public static class Ordenacao
    {
        // Notacao O(log n)
        public static int? BinarySort(int[] arr, int item)
        {
            int baixo = 0;
            int alto = arr.Length - 1;

            while (baixo <= alto)
            {
                int meio = (baixo + alto) / 2;
                int chute = arr[meio];

                if (chute == item)
                    return meio;

                if (chute > item)
                    alto = meio - 1;
                else
                    baixo = meio + 1;
            }

            return null;
        }

        //Notacao O(n²)
        public static void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                // Encontra o menor indice no array desordenado 
                int menor_indice = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[menor_indice])
                        menor_indice = j;

                // Substitui o menor indice encontrado com o primeiro item do array
                int temp = arr[menor_indice];
                arr[menor_indice] = arr[i];
                arr[i] = temp;
            }
        }

        //Notacao O(n log n)
        public static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                    QuickSort(arr, left, pivot - 1);

                if (pivot + 1 < right)
                    QuickSort(arr, pivot + 1, right);
            }

        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {
                //se o numero for menor que o pivo, parte para o proximo numero do array
                //comeca no inicio do array
                while (arr[left] < pivot) left++;

                //se o numero for maior que o pivo, parte para numero anterior do array
                //comeca no final do array
                while (arr[right] > pivot) right--;

                if (left < right)
                {
                    if (arr[left] == arr[right]) 
                        return right;

                    //trocar valores dos indices do array
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
