package Bai2;

public class Server extends Node {
    private volatile static int currentPrinter;
    public Server(String name) {
        super(name);
        currentPrinter = 1;
    }

    @Override
    public void accept(Packet p) {
        if (p.isDestination(this)) {
            System.out.println("*" + name + " is destination");

            try {
                Thread.sleep(2000);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }

            if (currentPrinter == 1) {
                Printer1.getInstance().print(p);
                currentPrinter = 2;
            } else {
                Printer2.getInstance().print(p);
                currentPrinter = 1;
            }
            this.setReceived(true);
        } else {
            System.out.println("*" + name + " -> ");
            this.setReceived(false);
        }
    }
}
