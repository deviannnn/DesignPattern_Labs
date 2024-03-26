using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStrategy
{
    public interface ISortStrategy
    {
        void DoSort(List<int> list);
    }

    public class QuickSort : ISortStrategy
    {
        public void DoSort(List<int> list)
        {
            Console.Write("Quick Sort: ");

            if (list == null || list.Count <= 1)
            {
                return;
            }

            QuickSortAlgorithm(list, 0, list.Count - 1);
        }

        private void QuickSortAlgorithm(List<int> list, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(list, low, high);

                QuickSortAlgorithm(list, low, pivotIndex - 1);
                QuickSortAlgorithm(list, pivotIndex + 1, high);
            }
        }

        private int Partition(List<int> list, int low, int high)
        {
            int pivot = list[high];

            int i = low - 1;

            for (int j = low; j <= high - 1; j++)
            {
                if (list[j] <= pivot)
                {
                    i++;
                    int temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                }
            }

            int tempPivot = list[i + 1];
            list[i + 1] = list[high];
            list[high] = tempPivot;

            return i + 1;
        }
    }
    public class InsertionSort : ISortStrategy
    {
        public void DoSort(List<int> list)
        {
            Console.Write("Insertion Sort: ");

            if (list == null || list.Count <= 1)
            {
                return;
            }

            for (int i = 1; i < list.Count; i++)
            {
                int key = list[i];
                int j = i - 1;

                while (j >= 0 && list[j] > key)
                {
                    list[j + 1] = list[j];
                    j = j - 1;
                }

                list[j + 1] = key;
            }
        }
    }

    public class SelectionSort : ISortStrategy
    {
        public void DoSort(List<int> list)
        {
            Console.Write("Selection Sort: ");

            if (list == null || list.Count <= 1)
            {
                return;
            }

            int n = list.Count;

            for (int i = 0; i < n - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (list[j] > list[maxIndex])
                    {
                        maxIndex = j;
                    }
                }

                int temp = list[maxIndex];
                list[maxIndex] = list[i];
                list[i] = temp;
            }
        }
    }
}
