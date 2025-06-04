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
End Class
