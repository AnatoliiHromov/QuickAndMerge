module Tests

open System
open Xunit
open Xunit.Abstractions
open System.IO
open Merge
open Quick

let nums1 : 'a list = 
    use sr = new StreamReader @"Arr1.txt" 
    let all = sr.ReadToEnd().Split(' ')
    let all = Array.where (fun x -> x.ToString().Length >0 ) all
    let n= [for a in all ->   LanguagePrimitives.ParseInt32(a) ]
    n
let s1 = List.sort(nums1)
let nums2 : 'a list = 
    use sr = new StreamReader @"Arr2.txt" 
    let all = sr.ReadToEnd().Split(' ')
    let all = Array.where (fun x -> x.ToString().Length >0 ) all
    let n= [for a in all -> LanguagePrimitives.ParseInt32(a)]
    n
let s2 = List.sort(nums2)
let nums3 : 'a list = 
    use sr = new StreamReader @"Arr3.txt" 
    let all = sr.ReadToEnd().Split(' ')
    let all = Array.where (fun x -> x.ToString().Length >0 ) all
    let n= [for a in all -> LanguagePrimitives.ParseInt32(a)]
    n
let s3 = List.sort(nums3)
let nums4 : 'a list = 
    use sr = new StreamReader @"Arr4.txt" 
    let all = sr.ReadToEnd().Split(' ')
    let all = Array.where (fun x -> x.ToString().Length >0 ) all
    let n= [for a in all -> LanguagePrimitives.ParseInt32(a)]
    n
let s4 = List.sort(nums4)
let nums5 : 'a list = 
    use sr = new StreamReader @"Arr5.txt" 
    let all = sr.ReadToEnd().Split(' ')
    let all = Array.where (fun x -> x.ToString().Length >0 ) all
    let n= [for a in all -> LanguagePrimitives.ParseInt32(a)]
    n
let s5 = List.sort(nums5)
    
let anums1 : 'a array = 
    use sr = new StreamReader @"Arr1.txt" 
    let all = sr.ReadToEnd().Split(' ')
    let all = Array.where (fun x -> x.ToString().Length >0 ) all
    let n= [|for a in all -> LanguagePrimitives.ParseInt32(a)|]
    n
let as1 = Array.sort(anums1)
let anums2 : 'a array = 
    use sr = new StreamReader @"Arr2.txt" 
    let all = sr.ReadToEnd().Split(' ')
    let all = Array.where (fun x -> x.ToString().Length >0 ) all
    let n= [|for a in all -> LanguagePrimitives.ParseInt32(a)|]
    n
let as2 = Array.sort(anums2)
let anums3 : 'a array = 
    use sr = new StreamReader @"Arr3.txt" 
    let all = sr.ReadToEnd().Split(' ')
    let all = Array.where (fun x -> x.ToString().Length >0 ) all
    let n= [|for a in all -> LanguagePrimitives.ParseInt32(a)|]
    n
let as3= Array.sort(anums3)
let anums4 : 'a array = 
    use sr = new StreamReader @"Arr4.txt" 
    let all = sr.ReadToEnd().Split(' ')
    let all = Array.where (fun x -> x.ToString().Length >0 ) all
    let n= [|for a in all -> LanguagePrimitives.ParseInt32(a)|]
    n
let as4 = Array.sort(anums4)
let anums5 : 'a array = 
    use sr = new StreamReader @"Arr5.txt" 
    let all = sr.ReadToEnd().Split(' ')
    let all = Array.where (fun x -> x.ToString().Length >0 ) all
    let n= [|for a in all -> LanguagePrimitives.ParseInt32(a)|]
    n
let as5 = Array.sort(anums5)

[<Fact>]
let ``Test1`` () =
    let s = sort anums1 
    Assert.Equal<'a array>(s,as1)

[<Fact>]
let ``Test2`` () =
    let s = sort anums2 
    Assert.Equal<'a array>(s,as2)

[<Fact>]
let ``Test3`` () =
    let s = sort anums3
    Assert.Equal<'a array>(s,as3)

[<Fact>]
let ``Test4`` () =
    let s = sort anums4
    Assert.Equal<'a array>(s,as4)

[<Fact>]
let ``Test5``() =
    let s = sort anums5
    Assert.Equal<'a array>(s,as5)

[<Fact>]
let ``qTest1`` () =
    let s = quicksort nums1    
    Assert.Equal<'a list>(s,s1)

[<Fact>]
let ``qTest2`` () =
    let s = quicksort nums2 
    Assert.Equal<'a list>(s,s2)

[<Fact>]
let ``qTest3`` () =
    let s = quicksort nums3
    Assert.Equal<'a list>(s,s3)

[<Fact>]
let ``qTest4`` () =
    let s = quicksort nums4
    Assert.Equal<'a list>(s,s4)

[<Fact>]
let ``qTest5`` () =
    let s = quicksort nums5
    Assert.Equal<'a list>(s,s5)

