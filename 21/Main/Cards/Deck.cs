namespace _21
{
    public class Deck
    {
        public Card[,] Cards = new Card[,]{{ new Hearts(5,"5"), new Hearts(6, "6"), new Hearts(7,"7"), new Hearts(8,"8"), new Hearts(9,"9"), new Hearts(10,"10"), new Hearts(2,"J"), new Hearts(3,"Q"), new Hearts(4,"K"), new Hearts(11,"A") },
                                           { new Tiles(5,"5"), new Tiles(6,"6"), new Tiles(7,"7"), new Tiles(8,"8"), new Tiles(9,"9"), new Tiles(10,"10"), new Tiles(2,"J"), new Tiles(3,"Q"), new Tiles(4,"K"), new Tiles(11,"A") },
                                           { new Pikes(5,"5"), new Pikes(6,"6"), new Pikes(7,"7"), new Pikes(8,"8"), new Pikes(9,"9"), new Pikes(10,"10"), new Pikes(2,"J"), new Pikes(3,"Q"), new Pikes(4,"K"), new Pikes(11,"A") },
                                           { new Clovers(5,"5"), new Clovers(6,"6"), new Clovers(7,"7"), new Clovers(8,"8"), new Clovers(9,"9"), new Clovers(10,"10"), new Clovers(2,"J"), new Clovers(3,"Q"), new Clovers(4,"K"), new Clovers(11,"A") }};
    }
}
