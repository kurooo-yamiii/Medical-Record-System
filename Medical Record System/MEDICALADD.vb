Public Class MEDICALADD
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
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        openchildform(New MEDICAL())
        Me.Hide()

    End Sub

    Private Sub BunifuThinButton23_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
       
        If BunifuMaterialTextbox2.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox5.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox7.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox10.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox11.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox14.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox16.Text = "" Then
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
        ElseIf BunifuMaterialTextbox27.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox28.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox29.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox30.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox32.Text = "" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox2.Text = "Sex" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox5.Text = "Address" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox7.Text = "Room/Building" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox10.Text = "School ID No." Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox11.Text = "Chief Complaints" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox14.Text = "Nationality" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox16.Text = "Name Adviser" Then
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
        ElseIf BunifuMaterialTextbox27.Text = "RR" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox28.Text = "PR" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox29.Text = "Temperature" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox30.Text = "O2Sat" Then
            MsgBox("PLease fill up the missing information")
        ElseIf BunifuMaterialTextbox32.Text = "Remarks" Then
            MsgBox("PLease fill up the missing information")
        Else

           
            Class1.Sex = BunifuMaterialTextbox2.Text
            Class1.CivilStatus = BunifuMaterialTextbox5.Text
            Class1.RoomBuilding = BunifuMaterialTextbox7.Text
            Class1.SchoolID = BunifuMaterialTextbox10.Text
            Class1.ChiefComplaints = BunifuMaterialTextbox11.Text
            Class1.Nationality = BunifuMaterialTextbox14.Text
            Class1.NameAdviser = BunifuMaterialTextbox16.Text
            Class1.HealthHx = BunifuMaterialTextbox21.Text
            Class1.MedsTaken = BunifuMaterialTextbox22.Text
            Class1.Allergies = BunifuMaterialTextbox23.Text
            Class1.Medicine = BunifuMaterialTextbox24.Text
            Class1.Food = BunifuMaterialTextbox25.Text
            Class1.RR = BunifuMaterialTextbox27.Text
            Class1.PR = BunifuMaterialTextbox28.Text
            Class1.Temperature = BunifuMaterialTextbox29.Text
            Class1.O2Sat = BunifuMaterialTextbox30.Text
            Class1.Remarks = BunifuMaterialTextbox32.Text

            openchildform(New MEDICALADD2())
            Me.Hide()
        End If
    End Sub

End Class