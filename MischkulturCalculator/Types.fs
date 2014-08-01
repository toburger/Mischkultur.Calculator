namespace MischkulturCalculator

type Wurzel = Tief | Mittel | Flach
type Nährstoffverbrauch = Stark | Mittel | Schwach
type Pflanzenfamilie = Pflanzenfamilie of string
type Pflanze =
    { Name : string
      Wurzel : Wurzel
      Nährstoffverbrauch : Nährstoffverbrauch
      Pflanzenfamilie : Pflanzenfamilie }

type Reihe = int
type Vorgängerkultur = Vorgängerkultur of Pflanze * Reihe
type Nachfolgekultur = Nachfolgekultur of Pflanze * Reihe
