namespace Tests

open NUnit.Framework
open Alex75.IPChecker

[<TestClass>]
type TestClass () =

    [<SetUp>]
    member this.Setup () =
        ()

    [<Test>]
    member this.Test1 () =

        let data = Main.GetData("")


        Assert.NotNull(data)
