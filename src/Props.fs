namespace Feliz.Clerk

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open System
open System.ComponentModel
open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Feliz


[<Erase>]
type authenticateWithRedirectCallback =
  /// Full URL or path to navigate after successful sign in.
  static member inline afterSignInUrl (value: string) = Interop.mkAttr "afterSignInUrl" (value)
  /// Full URL or path to navigate after successful sign up.
  static member inline afterSignUpUrl (value: string) = Interop.mkAttr "afterSignUpUrl" (value)
  /// Full URL or path to navigate after successful sign in or sign up. This is the same as setting afterSignInUrl and afterSignUpUrl to the same value.
  static member inline redirectUrl (value: string) = Interop.mkAttr "redirectUrl" (value)
  /// Full URL or path to navigate during sign in, if 2FA is enabled.
  static member inline secondFactorUrl (value: string) = Interop.mkAttr "secondFactorUrl" (value)






[<Erase>]
type clerkProvider =
  /// The default URL to use after the user signs in.
  static member inline afterSignInUrl (value: string) = Interop.mkAttr "afterSignInUrl?" (value)
  /// The default URL to use after the user signs up.
  static member inline afterSignUpUrl (value: string) = Interop.mkAttr "afterSignUpUrl?" (value)
  /// Optional array of domains used to validate against the query param of an auth redirect. If no match is made, the redirect is considered unsafe and the default redirect will be used with a warning passed to the console.
  static member inline allowedRedirectOrigins (value: string[]) = Interop.mkAttr "allowedRedirectOrigins?" (value)
  /// Optional array of domains used to validate against the query param of an auth redirect. If no match is made, the redirect is considered unsafe and the default redirect will be used with a warning passed to the console.
  static member inline allowedRedirectOrigins (value: System.Text.RegularExpressions.Regex[]) = Interop.mkAttr "allowedRedirectOrigins?" (value)
  /// Optional object to style your components. Will only affect Clerk Components and not Account Portal pages.
  static member inline appearance (appearance: Appearance) = Interop.mkAttr "appearance?" (!!appearance |> createObj |> unbox<Appearance>)
  /// Define the URL that @clerk/clerk-react should hot-load @clerk/clerk-js from.
  static member inline clerkJSUrl (value: string) = Interop.mkAttr "clerkJSUrl?" (value)
  /// If your web application only uses Control components, you can set this value to headless and load a minimal ClerkJS bundle for optimal page performance.
  static member inline clerkJSVariant (value: string) = Interop.mkAttr "clerkJSVariant?" (value)
  /// Define the npm version for @clerk/clerk-js.
  static member inline clerkJSVersion (value: string) = Interop.mkAttr "clerkJSVersion?" (value)
  /// This option sets the domain of the satellite application. If your application is a satellite application, this option is required.
  static member inline domain (value: string) = Interop.mkAttr "domain?" (value)
  /// This option sets the domain of the satellite application. If your application is a satellite application, this option is required.
  static member inline domain (value: (string -> bool)) = Interop.mkAttr "domain?" (value)
  /// The frontend API host for your instance. This can be found in your Clerk Dashboard on the API Keys page under the Advanced section.
  static member inline frontendApi (value: string) = Interop.mkAttr "frontendApi" (value)
  /// This option defines that the application is a satellite application.
  static member inline isSatellite (value: bool) = Interop.mkAttr "isSatellite?" (value)
  /// This option defines that the application is a satellite application.
  static member inline isSatellite (value: (string -> bool)) = Interop.mkAttr "isSatellite?" (value)
  /// Optional object to localize your components. Will only affect Clerk Components and not Account Portal pages.
  static member inline localization (localization: Localization) = Interop.mkAttr "localization" (!!localization |> createObj |> unbox<Localization>)
  /// A function which takes the destination path as an argument and performs a "push" navigation.
  static member inline navigate (value: (string -> Fable.Core.JS.Promise<'any>)) = Interop.mkAttr "navigate?" (value)
  /// A function which takes the destination path as an argument and performs a "push" navigation.
  static member inline navigate (value: (string -> unit)) = Interop.mkAttr "navigate?" (value)
  /// Clerk publishable key for your instance. This can be found in your Clerk Dashboard on the API Keys page.
  static member inline publishableKey (value: string) = Interop.mkAttr "publishableKey" (value)
  /// This url will be used for any redirects that might happen and needs to point to your primary application. This option is optional for production instances and required for development instances.
  static member inline signInUrl (value: string) = Interop.mkAttr "signInUrl" (value)
  /// Optional support email for display in authentication screens. Will only affect Clerk Components and not Account Portal pages.
  static member inline supportEmail (value: string) = Interop.mkAttr "supportEmail?" (value)


[<Erase>]
type createOrganization =
  /// Full URL or path to navigate after creating a new organization.
  static member inline afterCreateOrganizationUrl (value: string) = Interop.mkAttr "afterCreateOrganizationUrl" (value)
  /// Optional object to style your components. Will only affect Clerk Components and not Account Portal pages.
  static member inline appearance (appearance: Appearance) = Interop.mkAttr "appearance" (!!appearance |> createObj |> unbox<Appearance>)
  /// The path where the component is mounted when path-based routing is used. -e.g. /create-org. This prop is ignored in hash and virtual based routing.
  static member inline path (value: string) = Interop.mkAttr "path" (value)

module createOrganization =

  /// The routing strategy for your pages.
  [<Erase>]
  type routing =
    static member inline hash = Interop.mkAttr "routing" "hash"
    static member inline path = Interop.mkAttr "routing" "path"
    static member inline virtual' = Interop.mkAttr "routing" "virtual"




[<Erase>]
type organization =
  /// A getter boolean to check if the admin of the organization can delete it.
  static member inline adminDeleteEnabled (value: bool) = Interop.mkAttr "adminDeleteEnabled" (value)
  /// Date of the time the organization was created.
  static member inline createdAt (value: DateTime) = Interop.mkAttr "createdAt" (value)
  /// A getter boolean to check if the organization has an uploaded image. Returns false if Clerk is displaying an avatar for the organization.
  static member inline hasImage (value: bool) = Interop.mkAttr "hasImage" (value)
  /// The unique identifier of the related organization.
  static member inline id (value: string) = Interop.mkAttr "id" (value)
  /// Holds the organization logo or default logo.
  static member inline imageUrl (value: string) = Interop.mkAttr "imageUrl" (value)
  /// The number of members the associated organization contains.
  static member inline membersCount (value: int) = Interop.mkAttr "membersCount" (value)
  /// The name of the related organization.
  static member inline name (value: string) = Interop.mkAttr "name" (value)
  /// The number of pending invitations to users to join the organization.
  static member inline pendingInvitationsCount (value: int) = Interop.mkAttr "pendingInvitationsCount" (value)
  /// Additional information about the organization that can be read through the Frontend API, but written only from the Backend API.
  static member inline publicMetadata (value: IReactProperty list) = Interop.mkAttr "publicMetadata" (!!value |> createObj)
  /// Additional information about the organization that can be read through the Frontend API, but written only from the Backend API.
  static member inline publicMetadata (value: obj) = Interop.mkAttr "publicMetadata" (value)
  /// The organization slug. If supplied, it must be unique for the instance.
  static member inline slug (value: string) = Interop.mkAttr "slug" (value)
  /// Date of the last time the user was updated.
  static member inline updatedAt (value: DateTime) = Interop.mkAttr "updatedAt" (value)


[<Erase>]
type organizationList =
  /// Full URL or path to navigate after creating a new organization.
  static member inline afterCreateOrganizationUrl (value: (Organization -> string)) = Interop.mkAttr "afterCreateOrganizationUrl" (value)
  /// Full URL or path to navigate after creating a new organization.
  static member inline afterCreateOrganizationUrl (value: string) = Interop.mkAttr "afterCreateOrganizationUrl" (value)
  /// Full URL or path to navigate after selecting an organization. Defaults to undefined.
  static member inline afterSelectOrganizationUrl (value: (Organization -> string)) = Interop.mkAttr "afterSelectOrganizationUrl" (value)
  /// Full URL or path to navigate after selecting an organization. Defaults to undefined.
  static member inline afterSelectOrganizationUrl (value: string) = Interop.mkAttr "afterSelectOrganizationUrl" (value)
  /// Full URL or path to navigate after selecting the personal account. Defaults to undefined.
  static member inline afterSelectPersonalUrl (value: (Organization -> string)) = Interop.mkAttr "afterSelectPersonalUrl" (value)
  /// Full URL or path to navigate after selecting the personal account. Defaults to undefined.
  static member inline afterSelectPersonalUrl (value: string) = Interop.mkAttr "afterSelectPersonalUrl" (value)
  /// Optional object to style your components. Will only affect Clerk Components and not Account Portal pages.
  static member inline appearance (appearance: Appearance) = Interop.mkAttr "appearance" (!!appearance |> createObj |> unbox<Appearance>)
  /// By default, users can switch between organization and their personal account. This option controls whether <OrganizationList /> will include the users personal account in the organization list. Setting this to false will hide the personal account entry, and users will only be able to switch between organizations.  Defaults to false.
  static member inline hidePersonal (value: bool) = Interop.mkAttr "hidePersonal" (value)
  /// Hides the screen for sending invitations after an organization is created. When left undefined Clerk will automatically hide the screen if the number of max allowed members is equal to 1. Defaults to false.
  static member inline skipInvitationScreen (value: bool) = Interop.mkAttr "skipInvitationScreen" (value)


[<Erase>]
type organizationProfile =
  /// Full URL or path to navigate after leaving an organization.
  static member inline afterLeaveOrganizationUrl (value: string) = Interop.mkAttr "afterLeaveOrganizationUrl" (value)
  /// Optional object to style your components. Will only affect Clerk Components and not Account Portal pages.
  static member inline appearance (appearance: Appearance) = Interop.mkAttr "appearance" (!!appearance |> createObj |> unbox<Appearance>)
  /// The path where the component is mounted when path-based routing is used. -e.g. /create-org. This prop is ignored in hash and virtual based routing.
  static member inline path (value: string) = Interop.mkAttr "path" (value)

module organizationProfile =

  /// The routing strategy for your pages.
  [<Erase>]
  type routing =
    static member inline hash = Interop.mkAttr "routing" "hash"
    static member inline path = Interop.mkAttr "routing" "path"
    static member inline virtual' = Interop.mkAttr "routing" "virtual"


[<Erase>]
type organizationSwitcher =
  /// Full URL or path to navigate after creating a new organization.
  static member inline afterCreateOrganizationUrl (value: string) = Interop.mkAttr "afterCreateOrganizationUrl" (value)
  /// Full URL or path to navigate to after the user leaves the currently active organization.
  static member inline afterLeaveOrganizationUrl (value: string) = Interop.mkAttr "afterLeaveOrganizationUrl" (value)
  /// Full URL or path to navigate after a successful organization switch.
  static member inline afterSwitchOrganizationUrl (value: string) = Interop.mkAttr "afterSwitchOrganizationUrl" (value)
  /// Optional object to style your components. Will only affect Clerk Components and not Account Portal pages.
  static member inline appearance (appearance: Appearance) = Interop.mkAttr "appearance" (!!appearance |> createObj |> unbox<Appearance>)
  /// Full URL or path where the <CreateOrganization /> component is mounted.
  static member inline createOrganizationUrl (value: string) = Interop.mkAttr "createOrganizationUrl" (value)
  /// Controls the default state of the <OrganizationSwitcher /> component.
  static member inline defaultOpen (value: bool) = Interop.mkAttr "defaultOpen" (value)
  /// By default, users can switch between organizations and their personal workspace. This option controls whether <OrganizationSwitcher /> will include the users personal workspace in the organization list. Setting this to true will hide the personal workspace entry, and allow users to switch only between organizations. Defaults to: false.
  static member inline hidePersonal (value: bool) = Interop.mkAttr "hidePersonal" (value)
  /// Specify options for the underlying <OrganizationProfile /> component. e.g. {appearance: {...}}
  static member inline organizationProfileProps (value: IReactProperty list) = Interop.mkAttr "organizationProfileProps" (!!value |> createObj)
  /// Specify options for the underlying <OrganizationProfile /> component. e.g. {appearance: {...}}
  static member inline organizationProfileProps (value: obj) = Interop.mkAttr "organizationProfileProps" (value)
  /// Full URL or path where the <OrganizationProfile /> component is mounted.
  static member inline organizationProfileUrl (value: string) = Interop.mkAttr "organizationProfileUrl" (value)

module organizationSwitcher =

  /// Controls whether clicking the "Create organization" button will cause the <CreateOrganization /> component to open as a modal, or if the browser will navigate to the createOrganizationUrl where <CreateOrganization /> is mounted as a page. Defaults to: modal.
  [<Erase>]
  type createOrganizationMode =
    static member inline modal = Interop.mkAttr "createOrganizationMode" "modal"
    static member inline navigation = Interop.mkAttr "createOrganizationMode" "navigation"

  /// Controls whether clicking the "Manage organization" button will cause the <OrganizationProfile /> component to open as a modal, or if the browser will navigate to the organizationProfileUrl where <OrganizationProfile /> is mounted as a page. Defaults to: modal.
  [<Erase>]
  type organizationProfileMode =
    static member inline modal = Interop.mkAttr "organizationProfileMode" "modal"
    static member inline navigation = Interop.mkAttr "organizationProfileMode" "navigation"


[<Erase>]
type protect =
  /// Optional string corresponding to a Roles Permission in the format org:<resource>:<action>
  static member inline permission (value: string) = Interop.mkAttr "permission?" (value)
  /// Optional string corresponding to an Organizations Role in the format org:<role>
  static member inline role (value: string) = Interop.mkAttr "role?" (value)






[<Erase>]
type redirectToSignIn =
  /// The full URL or path to navigate after a successful sign in.
  static member inline afterSignInUrl (value: string) = Interop.mkAttr "afterSignInUrl" (value)
  /// The full URL or path to navigate after a successful sign up.
  static member inline afterSignUpUrl (value: string) = Interop.mkAttr "afterSignUpUrl" (value)
  /// The values used to prefill the sign-in fields with.
  static member inline initialValues (signInInitialValues: SignInInitialValues) = Interop.mkAttr "initialValues" (!!signInInitialValues |> createObj |> unbox<SignInInitialValues>)
  /// Full URL or path to navigate after successful sign in or sign up.  This is the same as setting afterSignInUrl and afterSignUpUrl to the same value.
  static member inline redirectUrl (value: string) = Interop.mkAttr "redirectUrl" (value)


[<Erase>]
type redirectToSignUp =
  /// The full URL or path to navigate after a successful sign in.
  static member inline afterSignInUrl (value: string) = Interop.mkAttr "afterSignInUrl" (value)
  /// The full URL or path to navigate after a successful sign up.
  static member inline afterSignUpUrl (value: string) = Interop.mkAttr "afterSignUpUrl" (value)
  /// The values used to prefill the sign-up fields with.
  static member inline initialValues (signUpInitialValues: SignUpInitialValues) = Interop.mkAttr "initialValues" (!!signUpInitialValues |> createObj |> unbox<SignUpInitialValues>)
  /// Full URL or path to navigate after successful sign in or sign up.  This is the same as setting afterSignInUrl and afterSignUpUrl to the same value.
  static member inline redirectUrl (value: string) = Interop.mkAttr "redirectUrl" (value)




[<Erase>]
type signIn =
  /// The full URL or path to navigate after a successful sign in.
  static member inline afterSignInUrl (value: string) = Interop.mkAttr "afterSignInUrl" (value)
  /// The full URL or path to navigate after a successful sign up.
  static member inline afterSignUpUrl (value: string) = Interop.mkAttr "afterSignUpUrl" (value)
  /// Optional object to style your components. Will only affect Clerk Components and not Account Portal pages.
  static member inline appearance (appearance: Appearance) = Interop.mkAttr "appearance" (!!appearance |> createObj |> unbox<Appearance>)
  /// The values used to prefill the sign-in fields with.
  static member inline initialValues (signInInitialValues: SignInInitialValues) = Interop.mkAttr "initialValues" (!!signInInitialValues |> createObj |> unbox<SignInInitialValues>)
  /// The path where the component is mounted on when path-based routing is used e.g. /sign-in.
  static member inline path (value: string) = Interop.mkAttr "path" (value)
  /// Full URL or path to navigate after successful sign in or sign up.  The same as setting afterSignInUrl and afterSignUpUrl to the same value.
  static member inline redirectUrl (value: string) = Interop.mkAttr "redirectUrl" (value)
  /// Full URL or path to the sign up page. Use this property to provide the target of the Sign Up link thats rendered.
  static member inline signUpUrl (value: string) = Interop.mkAttr "signUpUrl" (value)

module signIn =

  /// The routing strategy for your pages. Note: If you are using environment variables for Next.js or Remix to specify your routes, this will be set to path.
  [<Erase>]
  type routing =
    static member inline hash = Interop.mkAttr "routing" "hash"
    static member inline path = Interop.mkAttr "routing" "path"
    static member inline virtual' = Interop.mkAttr "routing" "virtual"


[<Erase>]
type signInButton =
  /// The full URL or path to navigate after a successful sign in.
  static member inline afterSignInUrl (value: string) = Interop.mkAttr "afterSignInUrl" (value)
  /// The full URL or path to navigate after a successful sign up.
  static member inline afterSignUpUrl (value: string) = Interop.mkAttr "afterSignUpUrl" (value)
  /// Full URL or path to navigate after successful sign in or sign up.  The same as setting afterSignInUrl and afterSignUpUrl to the same value.
  static member inline redirectUrl (value: string) = Interop.mkAttr "redirectUrl" (value)

module signInButton =

  /// Determines what happens when a user clicks on the <SignInButton>. Setting this to redirect will redirect the user to the sign-in route. Setting this to modal will open a modal on the current route. Defaults to redirect`
  [<Erase>]
  type mode =
    static member inline redirect = Interop.mkAttr "mode" "redirect"
    static member inline modal = Interop.mkAttr "mode" "modal"


[<Erase>]
type signInInitialValues =
  /// The email address of the user.
  static member inline emailAddress (value: string) = Interop.mkAttr "emailAddress?" (value)
  /// The phone number of the user.
  static member inline phoneNumber (value: string) = Interop.mkAttr "phoneNumber?" (value)
  /// The username of the user.
  static member inline username (value: string) = Interop.mkAttr "username?" (value)




[<Erase>]
type signOutButton =
  /// children you want to wrap the <SignOutButton> in.
  static member inline children (value:ReactElement) = Interop.mkAttr "children?" (value)
  /// A promise to handle after the sign out has successfully happened.
  static member inline signOutCallback (value: (unit -> unit)) = Interop.mkAttr "signOutCallback?" (value)
  /// A promise to handle after the sign out has successfully happened.
  static member inline signOutCallback (value: (unit -> Fable.Core.JS.Promise<'any>)) = Interop.mkAttr "signOutCallback?" (value)
  /// Object that has a sessionId property. The sessionId can be passed in to sign out a specific session, which is useful for multisession applications.
  static member inline signOutOptions (signOutOptions: SignOutOptions) = Interop.mkAttr "signOutOptions?" (!!signOutOptions |> createObj |> unbox<SignOutOptions>)


[<Erase>]
type signUp =
  /// The full URL or path to navigate to after a successful sign in.
  static member inline afterSignInUrl (value: string) = Interop.mkAttr "afterSignInUrl" (value)
  /// The full URL or path to navigate after a successful sign up.
  static member inline afterSignUpUrl (value: string) = Interop.mkAttr "afterSignUpUrl" (value)
  /// Optional object to style your components. Will only affect Clerk Components and not Account Portal pages.
  static member inline appearance (appearance: Appearance) = Interop.mkAttr "appearance" (!!appearance |> createObj |> unbox<Appearance>)
  /// The values used to prefill the sign-up fields with.
  static member inline initialValues (signUpInitialValues: SignUpInitialValues) = Interop.mkAttr "initialValues" (!!signUpInitialValues |> createObj |> unbox<SignUpInitialValues>)
  /// The path where the component is mounted on when path-based routing is used e.g. /sign-up.
  static member inline path (value: string) = Interop.mkAttr "path" (value)
  /// Full URL or path to navigate to after successful sign in or sign up. The same as setting afterSignInUrl and afterSignUpUrl to the same value.
  static member inline redirectUrl (value: string) = Interop.mkAttr "redirectUrl" (value)
  /// Full URL or path to the sign in page. Use this property to provide the target of the Sign In link thats rendered.
  static member inline signInUrl (value: string) = Interop.mkAttr "signInUrl" (value)
  /// An object with the key and value for unsafeMetadata that will be saved to the user after sign up. E.g. { "company": "companyID1234" }
  static member inline unsafeMetadata (value: IReactProperty list) = Interop.mkAttr "unsafeMetadata" (!!value |> createObj)
  /// An object with the key and value for unsafeMetadata that will be saved to the user after sign up. E.g. { "company": "companyID1234" }
  static member inline unsafeMetadata (value: obj) = Interop.mkAttr "unsafeMetadata" (value)

module signUp =

  /// The routing strategy for your pages. Note: If you are using environment variables for Next.js or Remix to specify your routes, this will be set to path.
  [<Erase>]
  type routing =
    static member inline hash = Interop.mkAttr "routing" "hash"
    static member inline path = Interop.mkAttr "routing" "path"
    static member inline virtual' = Interop.mkAttr "routing" "virtual"


[<Erase>]
type signUpButton =
  /// The full URL or path to navigate after a successful sign in.
  static member inline afterSignInUrl (value: string) = Interop.mkAttr "afterSignInUrl" (value)
  /// The full URL or path to navigate after a successful sign up.
  static member inline afterSignUpUrl (value: string) = Interop.mkAttr "afterSignUpUrl" (value)
  /// Full URL or path to navigate after successful sign in or sign up.  The same as setting afterSignInUrl and afterSignUpUrl to the same value.
  static member inline redirectUrl (value: string) = Interop.mkAttr "redirectUrl" (value)

module signUpButton =

  /// Determines what happens when a user clicks on the <SignUpButton>. Setting this to redirect will redirect the user to the sign-up route. Setting this to modal will open a modal on the current route. Defaults to redirect`
  [<Erase>]
  type mode =
    static member inline redirect = Interop.mkAttr "mode" "redirect"
    static member inline modal = Interop.mkAttr "mode" "modal"


[<Erase>]
type signUpInitialValues =
  /// The email address of the user.
  static member inline emailAddress (value: string) = Interop.mkAttr "emailAddress?" (value)
  /// The first name of the user.
  static member inline firstName (value: string) = Interop.mkAttr "firstName?" (value)
  /// The last name of the user.
  static member inline lastName (value: string) = Interop.mkAttr "lastName?" (value)
  /// The phone number of the user.
  static member inline phoneNumber (value: string) = Interop.mkAttr "phoneNumber?" (value)
  /// The username of the user.
  static member inline username (value: string) = Interop.mkAttr "username?" (value)






[<Erase>]
type userButton =
  /// The full URL or path to navigate to after a signing out from currently active account (multisession apps).
  static member inline afterMultiSessionSingleSignOutUrl (value: string) = Interop.mkAttr "afterMultiSessionSingleSignOutUrl" (value)
  /// The full URL or path to navigate to after a signing out from all accounts (applies to both single-session and multi-session apps).
  static member inline afterSignOutUrl (value: string) = Interop.mkAttr "afterSignOutUrl" (value)
  /// The full URL or path to navigate to after a successful account change (multi-session apps).
  static member inline afterSwitchSessionUrl (value: string) = Interop.mkAttr "afterSwitchSessionUrl" (value)
  /// Optional object to style your components. Will only affect Clerk Components and not Account Portal pages.
  static member inline appearance (appearance: Appearance) = Interop.mkAttr "appearance" (!!appearance |> createObj |> unbox<Appearance>)
  /// Controls whether the <UserButton /> should open by default during the first render.
  static member inline defaultOpen (value: bool) = Interop.mkAttr "defaultOpen" (value)
  /// Controls if the user name is displayed next to the user image button.
  static member inline showName (value: bool) = Interop.mkAttr "showName" (value)
  /// The full URL or path to navigate to when the "Add another account" button is clicked.
  static member inline signInUrl (value: string) = Interop.mkAttr "signInUrl" (value)
  /// Specify options for the underlying <UserProfile /> component. e.g. {additionalOAuthScopes: {google: [foo, bar], github: [qux]}}.
  static member inline userProfileProps (value: IReactProperty list) = Interop.mkAttr "userProfileProps" (!!value |> createObj)
  /// Specify options for the underlying <UserProfile /> component. e.g. {additionalOAuthScopes: {google: [foo, bar], github: [qux]}}.
  static member inline userProfileProps (value: obj) = Interop.mkAttr "userProfileProps" (value)
  /// The full URL or path leading to the user management interface.
  static member inline userProfileUrl (value: string) = Interop.mkAttr "userProfileUrl" (value)

module userButton =

  /// Controls whether clicking the "Manage your account" button will cause the <UserProfile /> component to open as a modal, or if the browser will navigate to the userProfileUrl where <UserProfile /> is mounted as a page. Defaults to: modal.
  [<Erase>]
  type userProfileMode =
    static member inline modal = Interop.mkAttr "userProfileMode" "modal"
    static member inline navigation = Interop.mkAttr "userProfileMode" "navigation"


[<Erase>]
type userProfile =
  /// Specify additional scopes per OAuth provider that your users would like to provide if not already approved.  e.g. {google: [foo, bar], github: [qux]}.
  static member inline additionalOAuthScopes (value: IReactProperty list) = Interop.mkAttr "additionalOAuthScopes" (!!value |> createObj)
  /// Specify additional scopes per OAuth provider that your users would like to provide if not already approved.  e.g. {google: [foo, bar], github: [qux]}.
  static member inline additionalOAuthScopes (value: obj) = Interop.mkAttr "additionalOAuthScopes" (value)
  /// Optional object to style your components. Will only affect Clerk Components and not Account Portal pages.
  static member inline appearance (appearance: Appearance) = Interop.mkAttr "appearance" (!!appearance |> createObj |> unbox<Appearance>)
  /// The path where the component is mounted on when path-based routing is used e.g. /sign-in.
  static member inline path (value: string) = Interop.mkAttr "path" (value)

module userProfile =

  /// The routing strategy for your pages.
  [<Erase>]
  type routing =
    static member inline hash = Interop.mkAttr "routing" "hash"
    static member inline path = Interop.mkAttr "routing" "path"
    static member inline virtual' = Interop.mkAttr "routing" "virtual"
