Public Class EMPLOYEEADD2
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
        ElseIf BunifuMaterialTextbox8.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox9.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox10.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox11.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox12.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox13.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox14.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox15.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox16.Text = "" Then
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
        ElseIf BunifuMaterialTextbox4.Text = "Disability Date Began" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox5.Text = "Parts of Body Affected" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox6.Text = "Time of Incident" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox7.Text = "Type of Incident" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox8.Text = "Property Damage" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox9.Text = "Personal Injury" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox10.Text = "Date of Returned to Work" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox11.Text = "Day Lost" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox12.Text = "Unsafe Act" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox13.Text = "Unsafe Mechanical/Unsafe Condition" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox14.Text = "Contributing Factor" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox15.Text = "Extent of Disability" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox16.Text = "Damage Property" Then
            MsgBox("PLease fill up the missing information")
        Else
            nonquery("insert into bxcq2xr2isgolaxd4zcg.employee values('" & Class2.Establishment & "','" & Class2.NameOfBusiness & "','" & Class2.AddressWork & "','" & Class2.NumOfEmploymentMale & "','" & Class2.NumofEmploymentFemale & "','" & Class2.TotalEmployees & "','" & Class2.Manager & "','" & Class2.Name & "','" & Class2.Age & "','" & Class2.Sex & "','" & Class2.CivilStatus & "','" & Class2.Address & "','" & Class2.Position & "','" & Class2.PhoneNum & "','" & Class2.Religion & "','" & Class2.Nationality & "','" & Class2.ExperienceOfOccupation & "','" & Class2.NumOfDependents & "','" & Class2.BirthDate & "','" & Class2.MonthlyWage & "','" & Class2.WorkshiftAM & "','" & Class2.WorkshiftPM & "','" & Class2.HoursOfWorkDay & "','" & Class2.Week & "','" & Class2.EmergencyNum & "','" & Class2.Relationship & "','" & Class2.Phone & "','" & Class2.Agency & "','" & Class2.AgencyAddress & "','" & Class2.ChiefComplaints & "','" & Class2.HealthHx & "','" & Class2.MedsTaken & "','" & Class2.Allergies & "','" & Class2.Medicine & "','" & Class2.Food & "','" & Class2.BP & "','" & Class2.RR & "','" & Class2.PR & "','" & Class2.Temperature & "','" & Class2.O2Sat & "','" & Class2.Wt & "','" & Class2.Ht & "','" & Class2.BMI & "','" & Class2.Remarks & "','" & Class2.LMP & "','" & BunifuMaterialTextbox1.Text & "','" & BunifuMaterialTextbox2.Text & "','" & BunifuMaterialTextbox3.Text & "','" & BunifuMaterialTextbox4.Text & "','" & BunifuMaterialTextbox5.Text & "','" & BunifuMaterialTextbox6.Text & "','" & BunifuMaterialTextbox7.Text & "','" & BunifuMaterialTextbox8.Text & "','" & BunifuMaterialTextbox9.Text & "','" & BunifuMaterialTextbox10.Text & "','" & BunifuMaterialTextbox11.Text & "','" & BunifuMaterialTextbox12.Text & "','" & BunifuMaterialTextbox13.Text & "','" & BunifuMaterialTextbox14.Text & "','" & BunifuMaterialTextbox15.Text & "','" & BunifuMaterialTextbox16.Text & "','" & RichTextBox1.Text & "','" & RichTextBox2.Text & "')")
            mypopulate("select * from bxcq2xr2isgolaxd4zcg.employee", EMPLOYEE.DataGridView1)
            MsgBox("Successfully Added")

            openchildform(New EMPLOYEE())
            Me.Hide()
        End If
    End Sub

End Class