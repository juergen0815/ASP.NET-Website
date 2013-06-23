Imports Microsoft.Web.WebPages.OAuth

Public Class AuthConfig
    Public Shared Sub RegisterAuth()
        ' To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
        ' you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

        ' OAuthWebSecurity.RegisterMicrosoftClient(
        '     clientId:="",
        '     clientSecret:="")

        OAuthWebSecurity.RegisterTwitterClient(
            consumerKey:="ao1yAl8zcNAKVqu5fJYuQ",
            consumerSecret:="v7Uurdq7bspow0VjgZcHOJb3u8NOEnXxJ1BNrMdNhM")

        OAuthWebSecurity.RegisterFacebookClient(
            appId:="550326008338942",
            appSecret:="33b8812afc1f67989502a250fd9054f0")

        ' OAuthWebSecurity.RegisterGoogleClient()
    End Sub
End Class