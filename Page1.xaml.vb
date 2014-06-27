Partial Public Class Page1
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
        WebBrowser2.Navigate(New Uri("http://www.refer.pt/MenuPrincipal/Passageiros/PartidaseChegadas.aspx", UriKind.Absolute))
    End Sub


End Class
