﻿Public Class MEDICINEE
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
    Private Sub MEDICINEE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mypopulate("select Medicine, Quantity, Datee, Transactionn, MedicineUse from bxcq2xr2isgolaxd4zcg.mrecord", DataGridView1)
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        BunifuMaterialTextbox1.Text = ""
    End Sub

    Private Sub BunifuMaterialTextbox1_OnValueChanged_1(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox1.OnValueChanged
        mypopulate("Select Medicine, Quantity, Datee, Transactionn, MedicineUse from bxcq2xr2isgolaxd4zcg.mrecord where " & ComboBox1.Text & " like '%" & BunifuMaterialTextbox1.Text & "%';", DataGridView1)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        BunifuMaterialTextbox1.Text = ""
    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        openchildform(New MEDICINEADD())
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton22_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Dim Medicine As String
        Dim Quantity As Integer
        Dim Datee As String
        Dim Transactionn As String
        Dim MedicineUse As String
        Dim Qt As String
        Dim Latest As Integer

        Medicine = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Quantity = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        Datee = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        Transactionn = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
        MedicineUse = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value

        MsgBox("Are you sure you want to delete this medicine?", MsgBoxStyle.YesNo)
        If MsgBoxResult.Yes Then
            Latest = Val(selectspecific("select Keynum from bxcq2xr2isgolaxd4zcg.marchive order by Keynum desc limit 1")) + 1
            nonquery("insert into bxcq2xr2isgolaxd4zcg.marchive values('" & Latest & "','" & Medicine & "','" & Quantity & "','" & Datee & "','" & Transactionn & "','" & MedicineUse & "')")
            Qt = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
            nonquery("delete from bxcq2xr2isgolaxd4zcg.mrecord where Medicine = '" & Qt & "'")
            mypopulate("select Medicine, Quantity, Datee, Transactionn, MedicineUse from bxcq2xr2isgolaxd4zcg.mrecord", DataGridView1)
            MsgBox("Successfully Deleted")
            mypopulate("select Medicine, Quantity, Datee, Transactionn, MedicineUse from bxcq2xr2isgolaxd4zcg.marchive", MEDICINEARCHIVE.DataGridView1)
        ElseIf MsgBoxResult.No Then
            Me.Show()
        End If
    End Sub

    Private Sub BunifuThinButton23_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        Class1.Medicinee = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Class1.Quantity = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        Class1.Datee = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        Class1.Transaction = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
        Class1.MedicineUse = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value
        openchildform(New MEDICINEUP2())
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton25_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        openchildform(New MEDICINEARCHIVE())
        Me.Hide()
    End Sub
End Class