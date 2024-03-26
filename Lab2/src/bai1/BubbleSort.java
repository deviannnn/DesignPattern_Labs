package bai1;

public class BubbleSort implements ISortStrategy {

    @Override
    public void sort(int[] array) {
        System.out.println("BubbleSort");
        bubbleSort(array);
    }

    private void bubbleSort(int[] array) {
        int n = array.length;

        for (int i = 0; i < n - 1; i++) {
            for (int j = 0; j < n - i - 1; j++) {
                if (array[j] > array[j + 1]) {
                    swap(array, j, j + 1);
                }
            }
        }
    }

    private void swap(int[] array, int i, int j) {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}
