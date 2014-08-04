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
let ``Pflanzenfamilienverträglichkeit`` ((pf1, pf2), expected) =
    pflanzenfamilieKompatibilität pf1 pf2 |> should equal expected

let nährstroffverträglichkeit =
    [ (Nährstoffverbrauch.Mittel, Nährstoffverbrauch.Mittel), false
      (Nährstoffverbrauch.Schwach, Nährstoffverbrauch.Schwach), false
      (Nährstoffverbrauch.Stark, Nährstoffverbrauch.Stark), false
      (Nährstoffverbrauch.Mittel, Nährstoffverbrauch.Schwach), true
      (Nährstoffverbrauch.Schwach, Nährstoffverbrauch.Stark), true
      (Nährstoffverbrauch.Stark, Nährstoffverbrauch.Mittel), true ]
    |> toTheoryData

[<Theory; PropertyData("nährstroffverträglichkeit")>]
let ``Nährstroffverträglichkeit`` ((ns1, ns2), expected) =
    nährstoffverbrauchKompatibilität ns1 ns2 |> should equal expected

let verträglichePflanzen =
    [ (Pflanzen.tomate, Pflanzen.artischoke), false
      (Pflanzen.basilikum, Pflanzen.gurke), true
      (Pflanzen.tomate, Pflanzen.zwiebel), false ]
    |> toTheoryData

[<Theory; PropertyData("verträglichePflanzen")>]
let ``Verträgliche Pflanzen`` ((p1, p2), expected) =
    istBesondersVerträglich p1 p2 |> should equal expected
    
let unverträglichePflanzen =
    [ (Pflanzen.tomate, Pflanzen.artischoke), false
      (Pflanzen.basilikum, Pflanzen.gurke), false
      (Pflanzen.tomate, Pflanzen.zwiebel), true ]
    |> toTheoryData

[<Theory; PropertyData("unverträglichePflanzen")>]
let ``Unverträgliche Pflanzen`` ((p1, p2), expected) =
    istBesondersUnverträglich p1 p2 |> should equal expected
