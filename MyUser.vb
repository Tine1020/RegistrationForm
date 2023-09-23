Public Class MyUser

    Public Property Email() As String
    Public Property FullName() As String
    Public Property Address() As String
    Public Property Password() As String

    Private Shared TheError As String = "Not Successfully SignUp"

    Public Sub ShowError()
        MessageBox.Show(TheError)
    End Sub

    Public Shared Function IsEqual(user As MyUser)


    End Function
End Class
