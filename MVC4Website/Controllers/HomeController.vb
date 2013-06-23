Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Message") = "Navigate through the site from here!"

        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "A small ASP.NET/MVC4 Site made by DeGambler."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Get in touch with me"

        Return View()
    End Function
End Class
