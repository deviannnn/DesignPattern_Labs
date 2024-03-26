using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStrategy
{
    public class SortApp
    {
        private static List<int> list = new List<int>();
        private ISortStrategy _sortStrategy;

        public SortApp(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void SetSortStrategy(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void ExecuteSort()
        {
            _sortStrategy.DoSort(list);
        }

        public void add(int number)
        {
            list.Add(number);
        }

        public void print()
        {
            foreach (int number in list)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}
