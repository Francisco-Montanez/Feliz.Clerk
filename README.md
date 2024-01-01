# Feliz.Clerk

A Fable binding library for [Clerk](https://clerk.com/), a user authentication and management platform. It provides a set of F# bindings that allow you to use Clerk components in a type-safe manner within your Fable applications.


## Installation

To install Feliz.Clerk, you can use the following command:

```dotnetcli
dotnet add package Feliz.Clerk
```


## Usage

Once installed, you can use the Clerk components in your Fable application. In order for the Clerk components to work, you need your **CLERK_PUBLISHABLE_KEY**. You can find this key in your Clerk dashboard. Once you have the key, you can use it to initialize Clerk in your application.

I use the following setup in *vite.config.ts*:

```typescript
import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'
import dotenv from 'dotenv';

dotenv.config();

/** @type {import('vite').UserConfig} */
export default defineConfig({
    plugins: [react({ jsxRuntime: 'classic'})], // jsxRuntime: 'classic' is required for fast-refresh for .js files
    root: "./src/Priv.Client",
    server: {
        port: 8080,
        proxy: {
            '/api': 'http://localhost:5000',
        }
    },
    build: {
        outDir:"../../publish/app/public"
    },
    define: {
        'process.env.CLERK_PUBLISHABLE_KEY': JSON.stringify(process.env.VITE_CLERK_PUBLISHABLE_KEY)
    }
})

```

*.env* in the root of my project:

```dotenv
VITE_CLERK_PUBLISHABLE_KEY=XXXXXXXX <--- your publishable key here
```

and this is how to use it in your Fable application:

```fsharp
open Feliz.Clerk

let clerkProvider (children: ReactElement seq) =
    Clerk.clerkProvider [
        clerkProvider.publishableKey Clerk.CLERK_PUBLISHABLE_KEY
        prop.children children
    ]
```

I attempt to follow the Clerk documentation found [here](https://clerk.com/docs/quickstarts/react)

## Customization

Feliz.Clerk supports some of the customization options provided by Clerk. You can customize the appearance of Clerk components, add or update localizations, and more. For more details, refer to the official Clerk documentation.


```fsharp
open Feliz.Clerk

let clerkProvider (children: ReactElement seq) =
    Clerk.clerkProvider [
        clerkProvider.publishableKey Clerk.CLERK_PUBLISHABLE_KEY
        clerkProvider.localization.enUS
        clerkProvider.theme.dark
        prop.children children
    ]
```

## Example

```fsharp
module Client.View

open Feliz
open Router
open Elmish
open Feliz.UseElmish

type private Msg =
    | UrlChanged of Page

type private State = {
    Page : Page
}

let private init () =
    let nextPage = Router.currentPath() |> Page.parseFromUrlSegments
    { Page = nextPage }, Cmd.navigatePage nextPage

let private update (msg:Msg) (state:State) : State * Cmd<Msg> =
    match msg with
    | UrlChanged page -> { state with Page = page }, Cmd.none



open FS.FluentUI
open Feliz.Clerk

module AppView =

    let navigation =
        Html.div [
            Html.a("Home", Page.Index)
            Html.span " | "
            Html.a("SignIn", Page.SignIn)
            Html.span " | "
            Html.a("SignUp", Page.SignUp)
            Html.span " | "
            Html.a("About", Page.About)
        ]

    let clerkProvider (children: ReactElement seq) =
        Clerk.clerkProvider [
            clerkProvider.publishableKey Clerk.CLERK_PUBLISHABLE_KEY
            prop.children children
        ]

    let fluentProvider (children: ReactElement seq) =
        Fui.fluentProvider [
            fluentProvider.theme.teamsLightTheme
            fluentProvider.children children
        ]

open AppView

[<ReactComponent>]
let AppView () =
    let state,dispatch = React.useElmish(init, update)

    let render =
        match state.Page with
        | Page.SignIn -> Clerk.signIn []
        | Page.SignUp -> Clerk.signUp []
        | Page.Index -> Pages.Index.IndexView ()
        | Page.About -> Html.text "learn more about us"

    let reactRouter (children: ReactElement list) =
        React.router [
            router.pathMode
            router.onUrlChanged (Page.parseFromUrlSegments >> UrlChanged >> dispatch)
            router.children children
        ]

    fluentProvider [
        clerkProvider [
            reactRouter [
                navigation
                render
            ]
        ]
    ]

```

## Support

If you encounter any issues or have questions, feel free to open an issue on the GitHub repository. I do this for fun, so I can't guarantee a quick or helpful response, but I'll do my best to help you out.


## Known Issues

- [ ] Using Fable version > 4.5.0 causes a runtime error due to the router looking for fable-library 4.5.0.