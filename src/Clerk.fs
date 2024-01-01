namespace Feliz.Clerk

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open System.ComponentModel
open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]
module ClerkHelpers =

  open Fable.React

  let reactElement (el: ReactElementType) (props: 'a) : ReactElement =
    import "createElement" "react"

  let reactElementTag (tag: string) (props: 'a) : ReactElement =
    import "createElement" "react"

  let createElement (el: ReactElementType) (properties: IReactProperty seq) : ReactElement =
    reactElement el (createObj !!properties)

  let createElementTag (tag: string) (properties: IReactProperty seq) : ReactElement =
    reactElementTag tag (createObj !!properties)

type Appearance = IReactProperty list
type Localization = IReactProperty list
type Organization = IReactProperty list
type SignInInitialValues = IReactProperty list
type SignOutOptions = IReactProperty list
type SignUpInitialValues = IReactProperty list

[<Erase>]
type Clerk =

  /// The <AuthenticateWithRedirectCallback /> is used to complete a custom OAuth flow. Simply render the component under the route you passed as redirectUrl to the authenticateWithRedirect methods.
  ///
  /// Required props:
  ///   - `afterSignInUrl`
  ///   - `afterSignUpUrl`
  ///   - `redirectUrl`
  ///   - `secondFactorUrl`
  static member inline authenticateWithRedirectCallback props = createElement (import "AuthenticateWithRedirectCallback " "@clerk/clerk-react") props

  /// The <ClerkLoaded /> component guarantees that the Clerk object has loaded and will be available under window.Clerk. This allows you to wrap child components to access the Clerk object without the need to check it exists.
  static member inline clerkLoaded props = createElement (import "ClerkLoaded " "@clerk/clerk-react") props

  /// The <ClerkLoading /> renders its children while Clerk is loading, and is helpful for showing a custom loading state.
  static member inline clerkLoading props = createElement (import "ClerkLoading " "@clerk/clerk-react") props

  /// The <ClerkProvider /> component wraps your React application to provide active session and user context to Clerks hooks and other components.
  /// The <ClerkProvider /> component must be added to your React entrypoint.
  ///
  /// Required props:
  ///   - `frontendApi`
  ///   - `publishableKey`
  ///   - `signInUrl`
  static member inline clerkProvider props = createElement (import "ClerkProvider " "@clerk/clerk-react") props

  /// The <CreateOrganization /> component is used to render an organization creation UI that allows users to create brand new organizations within your application.
  /// All props below are optional.
  /// To learn about how to customize Clerk components, see the customization documentation.
  ///
  /// Required props:
  ///   - `afterCreateOrganizationUrl`
  ///   - `path`
  ///   - `routing`
  static member inline createOrganization props = createElement (import "CreateOrganization " "@clerk/clerk-react") props

  /// The <MultisessionAppSupport /> provides a wrapper for your React application that guarantees a full rerendering cycle everytime the current session and user changes.
  static member inline multisessionAppSupport props = createElement (import "MultisessionAppSupport " "@clerk/clerk-react") props

  /// This is a class that represents an organization. Its returned from the .css-u8jhe2{color:var(--secondaryBlue);}.css-u8jhe2 code{color:var(--tertiaryBlue);}createOrganization and getOrganization methods on the Clerk class instance.
  /// Updates an organizations attributes.
  /// Deletes the organization. Only administrators can delete an organization.
  /// Please note that deleting an organization will also delete all memberships and invitations. This is not reversible.
  /// Sets or replaces an organizations logo. Accept the logo as a file or blob. The logo must be an image and its size cannot exceed 10MB.
  /// In addition to the methods listed above, the Organization class also has the following methods:
  ///
  /// Required props:
  ///   - `adminDeleteEnabled`
  ///   - `createdAt`
  ///   - `hasImage`
  ///   - `id`
  ///   - `imageUrl`
  ///   - `membersCount`
  ///   - `name`
  ///   - `pendingInvitationsCount`
  ///   - `publicMetadata`
  ///   - `updatedAt`
  static member inline organization props = createElement (import "Organization" "@clerk/clerk-react") props

  /// The <OrganizationList /> component is used to display organization related memberships, invitations, and suggestions for the user.
  /// If you would like to prohibit people from using their personal accounts and force them to be part of an organization, the hidePersonal property forces your user to join or create an organization in order to continue.
  /// All props below are optional.
  /// To learn about how to customize Clerk components, see the customization documentation.
  ///
  /// Required props:
  ///   - `afterCreateOrganizationUrl`
  ///   - `afterSelectOrganizationUrl`
  ///   - `afterSelectPersonalUrl`
  ///   - `hidePersonal`
  static member inline organizationList props = createElement (import "OrganizationList " "@clerk/clerk-react") props

  /// The <OrganizationProfile /> component is used to render a beautiful, full-featured organization management UI that allows users to manage their organization profile and security settings.
  /// All props below are optional.
  /// To learn about how to customize Clerk components, see the customization documentation.
  /// In addition, you also can add custom pages and links. For more information, refer to the Custom Pages documentation.
  ///
  /// Required props:
  ///   - `afterLeaveOrganizationUrl`
  ///   - `path`
  ///   - `routing`
  static member inline organizationProfile props = createElement (import "OrganizationProfile " "@clerk/clerk-react") props

  /// The .css-u8jhe2{color:var(--secondaryBlue);}.css-u8jhe2 code{color:var(--tertiaryBlue);}<OrganizationSwitcher /> component is used to enable the ability to switch between available organizations the user may be part of in your application.
  /// All props below are optional.
  /// To learn about how to customize Clerk components, see the customization documentation.
  ///
  /// Required props:
  ///   - `afterCreateOrganizationUrl`
  ///   - `afterLeaveOrganizationUrl`
  ///   - `afterSwitchOrganizationUrl`
  ///   - `createOrganizationMode`
  ///   - `createOrganizationUrl`
  ///   - `defaultOpen`
  ///   - `hidePersonal`
  ///   - `organizationProfileMode`
  ///   - `organizationProfileProps`
  ///   - `organizationProfileUrl`
  static member inline organizationSwitcher props = createElement (import "OrganizationSwitcher " "@clerk/clerk-react") props

  /// The <RedirectToCreateOrganization /> component will navigate to the create organization flow which has been configured in your application instance. The behavior will be just like a server-side (3xx) redirect, and will override the current location in the history stack.
  static member inline redirectToCreateOrganization props = createElement (import "RedirectToCreateOrganization " "@clerk/clerk-react") props

  /// The <RedirectToOrganizationProfile /> component will navigate to the organization profile URL which has been configured in your application instance. The behavior will be just like a server-side (3xx) redirect, and will override the current location in the history stack.
  static member inline redirectToOrganizationProfile props = createElement (import "RedirectToOrganizationProfile " "@clerk/clerk-react") props

  /// The <RedirectToSignIn /> component will navigate to the sign in URL which has been configured in your application instance. The behavior will be just like a server-side (3xx) redirect, and will override the current location in the history stack.
  ///
  /// Required props:
  ///   - `afterSignInUrl`
  ///   - `afterSignUpUrl`
  ///   - `initialValues`
  ///   - `redirectUrl`
  static member inline redirectToSignIn props = createElement (import "RedirectToSignIn " "@clerk/clerk-react") props

  /// The <RedirectToSignUp /> component will navigate to the sign up URL which has been configured in your application instance. The behavior will be just like a server-side (3xx) redirect, and will override the current location in the history stack.
  ///
  /// Required props:
  ///   - `afterSignInUrl`
  ///   - `afterSignUpUrl`
  ///   - `initialValues`
  ///   - `redirectUrl`
  static member inline redirectToSignUp props = createElement (import "RedirectToSignUp " "@clerk/clerk-react") props

  /// The <SignIn /> component renders a UI for signing in users. The functionality of the <SignIn /> component is controlled by the instance settings you specify in your .css-u8jhe2{color:var(--secondaryBlue);}.css-u8jhe2 code{color:var(--tertiaryBlue);}Clerk Dashboard. You can further customize your <SignIn /> component by passing additional properties at the time of rendering.
  /// Below is basic implementation of the <SignIn /> component. You can use this as a starting point for your own implementation.
  /// All props below are optional.
  /// To learn about how to customize Clerk components, see the customization documentation.
  ///
  /// Required props:
  ///   - `afterSignInUrl`
  ///   - `afterSignUpUrl`
  ///   - `initialValues`
  ///   - `path`
  ///   - `redirectUrl`
  ///   - `routing`
  ///   - `signUpUrl`
  static member inline signIn props = createElement (import "SignIn " "@clerk/clerk-react") props

  /// The <SignInButton /> component is a button that links to the sign-in page or displays the sign-in modal.
  /// In some cases you will want to use your own button, or button text. You can do that by wrapping your button up.
  ///
  /// Required props:
  ///   - `afterSignInUrl`
  ///   - `afterSignUpUrl`
  ///   - `mode`
  ///   - `redirectUrl`
  static member inline signInButton props = createElement (import "SignInButton " "@clerk/clerk-react") props

  /// The type for the initialValues prop that is used to pre-populate the sign-in form.
  static member inline signInInitialValues props = createElement (import "SignInInitialValues" "@clerk/clerk-react") props

  /// The <SignInWithMetamaskButton /> component is used to complete a one-click, cryptographically-secure login flow using MetaMask.
  /// In some cases you will want to use your own button, or button text. You can do that by wrapping your button up.
  static member inline signInWithMetamaskButton props = createElement (import "SignInWithMetamaskButton " "@clerk/clerk-react") props

  /// The <SignOutButton /> component is a button that signs a user out. By default, it is a <button> tag that says Sign Out, but it is completely customizable by passing children.
  /// The example below shows how to use the <SignOutButton /> component.
  /// You can create a custom button by wrapping your own button, or button text, in the <SignOutButton /> component.
  /// You can sign out of a specific session by passing in a sessionId to the signOutOptions prop. This is useful for signing a single account out of a multi-session (multiple account) application.
  /// In the example below, the sessionId is retrieved from the .css-u8jhe2{color:var(--secondaryBlue);}.css-u8jhe2 code{color:var(--tertiaryBlue);}useAuth() hook.
  /// You can sign out of all currently active sessions by passing a callback that returns the signOut() method to the signOutCallback prop. This is useful for signing out all currently active accounts from a multi-session (multiple account) application.
  /// In the example below, the signOut() method is retrieved from the useClerk() hook.
  static member inline signOutButton props = createElement (import "SignOutButton " "@clerk/clerk-react") props

  /// The <SignUp /> component renders a UI for signing up users. The functionality of the <SignUp /> component is controlled by the instance settings you specify in your .css-u8jhe2{color:var(--secondaryBlue);}.css-u8jhe2 code{color:var(--tertiaryBlue);}Clerk Dashboard. You can further customize your <SignUp /> component by passing additional properties at the time of rendering.
  /// Below is basic implementation of the <SignUp /> component. You can use this as a starting point for your own implementation
  /// All props below are optional.
  /// To learn about how to customize Clerk components, see the customization documentation.
  ///
  /// Required props:
  ///   - `afterSignInUrl`
  ///   - `afterSignUpUrl`
  ///   - `initialValues`
  ///   - `path`
  ///   - `redirectUrl`
  ///   - `routing`
  ///   - `signInUrl`
  ///   - `unsafeMetadata`
  static member inline signUp props = createElement (import "SignUp " "@clerk/clerk-react") props

  /// The <SignUpButton /> component is a button that links to the sign-up page or displays the sign-up modal.
  /// In some cases you will want to use your own button, or button text. You can do that by wrapping your button up.
  ///
  /// Required props:
  ///   - `afterSignInUrl`
  ///   - `afterSignUpUrl`
  ///   - `mode`
  ///   - `redirectUrl`
  static member inline signUpButton props = createElement (import "SignUpButton " "@clerk/clerk-react") props

  /// The type for the initialValues prop that is used to pre-populate the sign-up form.
  static member inline signUpInitialValues props = createElement (import "SignUpInitialValues" "@clerk/clerk-react") props

  /// The <SignedIn /> component offers authentication checks as a cross-cutting concern. Any children components wrapped by a <SignedIn /> component will be rendered only if theres a User with an active Session signed in your application.
  /// Below is an example of how to use <SignedIn /> with React Router. The <SignedIn /> component can be used as a child of a <Route /> component to render content only to signed in users.
  static member inline signedIn props = createElement (import "SignedIn " "@clerk/clerk-react") props

  /// The <SignedOut /> component offers authentication checks as a cross-cutting concern. Any child nodes wrapped by a <SignedOut /> component will be rendered only if theres no User signed in to your application.
  static member inline signedOut props = createElement (import "SignedOut " "@clerk/clerk-react") props

  /// The <UserButton /> component is used to render the familiar user button UI popularized by Google.
  /// Clerk is the only provider with multi-session support, allowing users to sign into multiple accounts at once and switch between them. For multisession apps, the <UserButton /> automatically supports instant account switching, without the need of a full page reload. For more information, you can check out the .css-u8jhe2{color:var(--secondaryBlue);}.css-u8jhe2 code{color:var(--tertiaryBlue);}Multi-session applications guide.
  /// In this example, <UserButton /> is mounted inside a header component, which is a common pattern on many websites and applications. When the user is signed in, they will see their avatar and be able to open the popup menu.
  /// All props below are optional.
  /// To learn about how to customize Clerk components, see the customization documentation.
  ///
  /// Required props:
  ///   - `afterMultiSessionSingleSignOutUrl`
  ///   - `afterSignOutUrl`
  ///   - `afterSwitchSessionUrl`
  ///   - `defaultOpen`
  ///   - `showName`
  ///   - `signInUrl`
  ///   - `userProfileMode`
  ///   - `userProfileProps`
  ///   - `userProfileUrl`
  static member inline userButton props = createElement (import "UserButton " "@clerk/clerk-react") props

  /// The <UserProfile /> component is used to render a beautiful, full-featured account management UI that allows users to manage their profile and security settings.
  /// All props below are optional.
  /// To learn about how to customize Clerk components, see the customization documentation.
  /// In addition, you also can add custom pages and links. For more information, refer to the Custom Pages documentation.
  ///
  /// Required props:
  ///   - `additionalOAuthScopes`
  ///   - `path`
  ///   - `routing`
  static member inline userProfile props = createElement (import "UserProfile " "@clerk/clerk-react") props
