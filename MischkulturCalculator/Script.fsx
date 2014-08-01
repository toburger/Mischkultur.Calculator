#load "Types.fs"
#load "Models.fs"
#load "Calculator.fs"

open MischkulturCalculator
open Pflanzen
open Calculator

let kombinationen pflanzen =
    [ for p1 in pflanzen do
        for p2 in pflanzen do
            if p1 <> p2
            then yield p1, p2 ]

module Tuple =
    let map f (t1, t2) =
        f t1, f t2

    let sort (t1, t2) =
        if t1 < t2 then t1, t2
        else t2, t1

let (|>>) f1 f2 arg =
    f1 arg ||> f2

let score b = if b then 0 else 1

let kombis = 
    [ tomate; paprika; melanzana; gurke; kürbis; melone; zucchini; basilikum; karotte; zwiebel; knoblauch;schnittlauch; erbse; bohne; kohl; radieschen; spinat; mangold; sellerie; endivie; lauch; kopfsalat; petersilie; spargel; artischoke; rotebeete ]
    |> kombinationen
    |> List.map Tuple.sort

let apply m f = Tuple.map m |>> f
let applyNot m f = apply m f >> not

let combineAnd checks x =
    List.fold (fun s c -> s && c x) true checks

let weight weights x =
    List.fold (fun s w -> w x + s) 0 weights

// Ergebnis basierend auf den Berechnungen, welche Pflanzen miteinander verträglich sind
let kompatKombis checks weights =
    kombis
    |> List.filter (combineAnd checks)
    |> List.sortBy (weight weights)
    
let checks = 
    [ apply    wurzel             wurzelKompatibilität
      apply    nährstoffverbrauch nährstoffverbrauchKompatibilität
      apply    pflanzenfamilie    pflanzenfamilieKompatibilität
      applyNot id                 istBesondersUnverträglich ]
let weights = [ apply id istBesondersVerträglich >> score ]

let combineOr checks x =
    List.fold (fun s c -> s || c x) false checks

let negate x = -x

// Ergebnis basierend auf den Berechnungen, welche Pflanzen miteinander NICHT verträglich sind
let notKompatKombis checks weights =
    kombis
    |> List.filter (combineOr checks)
    |> List.sortBy (weight weights >> negate)

let badchecks =
    [ applyNot wurzel             wurzelKompatibilität
      applyNot nährstoffverbrauch nährstoffverbrauchKompatibilität
      applyNot pflanzenfamilie    pflanzenfamilieKompatibilität
      apply    id                 istBesondersUnverträglich ]
let badweights = [ apply id istBesondersVerträglich >> score ]

