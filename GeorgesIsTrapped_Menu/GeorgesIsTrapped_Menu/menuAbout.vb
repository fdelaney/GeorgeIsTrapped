Public Class menuAbout

    Private Sub lblMainMenu_Click(sender As Object, e As EventArgs) Handles lblMainMenu.Click
        Close()
    End Sub

    Private Sub lblMainMenu_MouseEnter(sender As Object, e As EventArgs) Handles lblMainMenu.MouseEnter
        MouseEnterLabel(lblMainMenu, lblMainMenuSelected)
    End Sub

    Private Sub lblMainMenu_MouseLeave(sender As Object, e As EventArgs) Handles lblMainMenu.MouseLeave
        MouseLeaveLabel(lblMainMenu, lblMainMenuSelected)
    End Sub
End Class