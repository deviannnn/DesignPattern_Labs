package Bai1.version2;

public class Test {
    /* Nhận xét
    *
    *  - Khi run chương trình thì Logger.getInstance() ở 10 luồng đều rơi vào câu lệnh if (uniqueInstance == null).
    *  - Bằng chứng là nó đã println ra màn hình command line 10 dòng "is null" tương ứng với 10 luồng được thực thi.
    *  - Điều này có nghĩa khi chạy lần đầu tiên các uniqueInstance đều bằng null. Đồng nghĩa với việc tạo ra 10 Object.
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