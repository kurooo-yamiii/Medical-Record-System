Public Class EMPLOYEEUP
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
    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
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
        ElseIf BunifuMaterialTextbox17.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox18.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox19.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox20.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox21.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox22.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox23.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox24.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox25.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox26.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox27.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox28.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox29.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox30.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox31.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox32.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox33.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox34.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox35.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox36.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox37.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox38.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox39.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox40.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox41.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox42.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox43.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox44.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox45.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox1.Text = "Establishment" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox2.Text = "Name Of Business" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox3.Text = "Address" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox4.Text = "Num Of Employees Male" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox5.Text = "Num Of Employees Female" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox6.Text = "Total Employees" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox7.Text = "Manager" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox8.Text = "Name" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox9.Text = "Age" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox10.Text = "Sex" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox11.Text = "Civil Status" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox12.Text = "Address" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox13.Text = "Position/Type Of Employment" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox14.Text = "Phone Num" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox15.Text = "Religion" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox16.Text = "Nationality" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox17.Text = "Experience At Occupation" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox18.Text = "Num Of Dependents" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox19.Text = "Birthdate" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox20.Text = "Monthly Wage" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox21.Text = "Workshift 1st/AM" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox22.Text = "Workshift 2nd/PM" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox23.Text = "Hours of Work/Day" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox24.Text = "Week" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox25.Text = "In Case of Emergency, Please Contact" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox26.Text = "Relationship" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox27.Text = "Phone" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox28.Text = "Agency, If Outsourced" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox29.Text = "Agency Address" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox30.Text = "Chief Complaints" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox31.Text = "Health Hx" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox32.Text = "Meds Taken" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox33.Text = "Allergies" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox34.Text = "Medicine" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox35.Text = "Food" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox36.Text = "BP" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox37.Text = "RR" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox38.Text = "PR" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox39.Text = "Temperature" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox40.Text = "O2Sat" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox41.Text = "Wt" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox42.Text = "Ht" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox43.Text = "BMI" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox44.Text = "Remarks" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox45.Text = "LMP" Then
            MsgBox("PLease fill up the missing information")
        Else
            Class2.Establishment = BunifuMaterialTextbox1.Text
            Class2.NameOfBusiness = BunifuMaterialTextbox2.Text
            Class2.AddressWork = BunifuMaterialTextbox3.Text
            Class2.NumOfEmploymentMale = BunifuMaterialTextbox4.Text
            Class2.NumofEmploymentFemale = BunifuMaterialTextbox5.Text
            Class2.TotalEmployees = BunifuMaterialTextbox6.Text
            Class2.Manager = BunifuMaterialTextbox7.Text
            Class2.Name = BunifuMaterialTextbox8.Text
            Class2.Age = BunifuMaterialTextbox9.Text
            Class2.Sex = BunifuMaterialTextbox10.Text
            Class2.CivilStatus = BunifuMaterialTextbox11.Text
            Class2.Address = BunifuMaterialTextbox12.Text
            Class2.Position = BunifuMaterialTextbox13.Text
            Class2.PhoneNum = BunifuMaterialTextbox14.Text
            Class2.Religion = BunifuMaterialTextbox15.Text
            Class2.Nationality = BunifuMaterialTextbox16.Text
            Class2.ExperienceOfOccupation = BunifuMaterialTextbox17.Text
            Class2.NumOfDependents = BunifuMaterialTextbox18.Text
            Class2.BirthDate = BunifuMaterialTextbox19.Text
            Class2.MonthlyWage = BunifuMaterialTextbox20.Text
            Class2.WorkshiftAM = BunifuMaterialTextbox21.Text
            Class2.WorkshiftPM = BunifuMaterialTextbox22.Text
            Class2.HoursOfWorkDay = BunifuMaterialTextbox23.Text
            Class2.Week = BunifuMaterialTextbox24.Text
            Class2.EmergencyNum = BunifuMaterialTextbox25.Text
            Class2.Relationship = BunifuMaterialTextbox26.Text
            Class2.Phone = BunifuMaterialTextbox27.Text
            Class2.Agency = BunifuMaterialTextbox28.Text
            Class2.AgencyAddress = BunifuMaterialTextbox29.Text
            Class2.ChiefComplaints = BunifuMaterialTextbox30.Text
            Class2.HealthHx = BunifuMaterialTextbox31.Text
            Class2.MedsTaken = BunifuMaterialTextbox32.Text
            Class2.Allergies = BunifuMaterialTextbox33.Text
            Class2.Medicine = BunifuMaterialTextbox34.Text
            Class2.Food = BunifuMaterialTextbox35.Text
            Class2.BP = BunifuMaterialTextbox36.Text
            Class2.RR = BunifuMaterialTextbox37.Text
            Class2.PR = BunifuMaterialTextbox38.Text
            Class2.Temperature = BunifuMaterialTextbox39.Text
            Class2.O2Sat = BunifuMaterialTextbox40.Text
            Class2.Wt = BunifuMaterialTextbox41.Text
            Class2.Ht = BunifuMaterialTextbox42.Text
            Class2.BMI = BunifuMaterialTextbox43.Text
            Class2.Remarks = BunifuMaterialTextbox44.Text
            Class2.LMP = BunifuMaterialTextbox45.Text

            openchildform(New EMPLOYEEUP2())
            Me.Hide()

        End If
    End Sub

    Private Sub EMPLOYEEUP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuMaterialTextbox1.Text = Class2.Establishment
        BunifuMaterialTextbox2.Text = Class2.NameOfBusiness
        BunifuMaterialTextbox3.Text = Class2.AddressWork
        BunifuMaterialTextbox4.Text = Class2.NumOfEmploymentMale
        BunifuMaterialTextbox5.Text = Class2.NumofEmploymentFemale
        BunifuMaterialTextbox6.Text = Class2.TotalEmployees
        BunifuMaterialTextbox7.Text = Class2.Manager
        BunifuMaterialTextbox8.Text = Class2.Name
        BunifuMaterialTextbox9.Text = Class2.Age
        BunifuMaterialTextbox10.Text = Class2.Sex
        BunifuMaterialTextbox11.Text = Class2.CivilStatus
        BunifuMaterialTextbox12.Text = Class2.Address
        BunifuMaterialTextbox13.Text = Class2.Position
        BunifuMaterialTextbox14.Text = Class2.PhoneNum
        BunifuMaterialTextbox15.Text = Class2.Religion
        BunifuMaterialTextbox16.Text = Class2.Nationality
        BunifuMaterialTextbox17.Text = Class2.ExperienceOfOccupation
        BunifuMaterialTextbox18.Text = Class2.NumOfDependents
        BunifuMaterialTextbox19.Text = Class2.BirthDate
        BunifuMaterialTextbox20.Text = Class2.MonthlyWage
        BunifuMaterialTextbox21.Text = Class2.WorkshiftAM
        BunifuMaterialTextbox22.Text = Class2.WorkshiftPM
        BunifuMaterialTextbox23.Text = Class2.HoursOfWorkDay
        BunifuMaterialTextbox24.Text = Class2.Week
        BunifuMaterialTextbox25.Text = Class2.EmergencyNum
        BunifuMaterialTextbox26.Text = Class2.Relationship
        BunifuMaterialTextbox27.Text = Class2.Phone
        BunifuMaterialTextbox28.Text = Class2.Agency
        BunifuMaterialTextbox29.Text = Class2.AgencyAddress
        BunifuMaterialTextbox30.Text = Class2.ChiefComplaints
        BunifuMaterialTextbox31.Text = Class2.HealthHx
        BunifuMaterialTextbox32.Text = Class2.MedsTaken
        BunifuMaterialTextbox33.Text = Class2.Allergies
        BunifuMaterialTextbox34.Text = Class2.Medicine
        BunifuMaterialTextbox35.Text = Class2.Food
        BunifuMaterialTextbox36.Text = Class2.BP
        BunifuMaterialTextbox37.Text = Class2.RR
        BunifuMaterialTextbox38.Text = Class2.PR
        BunifuMaterialTextbox39.Text = Class2.Temperature
        BunifuMaterialTextbox40.Text = Class2.O2Sat
        BunifuMaterialTextbox41.Text = Class2.Wt
        BunifuMaterialTextbox42.Text = Class2.Ht
        BunifuMaterialTextbox43.Text = Class2.BMI
        BunifuMaterialTextbox44.Text = Class2.Remarks
        BunifuMaterialTextbox45.Text = Class2.LMP
    End Sub
End Class