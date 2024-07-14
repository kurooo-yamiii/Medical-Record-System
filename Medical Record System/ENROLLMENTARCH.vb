Public Class ENROLLMENTARCH
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
    Private Sub ENROLLMENTARCH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mypopulate("select * from bxcq2xr2isgolaxd4zcg.enrollmentarch", DataGridView1)
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim Name As String
        Dim CourseStrand As String
        Dim YearGrade As String
        Dim Religion As String
        Dim Address As String
        Dim DateOfBirth As String
        Dim Age As String
        Dim PhoneNum As String
        Dim Father As String
        Dim FatherNum As String
        Dim Mother As String
        Dim MotherNum As String
        Dim Guardian As String
        Dim GuardianNum As String
        Dim ChickenPox As String
        Dim Measles As String
        Dim Mumps As String
        Dim Poliomyelitis As String
        Dim Diphteria As String
        Dim TyphoidFever As String
        Dim DengueFever As String
        Dim KidneyInfection As String
        Dim Malaria As String
        Dim Asthma As String
        Dim Pheumonia As String
        Dim Tubercolosis As String
        Dim Anemia As String
        Dim Hemophilia As String
        Dim HeartDisease As String
        Dim Epilepsy As String
        Dim Diabetes As String
        Dim Hypertension As String
        Dim Allergies As String
        Dim AnyOther As String
        Dim Hospitalized As String
        Dim Hearing As String
        Dim Vision As String
        Dim Q1 As String
        Dim Q2 As String
        Dim Q3 As String
        Dim Q4 As String
        Dim Q5 As String
        Dim Q6 As String
        Dim Q7 As String
        Dim Q8 As String
        Dim Q9 As String
        Dim Q10 As String
        Dim Q11 As String
        Dim Q12 As String
        Dim Q13 As String
        Dim BP As String
        Dim BodyMarks As String
        Dim Vision2 As String
        Dim Height As String
        Dim Weight As String
        Dim BMI As String
        Dim DentalHealth As String
        Dim LMP As String
        Dim BP2 As String
        Dim DPTOPV1 As String
        Dim DPTOPV2 As String
        Dim DPTOPV3 As String
        Dim Hepatitis As String
        Dim Measles2 As String
        Dim Other As String
        Dim CommentsRecommendation As String

        Name = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        CourseStrand = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        YearGrade = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        Religion = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
        Address = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value
        DateOfBirth = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value
        Age = DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value
        PhoneNum = DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value
        Father = DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value
        FatherNum = DataGridView1.Item(9, DataGridView1.CurrentRow.Index).Value
        Mother = DataGridView1.Item(10, DataGridView1.CurrentRow.Index).Value
        MotherNum = DataGridView1.Item(11, DataGridView1.CurrentRow.Index).Value
        Guardian = DataGridView1.Item(12, DataGridView1.CurrentRow.Index).Value
        GuardianNum = DataGridView1.Item(13, DataGridView1.CurrentRow.Index).Value
        ChickenPox = DataGridView1.Item(14, DataGridView1.CurrentRow.Index).Value
        Measles = DataGridView1.Item(15, DataGridView1.CurrentRow.Index).Value
        Mumps = DataGridView1.Item(16, DataGridView1.CurrentRow.Index).Value
        Poliomyelitis = DataGridView1.Item(17, DataGridView1.CurrentRow.Index).Value
        Diphteria = DataGridView1.Item(18, DataGridView1.CurrentRow.Index).Value
        TyphoidFever = DataGridView1.Item(19, DataGridView1.CurrentRow.Index).Value
        DengueFever = DataGridView1.Item(20, DataGridView1.CurrentRow.Index).Value
        KidneyInfection = DataGridView1.Item(21, DataGridView1.CurrentRow.Index).Value
        Malaria = DataGridView1.Item(22, DataGridView1.CurrentRow.Index).Value
        Asthma = DataGridView1.Item(23, DataGridView1.CurrentRow.Index).Value
        Pheumonia = DataGridView1.Item(24, DataGridView1.CurrentRow.Index).Value
        Tubercolosis = DataGridView1.Item(25, DataGridView1.CurrentRow.Index).Value
        Anemia = DataGridView1.Item(26, DataGridView1.CurrentRow.Index).Value
        Hemophilia = DataGridView1.Item(27, DataGridView1.CurrentRow.Index).Value
        HeartDisease = DataGridView1.Item(28, DataGridView1.CurrentRow.Index).Value
        Epilepsy = DataGridView1.Item(29, DataGridView1.CurrentRow.Index).Value
        Diabetes = DataGridView1.Item(30, DataGridView1.CurrentRow.Index).Value
        Hypertension = DataGridView1.Item(31, DataGridView1.CurrentRow.Index).Value
        Allergies = DataGridView1.Item(32, DataGridView1.CurrentRow.Index).Value
        AnyOther = DataGridView1.Item(33, DataGridView1.CurrentRow.Index).Value
        Hospitalized = DataGridView1.Item(34, DataGridView1.CurrentRow.Index).Value
        Hearing = DataGridView1.Item(35, DataGridView1.CurrentRow.Index).Value
        Vision = DataGridView1.Item(36, DataGridView1.CurrentRow.Index).Value
        Q1 = DataGridView1.Item(37, DataGridView1.CurrentRow.Index).Value
        Q2 = DataGridView1.Item(38, DataGridView1.CurrentRow.Index).Value
        Q3 = DataGridView1.Item(39, DataGridView1.CurrentRow.Index).Value
        Q4 = DataGridView1.Item(40, DataGridView1.CurrentRow.Index).Value
        Q5 = DataGridView1.Item(41, DataGridView1.CurrentRow.Index).Value
        Q6 = DataGridView1.Item(42, DataGridView1.CurrentRow.Index).Value
        Q7 = DataGridView1.Item(43, DataGridView1.CurrentRow.Index).Value
        Q8 = DataGridView1.Item(44, DataGridView1.CurrentRow.Index).Value
        Q9 = DataGridView1.Item(45, DataGridView1.CurrentRow.Index).Value
        Q10 = DataGridView1.Item(46, DataGridView1.CurrentRow.Index).Value
        Q11 = DataGridView1.Item(47, DataGridView1.CurrentRow.Index).Value
        Q12 = DataGridView1.Item(48, DataGridView1.CurrentRow.Index).Value
        Q13 = DataGridView1.Item(49, DataGridView1.CurrentRow.Index).Value
        BP = DataGridView1.Item(50, DataGridView1.CurrentRow.Index).Value
        BodyMarks = DataGridView1.Item(51, DataGridView1.CurrentRow.Index).Value
        Vision2 = DataGridView1.Item(52, DataGridView1.CurrentRow.Index).Value
        Height = DataGridView1.Item(53, DataGridView1.CurrentRow.Index).Value
        Weight = DataGridView1.Item(54, DataGridView1.CurrentRow.Index).Value
        BMI = DataGridView1.Item(55, DataGridView1.CurrentRow.Index).Value
        DentalHealth = DataGridView1.Item(56, DataGridView1.CurrentRow.Index).Value
        LMP = DataGridView1.Item(57, DataGridView1.CurrentRow.Index).Value
        BP2 = DataGridView1.Item(58, DataGridView1.CurrentRow.Index).Value
        DPTOPV1 = DataGridView1.Item(59, DataGridView1.CurrentRow.Index).Value
        DPTOPV2 = DataGridView1.Item(60, DataGridView1.CurrentRow.Index).Value
        DPTOPV3 = DataGridView1.Item(61, DataGridView1.CurrentRow.Index).Value
        Hepatitis = DataGridView1.Item(62, DataGridView1.CurrentRow.Index).Value
        Measles2 = DataGridView1.Item(63, DataGridView1.CurrentRow.Index).Value
        Other = DataGridView1.Item(64, DataGridView1.CurrentRow.Index).Value
        CommentsRecommendation = DataGridView1.Item(65, DataGridView1.CurrentRow.Index).Value

        nonquery("insert into bxcq2xr2isgolaxd4zcg.enrollment values('" & Name & "','" & CourseStrand & "','" & YearGrade & "','" & Religion & "','" & Address & "','" & DateOfBirth & "','" & Age & "','" & PhoneNum & "','" & Father & "','" & FatherNum & "','" & Mother & "','" & MotherNum & "','" & Guardian & "','" & GuardianNum & "','" & ChickenPox & "','" & Measles & "','" & Mumps & "','" & Poliomyelitis & "','" & Diphteria & "','" & TyphoidFever & "','" & DengueFever & "','" & KidneyInfection & "','" & Malaria & "','" & Asthma & "','" & Pheumonia & "','" & Tubercolosis & "','" & Anemia & "','" & Hemophilia & "','" & HeartDisease & "','" & Epilepsy & "','" & Diabetes & "','" & Hypertension & "','" & Allergies & "','" & AnyOther & "','" & Hospitalized & "','" & Hearing & "','" & Vision & "','" & Q1 & "','" & Q2 & "','" & Q3 & "','" & Q4 & "','" & Q5 & "','" & Q6 & "','" & Q7 & "','" & Q8 & "','" & Q9 & "','" & Q10 & "','" & Q11 & "','" & Q12 & "','" & Q13 & "','" & BP & "','" & BodyMarks & "','" & Vision2 & "','" & Height & "','" & Weight & "','" & BMI & "','" & DentalHealth & "','" & LMP & "','" & BP2 & "','" & DPTOPV1 & "','" & DPTOPV2 & "','" & DPTOPV3 & "','" & Hepatitis & "','" & Measles2 & "','" & Other & "','" & CommentsRecommendation & "')")
        nonquery("delete from bxcq2xr2isgolaxd4zcg.enrollmentarch where Name = '" & Name & "' and Address = '" & Address & "'")
        mypopulate("select * from bxcq2xr2isgolaxd4zcg.enrollment", EMPLOYEE.DataGridView1)
        mypopulate("select * from bxcq2xr2isgolaxd4zcg.enrollmentarch", DataGridView1)
        MsgBox("Successfully Restored")
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        openchildform(New ENROLLMENT())
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Dim Name As String
        Dim Address As String

        Address = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value
        Name = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value


        Dim Result As DialogResult
        Result = MessageBox.Show("Are you sure you want to delete this medical record forever?", "Medical Record System", MessageBoxButtons.YesNo)

        If Result = System.Windows.Forms.DialogResult.Yes Then
            nonquery("delete from bxcq2xr2isgolaxd4zcg.enrollmentarch where Name = '" & Name & "' and Address = '" & Address & "'")
            mypopulate("select * from bxcq2xr2isgolaxd4zcg.enrollment", EMPLOYEE.DataGridView1)
            mypopulate("select * from bxcq2xr2isgolaxd4zcg.enrollmentarch", DataGridView1)
            MsgBox("Successfully Deleted")
        Else

        End If
    End Sub

    Private Sub BunifuMaterialTextbox6_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox6.OnValueChanged
        mypopulate("Select * from bxcq2xr2isgolaxd4zcg.enrollmentarch where " & ComboBox1.Text & " LIKE '%" & BunifuMaterialTextbox6.Text & "%'", DataGridView1)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        BunifuMaterialTextbox6.Text = ""
    End Sub
End Class