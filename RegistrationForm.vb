Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces



Public Class RegistrationForm

    Private fcon As New FirebaseConfig() With
       {
   .AuthSecret = "n6ylWds9p7AQWkybtN1zB4dP7QfcRIxzB8jJe9hK",
   .BasePath = "https://registervb-7cc9c-default-rtdb.asia-southeast1.firebasedatabase.app/"
   }
        Private client As IFirebaseClient

        Private Sub SignupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub signbtn_Click(sender As Object, e As EventArgs) Handles signbtn.Click
        Dim Newuser As New MyUser() With
            {
            .Email = emailtxt.Text,
            .FullName = nametxt.Text,
            .Address = addtxt.Text,
        .Password = passtxt.Text
            }

        Dim setter = client.Set("Users/" + emailtxt.Text, Newuser)
        Dim setterUser
        MessageBox.Show("Register Successfully")
    End Sub

End Class