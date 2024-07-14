Public Class MEDICALSHOW

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim Form As New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(Form, New Rectangle(0, 0, Me.Width, Me.Height))
        e.Graphics.DrawImage(Form, 50, 150)
    End Sub

    Private Sub Label70_Click(sender As Object, e As EventArgs) Handles Label70.Click
        PrintPreviewDialog1.ShowDialog()
        Me.Hide()

    End Sub
End Class