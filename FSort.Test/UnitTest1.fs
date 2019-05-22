namespace Tests

open System.IO
open NUnit.Framework
open Merge
open Quick

[<TestClass>]
type TestClass () =
    let nums1 : 'a list = 
        use sr = new StreamReader @"Arr1.txt" 
        let all = sr.ReadToEnd().Split(' ')
        let n= [for a in all -> LanguagePrimitives.ParseInt32(a)]
        n
    let s1 = List.sort(nums1)
    let nums2 : 'a list = 
        use sr = new StreamReader @"Arr2.txt" 
        let all = sr.ReadToEnd().Split(' ')
        let n= [for a in all -> LanguagePrimitives.ParseInt32(a)]
        n
    let s2 = List.sort(nums2)
    let nums3 : 'a list = 
        use sr = new StreamReader @"Arr3.txt" 
        let all = sr.ReadToEnd().Split(' ')
        let n= [for a in all -> LanguagePrimitives.ParseInt32(a)]
        n
    let s3 = List.sort(nums3)
    let nums4 : 'a list = 
        use sr = new StreamReader @"Arr4.txt" 
        let all = sr.ReadToEnd().Split(' ')
        let n= [for a in all -> LanguagePrimitives.ParseInt32(a)]
        n
    let s4 = List.sort(nums4)
    let nums5 : 'a list = 
        use sr = new StreamReader @"Arr5.txt" 
        let all = sr.ReadToEnd().Split(' ')
        let n= [for a in all -> LanguagePrimitives.ParseInt32(a)]
        n
    let s5 = List.sort(nums5)
        
    let anums1 : 'a array = 
        use sr = new StreamReader @"Arr1.txt" 
        let all = sr.ReadToEnd().Split(' ')
        let n= [|for a in all -> LanguagePrimitives.ParseInt32(a)|]
        n
    let as1 = Array.sort(anums1)
    let anums2 : 'a array = 
        use sr = new StreamReader @"Arr2.txt" 
        let all = sr.ReadToEnd().Split(' ')
        let n= [|for a in all -> LanguagePrimitives.ParseInt32(a)|]
        n
    let as2 = Array.sort(anums2)
    let anums3 : 'a array = 
        use sr = new StreamReader @"Arr3.txt" 
        let all = sr.ReadToEnd().Split(' ')
        let n= [|for a in all -> LanguagePrimitives.ParseInt32(a)|]
        n
    let as3= Array.sort(anums3)
    let anums4 : 'a array = 
        use sr = new StreamReader @"Arr4.txt" 
        let all = sr.ReadToEnd().Split(' ')
        let n= [|for a in all -> LanguagePrimitives.ParseInt32(a)|]
        n
    let as4 = Array.sort(anums4)
    let anums5 : 'a array = 
        use sr = new StreamReader @"Arr5.txt" 
        let all = sr.ReadToEnd().Split(' ')
        let n= [|for a in all -> LanguagePrimitives.ParseInt32(a)|]
        n
    let as5 = Array.sort(anums5)

    [<Test>]
    member this.Test1 () =
        let s = sort anums1
        printf "%d" !mcount
        Assert.AreEqual(s,as1)

    [<Test>]
    member this.Test2 () =
        let s = sort anums2
        printf "%d" !mcount
        Assert.AreEqual(s,as2)

    [<Test>]
    member this.Test3 () =
        let s = sort anums3
        printf "%d" !mcount
        Assert.AreEqual(s,as3)

    [<Test>]
    member this.Test4 () =
        let s = sort anums4
        printf "%d" !mcount
        Assert.AreEqual(s,as4)

    [<Test>]
    member this.Test5 () =
        let s = sort anums5
        printf "%d" !mcount
        Assert.AreEqual(s,as5)

    [<Test>]
    member this.qTest1 () =
        let s = quicksort nums1
        printf "%d" !mcount
        Assert.AreEqual(s,s1)

    [<Test>]
    member this.qTest2 () =
        let s = quicksort nums2
        printf "%d" !mcount
        Assert.AreEqual(s,s2)

    [<Test>]
    member this.qTest3 () =
        let s = quicksort nums3
        printf "%d" !mcount
        Assert.AreEqual(s,s3)

    [<Test>]
    member this.qTest4 () =
        let s = quicksort nums4
        printf "%d" !mcount
        Assert.AreEqual(s,s4)

    [<Test>]
    member this.qTest5 () =
        let s = quicksort nums5
        printf "%d" !mcount
        Assert.AreEqual(s,s5)