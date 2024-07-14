Public Class EMPLOYEEARCH

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
    Private Sub EMPLOYEEARCH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mypopulate("select * from bxcq2xr2isgolaxd4zcg.employeearch", DataGridView1)
    End Sub
    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs)
        Dim Name As String

        Name = DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value

        Dim Result As DialogResult
        Result = MessageBox.Show("Are you sure you want to delete this medical record forever?", "Medical Record System", MessageBoxButtons.YesNo)

        If Result = System.Windows.Forms.DialogResult.Yes Then
            nonquery("delete from bxcq2xr2isgolaxd4zcg.employeearch where Name = '" & Name & "'")
            mypopulate("select * from bxcq2xr2isgolaxd4zcg.employeearch", DataGridView1)
            MsgBox("Successfully Deleted")
        Else
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        BunifuMaterialTextbox6.Text = ""
    End Sub

    
    Private Sub BunifuThinButton22_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Dim Name As String

        Name = DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value

        Dim Result As DialogResult
        Result = MessageBox.Show("Are you sure you want to delete this medical record forever?", "Medical Record System", MessageBoxButtons.YesNo)

        If Result = System.Windows.Forms.DialogResult.Yes Then
            nonquery("delete from bxcq2xr2isgolaxd4zcg.employeearch where Name = '" & Name & "'")
            mypopulate("select * from bxcq2xr2isgolaxd4zcg.employeearch", DataGridView1)
            MsgBox("Successfully Deleted")
        Else

        End If
    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim Establishment As String
        Dim NameOfBusiness As String
        Dim AddressWork As String
        Dim NumOfEmploymentMale As String
        Dim NumofEmploymentFemale As String
        Dim TotalEmployees As String
        Dim Manager As String
        Dim Name As String
        Dim Age As String
        Dim Sex As String
        Dim CivilStatus As String
        Dim Address As String
        Dim Position As String
        Dim PhoneNum As String
        Dim Religion As String
        Dim Nationality As String
        Dim ExperienceOfOccupation As String
        Dim NumOfDependents As String
        Dim BirthDate As String
        Dim MonthlyWage As String
        Dim WorkshiftAM As String
        Dim WorkshiftPM As String
        Dim HoursOfWorkDay As String
        Dim Week As String
        Dim EmergencyNum As String
        Dim Relationship As String
        Dim Phone As String
        Dim Agency As String
        Dim AgencyAddress As String
        Dim ChiefComplaints As String
        Dim HealthHx As String
        Dim MedsTaken As String
        Dim Allergies As String
        Dim Medicine As String
        Dim Food As String
        Dim BP As String
        Dim RR As String
        Dim PR As String
        Dim Temperature As String
        Dim O2Sat As String
        Dim Wt As String
        Dim Ht As String
        Dim BMI As String
        Dim Remarks As String
        Dim LMP As String
        Dim NameOfIncident As String
        Dim PlaceOfIncident As String
        Dim DateOfIncident As String
        Dim DateOfDisabilityBegan As String
        Dim PartOfTheBodyAffected
        Dim TimeOfIncident As String
        Dim TypeOfIncident As String
        Dim PropertyDamage As String
        Dim PersonalInjury As String
        Dim DateOfReturnedToWork As String
        Dim DayLost As String
        Dim UnsafeAct As String
        Dim UnsafeMechanical As String
        Dim ContributingFactor As String
        Dim ExtentOfDisability As String
        Dim DamageOfProperty As String
        Dim DescriptionOfIncident As String
        Dim Witness As String

        Establishment = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        NameOfBusiness = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        AddressWork = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        NumOfEmploymentMale = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
        NumofEmploymentFemale = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value
        TotalEmployees = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value
        Manager = DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value
        Name = DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value
        Age = DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value
        Sex = DataGridView1.Item(9, DataGridView1.CurrentRow.Index).Value
        CivilStatus = DataGridView1.Item(10, DataGridView1.CurrentRow.Index).Value
        Address = DataGridView1.Item(11, DataGridView1.CurrentRow.Index).Value
        Position = DataGridView1.Item(12, DataGridView1.CurrentRow.Index).Value
        PhoneNum = DataGridView1.Item(13, DataGridView1.CurrentRow.Index).Value
        Religion = DataGridView1.Item(14, DataGridView1.CurrentRow.Index).Value
        Nationality = DataGridView1.Item(15, DataGridView1.CurrentRow.Index).Value
        ExperienceOfOccupation = DataGridView1.Item(16, DataGridView1.CurrentRow.Index).Value
        NumOfDependents = DataGridView1.Item(17, DataGridView1.CurrentRow.Index).Value
        BirthDate = DataGridView1.Item(18, DataGridView1.CurrentRow.Index).Value
        MonthlyWage = DataGridView1.Item(19, DataGridView1.CurrentRow.Index).Value
        WorkshiftAM = DataGridView1.Item(20, DataGridView1.CurrentRow.Index).Value
        WorkshiftPM = DataGridView1.Item(21, DataGridView1.CurrentRow.Index).Value
        HoursOfWorkDay = DataGridView1.Item(22, DataGridView1.CurrentRow.Index).Value
        Week = DataGridView1.Item(23, DataGridView1.CurrentRow.Index).Value
        EmergencyNum = DataGridView1.Item(24, DataGridView1.CurrentRow.Index).Value
        Relationship = DataGridView1.Item(25, DataGridView1.CurrentRow.Index).Value
        Phone = DataGridView1.Item(26, DataGridView1.CurrentRow.Index).Value
        Agency = DataGridView1.Item(27, DataGridView1.CurrentRow.Index).Value
        AgencyAddress = DataGridView1.Item(28, DataGridView1.CurrentRow.Index).Value
        ChiefComplaints = DataGridView1.Item(29, DataGridView1.CurrentRow.Index).Value
        HealthHx = DataGridView1.Item(30, DataGridView1.CurrentRow.Index).Value
        MedsTaken = DataGridView1.Item(31, DataGridView1.CurrentRow.Index).Value
        Allergies = DataGridView1.Item(32, DataGridView1.CurrentRow.Index).Value
        Medicine = DataGridView1.Item(33, DataGridView1.CurrentRow.Index).Value
        Food = DataGridView1.Item(34, DataGridView1.CurrentRow.Index).Value
        BP = DataGridView1.Item(35, DataGridView1.CurrentRow.Index).Value
        RR = DataGridView1.Item(36, DataGridView1.CurrentRow.Index).Value
        PR = DataGridView1.Item(37, DataGridView1.CurrentRow.Index).Value
        Temperature = DataGridView1.Item(38, DataGridView1.CurrentRow.Index).Value
        O2Sat = DataGridView1.Item(39, DataGridView1.CurrentRow.Index).Value
        Wt = DataGridView1.Item(40, DataGridView1.CurrentRow.Index).Value
        Ht = DataGridView1.Item(41, DataGridView1.CurrentRow.Index).Value
        BMI = DataGridView1.Item(42, DataGridView1.CurrentRow.Index).Value
        Remarks = DataGridView1.Item(43, DataGridView1.CurrentRow.Index).Value
        LMP = DataGridView1.Item(44, DataGridView1.CurrentRow.Index).Value
        NameOfIncident = DataGridView1.Item(45, DataGridView1.CurrentRow.Index).Value
        PlaceOfIncident = DataGridView1.Item(46, DataGridView1.CurrentRow.Index).Value
        DateOfIncident = DataGridView1.Item(47, DataGridView1.CurrentRow.Index).Value
        DateOfDisabilityBegan = DataGridView1.Item(48, DataGridView1.CurrentRow.Index).Value
        PartOfTheBodyAffected = DataGridView1.Item(49, DataGridView1.CurrentRow.Index).Value
        TimeOfIncident = DataGridView1.Item(50, DataGridView1.CurrentRow.Index).Value
        TypeOfIncident = DataGridView1.Item(51, DataGridView1.CurrentRow.Index).Value
        PropertyDamage = DataGridView1.Item(52, DataGridView1.CurrentRow.Index).Value
        PersonalInjury = DataGridView1.Item(53, DataGridView1.CurrentRow.Index).Value
        DateOfReturnedToWork = DataGridView1.Item(54, DataGridView1.CurrentRow.Index).Value
        DayLost = DataGridView1.Item(55, DataGridView1.CurrentRow.Index).Value
        UnsafeAct = DataGridView1.Item(56, DataGridView1.CurrentRow.Index).Value
        UnsafeMechanical = DataGridView1.Item(57, DataGridView1.CurrentRow.Index).Value
        ContributingFactor = DataGridView1.Item(58, DataGridView1.CurrentRow.Index).Value
        ExtentOfDisability = DataGridView1.Item(59, DataGridView1.CurrentRow.Index).Value
        DamageOfProperty = DataGridView1.Item(60, DataGridView1.CurrentRow.Index).Value
        DescriptionOfIncident = DataGridView1.Item(61, DataGridView1.CurrentRow.Index).Value
        Witness = DataGridView1.Item(62, DataGridView1.CurrentRow.Index).Value

        nonquery("insert into bxcq2xr2isgolaxd4zcg.employee values('" & Establishment & "','" & NameOfBusiness & "','" & AddressWork & "','" & NumOfEmploymentMale & "','" & NumofEmploymentFemale & "','" & TotalEmployees & "','" & Manager & "','" & Name & "','" & Age & "','" & Sex & "','" & CivilStatus & "','" & Address & "','" & Position & "','" & PhoneNum & "','" & Religion & "','" & Nationality & "','" & ExperienceOfOccupation & "','" & NumOfDependents & "','" & BirthDate & "','" & MonthlyWage & "','" & WorkshiftAM & "','" & WorkshiftPM & "','" & HoursOfWorkDay & "','" & Week & "','" & EmergencyNum & "','" & Relationship & "','" & Phone & "','" & Agency & "','" & AgencyAddress & "','" & ChiefComplaints & "','" & HealthHx & "','" & MedsTaken & "','" & Allergies & "','" & Medicine & "','" & Food & "','" & BP & "','" & RR & "','" & PR & "','" & Temperature & "','" & O2Sat & "','" & Wt & "','" & Ht & "','" & BMI & "','" & Remarks & "','" & LMP & "','" & NameOfIncident & "','" & PlaceOfIncident & "','" & DateOfIncident & "','" & DateOfDisabilityBegan & "','" & PartOfTheBodyAffected & "','" & TimeOfIncident & "','" & TypeOfIncident & "','" & PropertyDamage & "','" & PersonalInjury & "','" & DateOfReturnedToWork & "','" & DayLost & "','" & UnsafeAct & "','" & UnsafeMechanical & "','" & ContributingFactor & "','" & ExtentOfDisability & "','" & DamageOfProperty & "','" & DescriptionOfIncident & "','" & Witness & "')")
        nonquery("delete from bxcq2xr2isgolaxd4zcg.employeearch where Name = '" & Name & "'")
        mypopulate("select * from bxcq2xr2isgolaxd4zcg.employee", EMPLOYEE.DataGridView1)
        mypopulate("select * from bxcq2xr2isgolaxd4zcg.employeearch", DataGridView1)
        MsgBox("Successfully Restored")
        openchildform(New EMPLOYEE())
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton23_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        openchildform(New EMPLOYEE())
        Me.Hide()
    End Sub

    Private Sub BunifuMaterialTextbox6_OnValueChanged_1(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox6.OnValueChanged
        mypopulate("Select * from bxcq2xr2isgolaxd4zcg.employeearch where " & ComboBox1.Text & " LIKE '%" & BunifuMaterialTextbox6.Text & "%'", DataGridView1)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        BunifuMaterialTextbox6.Text = ""
    End Sub
End Class