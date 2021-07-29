Public Class Secret

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Close()
        Login.Show()
    End Sub

    'untuk mouse
    Dim Point As New System.Drawing.Point()
    Dim X, Y As Integer

    Private Sub GroupPanelBox11_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GroupPanelBox11.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub GroupPanelBox11_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GroupPanelBox11.MouseMove
        If e.Button = MouseButtons.Left Then
            Point = Control.MousePosition
            Point.X = Point.X - (X)
            Point.Y = Point.Y - (Y)
            Me.Location = Point
        End If
    End Sub


    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.Hide()
        Utama.Show()
    End Sub

End Class