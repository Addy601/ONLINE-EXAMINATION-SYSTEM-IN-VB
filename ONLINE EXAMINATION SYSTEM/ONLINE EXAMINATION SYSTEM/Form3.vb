Public Class Form3
    Public C As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            C = 4
        End If
        Form4.Show()
        RESULT.cc = C
        Me.Hide()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        MsgBox("TIMEOUT!")
        Form4.Show()
        Me.Hide()
    End Sub
End Class