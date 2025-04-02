// Define the Coach record
type Coach = { Name: string; FormerPlayer: bool }

// Define the Stats record
type Stats = { Wins: int; Losses: int }

// Define the Team record
type Team = { Name: string; Coach: Coach; Stats: Stats }

// Create a list of 5 teams
let teams = [
    { Name = "Golden State Warriors"; Coach = { Name = "Steve Kerr"; FormerPlayer = true }; Stats = { Wins = 44; Losses = 38 } }
    { Name = "Boston Celtics"; Coach = { Name = "Joe Mazzulla"; FormerPlayer = false }; Stats = { Wins = 57; Losses = 25 } }
    { Name = "Los Angeles Lakers"; Coach = { Name = "Darvin Ham"; FormerPlayer = true }; Stats = { Wins = 43; Losses = 39 } }
    { Name = "Miami Heat"; Coach = { Name = "Erik Spoelstra"; FormerPlayer = false }; Stats = { Wins = 44; Losses = 38 } }
    { Name = "Milwaukee Bucks"; Coach = { Name = "Adrian Griffin"; FormerPlayer = true }; Stats = { Wins = 58; Losses = 24 } }
]

// Filter successful teams
let successfulTeams = teams |> List.filter (fun team -> team.Stats.Wins > team.Stats.Losses)

// Calculate success percentage
let successPercentages =
    teams
    |> List.map (fun team -> team.Name, (float team.Stats.Wins / float (team.Stats.Wins + team.Stats.Losses)) * 100.0)

// Print results
printfn "Successful Teams:"
successfulTeams |> List.iter (fun team -> printfn "%s" team.Name)

printfn "\nSuccess Percentages:"
successPercentages |> List.iter (fun (name, percentage) -> printfn "%s: %.2f%%" name percentage)
