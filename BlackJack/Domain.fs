module BlackJack.Domain

type Suit = Hearts | Clubs | Diamonds | Spades

type Rank = Two | Three | Four | Five | Six | Seven | Eight | Nine | Ten | Jack | Queen | King | Ace

type Card = Suit * Rank

type Player = Player of string

type Hand = Card list

type PlayerHand = Player * Hand

type DealerHand = Dealer of Hand

type MoveType = Stick | Flip

type GameState = DealerHand * (PlayerHand list)



let notImplemented () = raise (new System.NotImplementedException())

let playerPlay moveType player gameState = notImplemented ()

let dealerPlay gameState = notImplemented ()

let scoreCard (card : Card) =
    match snd card with
    | Two                             -> 2
    | Three                           -> 3
    | Four                            -> 4
    | Five                            -> 5
    | Six                             -> 6
    | Seven                           -> 7
    | Eight                           -> 8
    | Nine                            -> 9
    | Ten | Jack | Queen | King | Ace -> 10

let scoreHand hand = hand |> Seq.map (scoreCard) |> Seq.fold (+) 0