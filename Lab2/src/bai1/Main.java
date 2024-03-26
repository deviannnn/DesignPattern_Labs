package bai1;

import java.util.Arrays;

public class Main {

    public static void main(String[] args) {
        int n = 10;

        int[] array1 = SortStrategy.createRandomArray(n);
        int[] array2 = SortStrategy.createRandomArray(n);
        int[] array3 = SortStrategy.createRandomArray(n);
        int[] array4 = SortStrategy.createRandomArray(n);

        System.out.println("Original Array: " + Arrays.toString(array1));
        SortStrategy context = new SortStrategy(new QuickSort());
        context.performSort(array1);
        System.out.println(Arrays.toString(array1));

        System.out.println("\nOriginal Array: " + Arrays.toString(array2));
        context.setSortStrategy(new MergeSort());
        context.performSort(array2);
        System.out.println(Arrays.toString(array2));

        System.out.println("\nOriginal Array: " + Arrays.toString(array3));
        context.setSortStrategy(new SelectionSort());
        context.performSort(array3);
        System.out.println(Arrays.toString(array3));

        System.out.println("\nOriginal Array: " + Arrays.toString(array4));
        context.setSortStrategy(new BubbleSort());
        context.performSort(array4);
        System.out.println(Arrays.toString(array4));
    }
}
