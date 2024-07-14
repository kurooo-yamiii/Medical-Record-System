Public Class TEACHER2


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
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim Qt As String

        Qt = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        MsgBox(Qt)
    End Sub
    Private Sub TRANSACTION2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mypopulate("select Datee, Remarks, Medicine, Num from bxcq2xr2isgolaxd4zcg.teacher2 where SchoolID = '" & Class1.T3 & "'", DataGridView1)
        Label3.Text = Date.Now.ToString("MMM dd, yyyy hh:mm:ss tt")
        Label1.Text = Class1.T1
        Label2.Text = Class1.T3
    End Sub

    Private Sub BunifuMaterialTextbox3_OnValueChanged_1(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox3.OnValueChanged
        Label4.Text = selectspecific("select Quantity from bxcq2xr2isgolaxd4zcg.mrecord where Medicine = '" & BunifuMaterialTextbox3.Text & "'")
    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim Bilang As String = selectspecific("select Quantity from bxcq2xr2isgolaxd4zcg.mrecord where Medicine = '" & BunifuMaterialTextbox3.Text & "'")
        Dim Medicine As String = selectspecific("select Medicine from bxcq2xr2isgolaxd4zcg.mrecord where Medicine = '" & BunifuMaterialTextbox3.Text & "'")

        Label4.Text = Val(Label4.Text) - Val(BunifuMaterialTextbox4.Text)
        nonquery("update bxcq2xr2isgolaxd4zcg.mrecord set Quantity = '" & Label4.Text & "' where Medicine = '" & BunifuMaterialTextbox3.Text & "'")
        nonquery("insert into bxcq2xr2isgolaxd4zcg.teacher2 values('" & Label2.Text & "','" & Label1.Text & "','" & Label3.Text & "','" & BunifuMaterialTextbox2.Text & "','" & BunifuMaterialTextbox4.Text & "','" & BunifuMaterialTextbox3.Text & "')")
        mypopulate("select Datee, Remarks, Medicine, Num from bxcq2xr2isgolaxd4zcg.teacher2 where SchoolID = '" & Label2.Text & "'", DataGridView1)
        Label4.Text = Bilang

        MsgBox("Added Successfully")

        BunifuMaterialTextbox2.Text = "Remarks"
        BunifuMaterialTextbox3.Text = "Medicine"
        BunifuMaterialTextbox4.Text = "No."

    End Sub

    Private Sub BunifuThinButton24_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        mypopulate("select Name, Department, SchoolID from bxcq2xr2isgolaxd4zcg.teacher", DataGridView1)
        openchildform(New TEACHER())
        Me.Hide()
    End Sub
End Class