Public Class Form1
    Private Sub BtnShowAnswer_Click(sender As Object, e As EventArgs) Handles btnShowAnswer.Click
        'Make answer visible'
        lblAnswer.Visible = True
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form'
        Me.Close()

    End Sub
End Class
