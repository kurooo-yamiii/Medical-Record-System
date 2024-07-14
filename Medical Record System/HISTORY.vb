Public Class HISTORY
    Private currentform As Form = Nothing

    Private Sub openchildform(ChildForm As Form)
        If currentform IsNot Nothing Then currentform.Close()
        currentform = ChildForm
        ChildForm.TopLevel = False
        ChildForm.FormBorderStyle = FormBorderStyle.None
        ChildForm.Dock = DockStyle.Fill
        MAMA.PanelChildForm.Controls.Add(ChildForm)
        MAMA.PanelChildForm.Tag = ChildForm
        ChildForm.BringToFront()
        ChildForm.Show()

    End Sub
    Private Sub HISTORY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mypopulate("select OldPassword, Date from bxcq2xr2isgolaxd4zcg.history", DataGridView1)
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        openchildform(New CHANPAS())
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim Datee As String
        Datee = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value

        MsgBox(Datee)
    End Sub
End Class