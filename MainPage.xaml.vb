Partial Public Class MainPage
    Inherits PhoneApplicationPage

    ' Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles Button1.Click
        NavigationService.Navigate(New Uri("/Page1.xaml?msg=", UriKind.Relative))
    End Sub

    Private Sub PhoneApplicationPage_Loaded(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles Button2.Click
        NavigationService.Navigate(New Uri("/Page2.xaml?msg=", UriKind.Relative))
    End Sub
End Class
