Public Class MEDICAL
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
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs)
        openchildform(New MEDICALADD())
        Me.Hide()
    End Sub
    Private Sub MEDICAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mypopulate("select * from bxcq2xr2isgolaxd4zcg.record", DataGridView1)
    End Sub
    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs)
        openchildform(New MEDICALADD())
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton22_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Dim Name As String
        Dim Age As Integer
        Dim Sex As String
        Dim CivilStatus As String
        Dim Address As String
        Dim GrYearSec As String
        Dim RoomBuilding As String
        Dim SchoolID As String
        Dim Guardian As String
        Dim NumGuardian As String
        Dim ChiefComplaints As String
        Dim PhoneNum As String
        Dim Religion As String
        Dim Nationality As String
        Dim BirthDate As String
        Dim NameAdviser As String
        Dim MotherName As String
        Dim MotherNum As String
        Dim FatherName As String
        Dim FatherNum As String
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
        Dim LMP As String
        Dim Remarks As String
        Dim BMI As String
        Dim Ht As String
        Dim Wt As String
        Dim NameOfIncident As String
        Dim PlaceOfIncident As String
        Dim DateOfIncident As String
        Dim DateOfDisabilityBegan As String
        Dim PartOfTheBodyAffected As String
        Dim TimeOfIncident As String
        Dim TypeOfIncident As String
        Dim DescriptionOfIncident As String
        Dim Witness As String


        Name = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Age = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        Sex = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        CivilStatus = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
        Address = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value
        GrYearSec = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value
        RoomBuilding = DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value
        SchoolID = DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value
        Guardian = DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value
        NumGuardian = DataGridView1.Item(9, DataGridView1.CurrentRow.Index).Value
        ChiefComplaints = DataGridView1.Item(10, DataGridView1.CurrentRow.Index).Value
        PhoneNum = DataGridView1.Item(11, DataGridView1.CurrentRow.Index).Value
        Religion = DataGridView1.Item(12, DataGridView1.CurrentRow.Index).Value
        Nationality = DataGridView1.Item(13, DataGridView1.CurrentRow.Index).Value
        BirthDate = DataGridView1.Item(14, DataGridView1.CurrentRow.Index).Value
        NameAdviser = DataGridView1.Item(15, DataGridView1.CurrentRow.Index).Value
        MotherName = DataGridView1.Item(16, DataGridView1.CurrentRow.Index).Value
        MotherNum = DataGridView1.Item(17, DataGridView1.CurrentRow.Index).Value
        FatherName = DataGridView1.Item(18, DataGridView1.CurrentRow.Index).Value
        FatherNum = DataGridView1.Item(19, DataGridView1.CurrentRow.Index).Value
        HealthHx = DataGridView1.Item(20, DataGridView1.CurrentRow.Index).Value
        MedsTaken = DataGridView1.Item(21, DataGridView1.CurrentRow.Index).Value
        Allergies = DataGridView1.Item(22, DataGridView1.CurrentRow.Index).Value
        Medicine = DataGridView1.Item(23, DataGridView1.CurrentRow.Index).Value
        Food = DataGridView1.Item(24, DataGridView1.CurrentRow.Index).Value
        BP = DataGridView1.Item(25, DataGridView1.CurrentRow.Index).Value
        RR = DataGridView1.Item(26, DataGridView1.CurrentRow.Index).Value
        PR = DataGridView1.Item(27, DataGridView1.CurrentRow.Index).Value
        Temperature = DataGridView1.Item(28, DataGridView1.CurrentRow.Index).Value
        O2Sat = DataGridView1.Item(29, DataGridView1.CurrentRow.Index).Value
        LMP = DataGridView1.Item(30, DataGridView1.CurrentRow.Index).Value
        Remarks = DataGridView1.Item(31, DataGridView1.CurrentRow.Index).Value
        BMI = DataGridView1.Item(32, DataGridView1.CurrentRow.Index).Value
        Ht = DataGridView1.Item(33, DataGridView1.CurrentRow.Index).Value
        Wt = DataGridView1.Item(34, DataGridView1.CurrentRow.Index).Value
        NameOfIncident = DataGridView1.Item(35, DataGridView1.CurrentRow.Index).Value
        PlaceOfIncident = DataGridView1.Item(36, DataGridView1.CurrentRow.Index).Value
        DateOfIncident = DataGridView1.Item(37, DataGridView1.CurrentRow.Index).Value
        DateOfDisabilityBegan = DataGridView1.Item(38, DataGridView1.CurrentRow.Index).Value
        PartOfTheBodyAffected = DataGridView1.Item(39, DataGridView1.CurrentRow.Index).Value
        TimeOfIncident = DataGridView1.Item(40, DataGridView1.CurrentRow.Index).Value
        TypeOfIncident = DataGridView1.Item(41, DataGridView1.CurrentRow.Index).Value
        DescriptionOfIncident = DataGridView1.Item(42, DataGridView1.CurrentRow.Index).Value
        Witness = DataGridView1.Item(43, DataGridView1.CurrentRow.Index).Value


        Dim Result As DialogResult
        Result = MessageBox.Show("Are you sure you want to delete this medical record?", "Medical Record System", MessageBoxButtons.YesNo)

        If Result = System.Windows.Forms.DialogResult.Yes Then
            nonquery("insert into bxcq2xr2isgolaxd4zcg.archive values('" & Name & "','" & Age & "','" & Sex & "','" & CivilStatus & "','" & Address & "','" & GrYearSec & "','" & RoomBuilding & "','" & SchoolID & "','" & Guardian & "','" & NumGuardian & "','" & ChiefComplaints & "','" & PhoneNum & "','" & Religion & "','" & Nationality & "','" & BirthDate & "','" & NameAdviser & "','" & MotherName & "','" & MotherNum & "','" & FatherName & "','" & FatherNum & "','" & HealthHx & "','" & MedsTaken & "','" & Allergies & "','" & Medicine & "','" & Food & "','" & BP & "','" & RR & "','" & PR & "','" & Temperature & "','" & O2Sat & "','" & LMP & "','" & Remarks & "','" & BMI & "','" & Ht & "','" & Wt & "','" & NameOfIncident & "','" & PlaceOfIncident & "','" & DateOfIncident & "','" & DateOfDisabilityBegan & "','" & PartOfTheBodyAffected & "','" & TimeOfIncident & "','" & TypeOfIncident & "','" & DescriptionOfIncident & "','" & Witness & "')")
            nonquery("delete from bxcq2xr2isgolaxd4zcg.record where SchoolID = '" & SchoolID & "'")
            mypopulate("select * from bxcq2xr2isgolaxd4zcg.record", DataGridView1)
            mypopulate("select * from bxcq2xr2isgolaxd4zcg.archive", MEDICALARCHIVE.DataGridView1)
            MsgBox("Successfully Deleted")
        Else

        End If
    End Sub

    Private Sub BunifuThinButton25_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        openchildform(New MEDICALARCHIVE())
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton23_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click

        Class1.Name = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Class1.Age = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        Class1.Sex = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        Class1.CivilStatus = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
        Class1.Address = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value
        Class1.GrYearSec = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value
        Class1.RoomBuilding = DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value
        Class1.SchoolID = DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value
        Class1.Guardian = DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value
        Class1.NumGuardian = DataGridView1.Item(9, DataGridView1.CurrentRow.Index).Value
        Class1.ChiefComplaints = DataGridView1.Item(10, DataGridView1.CurrentRow.Index).Value
        Class1.PhoneNum = DataGridView1.Item(11, DataGridView1.CurrentRow.Index).Value
        Class1.Religion = DataGridView1.Item(12, DataGridView1.CurrentRow.Index).Value
        Class1.Nationality = DataGridView1.Item(13, DataGridView1.CurrentRow.Index).Value
        Class1.BirthDate = DataGridView1.Item(14, DataGridView1.CurrentRow.Index).Value
        Class1.NameAdviser = DataGridView1.Item(15, DataGridView1.CurrentRow.Index).Value
        Class1.MotherName = DataGridView1.Item(16, DataGridView1.CurrentRow.Index).Value
        Class1.MotherNum = DataGridView1.Item(17, DataGridView1.CurrentRow.Index).Value
        Class1.FatherName = DataGridView1.Item(18, DataGridView1.CurrentRow.Index).Value
        Class1.FatherNum = DataGridView1.Item(19, DataGridView1.CurrentRow.Index).Value
        Class1.HealthHx = DataGridView1.Item(20, DataGridView1.CurrentRow.Index).Value
        Class1.MedsTaken = DataGridView1.Item(21, DataGridView1.CurrentRow.Index).Value
        Class1.Allergies = DataGridView1.Item(22, DataGridView1.CurrentRow.Index).Value
        Class1.Medicine = DataGridView1.Item(23, DataGridView1.CurrentRow.Index).Value
        Class1.Food = DataGridView1.Item(24, DataGridView1.CurrentRow.Index).Value
        Class1.BP = DataGridView1.Item(25, DataGridView1.CurrentRow.Index).Value
        Class1.RR = DataGridView1.Item(26, DataGridView1.CurrentRow.Index).Value
        Class1.PR = DataGridView1.Item(27, DataGridView1.CurrentRow.Index).Value
        Class1.Temperature = DataGridView1.Item(28, DataGridView1.CurrentRow.Index).Value
        Class1.O2Sat = DataGridView1.Item(29, DataGridView1.CurrentRow.Index).Value
        Class1.LMP = DataGridView1.Item(30, DataGridView1.CurrentRow.Index).Value
        Class1.Remarks = DataGridView1.Item(31, DataGridView1.CurrentRow.Index).Value
        Class1.BMI = DataGridView1.Item(32, DataGridView1.CurrentRow.Index).Value
        Class1.Ht = DataGridView1.Item(33, DataGridView1.CurrentRow.Index).Value
        Class1.Wt = DataGridView1.Item(34, DataGridView1.CurrentRow.Index).Value
        Class1.NameOfIncident = DataGridView1.Item(35, DataGridView1.CurrentRow.Index).Value
        Class1.PlaceOfIncident = DataGridView1.Item(36, DataGridView1.CurrentRow.Index).Value
        Class1.DateOfIncident = DataGridView1.Item(37, DataGridView1.CurrentRow.Index).Value
        Class1.DateOfDisabilityBegan = DataGridView1.Item(38, DataGridView1.CurrentRow.Index).Value
        Class1.PartOfTheBodyAffected = DataGridView1.Item(39, DataGridView1.CurrentRow.Index).Value
        Class1.TimeOfIncident = DataGridView1.Item(40, DataGridView1.CurrentRow.Index).Value
        Class1.TypeOfIncident = DataGridView1.Item(41, DataGridView1.CurrentRow.Index).Value
        Class1.DescriptionOfIncident = DataGridView1.Item(42, DataGridView1.CurrentRow.Index).Value
        Class1.Witness = DataGridView1.Item(43, DataGridView1.CurrentRow.Index).Value

        openchildform(New MEDICALUP())
        Me.Hide()
    End Sub

    Private Sub BunifuMaterialTextbox6_OnValueChanged_1(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox6.OnValueChanged
        mypopulate("Select * from bxcq2xr2isgolaxd4zcg.record where " & ComboBox1.Text & " LIKE '%" & BunifuMaterialTextbox6.Text & "%'", DataGridView1)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        BunifuMaterialTextbox6.Text = ""
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Class1.Name = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Class1.Age = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        Class1.Sex = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        Class1.CivilStatus = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
        Class1.Address = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value
        Class1.GrYearSec = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value
        Class1.RoomBuilding = DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value
        Class1.SchoolID = DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value
        Class1.Guardian = DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value
        Class1.NumGuardian = DataGridView1.Item(9, DataGridView1.CurrentRow.Index).Value
        Class1.ChiefComplaints = DataGridView1.Item(10, DataGridView1.CurrentRow.Index).Value
        Class1.PhoneNum = DataGridView1.Item(11, DataGridView1.CurrentRow.Index).Value
        Class1.Religion = DataGridView1.Item(12, DataGridView1.CurrentRow.Index).Value
        Class1.Nationality = DataGridView1.Item(13, DataGridView1.CurrentRow.Index).Value
        Class1.BirthDate = DataGridView1.Item(14, DataGridView1.CurrentRow.Index).Value
        Class1.NameAdviser = DataGridView1.Item(15, DataGridView1.CurrentRow.Index).Value
        Class1.MotherName = DataGridView1.Item(16, DataGridView1.CurrentRow.Index).Value
        Class1.MotherNum = DataGridView1.Item(17, DataGridView1.CurrentRow.Index).Value
        Class1.FatherName = DataGridView1.Item(18, DataGridView1.CurrentRow.Index).Value
        Class1.FatherNum = DataGridView1.Item(19, DataGridView1.CurrentRow.Index).Value
        Class1.HealthHx = DataGridView1.Item(20, DataGridView1.CurrentRow.Index).Value
        Class1.MedsTaken = DataGridView1.Item(21, DataGridView1.CurrentRow.Index).Value
        Class1.Allergies = DataGridView1.Item(22, DataGridView1.CurrentRow.Index).Value
        Class1.Medicine = DataGridView1.Item(23, DataGridView1.CurrentRow.Index).Value
        Class1.Food = DataGridView1.Item(24, DataGridView1.CurrentRow.Index).Value
        Class1.BP = DataGridView1.Item(25, DataGridView1.CurrentRow.Index).Value
        Class1.RR = DataGridView1.Item(26, DataGridView1.CurrentRow.Index).Value
        Class1.PR = DataGridView1.Item(27, DataGridView1.CurrentRow.Index).Value
        Class1.Temperature = DataGridView1.Item(28, DataGridView1.CurrentRow.Index).Value
        Class1.O2Sat = DataGridView1.Item(29, DataGridView1.CurrentRow.Index).Value
        Class1.LMP = DataGridView1.Item(30, DataGridView1.CurrentRow.Index).Value
        Class1.Remarks = DataGridView1.Item(31, DataGridView1.CurrentRow.Index).Value
        Class1.BMI = DataGridView1.Item(32, DataGridView1.CurrentRow.Index).Value
        Class1.Ht = DataGridView1.Item(33, DataGridView1.CurrentRow.Index).Value
        Class1.Wt = DataGridView1.Item(34, DataGridView1.CurrentRow.Index).Value
        Class1.NameOfIncident = DataGridView1.Item(35, DataGridView1.CurrentRow.Index).Value
        Class1.PlaceOfIncident = DataGridView1.Item(36, DataGridView1.CurrentRow.Index).Value
        Class1.DateOfIncident = DataGridView1.Item(37, DataGridView1.CurrentRow.Index).Value
        Class1.DateOfDisabilityBegan = DataGridView1.Item(38, DataGridView1.CurrentRow.Index).Value
        Class1.PartOfTheBodyAffected = DataGridView1.Item(39, DataGridView1.CurrentRow.Index).Value
        Class1.TimeOfIncident = DataGridView1.Item(40, DataGridView1.CurrentRow.Index).Value
        Class1.TypeOfIncident = DataGridView1.Item(41, DataGridView1.CurrentRow.Index).Value
        Class1.DescriptionOfIncident = DataGridView1.Item(42, DataGridView1.CurrentRow.Index).Value
        Class1.Witness = DataGridView1.Item(43, DataGridView1.CurrentRow.Index).Value

        MEDICALSHOW.TextBox1.Text = Class1.Name
        MEDICALSHOW.TextBox2.Text = Class1.Age
        MEDICALSHOW.TextBox3.Text = Class1.Sex
        MEDICALSHOW.TextBox4.Text = Class1.CivilStatus
        MEDICALSHOW.TextBox5.Text = Class1.Address
        MEDICALSHOW.TextBox6.Text = Class1.GrYearSec
        MEDICALSHOW.TextBox7.Text = Class1.RoomBuilding
        MEDICALSHOW.TextBox8.Text = Class1.SchoolID
        MEDICALSHOW.TextBox9.Text = Class1.Guardian
        MEDICALSHOW.TextBox10.Text = Class1.NumGuardian
        MEDICALSHOW.TextBox11.Text = Class1.ChiefComplaints
        MEDICALSHOW.TextBox12.Text = Class1.PhoneNum
        MEDICALSHOW.TextBox13.Text = Class1.Religion
        MEDICALSHOW.TextBox14.Text = Class1.Nationality
        MEDICALSHOW.TextBox15.Text = Class1.BirthDate
        MEDICALSHOW.TextBox16.Text = Class1.NameAdviser
        MEDICALSHOW.TextBox17.Text = Class1.MotherName
        MEDICALSHOW.TextBox18.Text = Class1.MotherNum
        MEDICALSHOW.TextBox19.Text = Class1.FatherName
        MEDICALSHOW.TextBox20.Text = Class1.FatherNum
        MEDICALSHOW.TextBox21.Text = Class1.HealthHx
        MEDICALSHOW.TextBox22.Text = Class1.MedsTaken
        MEDICALSHOW.TextBox23.Text = Class1.Allergies
        MEDICALSHOW.TextBox24.Text = Class1.Medicine
        MEDICALSHOW.TextBox25.Text = Class1.Food
        MEDICALSHOW.TextBox26.Text = Class1.BP
        MEDICALSHOW.TextBox27.Text = Class1.RR
        MEDICALSHOW.TextBox28.Text = Class1.PR
        MEDICALSHOW.TextBox29.Text = Class1.Temperature
        MEDICALSHOW.TextBox30.Text = Class1.O2Sat
        MEDICALSHOW.TextBox31.Text = Class1.LMP
        MEDICALSHOW.TextBox32.Text = Class1.Remarks
        MEDICALSHOW.TextBox33.Text = Class1.BMI
        MEDICALSHOW.TextBox34.Text = Class1.Ht
        MEDICALSHOW.TextBox35.Text = Class1.Wt
        MEDICALSHOW.TextBox36.Text = Class1.NameOfIncident
        MEDICALSHOW.TextBox37.Text = Class1.PlaceOfIncident
        MEDICALSHOW.TextBox38.Text = Class1.DateOfIncident
        MEDICALSHOW.TextBox39.Text = Class1.DateOfDisabilityBegan
        MEDICALSHOW.TextBox40.Text = Class1.PartOfTheBodyAffected
        MEDICALSHOW.TextBox41.Text = Class1.TimeOfIncident
        MEDICALSHOW.TextBox42.Text = Class1.TypeOfIncident
        MEDICALSHOW.RichTextBox1.Text = Class1.DescriptionOfIncident
        MEDICALSHOW.RichTextBox2.Text = Class1.Witness
        MEDICALSHOW.Label70.Text = Class1.Name

        MEDICALSHOW.Show()

    End Sub
End Class