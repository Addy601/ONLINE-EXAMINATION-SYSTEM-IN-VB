Public Class exam
    Public a As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton4.Checked Then
            a = 4
        End If
        Form2.Show()
        RESULT.aa = a
        Me.Hide()
    End Sub
    Private Sub exam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        MsgBox("TIMEOUT!")
        Form2.Show()
        Me.Hide()
    End Sub
End Class