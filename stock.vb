Public Class stock

    Implements IComparable
    Public Property Ticker As String
    Public Property Price As Double
    Public Property Earnings As Double

    Public Sub New(pTicker As String, pPrice As Double, pEarnings As Double)
        Ticker = pTicker
        Price = pPrice
        Earnings = pEarnings

    End Sub

    Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
        Return Ticker.CompareTo(CType(obj, stock).Ticker)
    End Function

    Public ReadOnly Property PeRation As Double
        Get
            If Earnings > 0 Then
                Return Price / Earnings
            Else
                Return 0.0
            End If
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return Ticker & ", price = " & Price.ToString("n") & ", P/E = " & PeRation.ToString("n")

    End Function
End Class
