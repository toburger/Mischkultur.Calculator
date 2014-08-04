namespace MischkulturCalculator

type Wurzel =
    | Tief
    | Mittel
    | Flach
    override self.ToString() = sprintf "%A" self

type Nährstoffverbrauch =
    | Stark
    | Mittel
    | Schwach
    override self.ToString() = sprintf "%A" self

type Pflanzenfamilie =
    | Pflanzenfamilie of string
    override self.ToString() =
        let (Pflanzenfamilie(n)) = self
        sprintf "%s" n

type Pflanze =
    { Name : string
      Wurzel : Wurzel
      Nährstoffverbrauch : Nährstoffverbrauch
      Pflanzenfamilie : Pflanzenfamilie }
    override self.ToString() = self.Name

type Reihe = int

type Vorgängerkultur =
    | Vorgängerkultur of Pflanze * Reihe
    override self.ToString() =
        let (Vorgängerkultur(p, r)) = self
        sprintf "%O, %i" p r

type Nachfolgekultur =
    | Nachfolgekultur of Pflanze * Reihe
    override self.ToString() =
        let (Nachfolgekultur(p, r)) = self
        sprintf "%O, %i" p r
