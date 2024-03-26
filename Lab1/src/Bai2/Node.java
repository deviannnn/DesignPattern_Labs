package Bai2;

abstract class Node {
    protected String name;
    protected Node _nextNode;
    public boolean received;

    public Node(String name) {
        this.name = name;
        this._nextNode = this;
        this.received = false;
    }

    public void insertNode(Node n) {
        n._nextNode = this._nextNode;
        this._nextNode = n;
    }

    public String getName() {
        return name;
    }

    public Node nextNode() { return this._nextNode; }

    public boolean isReceived() {
        return received;
    }

    public void setReceived(boolean received) {
        this.received = received;
    }

    public abstract void accept(Packet p);
}
