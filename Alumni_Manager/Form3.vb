Public Class mainPanel

    Dim hScrollHelper As Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper
    Dim vScrollHelper As Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper

    Private Sub ButtonData_MouseClick(sender As Object, e As MouseEventArgs) Handles buttonData.MouseClick
        panelHomeButton.Visible = False
        panelHome.Visible = False
        panelAlumniData.Visible = True
        panelDataButton.Visible = True
        panelAddAlumniButton.Visible = False
        panelAddAlumni.Visible = False
        panelEditAlumni.Visible = False
        panelEditAlumniButton.Visible = False
        panelRemoveAlumni.Visible = False
        panelRemoveDataButton.Visible = False
        panelLogs.Visible = False
        panelLogsButton.Visible = False
        panelManageAdminButton.Visible = False
        panelManageAdmin.Visible = False
        panelHelp.Visible = False
        panelHelpButton.Visible = False
        panelSettings.Visible = False
        panelSettingsButton.Visible = False
        panelAdminWelcome.Visible = False
    End Sub

    Private Sub ButtonHome_MouseClick(sender As Object, e As MouseEventArgs)
        panelHomeButton.Visible = True
        panelHome.Visible = True
        panelAlumniData.Visible = False
        panelDataButton.Visible = False
        panelAddAlumniButton.Visible = False
        panelAddAlumni.Visible = False
        panelEditAlumni.Visible = False
        panelEditAlumniButton.Visible = False
        panelRemoveAlumni.Visible = False
        panelRemoveDataButton.Visible = False
        panelLogs.Visible = False
        panelLogsButton.Visible = False
        panelManageAdminButton.Visible = False
        panelManageAdmin.Visible = False
        panelHelp.Visible = False
        panelHelpButton.Visible = False
        panelSettings.Visible = False
        panelSettingsButton.Visible = False
        panelAdminWelcome.Visible = False
    End Sub

    Private Sub Button2_MouseClick(sender As Object, e As MouseEventArgs) Handles Button2.MouseClick
        panelAddAlumniButton.Visible = True
        panelAddAlumni.Visible = True
        panelAlumniData.Visible = False
        panelDataButton.Visible = False
        panelEditAlumni.Visible = False
        panelEditAlumniButton.Visible = False
        panelRemoveAlumni.Visible = False
        panelRemoveDataButton.Visible = False
        panelManageAdminButton.Visible = False
        panelManageAdmin.Visible = False
        panelHelp.Visible = False
        panelHelpButton.Visible = False
        panelSettings.Visible = False
        panelSettingsButton.Visible = False
        panelHomeButton.Visible = False
        panelHome.Visible = False
        panelAdminWelcome.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        panelAddAlumniButton.Visible = False
        panelAddAlumni.Visible = False
        panelAlumniData.Visible = False
        panelDataButton.Visible = False
        panelEditAlumni.Visible = True
        panelEditAlumniButton.Visible = True
        panelRemoveAlumni.Visible = False
        panelRemoveDataButton.Visible = False
        panelLogs.Visible = False
        panelLogsButton.Visible = False
        panelManageAdminButton.Visible = False
        panelManageAdmin.Visible = False
        panelHelp.Visible = False
        panelHelpButton.Visible = False
        panelSettings.Visible = False
        panelSettingsButton.Visible = False
        panelHomeButton.Visible = False
        panelHome.Visible = False
        panelAdminWelcome.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        panelAddAlumniButton.Visible = False
        panelAddAlumni.Visible = False
        panelAlumniData.Visible = False
        panelDataButton.Visible = False
        panelEditAlumni.Visible = False
        panelEditAlumniButton.Visible = False
        panelRemoveAlumni.Visible = True
        panelRemoveDataButton.Visible = True
        panelLogs.Visible = False
        panelLogsButton.Visible = False
        panelManageAdminButton.Visible = False
        panelManageAdmin.Visible = False
        panelHelp.Visible = False
        panelHelpButton.Visible = False
        panelSettings.Visible = False
        panelSettingsButton.Visible = False
        panelHomeButton.Visible = False
        panelHome.Visible = False
        panelAdminWelcome.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

        panelAddAlumniButton.Visible = False
        panelAddAlumni.Visible = False
        panelAlumniData.Visible = False
        panelDataButton.Visible = False
        panelEditAlumni.Visible = False
        panelEditAlumniButton.Visible = False
        panelRemoveAlumni.Visible = False
        panelRemoveDataButton.Visible = False
        panelLogs.Visible = False
        panelLogsButton.Visible = False
        panelManageAdminButton.Visible = False
        panelManageAdmin.Visible = False
        panelHelp.Visible = False
        panelHelpButton.Visible = False
        panelSettings.Visible = False
        panelSettingsButton.Visible = False
        panelHomeButton.Visible = False
        panelHome.Visible = False
        panelAdminWelcome.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        panelLogs.Visible = True
        panelLogsButton.Visible = True
        panelAddAlumniButton.Visible = False
        panelAddAlumni.Visible = False
        panelAlumniData.Visible = False
        panelDataButton.Visible = False
        panelEditAlumni.Visible = False
        panelEditAlumniButton.Visible = False
        panelRemoveAlumni.Visible = False
        panelRemoveDataButton.Visible = False
        panelManageAdminButton.Visible = False
        panelManageAdmin.Visible = False
        panelHelp.Visible = False
        panelHelpButton.Visible = False
        panelSettings.Visible = False
        panelSettingsButton.Visible = False
        panelHomeButton.Visible = False
        panelHome.Visible = False
        panelAdminWelcome.Visible = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        panelManageAdminButton.Visible = True
        panelManageAdmin.Visible = True
        panelLogs.Visible = False
        panelLogsButton.Visible = False
        panelAddAlumniButton.Visible = False
        panelAddAlumni.Visible = False
        panelAlumniData.Visible = False
        panelDataButton.Visible = False
        panelEditAlumni.Visible = False
        panelEditAlumniButton.Visible = False
        panelRemoveAlumni.Visible = False
        panelRemoveDataButton.Visible = False
        panelHelp.Visible = False
        panelHelpButton.Visible = False
        panelSettings.Visible = False
        panelSettingsButton.Visible = False
        panelHomeButton.Visible = False
        panelHome.Visible = False
        panelAdminWelcome.Visible = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        panelHelp.Visible = True
        panelHelpButton.Visible = True
        panelManageAdminButton.Visible = False
        panelManageAdmin.Visible = False
        panelLogs.Visible = False
        panelLogsButton.Visible = False
        panelAddAlumniButton.Visible = False
        panelAddAlumni.Visible = False
        panelAlumniData.Visible = False
        panelDataButton.Visible = False
        panelEditAlumni.Visible = False
        panelEditAlumniButton.Visible = False
        panelRemoveAlumni.Visible = False
        panelRemoveDataButton.Visible = False
        panelSettings.Visible = False
        panelSettingsButton.Visible = False
        panelHomeButton.Visible = False
        panelHome.Visible = False
        panelAdminWelcome.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        panelSettings.Visible = True
        panelSettingsButton.Visible = True
        panelHelp.Visible = False
        panelHelpButton.Visible = False
        panelManageAdminButton.Visible = False
        panelManageAdmin.Visible = False
        panelLogs.Visible = False
        panelLogsButton.Visible = False
        panelAddAlumniButton.Visible = False
        panelAddAlumni.Visible = False
        panelAlumniData.Visible = False
        panelDataButton.Visible = False
        panelEditAlumni.Visible = False
        panelEditAlumniButton.Visible = False
        panelRemoveAlumni.Visible = False
        panelRemoveDataButton.Visible = False
        panelHomeButton.Visible = False
        panelHome.Visible = False
        panelAdminWelcome.Visible = False
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        panelRB.Visible = False
        panelContactUs.Visible = True
    End Sub

    Private Sub PanelFAQ_Click(sender As Object, e As EventArgs)
        panelRB.Visible = False
        panelContactUs.Visible = False
    End Sub

    Private Sub PanelReportBug_Click(sender As Object, e As EventArgs) Handles panelReportBug.Click
        panelRB.Visible = True
        panelContactUs.Visible = False
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Me.Dispose()
        Login.Show()
    End Sub

    Private Sub ButtonAccountSettings_Click(sender As Object, e As EventArgs) Handles buttonAccountSettings.Click
        panelLogout.Visible = False
        panelAccountSettings.Visible = True
    End Sub

    Private Sub ButtonInterface_Click(sender As Object, e As EventArgs)
        panelLogout.Visible = False
        panelAccountSettings.Visible = False
    End Sub

    Private Sub ButtonLogOut_Click(sender As Object, e As EventArgs) Handles buttonLogOut.Click
        panelLogout.Visible = True
        panelAccountSettings.Visible = False
    End Sub

    Private Sub Button25_MouseClick_1(sender As Object, e As MouseEventArgs) Handles Button25.MouseClick
        panelHomeButton.Visible = True
        panelHome.Visible = True
        panelAlumniData.Visible = False
        panelDataButton.Visible = False
        panelAddAlumniButton.Visible = False
        panelAddAlumni.Visible = False
        panelEditAlumni.Visible = False
        panelEditAlumniButton.Visible = False
        panelRemoveAlumni.Visible = False
        panelRemoveDataButton.Visible = False
        panelLogs.Visible = False
        panelLogsButton.Visible = False
        panelManageAdminButton.Visible = False
        panelHelp.Visible = False
        panelHelpButton.Visible = False
        panelSettings.Visible = False
        panelSettingsButton.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timerDateTime.Tick
        systemtime.Text = Date.Now.ToString("hh:mm:ss")
        systemdate.Text = Date.Now.ToString("MMMM dd, yyyy")
        adminTimeDate.Text = Date.Now.ToString("hh:mm:ss")
        adminDateTime.Text = Date.Now.ToString("MMMM dd, yyyy")
    End Sub

    Private Sub MainPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerDateTime.Enabled = True

        hScrollHelper = New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(GunaDataGridView4, GunaHScrollBar1, True)
        vScrollHelper = New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(GunaDataGridView4, GunaVScrollBar1, True)

        hScrollHelper.UpdateScrollBar()
        vScrollHelper.UpdateScrollBar()
    End Sub

    Private Sub AdminHome_Click(sender As Object, e As EventArgs) Handles adminHome.Click
        panelAdminHomeIndicator.Visible = True
        panelAdminWelcome.Visible = True
        panelAdminAlumniData.Visible = False
        panelAdminAddAlumni.Visible = False
        panelAdminEditData.Visible = False
        panelAdminRemoveData.Visible = False
        panelAdminHelpAlumni.Visible = False
        panelAdminSettings.Visible = False
        panelHome.Visible = False
        panelAlumniData.Visible = False
        panelHelp.Visible = False
        panelSettings.Visible = False
        panelAddAlumni.Visible = False
        panelRemoveAlumni.Visible = False
        panelLogs.Visible = False
        panelManageAdmin.Visible = False
        panelEditAlumni.Visible = False

    End Sub

    Private Sub AdminAlumniDataButton_Click(sender As Object, e As EventArgs) Handles adminAlumniDataButton.Click
        panelAdminHomeIndicator.Visible = False
        panelAdminWelcome.Visible = False
        panelAdminAlumniData.Visible = True
        panelAdminAddAlumni.Visible = False
        panelAdminEditData.Visible = False
        panelAdminRemoveData.Visible = False
        panelAdminHelpAlumni.Visible = False
        panelAdminSettings.Visible = False
        panelHome.Visible = False

        panelAlumniData.Visible = True
        panelHelp.Visible = False
        panelSettings.Visible = False
        panelAddAlumni.Visible = False
        panelRemoveAlumni.Visible = False
        panelLogs.Visible = False
        panelManageAdmin.Visible = False
        panelEditAlumni.Visible = False
    End Sub

    Private Sub adminAddAlumniButton_Click(sender As Object, e As EventArgs) Handles adminAddAlumniButton.Click
        panelAdminHomeIndicator.Visible = False
        panelAdminWelcome.Visible = False
        panelAdminAlumniData.Visible = False
        panelAdminAddAlumni.Visible = True
        panelAdminEditData.Visible = False
        panelAdminRemoveData.Visible = False
        panelAdminHelpAlumni.Visible = False
        panelAdminSettings.Visible = False
        panelHome.Visible = False

        panelAlumniData.Visible = False
        panelHelp.Visible = False
        panelSettings.Visible = False
        panelAddAlumni.Visible = True
        panelRemoveAlumni.Visible = False
        panelLogs.Visible = False
        panelManageAdmin.Visible = False
        panelEditAlumni.Visible = False
    End Sub

    Private Sub AdminEditDatabutton_Click(sender As Object, e As EventArgs) Handles adminEditDatabutton.Click
        panelAdminHomeIndicator.Visible = False
        panelAdminWelcome.Visible = False
        panelAdminAlumniData.Visible = False
        panelAdminAddAlumni.Visible = False
        panelAdminEditData.Visible = True
        panelAdminRemoveData.Visible = False
        panelAdminHelpAlumni.Visible = False
        panelAdminSettings.Visible = False
        panelHome.Visible = False

        panelAlumniData.Visible = False
        panelHelp.Visible = False
        panelSettings.Visible = False
        panelAddAlumni.Visible = False
        panelRemoveAlumni.Visible = False
        panelLogs.Visible = False
        panelManageAdmin.Visible = False
        panelEditAlumni.Visible = True
    End Sub

    Private Sub AdminRemoveDataButton_Click(sender As Object, e As EventArgs) Handles adminRemoveDataButton.Click
        panelAdminHomeIndicator.Visible = False
        panelAdminWelcome.Visible = False
        panelAdminAlumniData.Visible = False
        panelAdminAddAlumni.Visible = False
        panelAdminEditData.Visible = False
        panelAdminRemoveData.Visible = True
        panelAdminHelpAlumni.Visible = False
        panelAdminSettings.Visible = False
        panelHome.Visible = False

        panelAlumniData.Visible = False
        panelHelp.Visible = False
        panelSettings.Visible = False
        panelAddAlumni.Visible = False
        panelRemoveAlumni.Visible = True
        panelLogs.Visible = False
        panelManageAdmin.Visible = False
        panelEditAlumni.Visible = False
    End Sub

    Private Sub AdminButtonHelp_Click(sender As Object, e As EventArgs) Handles adminButtonHelp.Click
        panelAdminHomeIndicator.Visible = False
        panelAdminWelcome.Visible = False
        panelAdminAlumniData.Visible = False
        panelAdminAddAlumni.Visible = False
        panelAdminEditData.Visible = False
        panelAdminRemoveData.Visible = False
        panelAdminHelpAlumni.Visible = True
        panelAdminSettings.Visible = False
        panelHome.Visible = False

        panelAlumniData.Visible = False
        panelHelp.Visible = True
        panelSettings.Visible = False
        panelAddAlumni.Visible = False
        panelRemoveAlumni.Visible = False
        panelLogs.Visible = False
        panelManageAdmin.Visible = False
        panelEditAlumni.Visible = False
    End Sub

    Private Sub AdminButtonSettings_Click(sender As Object, e As EventArgs) Handles adminButtonSettings.Click
        panelAdminHomeIndicator.Visible = False
        panelAdminWelcome.Visible = False
        panelAdminAlumniData.Visible = False
        panelAdminAddAlumni.Visible = False
        panelAdminEditData.Visible = False
        panelAdminRemoveData.Visible = False
        panelAdminHelpAlumni.Visible = False
        panelAdminSettings.Visible = True
        panelHome.Visible = False

        panelAlumniData.Visible = False
        panelHelp.Visible = False
        panelSettings.Visible = True
        panelAddAlumni.Visible = False
        panelRemoveAlumni.Visible = False
        panelLogs.Visible = False
        panelManageAdmin.Visible = False
        panelEditAlumni.Visible = False
    End Sub

    Private Sub GunaAdvenceButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton4.Click
        youremail.Text = ""
        subject.Text = ""
        description.Text = ""
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        youremail.Text = ""
        subject.Text = ""
        description.Text = ""
        MessageBox.Show("You succesfully sent a report.")
    End Sub



    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        textboxAccountnum.ReadOnly = False
        txtboxFname.ReadOnly = False
        txtboxLname.ReadOnly = False
        txtboxAge.ReadOnly = False
        txtboxGender.ReadOnly = False
        textboxBirthday.ReadOnly = False
        txtboxAdminPhonenumber.ReadOnly = False
        txtboxTelNumber.ReadOnly = False
        MessageBox.Show("You can now edit your information.")
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        MessageBox.Show("Successfully changed account information.")
    End Sub

    Private Sub GunaTextBox1_Enter(sender As Object, e As EventArgs) Handles viewalumnTextBox.Enter
        If viewalumnTextBox.Text = "Input Keyword" Then
            viewalumnTextBox.Text = ""
        End If
    End Sub

    Private Sub GunaTextBox1_Leave(sender As Object, e As EventArgs) Handles viewalumnTextBox.Leave
        If viewalumnTextBox.Text = "" Then
            viewalumnTextBox.Text = "Input Keyword"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        If (MessageBox.Show("Do you want to clear all fields?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            GunaTextBox2.Text = "Student ID Number"
            GunaTextBox3.Text = "First Name"
            GunaTextBox4.Text = "Middle Name"
            GunaTextBox5.Text = "Last Name"
            GunaTextBox6.Text = "Address"
            GunaTextBox7.Text = "Birthdate"
            GunaTextBox8.Text = "Email"
            GunaTextBox9.Text = "Phone Number"
            GunaTextBox10.Text = "Parent/Guardian"
            GunaTextBox11.Text = "Parent/Guardian Contact No."
            GunaTextBox15.Text = "College/Department"
            GunaTextBox14.Text = "Course"
            GunaTextBox17.Text = "School/Campus Name"
            GunaTextBox13.Text = "Date Graduated"
            GunaTextBox12.Text = "BOT Resolution Number"
            GunaTextBox16.Text = "Date of BOT Resolution Released"
        End If
    End Sub

    Private Sub GunaTextBox2_Enter(sender As Object, e As EventArgs) Handles GunaTextBox2.Enter
        If GunaTextBox2.Text = "Student ID Number" Then
            GunaTextBox2.Text = ""
        End If
    End Sub

    Private Sub GunaTextBox2_Leave(sender As Object, e As EventArgs) Handles GunaTextBox2.Leave
        If GunaTextBox2.Text = "" Then
            GunaTextBox2.Text = "Student ID Number"
        End If
    End Sub

    Private Sub GunaTextBox3_Enter(sender As Object, e As EventArgs) Handles GunaTextBox3.Enter
        If GunaTextBox3.Text = "First Name" Then
            GunaTextBox3.Text = ""
        End If
    End Sub

    Private Sub GunaTextBox3_Leave(sender As Object, e As EventArgs) Handles GunaTextBox3.Leave
        If GunaTextBox3.Text = "" Then
            GunaTextBox3.Text = "First Name"
        End If
    End Sub

    Private Sub GunaTextBox4_Enter(sender As Object, e As EventArgs) Handles GunaTextBox4.Enter
        If GunaTextBox4.Text = "Middle Name" Then
            GunaTextBox4.Text = ""
        End If
    End Sub

    Private Sub GunaTextBox4_Leave(sender As Object, e As EventArgs) Handles GunaTextBox4.Leave
        If GunaTextBox4.Text = "" Then
            GunaTextBox4.Text = "Middle Name"
        End If
    End Sub

    Private Sub GunaTextBox6_Enter(sender As Object, e As EventArgs) Handles GunaTextBox6.Enter
        If GunaTextBox6.Text = "Address" Then
            GunaTextBox6.Text = ""
        End If
    End Sub

    Private Sub GunaTextBox6_Leave(sender As Object, e As EventArgs) Handles GunaTextBox6.Leave
        If GunaTextBox6.Text = "" Then
            GunaTextBox6.Text = "Address"
        End If
    End Sub

    Private Sub GunaTextBox7_Leave(sender As Object, e As EventArgs) Handles GunaTextBox7.Leave
        If GunaTextBox7.Text = "" Then
            GunaTextBox7.Text = "Birthdate"
        End If
    End Sub

    Private Sub GunaTextBox7_Enter(sender As Object, e As EventArgs) Handles GunaTextBox7.Enter
        If GunaTextBox7.Text = "Birthdate" Then
            GunaTextBox7.Text = ""
        End If
    End Sub


    Private Sub GunaTextBox8_Enter(sender As Object, e As EventArgs) Handles GunaTextBox8.Enter
        If GunaTextBox8.Text = "Email" Then
            GunaTextBox8.Text = ""
        End If
    End Sub

    Private Sub GunaTextBox8_Leave(sender As Object, e As EventArgs) Handles GunaTextBox8.Leave
        If GunaTextBox8.Text = "" Then
            GunaTextBox8.Text = "Email"
        End If
    End Sub

    Private Sub GunaTextBox9_Enter(sender As Object, e As EventArgs) Handles GunaTextBox9.Enter
        If GunaTextBox9.Text = "Phone Number" Then
            GunaTextBox9.Text = ""
        End If
    End Sub

    Private Sub GunaTextBox9_Leave(sender As Object, e As EventArgs) Handles GunaTextBox9.Leave
        If GunaTextBox9.Text = "" Then
            GunaTextBox9.Text = "Phone Number"
        End If
    End Sub

    Private Sub GunaTextBox10_Enter(sender As Object, e As EventArgs) Handles GunaTextBox10.Enter
        If GunaTextBox10.Text = "Parent/Guardian" Then
            GunaTextBox10.Text = ""
        End If
    End Sub

    Private Sub GunaTextBox10_Leave(sender As Object, e As EventArgs) Handles GunaTextBox10.Leave
        If GunaTextBox10.Text = "" Then
            GunaTextBox10.Text = "Parent/Guardian"
        End If
    End Sub

    Private Sub GunaTextBox11_Enter(sender As Object, e As EventArgs) Handles GunaTextBox11.Enter
        If GunaTextBox11.Text = "Parent/Guardian Contact No." Then
            GunaTextBox11.Text = ""
        End If
    End Sub

    Private Sub GunaTextBox11_Leave(sender As Object, e As EventArgs) Handles GunaTextBox11.Leave
        If GunaTextBox11.Text = "" Then
            GunaTextBox11.Text = "Parent/Guardian Contact No."
        End If
    End Sub

    Private Sub GunaTextBox15_Leave(sender As Object, e As EventArgs) Handles GunaTextBox15.Leave
        If GunaTextBox15.Text = "" Then
            GunaTextBox15.Text = "College/Department"
        End If
    End Sub

    Private Sub GunaTextBox15_Enter(sender As Object, e As EventArgs) Handles GunaTextBox15.Enter
        If GunaTextBox15.Text = "College/Department" Then
            GunaTextBox15.Text = ""
        End If
    End Sub

    Private Sub GunaTextBox14_Enter(sender As Object, e As EventArgs) Handles GunaTextBox14.Enter
        If GunaTextBox14.Text = "Course" Then
            GunaTextBox14.Text = ""
        End If
    End Sub

    Private Sub GunaTextBox14_Leave(sender As Object, e As EventArgs) Handles GunaTextBox14.Leave
        If GunaTextBox14.Text = "" Then
            GunaTextBox14.Text = "Course"
        End If
    End Sub

    Private Sub GunaTextBox17_Enter(sender As Object, e As EventArgs) Handles GunaTextBox17.Enter
        If GunaTextBox17.Text = "School/Campus Name" Then
            GunaTextBox17.Text = ""
        End If
    End Sub

    Private Sub GunaTextBox17_Leave(sender As Object, e As EventArgs) Handles GunaTextBox17.Leave
        If GunaTextBox17.Text = "" Then
            GunaTextBox17.Text = "School/Campus Name"
        End If

    End Sub

    Private Sub GunaTextBox13_Enter(sender As Object, e As EventArgs) Handles GunaTextBox13.Enter
        If GunaTextBox13.Text = "Date Graduated" Then
            GunaTextBox13.Text = ""
        End If
    End Sub

    Private Sub GunaTextBox13_Leave(sender As Object, e As EventArgs) Handles GunaTextBox13.Leave
        If GunaTextBox13.Text = "" Then
            GunaTextBox13.Text = "Date Graduated"
        End If
    End Sub

    Private Sub GunaTextBox12_Enter(sender As Object, e As EventArgs) Handles GunaTextBox12.Enter
        If GunaTextBox12.Text = "BOT Resolution Number" Then
            GunaTextBox12.Text = ""
        End If
    End Sub

    Private Sub GunaTextBox12_Leave(sender As Object, e As EventArgs) Handles GunaTextBox12.Leave
        If GunaTextBox12.Text = "" Then
            GunaTextBox12.Text = "BOT Resolution Number"
        End If
    End Sub

    Private Sub GunaTextBox16_Enter(sender As Object, e As EventArgs) Handles GunaTextBox16.Enter
        If GunaTextBox16.Text = "Date of BOT Resolution Released" Then
            GunaTextBox16.Text = ""
        End If
    End Sub

    Private Sub GunaTextBox16_Leave(sender As Object, e As EventArgs) Handles GunaTextBox16.Leave
        If GunaTextBox16.Text = "" Then
            GunaTextBox16.Text = "Date of BOT Resolution Released"
        End If
    End Sub

    Private Sub GunaTextBox5_Enter(sender As Object, e As EventArgs) Handles GunaTextBox5.Enter
        If GunaTextBox5.Text = "Last Name" Then
            GunaTextBox5.Text = ""
        End If
    End Sub

    Private Sub GunaTextBox5_Leave(sender As Object, e As EventArgs) Handles GunaTextBox5.Leave
        If GunaTextBox5.Text = "" Then
            GunaTextBox5.Text = "Last Name"
        End If
    End Sub

    Private Sub GunaTextBox35_Enter(sender As Object, e As EventArgs) Handles GunaTextBox35.Enter
        If GunaTextBox35.Text = "Input Keyword" Then
            GunaTextBox35.Text = ""
        End If
    End Sub

    Private Sub GunaTextBox35_Leave(sender As Object, e As EventArgs) Handles GunaTextBox35.Leave
        If GunaTextBox35.Text = "" Then
            GunaTextBox35.Text = "Input Keyword"
        End If
    End Sub

    Private Sub GunaTextBox33_Enter(sender As Object, e As EventArgs) Handles GunaTextBox33.Enter
        If GunaTextBox33.Text = "Input Keyword" Then
            GunaTextBox33.Text = ""
        End If
    End Sub

    Private Sub GunaTextBox33_Leave(sender As Object, e As EventArgs) Handles GunaTextBox33.Leave
        If GunaTextBox33.Text = "" Then
            GunaTextBox33.Text = "Input Keyword"
        End If
    End Sub

    Private Sub GunaTextBox34_Enter(sender As Object, e As EventArgs) Handles GunaTextBox34.Enter
        If GunaTextBox34.Text = "Input Alumni Student ID Number" Then
            GunaTextBox34.Text = ""
        End If
    End Sub

    Private Sub GunaTextBox34_Leave(sender As Object, e As EventArgs) Handles GunaTextBox34.Leave
        If GunaTextBox34.Text = "" Then
            GunaTextBox34.Text = "Input Alumni Student ID Number"
        End If
    End Sub

    Private Sub GunaTextBox46_Enter(sender As Object, e As EventArgs) Handles GunaTextBox46.Enter
        If GunaTextBox46.Text = "Input Keyword" Then
            GunaTextBox46.Text = ""
        End If
    End Sub

    Private Sub GunaTextBox46_Leave(sender As Object, e As EventArgs) Handles GunaTextBox46.Leave
        If GunaTextBox46.Text = "" Then
            GunaTextBox46.Text = "Input Keyword"
        End If
    End Sub

End Class