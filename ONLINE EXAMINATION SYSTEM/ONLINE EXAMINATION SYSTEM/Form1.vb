Public Class Form1
    Dim a As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Settings.Username Then
            a += 1
        End If
        If TextBox2.Text = My.Settings.Password Then
            a += 1
        End If
        If a = 2 Then
            MsgBox("**********LOGIN IS SUCCESSFULL*********", MsgBoxStyle.Information)
            questionform.Show()
            Me.Hide()
        Else
            MsgBox("INVALID USERNAME PASSWORD", MsgBoxStyle.Critical)
            a = 0
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
