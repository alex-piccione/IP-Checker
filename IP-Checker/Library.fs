module Alex75.IPChecker.Main

open Alex75.IPChecker.Objects
open System



let GetData (ipAddress:string) =

    if ipAddress = null || ipAddress = "" then raise (ArgumentException("IP cannot be null or empty"))

    IPData(ipAddress)