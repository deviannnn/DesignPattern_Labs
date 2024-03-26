using SortStrategy;

SortApp test = new SortApp(new QuickSort());
test.add(1);
test.add(5);
test.add(3);
test.add(9);
test.add(4);

Console.Write("Init: ");
test.print();

test.ExecuteSort();
test.print();

test.SetSortStrategy(new InsertionSort());
test.ExecuteSort();
test.print();

test.SetSortStrategy(new SelectionSort());
test.ExecuteSort();
test.print();