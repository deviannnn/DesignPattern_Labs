package bai1;

import java.util.Random;

public class SortStrategy {
    private ISortStrategy sortStrategy;

    public SortStrategy(ISortStrategy sortStrategy) {
        this.sortStrategy = sortStrategy;
    }
    
    public void setSortStrategy(ISortStrategy sortStrategy) {
        this.sortStrategy = sortStrategy;
    }

    public void performSort(int[] array) {
        sortStrategy.sort(array);
    }
    
    public static int[] createRandomArray(int n) {
        int[] array = new int[n];
        Random random = new Random();

        for (int i = 0; i < n; i++) {
            array[i] = random.nextInt(100);
        }

        return array;
    }
}
