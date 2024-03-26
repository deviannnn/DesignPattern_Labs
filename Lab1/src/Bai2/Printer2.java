package Bai2;

public class Printer2 extends Server {
    private boolean isPrinting;
    private volatile static Printer2 instance;

    private Printer2(String name) {
        super(name);
        isPrinting = false;
    }

    public static Printer2 getInstance() {
        if (instance == null) {
            synchronized(Printer1.class) {
                if (instance == null) {
                    instance = new Printer2("Printer2");
                }
            }
        }
        return instance;
    }

    public void print(Packet p) {
        if (!isPrinting) {
            isPrinting = true;

            System.out.println(name + " is printing: ...");

            try {
                Thread.sleep(p.getSize());
            } catch (InterruptedException e) {
                e.printStackTrace();
            }

            System.out.print(name + " printed: " + p.getContents());
            isPrinting = false;
        } else {
            System.out.println("Waiting for " + name + " to print.");
            try {
                Thread.sleep(p.getSize()+1000);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
            print(p);
        }
    }
}
