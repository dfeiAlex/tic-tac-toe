Public Class Form1
    Dim game = New TicTacToe()

    Private Sub btn_9_Click(sender As Object, e As EventArgs) _
        Handles btn_1.Click, btn_2.Click, btn_3.Click, btn_4.Click, btn_5.Click, btn_6.Click, btn_7.Click, btn_8.Click, btn_9.Click

        Dim cellClicked As Integer = Val(sender.Name.Split("_")(1))
    End Sub
End Class
