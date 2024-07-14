Public Class MAMA

    Private Sub BTNMEDICINE_Click(sender As Object, e As EventArgs) Handles BTNMEDICINE.Click
        'showsubmenu(PanelMEDICINESUBMENU)
        openchildform(New MEDICINEE())
        HIDESUB()
    End Sub

    Public Sub MAMA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HIDESUB()

    End Sub

    Private Sub HIDESUB()
        PanelMEDICALSUBMENU.Visible = False
        Panel2.Visible = False
    End Sub

    Private Sub showsubmenu(SUBMENU As Panel)
        If SUBMENU.Visible = False Then
            HIDESUB()
            SUBMENU.Visible = True
        Else
            SUBMENU.Visible = False

        End If
    End Sub

    Public currentform As Form = Nothing

    Public Sub openchildform(ChildForm As Form)
        If currentform IsNot Nothing Then currentform.Close()
        currentform = ChildForm
        ChildForm.TopLevel = False
        ChildForm.FormBorderStyle = FormBorderStyle.None
        ChildForm.Dock = DockStyle.Fill
        PanelChildForm.Controls.Add(ChildForm)
        PanelChildForm.Tag = ChildForm
        ChildForm.BringToFront()
        ChildForm.Show()

    End Sub
    Private Sub BTNMEDICAL_Click(sender As Object, e As EventArgs) Handles BTNMEDICAL.Click
        showsubmenu(PanelMEDICALSUBMENU)
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
      showsubmenu(Panel2)

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        openchildform(New MEDICAL())
        HIDESUB()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        openchildform(New EMPLOYEE())
        HIDESUB()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        openchildform(New ENROLLMENT())
        HIDESUB()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        openchildform(New MEDICINEADD())
        HIDESUB()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        openchildform(New MEDICINEUP2())
        HIDESUB()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        openchildform(New MEDICINEARCHIVE())
        HIDESUB()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        openchildform(New TRANSACTION())
        HIDESUB()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        openchildform(New TRANSACTION2())
        HIDESUB()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        LOGIN.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        openchildform(New CHANPAS())
        HIDESUB()
    End Sub
    
    Private Sub PanelChildForm_Paint(sender As Object, e As PaintEventArgs) Handles PanelChildForm.Paint

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        openchildform(New TRANSACTION())
        HIDESUB()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        openchildform(New TEACHER())
        HIDESUB()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        LOGIN.Show()
        Me.Hide()
    End Sub
End Class