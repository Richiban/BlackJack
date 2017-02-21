module BlackJack.Tests.Unit.DomainTests

open BlackJack.Domain
open Xunit
open Swensen.Unquote

[<Fact>]
let ``Score card returns correct int value`` () =
    let card = Hearts, Two
    let actual = scoreCard card

    test <@ actual = 2 @>

(*
When I am dealt a Queen and a King
And the dealer is dealt a pair of Kings
And I stick
And the dealer sticks
Then the result should be a draw
 *)