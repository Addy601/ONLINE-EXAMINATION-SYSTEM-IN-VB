Public Class RESULT
    Public AA As Integer
    Public bb As Integer
    Public cc As Integer
    Public dd As Integer
    Public ff As Integer

    Private Sub RESULT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If AA = 4 Then
            CheckBox1.Checked = True
        End If
        If bb = 4 Then
            CheckBox2.Checked = True
        End If
        If cc = 4 Then
            CheckBox3.Checked = True
        End If
        If dd = 4 Then
            CheckBox4.Checked = True
        End If
        If ff = 4 Then
            CheckBox5.Checked = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class