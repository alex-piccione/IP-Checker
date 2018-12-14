namespace Tests

open System
open NUnit.Framework
open Alex75.IPChecker



[<TestClass>]
type TestClass () =

    [<SetUp>]
    member __.Setup () =
        ()



    [<Test>]
    member __.Test1 () =

        let data = Main.GetData("1.2.3.4")


        Assert.NotNull(data)
        Assert.AreEqual("1.2.3.4", data.IP)


    [<Test>]
    member __.``Given a null IP an Exception is raised``() =

        let IP = null

        Assert.Throws<ArgumentException>( fun () -> Main.GetData(IP) |> ignore) |> ignore

    [<Test>]
    member __.``Given an empty IP an Exception is raised``() =

        let IP = ""

        Assert.Throws<ArgumentException>( fun () -> Main.GetData(IP) |> ignore) |> ignore