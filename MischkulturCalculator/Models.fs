namespace MischkulturCalculator

module Pflanzenfamilien =

    let liliengewächs = Pflanzenfamilie "Liliengewächs"
    let nachtschattengewächs = Pflanzenfamilie "Nachtschattengewächs"
    let kürbisgewächs = Pflanzenfamilie "Kürbisgewächs"
    let doldenblütler = Pflanzenfamilie "Doldenblütler"
    let korbblütler = Pflanzenfamilie "Korbblütler"
    let kreuzblütler = Pflanzenfamilie "Kreuzblütler"
    let hülsenfrucht = Pflanzenfamilie "Hülsenfrucht"
    let lippenblütler = Pflanzenfamilie "Lippenblütler"
    let gänsefussgewächs = Pflanzenfamilie "Gänsefussgewächs"

module Pflanzen =

    open Pflanzenfamilien

    let tomate =
        { Name = "Tomate"
          Wurzel = Tief
          Nährstoffverbrauch = Stark
          Pflanzenfamilie = nachtschattengewächs }
      
    let paprika =
        { Name = "Paprika"
          Wurzel = Wurzel.Mittel
          Nährstoffverbrauch = Stark
          Pflanzenfamilie = nachtschattengewächs }
      
    let melanzana =
        { Name = "Melanzana"
          Wurzel = Tief
          Nährstoffverbrauch = Stark
          Pflanzenfamilie = nachtschattengewächs }

    let gurke =
        { Name = "Gurke"
          Wurzel = Wurzel.Mittel
          Nährstoffverbrauch = Stark
          Pflanzenfamilie = kürbisgewächs }
      
    let kürbis =
        { Name = "Kürbis"
          Wurzel = Tief
          Nährstoffverbrauch = Stark
          Pflanzenfamilie = kürbisgewächs }

    let melone =
        { Name = "Melone"
          Wurzel = Tief
          Nährstoffverbrauch = Stark
          Pflanzenfamilie = kürbisgewächs }
      
    let zucchini =
        { Name = "Zucchini"
          Wurzel = Wurzel.Mittel
          Nährstoffverbrauch = Stark
          Pflanzenfamilie = kürbisgewächs }

    let basilikum = 
        { Name = "Basilikum"
          Wurzel = Flach
          Nährstoffverbrauch = Mittel
          Pflanzenfamilie = lippenblütler }
      
    let karotte = 
        { Name = "Karotte"
          Wurzel = Wurzel.Mittel
          Nährstoffverbrauch = Mittel
          Pflanzenfamilie = doldenblütler }
           
    let zwiebel =
        { Name = "Zwiebel"
          Wurzel = Wurzel.Flach
          Nährstoffverbrauch = Schwach
          Pflanzenfamilie = liliengewächs }
 
    let knoblauch = 
        { Name = "Knoblauch"
          Wurzel = Wurzel.Flach
          Nährstoffverbrauch = Schwach
          Pflanzenfamilie = liliengewächs }

    let schnittlauch = 
        { Name = "Schnittlauch"
          Wurzel = Wurzel.Flach
          Nährstoffverbrauch = Schwach
          Pflanzenfamilie = liliengewächs }
      
    let erbse = 
        { Name = "Erbse"
          Wurzel = Wurzel.Mittel
          Nährstoffverbrauch = Schwach
          Pflanzenfamilie = hülsenfrucht }
      
    let bohne = 
        { Name = "Bohne"
          Wurzel = Wurzel.Mittel
          Nährstoffverbrauch = Schwach
          Pflanzenfamilie = hülsenfrucht }
      
    let kohl = 
        { Name = "Kohl"
          Wurzel = Wurzel.Mittel
          Nährstoffverbrauch = Stark
          Pflanzenfamilie = kreuzblütler }
      
    let radieschen = 
        { Name = "Radieschen"
          Wurzel = Wurzel.Flach
          Nährstoffverbrauch = Schwach
          Pflanzenfamilie = kreuzblütler }

    let spinat = 
        { Name = "Spinat"
          Wurzel = Wurzel.Flach
          Nährstoffverbrauch = Mittel
          Pflanzenfamilie = gänsefussgewächs }
      
    let mangold = 
        { Name = "Mangold"
          Wurzel = Wurzel.Mittel
          Nährstoffverbrauch = Mittel
          Pflanzenfamilie = gänsefussgewächs }

    let sellerie = 
        { Name = "Sellerie"
          Wurzel = Wurzel.Flach
          Nährstoffverbrauch = Stark
          Pflanzenfamilie = gänsefussgewächs }
           
    let endivie = 
        { Name = "Endivie"
          Wurzel = Wurzel.Flach
          Nährstoffverbrauch = Mittel
          Pflanzenfamilie = korbblütler }

    let lauch = 
        { Name = "Lauch"
          Wurzel = Wurzel.Flach
          Nährstoffverbrauch = Stark
          Pflanzenfamilie = liliengewächs }

    let kopfsalat = 
        { Name = "Kopfsalat"
          Wurzel = Wurzel.Flach
          Nährstoffverbrauch = Mittel
          Pflanzenfamilie = korbblütler }
      
    let petersilie = 
        { Name = "Petersilie"
          Wurzel = Wurzel.Flach
          Nährstoffverbrauch = Mittel
          Pflanzenfamilie = doldenblütler }
      
    let spargel = 
        { Name = "Spargel"
          Wurzel = Wurzel.Tief
          Nährstoffverbrauch = Mittel
          Pflanzenfamilie = liliengewächs }
      
    let artischoke = 
        { Name = "Artischoke"
          Wurzel = Wurzel.Mittel
          Nährstoffverbrauch = Mittel
          Pflanzenfamilie = korbblütler }
      
    let rotebeete = 
        { Name = "Rote Beete"
          Wurzel = Wurzel.Mittel
          Nährstoffverbrauch = Schwach
          Pflanzenfamilie = gänsefussgewächs }

    let unverträglichePflanzen =
        set [ set [ tomate; zwiebel ] ]

    let verträglichePflanzen =
        set [ set [ basilikum; gurke ] ]
