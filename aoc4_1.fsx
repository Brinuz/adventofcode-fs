let rec isLeftToRight number position =
    if position + 1 >= Array.length number then true
    else if number.[position + 1] >= number.[position] then isLeftToRight number (position + 1)
    else false

let rec hasTwoAdjacent number position =
    if position + 1 >= Array.length number then false
    else if number.[position + 1] <> number.[position] then hasTwoAdjacent number (position + 1)
    else true

let num = 123444 |> string |> Seq.toArray
hasTwoAdjacent num 0

[172851..675869]
|> List.map (string >> Seq.toArray)
|> List.filter (fun e -> isLeftToRight e 0 && hasTwoAdjacent e 0)
|> List.length  