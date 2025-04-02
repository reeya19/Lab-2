type Cuisine =
    | Korean
    | Turkish

type MovieType =
    | Regular
    | IMAX
    | DBOX
    | RegularWithSnacks
    | IMAXWithSnacks
    | DBOXWithSnacks

type Activity =
    | BoardGame
    | Chill
    | Movie of MovieType
    | Restaurant of Cuisine
    | LongDrive of int * float

let calculateBudget activity =
    match activity with
    | BoardGame -> 0
    | Chill -> 0
    | Movie movieType ->
        match movieType with
        | Regular -> 12
        | IMAX -> 17
        | DBOX -> 20
        | RegularWithSnacks -> 12 + 5
        | IMAXWithSnacks -> 17 + 5
        | DBOXWithSnacks -> 20 + 5
    | Restaurant cuisine ->
        match cuisine with
        | Korean -> 70
        | Turkish -> 65
    | LongDrive (km, fuelCostPerKm) -> int (float km * fuelCostPerKm)

// Example Usage
printfn "Board Game Budget: %d CAD" (calculateBudget BoardGame)
printfn "Chill Budget: %d CAD" (calculateBudget Chill)
printfn "Movie (IMAXWithSnacks) Budget: %d CAD" (calculateBudget (Movie IMAXWithSnacks))
printfn "Restaurant (Korean) Budget: %d CAD" (calculateBudget (Restaurant Korean))
printfn "Long Drive (100 km, 1.5 CAD/km) Budget: %d CAD" (calculateBudget (LongDrive (100, 1.5)))
