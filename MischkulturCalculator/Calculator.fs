module MischkulturCalculator.Calculator

open Pflanzen

let checkVertäglichkeit ls p1 p2 =
    ls |> Set.exists (Set.isSuperset (set [ p1; p2 ]))

//printfn "%b" <| checkVertäglichkeit verträglichePflanzen tomate gurke
 
let istBesondersUnverträglich =
    checkVertäglichkeit unverträglichePflanzen

let istBesondersVerträglich =
    checkVertäglichkeit verträglichePflanzen

let kombinationen pflanzen =
    [ for p1 in pflanzen do
        for p2 in pflanzen do
            if p1 <> p2
            then yield p1, p2 ]

let wurzel { Wurzel = w } = w
let nährstoffverbrauch { Nährstoffverbrauch = nv } = nv
let pflanzenfamilie { Pflanzenfamilie = pf } = pf

let wurzelKompatibilität w1 w2 =
    match w1, w2 with
    | Wurzel.Tief, Wurzel.Tief -> false
    | Wurzel.Mittel, Wurzel.Mittel -> false
    | Wurzel.Flach, Wurzel.Flach -> false
    | _ -> true


let nährstoffverbrauchKompatibilität n1 n2 =
    match n1, n2 with
    | Nährstoffverbrauch.Stark, Nährstoffverbrauch.Stark -> false
    | Nährstoffverbrauch.Mittel, Nährstoffverbrauch.Mittel -> false
    | Nährstoffverbrauch.Schwach, Nährstoffverbrauch.Schwach -> false
    | _ -> true

let pflanzenfamilieKompatibilität f1 f2 =
    match f1, f2 with
    | Pflanzenfamilie n1, Pflanzenfamilie n2 when n1 = n2 -> false
    | _ -> true
