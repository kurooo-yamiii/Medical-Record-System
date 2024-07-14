Public Class MEDICALUP
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
    Private Sub MEDICALUP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BunifuMaterialTextbox1.Text = Class1.Name
        Label1.Text = Class1.SchoolID
        BunifuMaterialTextbox3.Text = Class1.Age
        BunifuMaterialTextbox2.Text = Class1.Sex
        BunifuMaterialTextbox5.Text = Class1.CivilStatus
        BunifuMaterialTextbox4.Text = Class1.Address
        BunifuMaterialTextbox6.Text = Class1.GrYearSec
        BunifuMaterialTextbox7.Text = Class1.RoomBuilding
        BunifuMaterialTextbox8.Text = Class1.Guardian
        BunifuMaterialTextbox9.Text = Class1.NumGuardian
        BunifuMaterialTextbox11.Text = Class1.ChiefComplaints
        BunifuMaterialTextbox12.Text = Class1.PhoneNum
        BunifuMaterialTextbox13.Text = Class1.Religion
        BunifuMaterialTextbox14.Text = Class1.Nationality
        BunifuMaterialTextbox15.Text = Class1.BirthDate
        BunifuMaterialTextbox16.Text = Class1.NameAdviser
        BunifuMaterialTextbox17.Text = Class1.MotherName
        BunifuMaterialTextbox18.Text = Class1.MotherNum
        BunifuMaterialTextbox19.Text = Class1.FatherName
        BunifuMaterialTextbox20.Text = Class1.FatherNum
        BunifuMaterialTextbox21.Text = Class1.HealthHx
        BunifuMaterialTextbox22.Text = Class1.MedsTaken
        BunifuMaterialTextbox23.Text = Class1.Allergies
        BunifuMaterialTextbox24.Text = Class1.Medicine
        BunifuMaterialTextbox25.Text = Class1.Food
        BunifuMaterialTextbox26.Text = Class1.BP
        BunifuMaterialTextbox27.Text = Class1.RR
        BunifuMaterialTextbox28.Text = Class1.PR
        BunifuMaterialTextbox29.Text = Class1.Temperature
        BunifuMaterialTextbox30.Text = Class1.O2Sat
        BunifuMaterialTextbox31.Text = Class1.LMP
        BunifuMaterialTextbox32.Text = Class1.Remarks
        BunifuMaterialTextbox33.Text = Class1.BMI
        BunifuMaterialTextbox34.Text = Class1.Ht
        BunifuMaterialTextbox35.Text = Class1.Wt
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
        ElseIf BunifuMaterialTextbox1.Text = "Name" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox2.Text = "Sex" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox3.Text = "Age" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox4.Text = "Civil Status" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox5.Text = "Address" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox6.Text = "Grade/Year and Section" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox7.Text = "Room/Building" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox8.Text = "Guardian" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox9.Text = "Guardian No." Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox11.Text = "Chief Complaints" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox12.Text = "Phone No." Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox13.Text = "Religion" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox14.Text = "Nationality" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox15.Text = "Birthdate" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox16.Text = "Name Adviser" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox17.Text = "Mother's Name" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox18.Text = "Mother's Contact Num" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox19.Text = "Father's Name" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox20.Text = "Father's Contact Num" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox21.Text = "Health Hx" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox22.Text = "Meds Taken" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox23.Text = "Allergies" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox24.Text = "Medicine" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox25.Text = "Food" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox26.Text = "BP" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox27.Text = "RR" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox28.Text = "PR" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox29.Text = "Temperature" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox30.Text = "O2Sat" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox31.Text = "LMP" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox32.Text = "Remarks" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox33.Text = "BMI" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox34.Text = "Ht" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox35.Text = "Wt" Then
            MsgBox("PLease fill up the missing information")
        Else
            Class1.Name = BunifuMaterialTextbox1.Text
            Class1.Age = BunifuMaterialTextbox3.Text
            Class1.Sex = BunifuMaterialTextbox2.Text
            Class1.CivilStatus = BunifuMaterialTextbox5.Text
            Class1.Address = BunifuMaterialTextbox4.Text
            Class1.GrYearSec = BunifuMaterialTextbox6.Text
            Class1.RoomBuilding = BunifuMaterialTextbox7.Text
            Class1.SchoolID = Label1.Text
            Class1.Guardian = BunifuMaterialTextbox8.Text
            Class1.NumGuardian = BunifuMaterialTextbox9.Text
            Class1.ChiefComplaints = BunifuMaterialTextbox11.Text
            Class1.PhoneNum = BunifuMaterialTextbox12.Text
            Class1.Religion = BunifuMaterialTextbox13.Text
            Class1.Nationality = BunifuMaterialTextbox14.Text
            Class1.BirthDate = BunifuMaterialTextbox15.Text
            Class1.NameAdviser = BunifuMaterialTextbox16.Text
            Class1.MotherName = BunifuMaterialTextbox17.Text
            Class1.MotherNum = BunifuMaterialTextbox18.Text
            Class1.FatherName = BunifuMaterialTextbox19.Text
            Class1.FatherNum = BunifuMaterialTextbox20.Text
            Class1.HealthHx = BunifuMaterialTextbox21.Text
            Class1.MedsTaken = BunifuMaterialTextbox22.Text
            Class1.Allergies = BunifuMaterialTextbox23.Text
            Class1.Medicine = BunifuMaterialTextbox24.Text
            Class1.Food = BunifuMaterialTextbox25.Text
            Class1.BP = BunifuMaterialTextbox26.Text
            Class1.RR = BunifuMaterialTextbox27.Text
            Class1.PR = BunifuMaterialTextbox28.Text
            Class1.Temperature = BunifuMaterialTextbox29.Text
            Class1.O2Sat = BunifuMaterialTextbox30.Text
            Class1.LMP = BunifuMaterialTextbox31.Text
            Class1.Remarks = BunifuMaterialTextbox32.Text
            Class1.BMI = BunifuMaterialTextbox33.Text
            Class1.Ht = BunifuMaterialTextbox34.Text
            Class1.Wt = BunifuMaterialTextbox35.Text
            openchildform(New MEDICALUP2())
            Me.Hide()
        End If
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        openchildform(New MEDICAL())
        Me.Hide()
    End Sub
End Class