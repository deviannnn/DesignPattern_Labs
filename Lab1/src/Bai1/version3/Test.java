package Bai1.version3;

public class Test {
    /* Nhận xét
    *
    *  - Khác với ở version2 khi đã bổ sung đồng bộ đa luồng cho hàm getInstance().
    *  - Bằng chứng là nó chỉ println ra màn hình command line 1 dòng "is null" trên tổng số 10 luồng được thực thi.
    *  - Điều này có nghĩa khi chạy lần đầu tiên thì luồng đầu tiên gọi Logger.getInstance() thì có uniqueInstance
    *  bằng null. Các luồng tiếp theo thì có uniqueInstance khác null nên nó không println ra màn hình command line
    *  các dòng "is null" như ở version2.
    *
    * */

    public static void main(String[] args) {
        int numberOfThreads = 10;
        int numberOfIterations = 5;

        for (int i = 0; i < numberOfThreads; i++) {
            int threadNumber = i + 1;
            Thread thread = new Thread(() -> {
                Logger logger = Logger.getInstance();
                for (int j = 0; j < numberOfIterations; j++) {
                    String message = "Thread " + threadNumber + ": Iteration " + (j + 1) + " - Test message.";
                    logger.LogMessage(message);

                    try {
                        Thread.sleep(3000);
                    } catch (InterruptedException e) {
                        e.printStackTrace();
                    }
                }
            });
            thread.start();
        }
    }
}