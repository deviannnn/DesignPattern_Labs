package Bai2;

public class Workstation extends Node {
    public Workstation(String name) {
        super(name);
    }

    public void composeAndTransmit(Node des, String contents) {
        Packet p = new Packet(this.getName(), des.getName(), contents);
        p.transmit(this);
    }

    @Override
    public void accept(Packet p) {
        if (p.isOriginator(this)) {
            System.out.println("*" + name + " is originator ->");
        } else {
            System.out.println("*" + name + " ->");
        }
    }
}
