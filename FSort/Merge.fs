
module Merge

let split (arr : _ array) =
    let n = arr.Length
    arr.[0..n/2-1], arr.[n/2..n-1]

let rec mcount = ref 0
let rec merge (l : 'a array) (r : 'a array) =
    let n = l.Length + r.Length
    let res = Array.zeroCreate<'a> n
    let mutable i, j = 0, 0
    for k = 0 to n-1 do
        mcount:=!mcount+1;
        if i >= l.Length   then res.[k] <- r.[j]; j <- j + 1
        elif j >= r.Length then res.[k] <- l.[i]; i <- i + 1
        elif l.[i] < r.[j] then res.[k] <- l.[i]; i <- i + 1
        else res.[k] <- r.[j]; j <- j + 1
    res

let counted c f  =
    (fun x->
    c:= !c+1;
    f x)

let body mergeSort = function
    | [||]  -> [||]
    | [|a|] -> [|a|] 
    | arr   -> let (x, y) = split arr
               merge (mergeSort x) (mergeSort y)
let rec c = ref 0
let rec sort arr = counted c body sort arr
