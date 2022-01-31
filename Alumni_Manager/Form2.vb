Public Class Login

    Private Sub Sign_Click(sender As Object, e As EventArgs) Handles buttonSignIn.Click
        If adminButton.Checked Then
            mainPanel.Show()
            mainPanel.adminPanel.Visible = True
            mainPanel.superadminPanel.Visible = False
            mainPanel.panelHome.Visible = False
            mainPanel.panelAdminWelcome.Visible = True
            Me.Dispose()
            textboxUsername.Text = "Username"
            textboxPassword.Text = "Password"
        ElseIf superadminButton.Checked Then
            mainPanel.superadminPanel.Visible = True
            mainPanel.adminPanel.Visible = False

            mainPanel.Show()
            Me.Dispose()
            textboxUsername.Text = "Username"
            textboxPassword.Text = "Password"
        Else
            MessageBox.Show("Please choose which admin type.")
        End If
    End Sub

    Private Sub HideButton_Click(sender As Object, e As EventArgs) Handles hideButton.Click
        Me.Hide()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Dispose()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If textboxPassword.UseSystemPasswordChar = True Then
            textboxPassword.UseSystemPasswordChar = False
        Else
            textboxPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles buttonRegister.Click
        panelRegister.Visible = True
        panelLogin.Visible = False
        textboxUsername.Text = "Username"
        textboxPassword.Text = "Password"
    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles buttonBack.Click
        panelRegister.Visible = False
        panelLogin.Visible = True
    End Sub


    Private Sub TextboxUsername_MouseClick(sender As Object, e As MouseEventArgs) Handles textboxUsername.MouseClick
        If textboxUsername.Text = "Username" Then
            textboxUsername.Text = ""
        End If
        If textboxPassword.Text = "" Then
            textboxPassword.Text = "Password"
        End If

    End Sub

    Private Sub TextBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles textboxPassword.MouseClick
        textboxPassword.UseSystemPasswordChar = True
        If textboxPassword.Text = "Password" Then
            textboxPassword.Text = ""

        End If
        If textboxUsername.Text = "" Then
            textboxUsername.Text = "Username"
        End If
    End Sub

    Private Sub TextboxFname_Leave(sender As Object, e As EventArgs) Handles textboxFname.Leave
        If textboxFname.Text = "" Then
            textboxFname.Text = "First Name"
        End If
    End Sub

    Private Sub TextboxMname_Leave(sender As Object, e As EventArgs) Handles textboxMname.Leave
        If textboxMname.Text = "" Then
            textboxMname.Text = "Middle Name"
        End If
    End Sub

    Private Sub TextboxlName_Leave(sender As Object, e As EventArgs) Handles textboxlName.Leave
        If textboxlName.Text = "" Then
            textboxlName.Text = "Last Name"
        End If
    End Sub

    Private Sub TextboxFname_Enter(sender As Object, e As EventArgs) Handles textboxFname.Enter
        If textboxFname.Text = "First Name" Then
            textboxFname.Text = ""
        End If
    End Sub
    Private Sub TextboxMname_Enter(sender As Object, e As EventArgs) Handles textboxMname.Enter
        If textboxMname.Text = "Middle Name" Then
            textboxMname.Text = ""
        End If
    End Sub

    Private Sub TextboxlName_Enter(sender As Object, e As EventArgs) Handles textboxlName.Enter
        If textboxlName.Text = "Last Name" Then
            textboxlName.Text = ""
        End If
    End Sub



    Private Sub TextboxAddress_Leave(sender As Object, e As EventArgs) Handles textboxAddress.Leave
        If textboxAddress.Text = "" Then
            textboxAddress.Text = "Address"
        End If
    End Sub

    Private Sub TextboxAddress_Enter(sender As Object, e As EventArgs) Handles textboxAddress.Enter
        If textboxAddress.Text = "Address" Then
            textboxAddress.Text = ""
        End If
    End Sub

    Private Sub TextboxBday_Enter(sender As Object, e As EventArgs)
        textboxBday.Visible = False
        birthdatePicker.Visible = True
    End Sub

    Private Sub textboxEmail_Enter(sender As Object, e As EventArgs) Handles textboxEmail.Enter
        If textboxEmail.Text = "Email" Then
            textboxEmail.Text = ""
        End If
    End Sub

    Private Sub textboxEmail_Leave(sender As Object, e As EventArgs) Handles textboxEmail.Leave
        If textboxEmail.Text = "" Then
            textboxEmail.Text = "Email"
        End If
    End Sub

    Private Sub textboxUname_Enter(sender As Object, e As EventArgs) Handles textboxUname.Enter
        If textboxUname.Text = "Username" Then
            textboxUname.Text = ""
        End If
    End Sub

    Private Sub textboxUname_Leave(sender As Object, e As EventArgs) Handles textboxUname.Leave
        If textboxUname.Text = "" Then
            textboxUname.Text = "Username"
        End If
    End Sub

    Private Sub TextboxBday_Enter_1(sender As Object, e As EventArgs) Handles textboxBday.Enter
        textboxBday.Visible = False
        birthdatePicker.Visible = True
    End Sub

    Private Sub TextboxPass_Enter(sender As Object, e As EventArgs) Handles textboxPass.Enter

        If textboxPass.Text = "Password" Then
            textboxPass.Text = ""
            textboxPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TextboxPass_Leave(sender As Object, e As EventArgs) Handles textboxPass.Leave
        If textboxPass.Text = "" Then
            textboxPass.Text = "Password"
        End If
    End Sub

    Private Sub TextboxcPass_Enter(sender As Object, e As EventArgs) Handles textboxcPass.Enter
        If textboxcPass.Text = "Confirm Password" Then
            textboxcPass.Text = ""
            textboxcPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TextboxcPass_Leave(sender As Object, e As EventArgs) Handles textboxcPass.Leave
        If textboxcPass.Text = "" Then
            textboxcPass.Text = "Confirm Password"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        panelRegister.Visible = False
        panelLogin.Visible = True
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click



        If textboxPass.Text <> textboxcPass.Text Then
            MessageBox.Show("Your password and confirm password don't match.")
        Else
            panelRegister.Hide()
            panelLogin.Visible = True

            textboxFname.Text = "First Name"
            textboxMname.Text = "Middle Name"
            textboxlName.Text = "Last Name"
            textboxAddress.Text = "Address"
            textboxBday.Visible = True
            birthdatePicker.Visible = False
            textboxUname.Text = "Username"
            textboxEmail.Text = "Email"
            textboxPass.Text = "Password"
            textboxcPass.Text = "Confirm Password"
            textboxcPass.UseSystemPasswordChar = False
            textboxPass.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If textboxPass.UseSystemPasswordChar = True Then
            textboxPass.UseSystemPasswordChar = False
        Else
            textboxPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If textboxcPass.UseSystemPasswordChar = True Then
            textboxcPass.UseSystemPasswordChar = False
        Else
            textboxcPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TextboxEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles textboxEmail.KeyDown
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub TextboxEmail_KeyUp(sender As Object, e As KeyEventArgs) Handles textboxEmail.KeyUp
        textboxEmail.Text = textboxEmail.Text.Replace(" ", "")
    End Sub

    Private Sub TextboxUname_KeyDown(sender As Object, e As KeyEventArgs) Handles textboxUname.KeyDown
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub TextboxUname_KeyUp(sender As Object, e As KeyEventArgs) Handles textboxUname.KeyUp
        textboxUname.Text = textboxUname.Text.Replace(" ", "")
    End Sub

    Private Sub TextboxPass_KeyDown(sender As Object, e As KeyEventArgs) Handles textboxPass.KeyDown
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub TextboxPass_KeyUp(sender As Object, e As KeyEventArgs) Handles textboxPass.KeyUp
        textboxPass.Text = textboxPass.Text.Replace(" ", "")

    End Sub

    Private Sub TextboxcPass_KeyDown(sender As Object, e As KeyEventArgs) Handles textboxcPass.KeyDown
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub TextboxcPass_KeyUp(sender As Object, e As KeyEventArgs) Handles textboxcPass.KeyUp
        textboxcPass.Text = textboxcPass.Text.Replace(" ", "")

    End Sub

    Private Sub BirthdatePicker_ValueChanged(sender As Object, e As EventArgs) Handles birthdatePicker.ValueChanged

    End Sub
End Class