Public Class Form1
    Private StockList As New List(Of stock)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StockList.Add(New stock("MMA", 40, 5))
        StockList.Add(New stock("ABC", 80, 20))
        StockList.Add(New stock("XYZ", 77, 4))
        StockList.Add(New stock("LLT", 43, 5))
        StockList.Add(New stock("SBA", 42, 7))
    End Sub
    Private Sub DisplayList()

        lstBox.Items.Clear()
        For Each st As stock In StockList
            lstBox.Items.Add(st.ToString())
        Next
    End Sub

    Private Sub btnTicker_Click(sender As Object, e As EventArgs) Handles btnTicker.Click
        If chkDescending.Checked Then
            StockList.Sort()
            StockList.Reverse()

        Else
            StockList.Sort()

        End If

        DisplayList()
    End Sub

    Private Sub btnPrice_Click(sender As Object, e As EventArgs) Handles btnPrice.Click
        StockList.Sort(AddressOf CompareByPrice)
        DisplayList()
    End Sub
    Private Function CompareByPrice(x As stock, y As stock) As Integer
        If chkDescending.Checked Then
            Return y.Price.CompareTo(x.Price)
        End If
        Return x.Price.CompareTo(y.Price)
    End Function

    Private Sub btnPE_Click(sender As Object, e As EventArgs) Handles btnPE.Click
        StockList.Sort(AddressOf CompareByPEratio)
        DisplayList()
    End Sub
    Private Function CompareByPEratio(x As stock, y As stock) As Integer
        If chkDescending.Checked Then
            Return y.PeRation.CompareTo(x.PeRation)
        End If
        Return x.PeRation.CompareTo(y.PeRation)
    End Function
End Class
