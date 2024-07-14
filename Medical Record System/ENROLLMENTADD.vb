Public Class ENROLLMENTADD
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
            openchildform(New ENROLLMENTADD2())
            Me.Hide()
        End If
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        openchildform(New ENROLLMENT())
        Me.Hide()
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

