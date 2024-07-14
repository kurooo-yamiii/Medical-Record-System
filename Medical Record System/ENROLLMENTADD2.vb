Public Class ENROLLMENTADD2

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
            nonquery("insert into bxcq2xr2isgolaxd4zcg.enrollment values('" & Class3.Name & "','" & Class3.CourseStrand & "','" & Class3.YearGrade & "','" & Class3.Religion & "','" & Class3.Address & "','" & Class3.DateOfBirth & "','" & Class3.Age & "','" & Class3.PhoneNum & "','" & Class3.Father & "','" & Class3.FatherNum & "','" & Class3.Mother & "','" & Class3.MotherNum & "','" & Class3.Guardian & "','" & Class3.GuardianNum & "','" & Class3.ChickenPox & "','" & Class3.Measles & "','" & Class3.Mumps & "','" & Class3.Poliomyelitis & "','" & Class3.Diphteria & "','" & Class3.TyphoidFever & "','" & Class3.DengueFever & "','" & Class3.KidneyInfection & "','" & Class3.Malaria & "','" & Class3.Asthma & "','" & Class3.Pheumonia & "','" & Class3.Tubercolosis & "','" & Class3.Anemia & "','" & Class3.Hemophilia & "','" & Class3.HeartDisease & "','" & Class3.Epilepsy & "','" & Class3.Diabetes & "','" & Class3.Hypertension & "','" & Class3.Allergies & "','" & Class3.AnyOther & "','" & Class3.Hospitalized & "','" & Class3.Hearing & "','" & Class3.Vision & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & ComboBox3.Text & "','" & ComboBox4.Text & "','" & ComboBox5.Text & "','" & ComboBox6.Text & "','" & ComboBox7.Text & "','" & ComboBox8.Text & "','" & ComboBox9.Text & "','" & ComboBox10.Text & "','" & ComboBox11.Text & "','" & ComboBox12.Text & "','" & ComboBox13.Text & "','" & BunifuMaterialTextbox1.Text & "','" & BunifuMaterialTextbox2.Text & "','" & BunifuMaterialTextbox3.Text & "','" & BunifuMaterialTextbox4.Text & "','" & BunifuMaterialTextbox5.Text & "','" & BunifuMaterialTextbox6.Text & "','" & BunifuMaterialTextbox7.Text & "','" & BunifuMaterialTextbox8.Text & "','" & BunifuMaterialTextbox9.Text & "','" & BunifuMaterialTextbox10.Text & "','" & BunifuMaterialTextbox11.Text & "','" & BunifuMaterialTextbox12.Text & "','" & BunifuMaterialTextbox13.Text & "','" & BunifuMaterialTextbox14.Text & "','" & BunifuMaterialTextbox15.Text & "','" & RichTextBox1.Text & "')")
            mypopulate("select * from bxcq2xr2isgolaxd4zcg.enrollment", ENROLLMENT.DataGridView1)
            MsgBox("Successfully Added")
            openchildform(New ENROLLMENT())
            Me.Hide()
        End If
    End Sub
End Class