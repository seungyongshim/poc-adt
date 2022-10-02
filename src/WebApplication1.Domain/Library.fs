namespace WebApplication1.Domain

[<AutoOpen>]
module Domain =
    type Phone = |Phone of string
    type Name = |Name of string
    type TranId = |SendTalk of Phone * Name

    let sample = SendTalk (Phone "xxx", Name "yyy")

[<AutoOpen>]
module Dto =
    type SendTalk = {
        Phone : string
        Name : string
    }
    
    let sample = {
        Phone = "xxx"
        Name = "yyy"
    }
