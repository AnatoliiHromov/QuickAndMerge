module Quick
let qcount = ref 0
let rec quicksort list =
   match list with
   | [] -> []                          
   | firstElem::otherElements ->
        qcount:=!qcount+1;
        let smallerElements =         
            otherElements             
            |> List.filter (fun e -> e < firstElem) 
            |> quicksort 
        qcount:=!qcount+1;
        let largerElements =          
            otherElements 
            |> List.filter (fun e -> e >= firstElem)
            |> quicksort
        List.concat [smallerElements; [firstElem]; largerElements] 

