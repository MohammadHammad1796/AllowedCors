Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Http
Imports System.Web.Http.Cors

Public Module WebApiConfig
    Public Sub Register(ByVal config As HttpConfiguration)
        ' Web API configuration and services

        ' Web API routes
        config.MapHttpAttributeRoutes()

#If DEBUG Then
        Dim corsConfig = New EnableCorsAttribute("https://www.youtube.com", "*", "*")
        config.EnableCors(corsConfig)
#End If

        config.Routes.MapHttpRoute(
            name:="DefaultApi",
            routeTemplate:="api/{controller}/{id}",
            defaults:=New With {.id = RouteParameter.Optional}
        )
    End Sub
End Module
