namespace _21
{
    public class Deck
    {
        public card[,] Cards = new card[,]{{ new Hearts(2,"2"), new Hearts(3,"3"), new Hearts(4,"4"), new Hearts(5,"5"), new Hearts(6, "6"), new Hearts(7,"7"), new Hearts(8,"8"), new Hearts(9,"9"), new Hearts(10,"10"), new Hearts(2,"J"), new Hearts(3,"Q"), new Hearts(4,"K"), new Hearts(11,"A") },
                                           { new Diamonds(2,"2"), new Diamonds(3,"3"), new Diamonds(4,"4"), new Diamonds(5,"5"), new Diamonds(6,"6"), new Diamonds(7,"7"), new Diamonds(8,"8"), new Diamonds(9,"9"), new Diamonds(10,"10"), new Diamonds(2,"J"), new Diamonds(3,"Q"), new Diamonds(4,"K"), new Diamonds(11,"A") },
                                           { new Spades(2,"2"), new Spades(3,"3"), new Spades(4,"4"), new Spades(5,"5"), new Spades(6,"6"), new Spades(7,"7"), new Spades(8,"8"), new Spades(9,"9"), new Spades(10,"10"), new Spades(2,"J"), new Spades(3,"Q"), new Spades(4,"K"), new Spades(11,"A") },
                                           { new Clubs(2,"2"), new Clubs(3,"3"), new Clubs(4,"4"), new Clubs(5,"5"), new Clubs(6,"6"), new Clubs(7,"7"), new Clubs(8,"8"), new Clubs(9,"9"), new Clubs(10,"10"), new Clubs(2,"J"), new Clubs(3,"Q"), new Clubs(4,"K"), new Clubs(11,"A") }};
    }
}
