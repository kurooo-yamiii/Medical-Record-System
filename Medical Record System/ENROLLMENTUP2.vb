Public Class ENROLLMENTUP2

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
        ElseIf ComboBox1.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf ComboBox2.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf ComboBox3.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf ComboBox4.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf ComboBox5.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf ComboBox6.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf ComboBox7.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf ComboBox8.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf ComboBox9.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf ComboBox10.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf ComboBox11.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf ComboBox12.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf ComboBox13.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox1.Text = "BCG" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox2.Text = "BODY MARKS" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox3.Text = "VISION" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox4.Text = "HEIGHT(CM)" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox5.Text = "WEIGHT(KG)" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox6.Text = "BMI" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox7.Text = "DENTAL HEALTH" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox8.Text = "LMP" Then
            MsgBox("PLease fill up the missing information")
        Else
            nonquery("update bxcq2xr2isgolaxd4zcg.enrollment set Name = '" & Class3.Name & "', CourseStrand = '" & Class3.CourseStrand & "', YearGrade = '" & Class3.YearGrade & "', Religion = '" & Class3.Religion & "', Address = '" & Class3.Address & "', DateOfBirth = '" & Class3.DateOfBirth & "', Age = '" & Class3.Age & "', PhoneNum = '" & Class3.PhoneNum & "', Father = '" & Class3.Father & "', FatherNum = '" & Class3.FatherNum & "', Mother = '" & Class3.Mother & "', MotherNum = '" & Class3.MotherNum & "', Guardian = '" & Class3.Guardian & "', GuardianNum = '" & Class3.GuardianNum & "', ChickenPox = '" & Class3.ChickenPox & "', Measles = '" & Class3.Measles & "', Mumps = '" & Class3.Mumps & "', Poliomyelitis = '" & Class3.Poliomyelitis & "', Diphteria = '" & Class3.Diphteria & "', TyphoidFever = '" & Class3.TyphoidFever & "', DengueFever = '" & Class3.DengueFever & "', KidneyInfection = '" & Class3.KidneyInfection & "', Malaria = '" & Class3.Malaria & "', Asthma = '" & Class3.Asthma & "', Pheumonia = '" & Class3.Pheumonia & "', Tubercolosis = '" & Class3.Tubercolosis & "', Anemia = '" & Class3.Anemia & "', Hemophilia = '" & Class3.Hemophilia & "', HeartDisease = '" & Class3.HeartDisease & "', Epilepsy = '" & Class3.Epilepsy & "', Diabetes = '" & Class3.Diabetes & "', Hypertension = '" & Class3.Hypertension & "', Allergies = '" & Class3.Allergies & "', AnyOther = '" & Class3.AnyOther & "', Hospitalized = '" & Class3.Hospitalized & "', Hearing = '" & Class3.Hearing & "', Vision = '" & Class3.Vision & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & ComboBox3.Text & "','" & ComboBox4.Text & "','" & ComboBox5.Text & "','" & ComboBox6.Text & "','" & ComboBox7.Text & "','" & ComboBox8.Text & "','" & ComboBox9.Text & "','" & ComboBox10.Text & "','" & ComboBox11.Text & "','" & ComboBox12.Text & "','" & ComboBox13.Text & "','" & BunifuMaterialTextbox1.Text & "','" & BunifuMaterialTextbox2.Text & "','" & BunifuMaterialTextbox3.Text & "','" & BunifuMaterialTextbox4.Text & "','" & BunifuMaterialTextbox5.Text & "','" & BunifuMaterialTextbox6.Text & "','" & BunifuMaterialTextbox7.Text & "','" & BunifuMaterialTextbox8.Text & "','" & BunifuMaterialTextbox9.Text & "','" & BunifuMaterialTextbox10.Text & "','" & BunifuMaterialTextbox11.Text & "','" & BunifuMaterialTextbox12.Text & "','" & BunifuMaterialTextbox13.Text & "','" & BunifuMaterialTextbox14.Text & "','" & BunifuMaterialTextbox15.Text & "','" & RichTextBox1.Text & "')")
            mypopulate("select * from bxcq2xr2isgolaxd4zcg.enrollment", ENROLLMENT.DataGridView1)
            MsgBox("Successfully Added")
            openchildform(New ENROLLMENT())
            Me.Hide()
        End If
    End Sub

    Private Sub ENROLLMENTUP2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = Class3.Q1
        ComboBox2.Text = Class3.Q2
        ComboBox3.Text = Class3.Q3
        ComboBox4.Text = Class3.Q4
        ComboBox5.Text = Class3.Q5
        ComboBox6.Text = Class3.Q6
        ComboBox7.Text = Class3.Q7
        ComboBox8.Text = Class3.Q8
        ComboBox9.Text = Class3.Q9
        ComboBox10.Text = Class3.Q10
        ComboBox11.Text = Class3.Q11
        ComboBox12.Text = Class3.Q12
        ComboBox13.Text = Class3.Q13
        BunifuMaterialTextbox1.Text = Class3.BP
        BunifuMaterialTextbox2.Text = Class3.BodyMarks
        BunifuMaterialTextbox3.Text = Class3.Vision2
        BunifuMaterialTextbox4.Text = Class3.Height
        BunifuMaterialTextbox5.Text = Class3.Weight
        BunifuMaterialTextbox6.Text = Class3.BMI
        BunifuMaterialTextbox7.Text = Class3.DentalHealth
        BunifuMaterialTextbox8.Text = Class3.LMP
        BunifuMaterialTextbox9.Text = Class3.BP2
        BunifuMaterialTextbox10.Text = Class3.DPTOPV1
        BunifuMaterialTextbox11.Text = Class3.DPTOPV2
        BunifuMaterialTextbox12.Text = Class3.DPTOPV3
        BunifuMaterialTextbox13.Text = Class3.Hepatitis
        BunifuMaterialTextbox14.Text = Class3.Measles2
        BunifuMaterialTextbox15.Text = Class3.Other
        RichTextBox1.Text = Class3.CommentsRecommendation
    End Sub
End Class