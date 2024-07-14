Public Class MEDICINE
    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs)
        BASE.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs)
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
        If MsgBoxResult.No Then
            Me.Hide()
        ElseIf MsgBoxResult.Yes Then
            Latest = Val(selectspecific("select Keynum from medical.marchive order by Keynum desc limit 1")) + 1
            nonquery("insert into medical.marchive values('" & Latest & "','" & Medicine & "','" & Quantity & "','" & Datee & "','" & Transactionn & "','" & MedicineUse & "')")
            Qt = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
            nonquery("delete from medical.mrecord where Medicine = '" & Qt & "'")
            mypopulate("select Medicine, Quantity, Datee, Transactionn, MedicineUse from medical.mrecord", DataGridView1)
            MsgBox("Successfully Deleted")
            mypopulate("select Medicine, Quantity, Datee, Transactionn, MedicineUse from medical.marchive", MEDICINEARCHIVE.DataGridView1)
        End If
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs)
        MEDICINEUP2.Show()
        Me.Hide()
    End Sub
    Private Sub MEDICINE_Load(sender As Object, e As EventArgs)
        mypopulate("select Medicine, Quantity, Datee, Transactionn, MedicineUse from medical.mrecord", DataGridView1)
    End Sub

    Private Sub BunifuMaterialTextbox1_OnValueChanged(sender As Object, e As EventArgs)
        mypopulate("Select Medicine, Quantity, Datee, Transactionn, MedicineUse from medical.mrecord where " & ComboBox1.Text & " like '%" & BunifuMaterialTextbox1.Text & "%';", DataGridView1)
    End Sub
    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs)
        MEDICINEARCHIVE.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        MEDICINEADD.Show()
        Me.Hide()
    End Sub
End Class