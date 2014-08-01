module MischkulturCalculator.Calculator

open Pflanzen

let unverträglichePflanzen =
    set [ set [ tomate; zwiebel ] ]

let verträglichePflanzen =
    set [ set [ basilikum; gurke ] ]

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

