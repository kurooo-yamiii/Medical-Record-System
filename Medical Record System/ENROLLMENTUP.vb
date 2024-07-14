Public Class ENROLLMENTUP
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
    Private Sub ENROLLMENTUP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuMaterialTextbox1.Text = Class3.Name
        BunifuMaterialTextbox2.Text = Class3.CourseStrand
        BunifuMaterialTextbox3.Text = Class3.YearGrade
        BunifuMaterialTextbox4.Text = Class3.Religion
        BunifuMaterialTextbox5.Text = Class3.Address
        BunifuMaterialTextbox6.Text = Class3.DateOfBirth
        BunifuMaterialTextbox7.Text = Class3.Age
        BunifuMaterialTextbox8.Text = Class3.PhoneNum
        BunifuMaterialTextbox9.Text = Class3.Father
        BunifuMaterialTextbox10.Text = Class3.FatherNum
        BunifuMaterialTextbox11.Text = Class3.Mother
        BunifuMaterialTextbox12.Text = Class3.MotherNum
        BunifuMaterialTextbox13.Text = Class3.Guardian
        BunifuMaterialTextbox14.Text = Class3.GuardianNum
        BunifuMaterialTextbox15.Text = Class3.AnyOther
        BunifuMaterialTextbox16.Text = Class3.Hospitalized
        BunifuMaterialTextbox17.Text = Class3.Hearing
        BunifuMaterialTextbox18.Text = Class3.Vision

        CheckBox1.Text = Class3.ChickenPox
        CheckBox2.Text = Class3.Measles
        CheckBox3.Text = Class3.Mumps
        CheckBox4.Text = Class3.Poliomyelitis
        CheckBox5.Text = Class3.Diphteria
        CheckBox6.Text = Class3.TyphoidFever
        CheckBox7.Text = Class3.DengueFever
        CheckBox8.Text = Class3.KidneyInfection
        CheckBox9.Text = Class3.Malaria
        CheckBox10.Text = Class3.Asthma
        CheckBox11.Text = Class3.Pheumonia
        CheckBox12.Text = Class3.Tubercolosis
        CheckBox13.Text = Class3.Anemia
        CheckBox14.Text = Class3.Hemophilia
        CheckBox15.Text = Class3.HeartDisease
        CheckBox16.Text = Class3.Epilepsy
        CheckBox17.Text = Class3.Diabetes
        CheckBox18.Text = Class3.Hypertension
        CheckBox19.Text = Class3.Allergies

        If CheckBox1.Text = "Positive" Then
            CheckBox1.Checked = True
            CheckBox1.Text = "Chicken Pox"
        End If
        If CheckBox1.Text = "Negative" Then
            CheckBox1.Checked = False
            CheckBox1.Text = "Chicken Pox"
        End If
        If CheckBox2.Text = "Positive" Then
            CheckBox2.Checked = True
            CheckBox2.Text = "Measles"
        End If
        If CheckBox2.Text = "Negative" Then
            CheckBox2.Checked = False
            CheckBox2.Text = "Measles"
        End If
        If CheckBox3.Text = "Positive" Then
            CheckBox3.Checked = True
            CheckBox3.Text = "Mumps"
        End If
        If CheckBox3.Text = "Negative" Then
            CheckBox3.Checked = False
            CheckBox3.Text = "Mumps"
        End If
        If CheckBox4.Text = "Positive" Then
            CheckBox4.Checked = True
            CheckBox4.Text = "Poliomyelitis"
        End If
        If CheckBox4.Text = "Negative" Then
            CheckBox4.Checked = False
            CheckBox4.Text = "Poliomyelitis"
        End If
        If CheckBox5.Text = "Positive" Then
            CheckBox5.Checked = True
            CheckBox5.Text = "Diphteria"
        End If
        If CheckBox5.Text = "Negative" Then
            CheckBox5.Checked = False
            CheckBox5.Text = "Diphteria"
        End If
        If CheckBox6.Text = "Positive" Then
            CheckBox6.Checked = True
            CheckBox6.Text = "Typhoid Fever"
        End If
        If CheckBox6.Text = "Negative" Then
            CheckBox6.Checked = False
            CheckBox6.Text = "Typhoid Fever"
        End If
        If CheckBox7.Text = "Positive" Then
            CheckBox7.Checked = True
            CheckBox7.Text = "Dengue Fever"
        End If
        If CheckBox7.Text = "Negative" Then
            CheckBox7.Checked = False
            CheckBox7.Text = "Dengue Fever"
        End If
        If CheckBox8.Text = "Positive" Then
            CheckBox8.Checked = True
            CheckBox8.Text = "Kidney Infection"
        End If
        If CheckBox8.Text = "Negative" Then
            CheckBox8.Checked = False
            CheckBox8.Text = "Kidney Infection"
        End If
        If CheckBox9.Text = "Positive" Then
            CheckBox9.Checked = True
            CheckBox9.Text = "Malaria"
        End If
        If CheckBox9.Text = "Negative" Then
            CheckBox9.Checked = False
            CheckBox9.Text = "Malaria"
        End If
        If CheckBox10.Text = "Positive" Then
            CheckBox10.Checked = True
            CheckBox10.Text = "Asthma"
        End If
        If CheckBox10.Text = "Negative" Then
            CheckBox10.Checked = False
            CheckBox10.Text = "Asthma"
        End If
        If CheckBox11.Text = "Positive" Then
            CheckBox11.Checked = True
            CheckBox11.Text = "Pheumonia"
        End If
        If CheckBox11.Text = "Negative" Then
            CheckBox11.Checked = False
            CheckBox11.Text = "Pheumonia"
        End If
        If CheckBox12.Text = "Positive" Then
            CheckBox12.Checked = True
            CheckBox12.Text = "Tubercolosis"
        End If
        If CheckBox12.Text = "Negative" Then
            CheckBox12.Checked = False
            CheckBox12.Text = "Tubercolosis"
        End If
        If CheckBox13.Text = "Positive" Then
            CheckBox13.Checked = True
            CheckBox13.Text = "Anemia"
        End If
        If CheckBox13.Text = "Negative" Then
            CheckBox13.Checked = False
            CheckBox13.Text = "Anemia"
        End If
        If CheckBox14.Text = "Positive" Then
            CheckBox14.Checked = True
            CheckBox14.Text = "Hemophilia"
        End If
        If CheckBox14.Text = "Negative" Then
            CheckBox14.Checked = False
            CheckBox14.Text = "Hemophilia"
        End If
        If CheckBox15.Text = "Positive" Then
            CheckBox15.Checked = True
            CheckBox15.Text = "Heart Disease"
        End If
        If CheckBox15.Text = "Negative" Then
            CheckBox15.Checked = False
            CheckBox15.Text = "Heart Disease"
        End If
        If CheckBox16.Text = "Positive" Then
            CheckBox16.Checked = True
            CheckBox16.Text = "Epelepsy"
        End If
        If CheckBox16.Text = "Negative" Then
            CheckBox16.Checked = False
            CheckBox16.Text = "Epilepsy"
        End If
        If CheckBox17.Text = "Positive" Then
            CheckBox17.Checked = True
            CheckBox17.Text = "Diabetes"
        End If
        If CheckBox17.Text = "Negative" Then
            CheckBox17.Checked = False
            CheckBox17.Text = "Diabetes"
        End If
        If CheckBox18.Text = "Positive" Then
            CheckBox18.Checked = True
            CheckBox18.Text = "Hypertension"
        End If
        If CheckBox18.Text = "Negative" Then
            CheckBox18.Checked = False
            CheckBox18.Text = "Hypertension"
        End If
        If CheckBox19.Text = "Positive" Then
            CheckBox19.Checked = True
            CheckBox19.Text = "Allergies"
        End If
        If CheckBox19.Text = "Negative" Then
            CheckBox19.Checked = False
            CheckBox19.Text = "Allergies"
        End If
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
        ElseIf BunifuMaterialTextbox1.Text = "Name" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox2.Text = "Course/Strand" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox3.Text = "Year/Grade" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox4.Text = "Religion" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox5.Text = "Address" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox6.Text = "Date of Birth" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox7.Text = "Age" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox8.Text = "Phone Num" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox9.Text = "Name of Father" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox10.Text = "Tel/Mobile Number" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox11.Text = "Name of Mother" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox12.Text = "Tel/Mobile Number" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox13.Text = "Name of Guardian" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox14.Text = "Tel/Mobile Number" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox15.Text = "Any Other" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox16.Text = "Have you been Hospitalized? If yes why?" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox17.Text = "Do you suffer Hearing difficulties? If yes, What ear is affected?" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox18.Text = "Do you suffer Blurring of visions? If yes, What eye is affected?" Then
            MsgBox("PLease fill up the missing information")
        Else
            Class3.Name = BunifuMaterialTextbox1.Text
            Class3.CourseStrand = BunifuMaterialTextbox2.Text
            Class3.YearGrade = BunifuMaterialTextbox3.Text
            Class3.Religion = BunifuMaterialTextbox4.Text
            Class3.Address = BunifuMaterialTextbox5.Text
            Class3.DateOfBirth = BunifuMaterialTextbox6.Text
            Class3.Age = BunifuMaterialTextbox7.Text
            Class3.PhoneNum = BunifuMaterialTextbox8.Text
            Class3.Father = BunifuMaterialTextbox9.Text
            Class3.FatherNum = BunifuMaterialTextbox10.Text
            Class3.Mother = BunifuMaterialTextbox11.Text
            Class3.MotherNum = BunifuMaterialTextbox12.Text
            Class3.Guardian = BunifuMaterialTextbox13.Text
            Class3.GuardianNum = BunifuMaterialTextbox14.Text
            Class3.AnyOther = BunifuMaterialTextbox15.Text
            Class3.Hospitalized = BunifuMaterialTextbox16.Text
            Class3.Hearing = BunifuMaterialTextbox17.Text
            openchildform(New ENROLLMENTUP2())
            Me.Hide()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            Class3.ChickenPox = "Negative"
        ElseIf CheckBox1.Checked = True Then
            Class3.ChickenPox = "Positive"
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = False Then
            Class3.Measles = "Negative"
        ElseIf CheckBox2.Checked = True Then
            Class3.Measles = "Positive"
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = False Then
            Class3.Mumps = "Negative"
        ElseIf CheckBox3.Checked = True Then
            Class3.Mumps = "Positive"
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = False Then
            Class3.Poliomyelitis = "Negative"
        ElseIf CheckBox4.Checked = True Then
            Class3.Poliomyelitis = "Positive"
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = False Then
            Class3.Diphteria = "Negative"
        ElseIf CheckBox5.Checked = True Then
            Class3.Diphteria = "Positive"
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = False Then
            Class3.TyphoidFever = "Negative"
        ElseIf CheckBox6.Checked = True Then
            Class3.TyphoidFever = "Positive"
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = False Then
            Class3.DengueFever = "Negative"
        ElseIf CheckBox7.Checked = True Then
            Class3.DengueFever = "Positive"
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = False Then
            Class3.KidneyInfection = "Negative"
        ElseIf CheckBox8.Checked = True Then
            Class3.KidneyInfection = "Positive"
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked = False Then
            Class3.Malaria = "Negative"
        ElseIf CheckBox9.Checked = True Then
            Class3.Malaria = "Positive"
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked = False Then
            Class3.Asthma = "Negative"
        ElseIf CheckBox10.Checked = True Then
            Class3.Asthma = "Positive"
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked = False Then
            Class3.Pheumonia = "Negative"
        ElseIf CheckBox11.Checked = True Then
            Class3.Pheumonia = "Positive"
        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        If CheckBox12.Checked = False Then
            Class3.Tubercolosis = "Negative"
        ElseIf CheckBox12.Checked = True Then
            Class3.Tubercolosis = "Positive"
        End If
    End Sub

    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged
        If CheckBox13.Checked = False Then
            Class3.Anemia = "Negative"
        ElseIf CheckBox13.Checked = True Then
            Class3.Anemia = "Positive"
        End If
    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged
        If CheckBox14.Checked = False Then
            Class3.Hemophilia = "Negative"
        ElseIf CheckBox14.Checked = True Then
            Class3.Hemophilia = "Positive"
        End If
    End Sub

    Private Sub CheckBox15_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox15.CheckedChanged
        If CheckBox15.Checked = False Then
            Class3.HeartDisease = "Negative"
        ElseIf CheckBox15.Checked = True Then
            Class3.HeartDisease = "Positive"
        End If
    End Sub

    Private Sub CheckBox16_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox16.CheckedChanged
        If CheckBox16.Checked = False Then
            Class3.Epilepsy = "Negative"
        ElseIf CheckBox16.Checked = True Then
            Class3.Epilepsy = "Positive"
        End If
    End Sub

    Private Sub CheckBox17_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox17.CheckedChanged
        If CheckBox17.Checked = False Then
            Class3.Diabetes = "Negative"
        ElseIf CheckBox17.Checked = True Then
            Class3.Diabetes = "Positive"
        End If
    End Sub

    Private Sub CheckBox18_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox18.CheckedChanged
        If CheckBox18.Checked = False Then
            Class3.Hypertension = "Negative"
        ElseIf CheckBox18.Checked = True Then
            Class3.Hypertension = "Positive"
        End If
    End Sub

    Private Sub CheckBox19_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox19.CheckedChanged
        If CheckBox19.Checked = False Then
            Class3.Allergies = "Negative"
        ElseIf CheckBox19.Checked = True Then
            Class3.Allergies = "Positive"
        End If
    End Sub
End Class