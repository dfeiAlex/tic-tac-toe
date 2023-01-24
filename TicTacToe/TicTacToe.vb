Public Class TicTacToe
    Dim dictCells = New Dictionary(Of Integer, String) From {
        {1, "Empty"}, {2, "Empty"}, {3, "Empty"},
        {4, "Empty"}, {5, "Empty"}, {6, "Empty"},
        {7, "Empty"}, {8, "Empty"}, {9, "Empty"}
    }

    Dim listWinningCells = {
        {1, 2, 3}, {4, 5, 6}, {7, 8, 9}, {1, 4, 7}, {2, 5, 8}, {3, 6, 9}, {1, 5, 9}, {3, 5, 7}
    }

    Public Sub newGame()
        dictCells = {{1, "Empty"}, {2, "Empty"}, {3, "Empty"}, {4, "Empty"}, {5, "Empty"}, {6, "Empty"}, {7, "Empty"}, {8, "Empty"}, {9, "Empty"}}

        For Each button As Button In My.Forms.Form1.grpCells.Controls
            button.Text = ""
        Next
    End Sub
End Class
