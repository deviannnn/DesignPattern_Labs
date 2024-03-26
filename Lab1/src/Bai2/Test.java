package Bai2;

public class Test {
    public static void main(String[] args) {
        Workstation ws1 = new Workstation("WS1");
        Workstation ws2 = new Workstation("WS2");
        Workstation ws3 = new Workstation("WS3");
        Server sv1 = new Server("Server1");
        Server sv2 = new Server("Server2");
        ws1.insertNode(ws2);
        ws1.insertNode(ws3);
        ws1.insertNode(sv1);
        ws1.insertNode(sv2);

        int numberOfThreads = 3;

        for (int i = 0; i < numberOfThreads; i++) {
            Thread thread = new Thread(() -> {
                ws3.composeAndTransmit(sv2, "Print this document 1");
//                try {
//                    Thread.sleep(10000);
//                    System.out.println();
//                } catch (InterruptedException e) {
//                    e.printStackTrace();
//                }
                ws1.composeAndTransmit(sv1, "Print this document 2");
                //        ws2.composeAndTransmit(sv2, "Print this document 2");
                //        ws3.composeAndTransmit(sv2, "Print this document 3");
            });
            thread.start();
        }
    }
}
