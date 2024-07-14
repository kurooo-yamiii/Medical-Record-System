Public Class MEDICINEUP2
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
    Private Sub MEDICINEUP2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Class1.Medicinee
        BunifuMaterialTextbox2.Text = Class1.Quantity
        BunifuMaterialTextbox3.Text = Class1.Datee
        BunifuMaterialTextbox4.Text = Class1.Transaction
        BunifuMaterialTextbox5.Text = Class1.MedicineUse
    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If BunifuMaterialTextbox2.Text = "" Then
            MsgBox("Please fill up the information needed")
        ElseIf BunifuMaterialTextbox3.Text = "" And BunifuMaterialTextbox4.Text = "" Then
            MsgBox("Please fill up the information needed")
        ElseIf BunifuMaterialTextbox5.Text = "" Then
            MsgBox("Please fill up the information needed")
        Else
            Dim Latest As Integer
            Latest = Val(selectspecific("select Keynum from bxcq2xr2isgolaxd4zcg.mrecord order by Keynum desc limit 1")) + 1
            nonquery("update bxcq2xr2isgolaxd4zcg.mrecord set Keynum = '" & Latest & "', Medicine = '" & Label1.Text & "', Quantity = '" & BunifuMaterialTextbox2.Text & "', Datee = '" & BunifuMaterialTextbox3.Text & "', Transactionn = '" & BunifuMaterialTextbox4.Text & "', MedicineUse = '" & BunifuMaterialTextbox5.Text & "' where Medicine = '" & Label1.Text & "'")
            mypopulate("select Medicine, Quantity, Datee, Transactionn, MedicineUse from bxcq2xr2isgolaxd4zcg.mrecord", MEDICINEE.DataGridView1)
            MsgBox("Successfuly Updated")
            openchildform(New MEDICINEE())
            Me.Hide()
        End If
    End Sub

    Private Sub BunifuThinButton24_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        openchildform(New MEDICINEE())
        Me.Hide()
    End Sub
End Class