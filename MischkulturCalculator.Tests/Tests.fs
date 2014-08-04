module MischkulturCalculator.Tests

open Xunit
open FsUnit.Xunit
open Calculator
open Xunit.Extensions

let inline toTheoryData (seq: #seq<'a * 'b>): obj[][] =
    seq |> Seq.map (fun (a, b) -> [| box a; box b |]) |> Seq.toArray

let wurzeldaten =
    [ (Wurzel.Tief, Wurzel.Tief), false
      (Wurzel.Flach, Wurzel.Flach), false
      (Wurzel.Mittel, Wurzel.Mittel), false
      (Wurzel.Tief, Wurzel.Flach), true
      (Wurzel.Mittel, Wurzel.Flach), true
      (Wurzel.Flach, Wurzel.Tief), true ]
    |> toTheoryData

[<Theory; PropertyData("wurzeldaten")>]
let ``Wurzelunverträglichkeit`` ((w1, w2), expected) =
    wurzelKompatibilität w1 w2 |> should equal expected

let pflanzenfamiliendaten =
    [ (Pflanzenfamilien.doldenblütler, Pflanzenfamilien.gänsefussgewächs), true
      (Pflanzenfamilien.doldenblütler, Pflanzenfamilien.doldenblütler), false ]
    |> toTheoryData

[<Theory; PropertyData("pflanzenfamiliendaten")>]
let ``Pflanzenfamilienverträglichkeit`` ((pf1: Pflanzenfamilie, pf2: Pflanzenfamilie), expected) =
    pflanzenfamilieKompatibilität pf1 pf2 |> should equal expected
