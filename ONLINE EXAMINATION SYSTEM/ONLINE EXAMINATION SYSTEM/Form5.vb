Public Class Form5
    Public f As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            f = 4
        End If
        RESULT.Show()
        RESULT.ff = f
        Me.Hide()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        MsgBox("TIMEOUT!")
        RESULT.Show()
        Me.Hide()
    End Sub
End Class