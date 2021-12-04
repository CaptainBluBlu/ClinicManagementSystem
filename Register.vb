Public Class Register

    Dim db As New Database

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Application.Exit()
    End Sub
    'Hide Admin Code Textbox if Administrator is not selected
    Private Sub cboUserType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUserType.SelectedIndexChanged
        If cboUserType.Text = "Administrator" Then
            btnSignUp.Location = New Point(163, 435)
            lblCancel.Location = New Point(211, 487)
            Panel4.Visible = True
        Else
            btnSignUp.Location = New Point(156, 380)
            lblCancel.Location = New Point(201, 424)
            Panel4.Visible = False
        End If
    End Sub
    'Making Placeholders in Textbox
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        If TextBox1.Text = "Username" Then
            TextBox1.Text = ""
        Else
        End If
    End Sub
    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = "" Then
            TextBox1.Text = "Username"
        End If
    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        If txtPassword.Text = "Password" Then
            txtPassword.UseSystemPasswordChar = True
            txtPassword.Text = ""
        Else
        End If
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If txtPassword.Text = "" Then
            txtPassword.Text = "Password"
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtEmName_Click(sender As Object, e As EventArgs) Handles txtEmName.Click
        If txtEmName.Text = "Employee Name" Then
            txtEmName.Text = ""
        Else
        End If
    End Sub

    Private Sub txtEmName_Leave(sender As Object, e As EventArgs) Handles txtEmName.Leave
        If txtEmName.Text = "" Then
            txtEmName.Text = "Employee Name"
        End If
    End Sub

    Private Sub txtAdminCode_Click(sender As Object, e As EventArgs) Handles txtAdminCode.Click
        If txtAdminCode.Text = "Admin Code" Then
            txtAdminCode.UseSystemPasswordChar = True
            txtAdminCode.Text = ""
        Else
        End If
    End Sub

    Private Sub txtAdminCode_Leave(sender As Object, e As EventArgs) Handles txtAdminCode.Leave
        If txtAdminCode.Text = "" Then
            txtAdminCode.Text = "Admin Code"
            txtAdminCode.UseSystemPasswordChar = False
        Else
            txtAdminCode.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub lblCancel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblCancel.LinkClicked
        Login.Show()
        Me.Hide()
    End Sub
    'End Place Holder Section

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        'Checking for data validation or syntax errors
        If TextBox1.Text = "Username" OrElse txtPassword.Text = "Password" Then
            MsgBox("Your username cannot be 'username' and password cannot be 'Password'")
        ElseIf cboUserType.Text = "" OrElse TextBox1.Text = "" OrElse txtPassword.Text = "" Then
            MsgBox("Please fill in all the fields")
        ElseIf cboUserType.Text = "Administrator" And txtAdminCode.Text = "Admin Code" Then
            MsgBox("You need to fill in the admin code")
            txtAdminCode.Focus()
        ElseIf cboUserType.Text = "Administrator" And txtAdminCode.Text <> "admin123" Then
            MsgBox("You do not have Admin rights.")

        ElseIf db.CheckUserExist(TextBox1.Text) Then 'check if another user with the same username exist
            MsgBox("Username has already been taken.", MsgBoxStyle.Exclamation, "Username Taken")
        Else
            db.AddUsers(cboUserType.Text, TextBox1.Text, txtPassword.Text, txtEmName.Text)

            Login.Show()
            Me.Hide()
        End If
    End Sub

End Class
