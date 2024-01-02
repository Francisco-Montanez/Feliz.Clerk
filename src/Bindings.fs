namespace Feliz.Clerk

open Fable.Core


type PublishableKey = 
    [<Emit("process.env.CLERK_PUBLISHABLE_KEY")>]
    static member inline CLERK_PUBLISHABLE_KEY : string = jsNative