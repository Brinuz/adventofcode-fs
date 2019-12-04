let proc (operation: int[], intprogram: int[]) =
    match operation with
    | [| 1; _; _; _ |] -> intprogram.[operation.[1]] + intprogram.[operation.[2]]
    | [| 2; _; _; _ |] -> intprogram.[operation.[1]] * intprogram.[operation.[2]]
    | _ -> 0

//1,9,10,3,2,3,11,0,99,30,40,50