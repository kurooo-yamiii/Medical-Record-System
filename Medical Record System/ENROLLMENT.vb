Public Class ENROLLMENT
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
        openchildform(New ENROLLMENTADD())
        Me.Hide()
    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint
        mypopulate("select * from bxcq2xr2isgolaxd4zcg.enrollment", DataGridView1)
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
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

        Dim Result As DialogResult
        Result = MessageBox.Show("Are you sure you want to delete this medical record?", "Medical Record System", MessageBoxButtons.YesNo)

        If Result = System.Windows.Forms.DialogResult.Yes Then
            nonquery("insert into bxcq2xr2isgolaxd4zcg.enrollmentarch values('" & Name & "','" & CourseStrand & "','" & YearGrade & "','" & Religion & "','" & Address & "','" & DateOfBirth & "','" & Age & "','" & PhoneNum & "','" & Father & "','" & FatherNum & "','" & Mother & "','" & MotherNum & "','" & Guardian & "','" & GuardianNum & "','" & ChickenPox & "','" & Measles & "','" & Mumps & "','" & Poliomyelitis & "','" & Diphteria & "','" & TyphoidFever & "','" & DengueFever & "','" & KidneyInfection & "','" & Malaria & "','" & Asthma & "','" & Pheumonia & "','" & Tubercolosis & "','" & Anemia & "','" & Hemophilia & "','" & HeartDisease & "','" & Epilepsy & "','" & Diabetes & "','" & Hypertension & "','" & Allergies & "','" & AnyOther & "','" & Hospitalized & "','" & Hearing & "','" & Vision & "','" & Q1 & "','" & Q2 & "','" & Q3 & "','" & Q4 & "','" & Q5 & "','" & Q6 & "','" & Q7 & "','" & Q8 & "','" & Q9 & "','" & Q10 & "','" & Q11 & "','" & Q12 & "','" & Q13 & "','" & BP & "','" & BodyMarks & "','" & Vision2 & "','" & Height & "','" & Weight & "','" & BMI & "','" & DentalHealth & "','" & LMP & "','" & BP2 & "','" & DPTOPV1 & "','" & DPTOPV2 & "','" & DPTOPV3 & "','" & Hepatitis & "','" & Measles2 & "','" & Other & "','" & CommentsRecommendation & "')")
            nonquery("delete from bxcq2xr2isgolaxd4zcg.enrollment where Name = '" & Name & "' and Address = '" & Address & "'")
            mypopulate("select * from bxcq2xr2isgolaxd4zcg.enrollmentarch", EMPLOYEEARCH.DataGridView1)
            mypopulate("select * from bxcq2xr2isgolaxd4zcg.enrollment", DataGridView1)
            MsgBox("Successfully Deleted")
        Else

        End If
    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        openchildform(New ENROLLMENTARCH())
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        Class3.Name = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Class3.CourseStrand = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        Class3.YearGrade = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        Class3.Religion = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
        Class3.Address = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value
        Class3.DateOfBirth = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value
        Class3.Age = DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value
        Class3.PhoneNum = DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value
        Class3.Father = DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value
        Class3.FatherNum = DataGridView1.Item(9, DataGridView1.CurrentRow.Index).Value
        Class3.Mother = DataGridView1.Item(10, DataGridView1.CurrentRow.Index).Value
        Class3.MotherNum = DataGridView1.Item(11, DataGridView1.CurrentRow.Index).Value
        Class3.Guardian = DataGridView1.Item(12, DataGridView1.CurrentRow.Index).Value
        Class3.GuardianNum = DataGridView1.Item(13, DataGridView1.CurrentRow.Index).Value
        Class3.ChickenPox = DataGridView1.Item(14, DataGridView1.CurrentRow.Index).Value
        Class3.Measles = DataGridView1.Item(15, DataGridView1.CurrentRow.Index).Value
        Class3.Mumps = DataGridView1.Item(16, DataGridView1.CurrentRow.Index).Value
        Class3.Poliomyelitis = DataGridView1.Item(17, DataGridView1.CurrentRow.Index).Value
        Class3.Diphteria = DataGridView1.Item(18, DataGridView1.CurrentRow.Index).Value
        Class3.TyphoidFever = DataGridView1.Item(19, DataGridView1.CurrentRow.Index).Value
        Class3.DengueFever = DataGridView1.Item(20, DataGridView1.CurrentRow.Index).Value
        Class3.KidneyInfection = DataGridView1.Item(21, DataGridView1.CurrentRow.Index).Value
        Class3.Malaria = DataGridView1.Item(22, DataGridView1.CurrentRow.Index).Value
        Class3.Asthma = DataGridView1.Item(23, DataGridView1.CurrentRow.Index).Value
        Class3.Pheumonia = DataGridView1.Item(24, DataGridView1.CurrentRow.Index).Value
        Class3.Tubercolosis = DataGridView1.Item(25, DataGridView1.CurrentRow.Index).Value
        Class3.Anemia = DataGridView1.Item(26, DataGridView1.CurrentRow.Index).Value
        Class3.Hemophilia = DataGridView1.Item(27, DataGridView1.CurrentRow.Index).Value
        Class3.HeartDisease = DataGridView1.Item(28, DataGridView1.CurrentRow.Index).Value
        Class3.Epilepsy = DataGridView1.Item(29, DataGridView1.CurrentRow.Index).Value
        Class3.Diabetes = DataGridView1.Item(30, DataGridView1.CurrentRow.Index).Value
        Class3.Hypertension = DataGridView1.Item(31, DataGridView1.CurrentRow.Index).Value
        Class3.Allergies = DataGridView1.Item(32, DataGridView1.CurrentRow.Index).Value
        Class3.AnyOther = DataGridView1.Item(33, DataGridView1.CurrentRow.Index).Value
        Class3.Hospitalized = DataGridView1.Item(34, DataGridView1.CurrentRow.Index).Value
        Class3.Hearing = DataGridView1.Item(35, DataGridView1.CurrentRow.Index).Value
        Class3.Vision = DataGridView1.Item(36, DataGridView1.CurrentRow.Index).Value
        Class3.Q1 = DataGridView1.Item(37, DataGridView1.CurrentRow.Index).Value
        Class3.Q2 = DataGridView1.Item(38, DataGridView1.CurrentRow.Index).Value
        Class3.Q3 = DataGridView1.Item(39, DataGridView1.CurrentRow.Index).Value
        Class3.Q4 = DataGridView1.Item(40, DataGridView1.CurrentRow.Index).Value
        Class3.Q5 = DataGridView1.Item(41, DataGridView1.CurrentRow.Index).Value
        Class3.Q6 = DataGridView1.Item(42, DataGridView1.CurrentRow.Index).Value
        Class3.Q7 = DataGridView1.Item(43, DataGridView1.CurrentRow.Index).Value
        Class3.Q8 = DataGridView1.Item(44, DataGridView1.CurrentRow.Index).Value
        Class3.Q9 = DataGridView1.Item(45, DataGridView1.CurrentRow.Index).Value
        Class3.Q10 = DataGridView1.Item(46, DataGridView1.CurrentRow.Index).Value
        Class3.Q11 = DataGridView1.Item(47, DataGridView1.CurrentRow.Index).Value
        Class3.Q12 = DataGridView1.Item(48, DataGridView1.CurrentRow.Index).Value
        Class3.Q13 = DataGridView1.Item(49, DataGridView1.CurrentRow.Index).Value
        Class3.BP = DataGridView1.Item(50, DataGridView1.CurrentRow.Index).Value
        Class3.BodyMarks = DataGridView1.Item(51, DataGridView1.CurrentRow.Index).Value
        Class3.Vision2 = DataGridView1.Item(52, DataGridView1.CurrentRow.Index).Value
        Class3.Height = DataGridView1.Item(53, DataGridView1.CurrentRow.Index).Value
        Class3.Weight = DataGridView1.Item(54, DataGridView1.CurrentRow.Index).Value
        Class3.BMI = DataGridView1.Item(55, DataGridView1.CurrentRow.Index).Value
        Class3.DentalHealth = DataGridView1.Item(56, DataGridView1.CurrentRow.Index).Value
        Class3.LMP = DataGridView1.Item(57, DataGridView1.CurrentRow.Index).Value
        Class3.BP2 = DataGridView1.Item(58, DataGridView1.CurrentRow.Index).Value
        Class3.DPTOPV1 = DataGridView1.Item(59, DataGridView1.CurrentRow.Index).Value
        Class3.DPTOPV2 = DataGridView1.Item(60, DataGridView1.CurrentRow.Index).Value
        Class3.DPTOPV3 = DataGridView1.Item(61, DataGridView1.CurrentRow.Index).Value
        Class3.Hepatitis = DataGridView1.Item(62, DataGridView1.CurrentRow.Index).Value
        Class3.Measles2 = DataGridView1.Item(63, DataGridView1.CurrentRow.Index).Value
        Class3.Other = DataGridView1.Item(64, DataGridView1.CurrentRow.Index).Value
        Class3.CommentsRecommendation = DataGridView1.Item(65, DataGridView1.CurrentRow.Index).Value
        openchildform(New ENROLLMENTUP())
        Me.Hide()
    End Sub

    Private Sub BunifuMaterialTextbox6_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox6.OnValueChanged
        mypopulate("Select * from bxcq2xr2isgolaxd4zcg.enrollment where " & ComboBox1.Text & " LIKE '%" & BunifuMaterialTextbox6.Text & "%'", DataGridView1)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        BunifuMaterialTextbox6.Text = ""
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Class3.Name = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Class3.CourseStrand = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        Class3.YearGrade = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        Class3.Religion = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
        Class3.Address = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value
        Class3.DateOfBirth = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value
        Class3.Age = DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value
        Class3.PhoneNum = DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value
        Class3.Father = DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value
        Class3.FatherNum = DataGridView1.Item(9, DataGridView1.CurrentRow.Index).Value
        Class3.Mother = DataGridView1.Item(10, DataGridView1.CurrentRow.Index).Value
        Class3.MotherNum = DataGridView1.Item(11, DataGridView1.CurrentRow.Index).Value
        Class3.Guardian = DataGridView1.Item(12, DataGridView1.CurrentRow.Index).Value
        Class3.GuardianNum = DataGridView1.Item(13, DataGridView1.CurrentRow.Index).Value
        Class3.ChickenPox = DataGridView1.Item(14, DataGridView1.CurrentRow.Index).Value
        Class3.Measles = DataGridView1.Item(15, DataGridView1.CurrentRow.Index).Value
        Class3.Mumps = DataGridView1.Item(16, DataGridView1.CurrentRow.Index).Value
        Class3.Poliomyelitis = DataGridView1.Item(17, DataGridView1.CurrentRow.Index).Value
        Class3.Diphteria = DataGridView1.Item(18, DataGridView1.CurrentRow.Index).Value
        Class3.TyphoidFever = DataGridView1.Item(19, DataGridView1.CurrentRow.Index).Value
        Class3.DengueFever = DataGridView1.Item(20, DataGridView1.CurrentRow.Index).Value
        Class3.KidneyInfection = DataGridView1.Item(21, DataGridView1.CurrentRow.Index).Value
        Class3.Malaria = DataGridView1.Item(22, DataGridView1.CurrentRow.Index).Value
        Class3.Asthma = DataGridView1.Item(23, DataGridView1.CurrentRow.Index).Value
        Class3.Pheumonia = DataGridView1.Item(24, DataGridView1.CurrentRow.Index).Value
        Class3.Tubercolosis = DataGridView1.Item(25, DataGridView1.CurrentRow.Index).Value
        Class3.Anemia = DataGridView1.Item(26, DataGridView1.CurrentRow.Index).Value
        Class3.Hemophilia = DataGridView1.Item(27, DataGridView1.CurrentRow.Index).Value
        Class3.HeartDisease = DataGridView1.Item(28, DataGridView1.CurrentRow.Index).Value
        Class3.Epilepsy = DataGridView1.Item(29, DataGridView1.CurrentRow.Index).Value
        Class3.Diabetes = DataGridView1.Item(30, DataGridView1.CurrentRow.Index).Value
        Class3.Hypertension = DataGridView1.Item(31, DataGridView1.CurrentRow.Index).Value
        Class3.Allergies = DataGridView1.Item(32, DataGridView1.CurrentRow.Index).Value
        Class3.AnyOther = DataGridView1.Item(33, DataGridView1.CurrentRow.Index).Value
        Class3.Hospitalized = DataGridView1.Item(34, DataGridView1.CurrentRow.Index).Value
        Class3.Hearing = DataGridView1.Item(35, DataGridView1.CurrentRow.Index).Value
        Class3.Vision = DataGridView1.Item(36, DataGridView1.CurrentRow.Index).Value
        Class3.Q1 = DataGridView1.Item(37, DataGridView1.CurrentRow.Index).Value
        Class3.Q2 = DataGridView1.Item(38, DataGridView1.CurrentRow.Index).Value
        Class3.Q3 = DataGridView1.Item(39, DataGridView1.CurrentRow.Index).Value
        Class3.Q4 = DataGridView1.Item(40, DataGridView1.CurrentRow.Index).Value
        Class3.Q5 = DataGridView1.Item(41, DataGridView1.CurrentRow.Index).Value
        Class3.Q6 = DataGridView1.Item(42, DataGridView1.CurrentRow.Index).Value
        Class3.Q7 = DataGridView1.Item(43, DataGridView1.CurrentRow.Index).Value
        Class3.Q8 = DataGridView1.Item(44, DataGridView1.CurrentRow.Index).Value
        Class3.Q9 = DataGridView1.Item(45, DataGridView1.CurrentRow.Index).Value
        Class3.Q10 = DataGridView1.Item(46, DataGridView1.CurrentRow.Index).Value
        Class3.Q11 = DataGridView1.Item(47, DataGridView1.CurrentRow.Index).Value
        Class3.Q12 = DataGridView1.Item(48, DataGridView1.CurrentRow.Index).Value
        Class3.Q13 = DataGridView1.Item(49, DataGridView1.CurrentRow.Index).Value
        Class3.BP = DataGridView1.Item(50, DataGridView1.CurrentRow.Index).Value
        Class3.BodyMarks = DataGridView1.Item(51, DataGridView1.CurrentRow.Index).Value
        Class3.Vision2 = DataGridView1.Item(52, DataGridView1.CurrentRow.Index).Value
        Class3.Height = DataGridView1.Item(53, DataGridView1.CurrentRow.Index).Value
        Class3.Weight = DataGridView1.Item(54, DataGridView1.CurrentRow.Index).Value
        Class3.BMI = DataGridView1.Item(55, DataGridView1.CurrentRow.Index).Value
        Class3.DentalHealth = DataGridView1.Item(56, DataGridView1.CurrentRow.Index).Value
        Class3.LMP = DataGridView1.Item(57, DataGridView1.CurrentRow.Index).Value
        Class3.BP2 = DataGridView1.Item(58, DataGridView1.CurrentRow.Index).Value
        Class3.DPTOPV1 = DataGridView1.Item(59, DataGridView1.CurrentRow.Index).Value
        Class3.DPTOPV2 = DataGridView1.Item(60, DataGridView1.CurrentRow.Index).Value
        Class3.DPTOPV3 = DataGridView1.Item(61, DataGridView1.CurrentRow.Index).Value
        Class3.Hepatitis = DataGridView1.Item(62, DataGridView1.CurrentRow.Index).Value
        Class3.Measles2 = DataGridView1.Item(63, DataGridView1.CurrentRow.Index).Value
        Class3.Other = DataGridView1.Item(64, DataGridView1.CurrentRow.Index).Value
        Class3.CommentsRecommendation = DataGridView1.Item(65, DataGridView1.CurrentRow.Index).Value

        ENROLLMENTSHOW.TextBox1.Text = Class3.Name
        ENROLLMENTSHOW.TextBox2.Text = Class3.CourseStrand
        ENROLLMENTSHOW.TextBox3.Text = Class3.YearGrade
        ENROLLMENTSHOW.TextBox4.Text = Class3.Religion
        ENROLLMENTSHOW.TextBox5.Text = Class3.Address
        ENROLLMENTSHOW.TextBox6.Text = Class3.DateOfBirth
        ENROLLMENTSHOW.TextBox7.Text = Class3.Age
        ENROLLMENTSHOW.TextBox8.Text = Class3.PhoneNum
        ENROLLMENTSHOW.TextBox9.Text = Class3.Father
        ENROLLMENTSHOW.TextBox10.Text = Class3.FatherNum
        ENROLLMENTSHOW.TextBox11.Text = Class3.Mother
        ENROLLMENTSHOW.TextBox12.Text = Class3.MotherNum
        ENROLLMENTSHOW.TextBox13.Text = Class3.Guardian
        ENROLLMENTSHOW.TextBox14.Text = Class3.GuardianNum
        ENROLLMENTSHOW.TextBox15.Text = Class3.AnyOther
        ENROLLMENTSHOW.TextBox16.Text = Class3.Hospitalized
        ENROLLMENTSHOW.TextBox17.Text = Class3.Hearing
        ENROLLMENTSHOW.TextBox18.Text = Class3.Vision
        ENROLLMENTSHOW.TextBox19.Text = Class3.BP
        ENROLLMENTSHOW.TextBox20.Text = Class3.BodyMarks
        ENROLLMENTSHOW.TextBox21.Text = Class3.Vision2
        ENROLLMENTSHOW.TextBox22.Text = Class3.Height
        ENROLLMENTSHOW.TextBox23.Text = Class3.Weight
        ENROLLMENTSHOW.TextBox24.Text = Class3.BMI
        ENROLLMENTSHOW.TextBox25.Text = Class3.LMP
        ENROLLMENTSHOW.TextBox26.Text = Class3.DentalHealth
        ENROLLMENTSHOW.TextBox27.Text = Class3.BP2
        ENROLLMENTSHOW.TextBox28.Text = Class3.DPTOPV1
        ENROLLMENTSHOW.TextBox29.Text = Class3.DPTOPV2
        ENROLLMENTSHOW.TextBox30.Text = Class3.DPTOPV3
        ENROLLMENTSHOW.TextBox31.Text = Class3.Hepatitis
        ENROLLMENTSHOW.TextBox32.Text = Class3.Measles2
        ENROLLMENTSHOW.TextBox33.Text = Class3.Other
        ENROLLMENTSHOW.TextBox34.Text = Class3.CommentsRecommendation

        ENROLLMENTSHOW.ComboBox1.Text = Class3.Q1
        ENROLLMENTSHOW.ComboBox2.Text = Class3.Q2
        ENROLLMENTSHOW.ComboBox3.Text = Class3.Q3
        ENROLLMENTSHOW.ComboBox4.Text = Class3.Q4
        ENROLLMENTSHOW.ComboBox5.Text = Class3.Q5
        ENROLLMENTSHOW.ComboBox6.Text = Class3.Q6
        ENROLLMENTSHOW.ComboBox7.Text = Class3.Q7
        ENROLLMENTSHOW.ComboBox8.Text = Class3.Q8
        ENROLLMENTSHOW.ComboBox9.Text = Class3.Q9
        ENROLLMENTSHOW.ComboBox10.Text = Class3.Q10
        ENROLLMENTSHOW.ComboBox11.Text = Class3.Q11
        ENROLLMENTSHOW.ComboBox12.Text = Class3.Q12
        ENROLLMENTSHOW.ComboBox13.Text = Class3.Q13

        ENROLLMENTSHOW.CheckBox1.Text = Class3.ChickenPox
        ENROLLMENTSHOW.CheckBox2.Text = Class3.Measles
        ENROLLMENTSHOW.CheckBox3.Text = Class3.Mumps
        ENROLLMENTSHOW.CheckBox4.Text = Class3.Poliomyelitis
        ENROLLMENTSHOW.CheckBox5.Text = Class3.Diphteria
        ENROLLMENTSHOW.CheckBox6.Text = Class3.TyphoidFever
        ENROLLMENTSHOW.CheckBox7.Text = Class3.DengueFever
        ENROLLMENTSHOW.CheckBox8.Text = Class3.KidneyInfection
        ENROLLMENTSHOW.CheckBox9.Text = Class3.Malaria
        ENROLLMENTSHOW.CheckBox10.Text = Class3.Asthma
        ENROLLMENTSHOW.CheckBox11.Text = Class3.Pheumonia
        ENROLLMENTSHOW.CheckBox12.Text = Class3.Tubercolosis
        ENROLLMENTSHOW.CheckBox13.Text = Class3.Anemia
        ENROLLMENTSHOW.CheckBox14.Text = Class3.Hemophilia
        ENROLLMENTSHOW.CheckBox15.Text = Class3.HeartDisease
        ENROLLMENTSHOW.CheckBox16.Text = Class3.Epilepsy
        ENROLLMENTSHOW.CheckBox17.Text = Class3.Diabetes
        ENROLLMENTSHOW.CheckBox18.Text = Class3.Hypertension
        ENROLLMENTSHOW.CheckBox19.Text = Class3.Allergies

        ENROLLMENTSHOW.Show()

        If ENROLLMENTSHOW.CheckBox1.Text = "Positive" Then
            ENROLLMENTSHOW.CheckBox1.Checked = True
            ENROLLMENTSHOW.CheckBox1.Text = "Chicken Pox"
        End If
        If ENROLLMENTSHOW.CheckBox1.Text = "Negative" Then
            ENROLLMENTSHOW.CheckBox1.Checked = False
            ENROLLMENTSHOW.CheckBox1.Text = "Chicken Pox"
        End If
        If ENROLLMENTSHOW.CheckBox2.Text = "Positive" Then
            ENROLLMENTSHOW.CheckBox2.Checked = True
            ENROLLMENTSHOW.CheckBox2.Text = "Measles"
        End If
        If ENROLLMENTSHOW.CheckBox2.Text = "Negative" Then
            ENROLLMENTSHOW.CheckBox2.Checked = False
            ENROLLMENTSHOW.CheckBox2.Text = "Measles"
        End If
        If ENROLLMENTSHOW.CheckBox3.Text = "Positive" Then
            ENROLLMENTSHOW.CheckBox3.Checked = True
            ENROLLMENTSHOW.CheckBox3.Text = "Mumps"
        End If
        If ENROLLMENTSHOW.CheckBox3.Text = "Negative" Then
            ENROLLMENTSHOW.CheckBox3.Checked = False
            ENROLLMENTSHOW.CheckBox3.Text = "Mumps"
        End If
        If ENROLLMENTSHOW.CheckBox4.Text = "Positive" Then
            ENROLLMENTSHOW.CheckBox4.Checked = True
            ENROLLMENTSHOW.CheckBox4.Text = "Poliomyelitis"
        End If
        If ENROLLMENTSHOW.CheckBox4.Text = "Negative" Then
            ENROLLMENTSHOW.CheckBox4.Checked = False
            ENROLLMENTSHOW.CheckBox4.Text = "Poliomyelitis"
        End If
        If ENROLLMENTSHOW.CheckBox5.Text = "Positive" Then
            ENROLLMENTSHOW.CheckBox5.Checked = True
            ENROLLMENTSHOW.CheckBox5.Text = "Diphteria"
        End If
        If ENROLLMENTSHOW.CheckBox5.Text = "Negative" Then
            ENROLLMENTSHOW.CheckBox5.Checked = False
            ENROLLMENTSHOW.CheckBox5.Text = "Diphteria"
        End If
        If ENROLLMENTSHOW.CheckBox6.Text = "Positive" Then
            ENROLLMENTSHOW.CheckBox6.Checked = True
            ENROLLMENTSHOW.CheckBox6.Text = "Typhoid Fever"
        End If
        If ENROLLMENTSHOW.CheckBox6.Text = "Negative" Then
            ENROLLMENTSHOW.CheckBox6.Checked = False
            ENROLLMENTSHOW.CheckBox6.Text = "Typhoid Fever"
        End If
        If ENROLLMENTSHOW.CheckBox7.Text = "Positive" Then
            ENROLLMENTSHOW.CheckBox7.Checked = True
            ENROLLMENTSHOW.CheckBox7.Text = "Dengue Fever"
        End If
        If ENROLLMENTSHOW.CheckBox7.Text = "Negative" Then
            ENROLLMENTSHOW.CheckBox7.Checked = False
            ENROLLMENTSHOW.CheckBox7.Text = "Dengue Fever"
        End If
        If ENROLLMENTSHOW.CheckBox8.Text = "Positive" Then
            ENROLLMENTSHOW.CheckBox8.Checked = True
            ENROLLMENTSHOW.CheckBox8.Text = "Kidney Infection"
        End If
        If ENROLLMENTSHOW.CheckBox8.Text = "Negative" Then
            ENROLLMENTSHOW.CheckBox8.Checked = False
            ENROLLMENTSHOW.CheckBox8.Text = "Kidney Infection"
        End If
        If ENROLLMENTSHOW.CheckBox9.Text = "Positive" Then
            ENROLLMENTSHOW.CheckBox9.Checked = True
            ENROLLMENTSHOW.CheckBox9.Text = "Malaria"
        End If
        If ENROLLMENTSHOW.CheckBox9.Text = "Negative" Then
            ENROLLMENTSHOW.CheckBox9.Checked = False
            ENROLLMENTSHOW.CheckBox9.Text = "Malaria"
        End If
        If ENROLLMENTSHOW.CheckBox10.Text = "Positive" Then
            ENROLLMENTSHOW.CheckBox10.Checked = True
            ENROLLMENTSHOW.CheckBox10.Text = "Asthma"
        End If
        If ENROLLMENTSHOW.CheckBox10.Text = "Negative" Then
            ENROLLMENTSHOW.CheckBox10.Checked = False
            ENROLLMENTSHOW.CheckBox10.Text = "Asthma"
        End If
        If ENROLLMENTSHOW.CheckBox11.Text = "Positive" Then
            ENROLLMENTSHOW.CheckBox11.Checked = True
            ENROLLMENTSHOW.CheckBox11.Text = "Pheumonia"
        End If
        If ENROLLMENTSHOW.CheckBox11.Text = "Negative" Then
            ENROLLMENTSHOW.CheckBox11.Checked = False
            ENROLLMENTSHOW.CheckBox11.Text = "Pheumonia"
        End If
        If ENROLLMENTSHOW.CheckBox12.Text = "Positive" Then
            ENROLLMENTSHOW.CheckBox12.Checked = True
            ENROLLMENTSHOW.CheckBox12.Text = "Tubercolosis"
        End If
        If ENROLLMENTSHOW.CheckBox12.Text = "Negative" Then
            ENROLLMENTSHOW.CheckBox12.Checked = False
            ENROLLMENTSHOW.CheckBox12.Text = "Tubercolosis"
        End If
        If ENROLLMENTSHOW.CheckBox13.Text = "Positive" Then
            ENROLLMENTSHOW.CheckBox13.Checked = True
            ENROLLMENTSHOW.CheckBox13.Text = "Anemia"
        End If
        If ENROLLMENTSHOW.CheckBox13.Text = "Negative" Then
            ENROLLMENTSHOW.CheckBox13.Checked = False
            ENROLLMENTSHOW.CheckBox13.Text = "Anemia"
        End If
        If ENROLLMENTSHOW.CheckBox14.Text = "Positive" Then
            ENROLLMENTSHOW.CheckBox14.Checked = True
            ENROLLMENTSHOW.CheckBox14.Text = "Hemophilia"
        End If
        If ENROLLMENTSHOW.CheckBox14.Text = "Negative" Then
            ENROLLMENTSHOW.CheckBox14.Checked = False
            ENROLLMENTSHOW.CheckBox14.Text = "Hemophilia"
        End If
        If ENROLLMENTSHOW.CheckBox15.Text = "Positive" Then
            ENROLLMENTSHOW.CheckBox15.Checked = True
            ENROLLMENTSHOW.CheckBox15.Text = "Heart Disease"
        End If
        If ENROLLMENTSHOW.CheckBox15.Text = "Negative" Then
            ENROLLMENTSHOW.CheckBox15.Checked = False
            ENROLLMENTSHOW.CheckBox15.Text = "Heart Disease"
        End If
        If ENROLLMENTSHOW.CheckBox16.Text = "Positive" Then
            ENROLLMENTSHOW.CheckBox16.Checked = True
            ENROLLMENTSHOW.CheckBox16.Text = "Epelepsy"
        End If
        If ENROLLMENTSHOW.CheckBox16.Text = "Negative" Then
            ENROLLMENTSHOW.CheckBox16.Checked = False
            ENROLLMENTSHOW.CheckBox16.Text = "Epilepsy"
        End If
        If ENROLLMENTSHOW.CheckBox17.Text = "Positive" Then
            ENROLLMENTSHOW.CheckBox17.Checked = True
            ENROLLMENTSHOW.CheckBox17.Text = "Diabetes"
        End If
        If ENROLLMENTSHOW.CheckBox17.Text = "Negative" Then
            ENROLLMENTSHOW.CheckBox17.Checked = False
            ENROLLMENTSHOW.CheckBox17.Text = "Diabetes"
        End If
        If ENROLLMENTSHOW.CheckBox18.Text = "Positive" Then
            ENROLLMENTSHOW.CheckBox18.Checked = True
            ENROLLMENTSHOW.CheckBox18.Text = "Hypertension"
        End If
        If ENROLLMENTSHOW.CheckBox18.Text = "Negative" Then
            ENROLLMENTSHOW.CheckBox18.Checked = False
            ENROLLMENTSHOW.CheckBox18.Text = "Hypertension"
        End If
        If ENROLLMENTSHOW.CheckBox19.Text = "Positive" Then
            ENROLLMENTSHOW.CheckBox19.Checked = True
            ENROLLMENTSHOW.CheckBox19.Text = "Allergies"
        End If
        If ENROLLMENTSHOW.CheckBox19.Text = "Negative" Then
            ENROLLMENTSHOW.CheckBox19.Checked = False
            ENROLLMENTSHOW.CheckBox19.Text = "Allergies"
        End If

    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        Class1.Name = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Class1.GrYearSec = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        Class1.Religion = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
        Class1.Address = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value
        Class1.Age = DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value
        Class1.PhoneNum = DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value
        Class1.FatherName = DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value
        Class1.FatherNum = DataGridView1.Item(9, DataGridView1.CurrentRow.Index).Value
        Class1.MotherName = DataGridView1.Item(10, DataGridView1.CurrentRow.Index).Value
        Class1.MotherNum = DataGridView1.Item(11, DataGridView1.CurrentRow.Index).Value
        Class1.Guardian = DataGridView1.Item(12, DataGridView1.CurrentRow.Index).Value
        Class1.NumGuardian = DataGridView1.Item(13, DataGridView1.CurrentRow.Index).Value
        Class1.Wt = DataGridView1.Item(54, DataGridView1.CurrentRow.Index).Value
        Class1.Ht = DataGridView1.Item(53, DataGridView1.CurrentRow.Index).Value
        Class1.LMP = DataGridView1.Item(57, DataGridView1.CurrentRow.Index).Value
        Class1.BMI = DataGridView1.Item(55, DataGridView1.CurrentRow.Index).Value
        Class1.BP = DataGridView1.Item(50, DataGridView1.CurrentRow.Index).Value
        Class1.BirthDate = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value

        openchildform(New MEDICALADD())
        Me.Hide()
    End Sub
End Class