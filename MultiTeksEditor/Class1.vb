Public Class Files
    Public Property Path As String
    Public Property Name As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal Path1 As String,
                   ByVal Name1 As String)
        Path = Path1
        Name = Name1
    End Sub
End Class
