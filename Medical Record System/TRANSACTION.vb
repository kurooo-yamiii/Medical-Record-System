Public Class TRANSACTION
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
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim SchoolID As String
        SchoolID = selectspecific("select SchoolID from bxcq2xr2isgolaxd4zcg.transactionn")

        If BunifuMaterialTextbox3.Text = SchoolID Then
            MsgBox("This student is already registered")
        Else
            nonquery("insert into bxcq2xr2isgolaxd4zcg.transactionn values('" & BunifuMaterialTextbox3.Text & "','" & BunifuMaterialTextbox1.Text & "','" & BunifuMaterialTextbox2.Text & "')")
            mypopulate("select Name, GrYearSec, SchoolID from bxcq2xr2isgolaxd4zcg.transactionn", DataGridView1)
            BunifuMaterialTextbox1.Text = "Name"
            BunifuMaterialTextbox2.Text = "Grade/Year & Section"
            BunifuMaterialTextbox3.Text = "SchoolID"
            MsgBox("Successfully Added")
        End If
    End Sub
    Private Sub TRANSACTION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mypopulate("select Name, GrYearSec, SchoolID from bxcq2xr2isgolaxd4zcg.transactionn", DataGridView1)
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Class1.Qt = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Class1.GrYearSecc = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        Class1.Num = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value

            TRANSACTION2.Label1.Text = Class1.Qt
            TRANSACTION2.Label2.Text = Class1.Num
            openchildform(New TRANSACTION2())
            Me.Hide()

        mypopulate("select Datee, Remarks, Medicine, Num from bxcq2xr2isgolaxd4zcg.transactionn2 where SchoolID = '" & Class1.Num & "'", TRANSACTION2.DataGridView1)
    End Sub

    Private Sub BunifuMaterialTextbox6_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox6.OnValueChanged
        mypopulate("Select * from bxcq2xr2isgolaxd4zcg.transactionn where " & ComboBox1.Text & " LIKE '%" & BunifuMaterialTextbox6.Text & "%'", DataGridView1)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        BunifuMaterialTextbox6.Text = ""
    End Sub
End Class