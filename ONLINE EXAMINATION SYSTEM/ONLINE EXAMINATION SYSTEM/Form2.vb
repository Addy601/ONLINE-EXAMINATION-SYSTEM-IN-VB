Public Class Form2
    Public B As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton3.Checked Then
            B = 4
        End If
        Form3.Show()
        RESULT.bb = B
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        MsgBox("TIMEOUT!")
        Form3.Show()
        Me.Hide()
    End Sub
End Class