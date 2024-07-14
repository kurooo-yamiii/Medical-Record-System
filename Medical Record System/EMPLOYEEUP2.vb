Public Class EMPLOYEEUP2
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
            nonquery("update bxcq2xr2isgolaxd4zcg.employee set Establishment = '" & Class2.Establishment & "', NameOfBusiness = '" & Class2.NameOfBusiness & "', AddressWork = '" & Class2.AddressWork & "', NumOfEmploymentMale = '" & Class2.NumOfEmploymentMale & "', NumOfEmploymentFemale = '" & Class2.NumofEmploymentFemale & "', TotalEmployee = '" & Class2.TotalEmployees & "', Manager = '" & Class2.Manager & "', Name = '" & Class2.Name & "', Age = '" & Class2.Age & "', Sex = '" & Class2.Sex & "', CivilStatus = '" & Class2.CivilStatus & "', Address = '" & Class2.Address & "', Position = '" & Class2.Position & "', PhoneNum = '" & Class2.PhoneNum & "', Religion = '" & Class2.Religion & "', Nationality = '" & Class2.Nationality & "', ExperienceOfOccupation = '" & Class2.ExperienceOfOccupation & "', NumOfDependents = '" & Class2.NumOfDependents & "', BirthDate = '" & Class2.BirthDate & "', MonthlyWage = '" & Class2.MonthlyWage & "', WorkshiftAM = '" & Class2.WorkshiftAM & "', WorkshiftPM = '" & Class2.WorkshiftPM & "', HoursOfWorkDay = '" & Class2.HoursOfWorkDay & "', Week = '" & Class2.Week & "', EmergencyNum = '" & Class2.EmergencyNum & "', Relationship = '" & Class2.Relationship & "', Phone = '" & Class2.Phone & "', Agency = '" & Class2.Agency & "', AgencyAddress = '" & Class2.AgencyAddress & "', ChiefComplaints = '" & Class2.ChiefComplaints & "', HealthHx = '" & Class2.HealthHx & "', MedsTaken = '" & Class2.MedsTaken & "', Allergies = '" & Class2.Allergies & "', Medicine = '" & Class2.Medicine & "', Food = '" & Class2.Food & "', BP = '" & Class2.BP & "', RR = '" & Class2.RR & "', PR = '" & Class2.PR & "', Temperature = '" & Class2.Temperature & "', O2Sat = '" & Class2.O2Sat & "', Wt = '" & Class2.Wt & "', Ht = '" & Class2.Ht & "', BMI = '" & Class2.BMI & "', Remarks = '" & Class2.Remarks & "', LMP = '" & Class2.LMP & "', NameOfIncident = '" & BunifuMaterialTextbox1.Text & "', PlaceOfIncident = '" & BunifuMaterialTextbox2.Text & "', DateOfIncident = '" & BunifuMaterialTextbox3.Text & "', DisabilityDateBegan = '" & BunifuMaterialTextbox4.Text & "', PartsOfBodyAffected = '" & BunifuMaterialTextbox5.Text & "', TimeOfIncident = '" & BunifuMaterialTextbox6.Text & "', TypeOfIncident = '" & BunifuMaterialTextbox7.Text & "', PropertyDamage = '" & BunifuMaterialTextbox8.Text & "', PersonalInjury = '" & BunifuMaterialTextbox9.Text & "', DateOfReturnedToWork = '" & BunifuMaterialTextbox10.Text & "', DayLost = '" & BunifuMaterialTextbox11.Text & "', UnsafeAct = '" & BunifuMaterialTextbox12.Text & "', UnsafeMechanics = '" & BunifuMaterialTextbox13.Text & "', ContributingFactor = '" & BunifuMaterialTextbox14.Text & "', ExtentOfDisability = '" & BunifuMaterialTextbox15.Text & "', DamageOfProperty = '" & BunifuMaterialTextbox16.Text & "', DescriptionOfAccident = '" & RichTextBox1.Text & "', Witness = '" & RichTextBox2.Text & "' where Name = '" & Class2.Name & "' and Address = '" & Class2.Address & "'")
            mypopulate("select * from bxcq2xr2isgolaxd4zcg.employee", EMPLOYEE.DataGridView1)
            MsgBox("Successfully Updated")
            openchildform(New EMPLOYEE())
        End If
    End Sub

    Private Sub EMPLOYEEUP2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuMaterialTextbox1.Text = Class2.NameOfIncident
        BunifuMaterialTextbox2.Text = Class2.PlaceOfIncident
        BunifuMaterialTextbox3.Text = Class2.DateOfIncident
        BunifuMaterialTextbox4.Text = Class2.DateOfDisabilityBegan
        BunifuMaterialTextbox5.Text = Class2.PartOfTheBodyAffected
        BunifuMaterialTextbox6.Text = Class2.TimeOfIncident
        BunifuMaterialTextbox7.Text = Class2.TypeOfIncident
        BunifuMaterialTextbox8.Text = Class2.PropertyDamage
        BunifuMaterialTextbox9.Text = Class2.PersonalInjury
        BunifuMaterialTextbox10.Text = Class2.DateOfReturnedToWork
        BunifuMaterialTextbox11.Text = Class2.DayLost
        BunifuMaterialTextbox12.Text = Class2.UnsafeAct
        BunifuMaterialTextbox13.Text = Class2.UnsafeMechanical
        BunifuMaterialTextbox14.Text = Class2.ContributingFactor
        BunifuMaterialTextbox15.Text = Class2.ExtentOfDisability
        BunifuMaterialTextbox16.Text = Class2.DamageOfProperty
        RichTextBox1.Text = Class2.DescriptionOfIncident
        RichTextBox2.Text = Class2.Witness
    End Sub
End Class