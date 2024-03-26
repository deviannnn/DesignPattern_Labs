package Bai2;

public class Packet {
    public String originator;
    public String destination;
    public String contents;

    public Packet(String originator, String destination, String contents) {
        this.originator = originator;
        this.destination = destination;
        this.contents = contents;
    }

    public boolean isOriginator(Node n) {
        return (this.originator.equals(n.name));
    }

    public boolean isDestination(Node n) {
        return (this.destination.equals(n.name));
    }

    public String getContents() {
        return contents;
    }

    public int getSize() {
        return contents.length()*200;
    }

    public void transmit(Node startingNode) {
        Node currentNode = startingNode;
        do {
            try {
                Thread.sleep(2000);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }

            currentNode.accept(this);
            if (currentNode.isReceived()) {
                break;
            }
            currentNode = currentNode.nextNode();
        } while (currentNode != startingNode);

        System.out.print(" -> Done.\n");
    }
}
