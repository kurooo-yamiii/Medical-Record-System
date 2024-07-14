Public Class LOGIN


    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        If BunifuMaterialTextbox1.Text = "Admin" And BunifuMaterialTextbox2.Text = selectspecific("select NewPassword from bxcq2xr2isgolaxd4zcg.passwordd where Keynum = 1") Then
            MAMA.Show()
            Me.Hide()
        ElseIf BunifuMaterialTextbox1.Text = "" And BunifuMaterialTextbox2.Text = "" Then
            MsgBox("Please Fill up the Information Needed")
        ElseIf Not BunifuMaterialTextbox1.Text = "Admin" Then
            MsgBox("Incorrect Username")
        ElseIf Not BunifuMaterialTextbox2.Text = selectspecific("select NewPassword from bxcq2xr2isgolaxd4zcg.passwordd where Keynum = 1") Then
            MsgBox("Incorrect Password")
        End If
        BunifuMaterialTextbox1.Text = "USERNAME"
        BunifuMaterialTextbox2.Text = "PASSWORD"
    End Sub

    Private Sub BunifuMaterialTextbox1_Enter(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox1.Enter


        If BunifuMaterialTextbox1.Text = "USERNAME" Then

            BunifuMaterialTextbox1.Text = ""
            BunifuMaterialTextbox1.ForeColor = Color.Black


        End If

    End Sub

    Private Sub BunifuMaterialTextbox1_Leave(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox1.Leave

        If BunifuMaterialTextbox1.Text = "" Then

            BunifuMaterialTextbox1.Text = "USERNAME"
            BunifuMaterialTextbox1.ForeColor = Color.Gray

        End If


    End Sub

    Private Sub BunifuMaterialTextbox2_Enter(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox2.Enter

        If BunifuMaterialTextbox2.Text = "PASSWORD" Then

            BunifuMaterialTextbox2.Text = ""
            BunifuMaterialTextbox2.ForeColor = Color.Black

        End If
    End Sub

    Private Sub BunifuMaterialTextbox2_Leave(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox2.Leave

        If BunifuMaterialTextbox2.Text = "" Then

            BunifuMaterialTextbox2.Text = "PASSWORD"
            BunifuMaterialTextbox2.ForeColor = Color.Gray

        End If

    End Sub

   
End Class
