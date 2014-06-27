Partial Public Class Page2
    Inherits PhoneApplicationPage
    ' DECLARACAO DE VARIAVEIS '
    Private Function CarregaListBox1()
        Dim estacoesdeorigemarray(0 To 37) As String
        Dim horasarray(0 To 20) As String
        Dim minutosarray(0 To 3) As String
        Dim pronto As Integer
        estacoesdeorigemarray(0) = "Azambuja"
        estacoesdeorigemarray(1) = "Espadanal da Azambuja"
        estacoesdeorigemarray(2) = "Vila Nova da Rainha"
        estacoesdeorigemarray(3) = "Carregado"
        estacoesdeorigemarray(4) = "Castanheira do Ribatejo"
        estacoesdeorigemarray(5) = "Vila Franca de Xira"
        estacoesdeorigemarray(6) = "Alhandra"
        estacoesdeorigemarray(7) = "Alverca"
        estacoesdeorigemarray(8) = "Póvoa"
        estacoesdeorigemarray(9) = "Santa Iria"
        estacoesdeorigemarray(10) = "Bobadela"
        estacoesdeorigemarray(11) = "Sacavém"
        estacoesdeorigemarray(12) = "Moscavide"
        estacoesdeorigemarray(13) = "Oriente"
        estacoesdeorigemarray(14) = "Braço de Prata"
        estacoesdeorigemarray(15) = "Santa Apolónia"
        estacoesdeorigemarray(16) = "Marvila"
        estacoesdeorigemarray(17) = "Chelas"
        estacoesdeorigemarray(18) = "Roma - Areeiro"
        estacoesdeorigemarray(19) = "Entrecampos"
        estacoesdeorigemarray(20) = "Sete Rios"
        estacoesdeorigemarray(21) = "Rossio"
        estacoesdeorigemarray(22) = "Campolide"
        estacoesdeorigemarray(23) = "Alcântara - Terra"
        estacoesdeorigemarray(24) = "Benfica"
        estacoesdeorigemarray(25) = "Sta. Cruz / Damaia"
        estacoesdeorigemarray(26) = "Reboleira"
        estacoesdeorigemarray(27) = "Amadora"
        estacoesdeorigemarray(28) = "Queluz - Belas"
        estacoesdeorigemarray(29) = "Monte Abraão"
        estacoesdeorigemarray(30) = "Massamá - Barcarena"
        estacoesdeorigemarray(31) = "Cacém"
        estacoesdeorigemarray(32) = "Mira Sintra - Meleças"
        estacoesdeorigemarray(33) = "Rio de Mouro"
        estacoesdeorigemarray(34) = "Mercês"
        estacoesdeorigemarray(35) = "Algueirão"
        estacoesdeorigemarray(36) = "Portela"
        estacoesdeorigemarray(37) = "Sintra"

        horasarray(0) = "0"
        horasarray(1) = "1"
        horasarray(2) = "2"
        horasarray(3) = "6"
        horasarray(4) = "7"
        horasarray(5) = "8"
        horasarray(6) = "9"
        horasarray(7) = "10"
        horasarray(8) = "11"
        horasarray(9) = "12"
        horasarray(10) = "13"
        horasarray(11) = "14"
        horasarray(12) = "15"
        horasarray(13) = "16"
        horasarray(14) = "17"
        horasarray(15) = "18"
        horasarray(16) = "19"
        horasarray(17) = "20"
        horasarray(18) = "21"
        horasarray(19) = "22"
        horasarray(20) = "23"

        minutosarray(0) = "00"
        minutosarray(1) = "15"
        minutosarray(2) = "30"
        minutosarray(3) = "45"

        Dim intCount As Integer
        For intCount = 0 To (37)
            ListBox1.Items.Add(estacoesdeorigemarray(intCount))
        Next intCount

        For intCount = 0 To (37)
            ListBox2.Items.Add(estacoesdeorigemarray(intCount))
        Next intCount

        For intCount = 0 To (20)
            ListBox3.Items.Add(horasarray(intCount))
        Next intCount

        For intCount = 0 To (3)
            ListBox4.Items.Add(minutosarray(intCount))
        Next intCount

        Return pronto
    End Function

    Public Sub New()
        InitializeComponent()
        ListBox1.Visibility = Windows.Visibility.Collapsed
        ListBox2.Visibility = Windows.Visibility.Collapsed
        ListBox3.Visibility = Windows.Visibility.Collapsed
        ListBox4.Visibility = Windows.Visibility.Collapsed
        Call CarregaListBox1()
        If ListBox3.SelectedItem !=  Then

        End If
        'ListBox1.Items.Add("Azambuja")'

    End Sub

    Private Sub ListBox1_SelectionChanged(sender As System.Object, e As System.Windows.Controls.SelectionChangedEventArgs) Handles ListBox1.SelectionChanged

        TextBox1.Text = ListBox1.SelectedItem
        ListBox1.Visibility = Windows.Visibility.Collapsed       ' LISTA DA ORIGEM'
        TextBox1.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub TextBox1_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles TextBox1.GotFocus

        ListBox1.Visibility = Windows.Visibility.Visible
        TextBox1.Visibility = Windows.Visibility.Collapsed      ' CAIXA DA ORIGEM '

    End Sub

    Private Sub ListBox2_SelectionChanged(sender As System.Object, e As System.Windows.Controls.SelectionChangedEventArgs) Handles ListBox2.SelectionChanged

        TextBox2.Text = ListBox2.SelectedItem
        ListBox2.Visibility = Windows.Visibility.Collapsed       ' LISTA DO DESTINO'
        TextBox2.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub TextBox2_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles TextBox2.GotFocus

        ListBox2.Visibility = Windows.Visibility.Visible
        TextBox2.Visibility = Windows.Visibility.Collapsed      ' CAIXA DO DESTINO'

    End Sub

    Private Sub ListBox3_SelectionChanged(sender As System.Object, e As System.Windows.Controls.SelectionChangedEventArgs) Handles ListBox3.SelectionChanged

        ListBox3.Visibility = Windows.Visibility.Collapsed       ' LISTA DO DESTINO'
        TextBox3.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub ListBox4_SelectionChanged(sender As System.Object, e As System.Windows.Controls.SelectionChangedEventArgs) Handles ListBox4.SelectionChanged

        ListBox4.Visibility = Windows.Visibility.Collapsed       ' LISTA DO DESTINO'
        TextBox3.Visibility = Windows.Visibility.Visible
        TextBox3.Text = String.Concat(ListBox3.SelectedItem, ListBox4.SelectedItem)
    End Sub

    Private Sub TextBox3_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles TextBox3.GotFocus

        ListBox3.Visibility = Windows.Visibility.Visible
        ListBox4.Visibility = Windows.Visibility.Visible
        TextBox3.Visibility = Windows.Visibility.Collapsed      ' CAIXA DAS HORAS'

    End Sub

   
    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.Windows.Controls.TextChangedEventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
