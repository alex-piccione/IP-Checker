module Alex75.IPChecker.Main

open System
open Flurl.Http

open Alex75.IPChecker.Objects






// http://ip-api.com/docs/api:json

let data_from_ip_api_com(ip) =

    let url = ""
    let result = url.GetJsonAsync().Result


    IPData(ip)
    


let GetData (ipAddress:string) =

    if ipAddress = null || ipAddress = "" then raise (ArgumentException("IP cannot be null or empty"))

    IPData(ipAddress)