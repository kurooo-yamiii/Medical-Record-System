Public Class MEDICINEADD
    Private Sub showsubmenu(SUBMENU As Panel)
        If SUBMENU.Visible = False Then

            SUBMENU.Visible = True
        Else
            SUBMENU.Visible = False

        End If
    End Sub
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
    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim Medicine As String
        Medicine = selectspecific("select Medicine from bxcq2xr2isgolaxd4zcg.mrecord")
        If BunifuMaterialTextbox1.Text = Medicine Then
            MsgBox("This medicine is recorded already")
        ElseIf BunifuMaterialTextbox1.Text = "" And BunifuMaterialTextbox2.Text = "" Then
            MsgBox("Please fill up the information needed")
        ElseIf BunifuMaterialTextbox3.Text = "" And BunifuMaterialTextbox4.Text = "" Then
            MsgBox("Please fill up the information needed")
        ElseIf BunifuMaterialTextbox5.Text = "" Then
            MsgBox("Please fill up the information needed")
        ElseIf BunifuMaterialTextbox1.Text = "Name" And BunifuMaterialTextbox2.Text = "Quantity" Then
            MsgBox("Please fill up the information needed")
        ElseIf BunifuMaterialTextbox3.Text = "Date" And BunifuMaterialTextbox4.Text = "Transaction" Then
            MsgBox("Please fill up the information needed")
        ElseIf BunifuMaterialTextbox5.Text = "Medicine Use" Then
            MsgBox("Please fill up the information needed")
        Else
            Dim latest As Integer
            latest = Val(selectspecific("select keynum from bxcq2xr2isgolaxd4zcg.mrecord order by Keynum desc limit 1")) + 1
            nonquery("insert into bxcq2xr2isgolaxd4zcg.mrecord values(" & latest & ",'" & BunifuMaterialTextbox1.Text & "','" & BunifuMaterialTextbox2.Text & "','" & BunifuMaterialTextbox3.Text & "','" & BunifuMaterialTextbox4.Text & "','" & BunifuMaterialTextbox5.Text & "')")
            mypopulate("select Medicine, Quantity, Datee, Transactionn, MedicineUse from bxcq2xr2isgolaxd4zcg.mrecord", MEDICINEE.DataGridView1)
            MsgBox("Successfully Added")
            openchildform(New MEDICINEE())
            Me.Hide()
        End If
    End Sub

    Private Sub BunifuThinButton24_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        openchildform(New MEDICINEE())
        Me.Hide()
    End Sub
End Class