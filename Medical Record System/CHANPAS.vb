Public Class CHANPAS

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

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        MAMA.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If Not BunifuMaterialTextbox2.Text = BunifuMaterialTextbox3.Text Then
            MsgBox("New password and re-type new password didn't matched")
        ElseIf BunifuMaterialTextbox2.Text = "" And BunifuMaterialTextbox3.Text = "" Then
            MsgBox("Please fill up the information needed")
        ElseIf Not BunifuMaterialTextbox1.Text = selectspecific("select NewPassword from bxcq2xr2isgolaxd4zcg.passwordd where Keynum = 1") Then
            MsgBox("Wrong Old Password")
        ElseIf BunifuMaterialTextbox1.Text = "" Then
            MsgBox("Please fill up the information needed")
        Else
            nonquery("Delete from bxcq2xr2isgolaxd4zcg.passwordd where keynum = 1")
            Dim latest As Integer
            latest = Val(selectspecific("select keynum from bxcq2xr2isgolaxd4zcg.passwordd order by Keynum desc limit 1")) + 1
            nonquery("insert into bxcq2xr2isgolaxd4zcg.history values(" & latest & ",'" & BunifuMaterialTextbox1.Text & "','" & BunifuMaterialTextbox1.Text & "','" & Label4.Text & "')")
            nonquery("Insert into bxcq2xr2isgolaxd4zcg.passwordd values(" & latest & ",'" & BunifuMaterialTextbox2.Text & "','" & BunifuMaterialTextbox3.Text & "','" & Label4.Text & "')")
            MsgBox("Change password successfuly")
            BunifuMaterialTextbox1.Text = "Old Password"
            BunifuMaterialTextbox2.Text = "New Password"
            BunifuMaterialTextbox3.Text = "Retype New Password"
            LOGIN.Show()
            Me.Hide()
            MAMA.Hide()

        End If
    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint
        Label4.Text = Date.Now.ToString("MMM dd, yyyy hh:mm:ss tt")
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        openchildform(New HISTORY())
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class