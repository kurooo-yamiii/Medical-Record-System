Public Class MEDICALUP2
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
    Private Sub MEDICALUP2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuMaterialTextbox1.Text = Class1.NameOfIncident
        BunifuMaterialTextbox2.Text = Class1.PlaceOfIncident
        BunifuMaterialTextbox3.Text = Class1.DateOfIncident
        BunifuMaterialTextbox4.Text = Class1.DateOfDisabilityBegan
        BunifuMaterialTextbox5.Text = Class1.PartOfTheBodyAffected
        BunifuMaterialTextbox6.Text = Class1.TimeOfIncident
        BunifuMaterialTextbox7.Text = Class1.TypeOfIncident
        RichTextBox1.Text = Class1.DescriptionOfIncident
        RichTextBox2.Text = Class1.Witness
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
            nonquery("update bxcq2xr2isgolaxd4zcg.record set Name = '" & Class1.Name & "', Age = '" & Class1.Age & "', Sex = '" & Class1.Sex & "', CivilStatus = '" & Class1.CivilStatus & "', Address = '" & Class1.Address & "', GrYearSec = '" & Class1.GrYearSec & "', RoomBuilding = '" & Class1.RoomBuilding & "', SchoolID = '" & Class1.SchoolID & "', Guardian = '" & Class1.Guardian & "', GuardianNum = '" & Class1.NumGuardian & "', ChiefComplaints = '" & Class1.ChiefComplaints & "', PhoneNum = '" & Class1.PhoneNum & "', Religion = '" & Class1.Religion & "', Nationality = '" & Class1.Nationality & "', BirthDate = '" & Class1.BirthDate & "', NameAdviser = '" & Class1.NameAdviser & "', MotherName = '" & Class1.MotherName & "', MotherNameNum = '" & Class1.MotherNum & "', FatherName = '" & Class1.FatherName & "', FatherNameNum = '" & Class1.FatherNum & "', HealthHx = '" & Class1.HealthHx & "', MedsTaken = '" & Class1.MedsTaken & "', Allergies = '" & Class1.Allergies & "', Medicine = '" & Class1.Medicine & "', Food = '" & Class1.Food & "', BP = '" & Class1.BP & "', RR = '" & Class1.RR & "', PR = '" & Class1.PR & "', Temperature = '" & Class1.Temperature & "', O2Sat = '" & Class1.O2Sat & "', LMP = '" & Class1.LMP & "', Remarks = '" & Class1.Remarks & "', BMI = '" & Class1.BMI & "', Ht = '" & Class1.Ht & "', Wt = '" & Class1.Wt & "', NameOfIncident = '" & BunifuMaterialTextbox1.Text & "', PlaceOfIncident = '" & BunifuMaterialTextbox2.Text & "', DateOfIncident = '" & BunifuMaterialTextbox3.Text & "', DateOfDisabilityBegan = '" & BunifuMaterialTextbox4.Text & "', PartOfBodyAffected = '" & BunifuMaterialTextbox5.Text & "', TimeOfIncident = '" & BunifuMaterialTextbox6.Text & "', TypeOfIncident = '" & BunifuMaterialTextbox7.Text & "', DescriptionOfAccident = '" & RichTextBox1.Text & "', Witness = '" & RichTextBox2.Text & "' where SchoolID = '" & Class1.SchoolID & "'")
            mypopulate("select * from bxcq2xr2isgolaxd4zcg.record", MEDICAL.DataGridView1)
            MsgBox("Succesfully Updated")
            openchildform(New MEDICAL())
            Me.Hide()
        End If
    End Sub
End Class
