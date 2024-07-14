Public Class MEDICALADD2
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
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If BunifuMaterialTextbox1.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox2.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox3.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox4.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox5.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox6.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox7.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf RichTextBox1.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf RichTextBox2.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox1.Text = "Name of Incident" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox2.Text = "Place of Incident" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox3.Text = "Date of Incident" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox4.Text = "Date of Disabilty Began" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox5.Text = "Part of the Body Affected" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox6.Text = "Time of Incident" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox7.Text = "Type of Incident" Then
            MsgBox("PLease fill up the missing information")
        Else
            nonquery("insert into bxcq2xr2isgolaxd4zcg.record values('" & Class1.Name & "','" & Class1.Age & "','" & Class1.Sex & "','" & Class1.CivilStatus & "','" & Class1.Address & "','" & Class1.GrYearSec & "','" & Class1.RoomBuilding & "','" & Class1.SchoolID & "','" & Class1.Guardian & "','" & Class1.NumGuardian & "','" & Class1.ChiefComplaints & "','" & Class1.PhoneNum & "','" & Class1.Religion & "','" & Class1.Nationality & "','" & Class1.BirthDate & "','" & Class1.NameAdviser & "','" & Class1.MotherName & "','" & Class1.MotherNum & "','" & Class1.FatherName & "','" & Class1.FatherNum & "','" & Class1.HealthHx & "','" & Class1.MedsTaken & "','" & Class1.Allergies & "','" & Class1.Medicine & "','" & Class1.Food & "','" & Class1.BP & "','" & Class1.RR & "','" & Class1.PR & "','" & Class1.Temperature & "','" & Class1.O2Sat & "','" & Class1.LMP & "','" & Class1.Remarks & "','" & Class1.BMI & "','" & Class1.Ht & "','" & Class1.Wt & "','" & BunifuMaterialTextbox1.Text & "','" & BunifuMaterialTextbox2.Text & "','" & BunifuMaterialTextbox3.Text & "','" & BunifuMaterialTextbox4.Text & "','" & BunifuMaterialTextbox5.Text & "','" & BunifuMaterialTextbox6.Text & "','" & BunifuMaterialTextbox7.Text & "','" & RichTextBox1.Text & "','" & RichTextBox2.Text & "')")
            mypopulate("select * from bxcq2xr2isgolaxd4zcg.record", MEDICAL.DataGridView1)
            MsgBox("Successfully Added")

            openchildform(New MEDICAL())
            Me.Hide()
        End If
    End Sub
End Class