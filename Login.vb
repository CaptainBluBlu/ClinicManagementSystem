Public Class Login
    Dim db As New Database
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Shared EmployeeName As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Data entry validation or syntax error
        If TextBox2.Text = "Password" OrElse TextBox1.Text = "Username" Then
            MsgBox("Your username cannot be 'Username' and password cannot be 'Password'")
        ElseIf ComboBox1.Text = "" Then
            MsgBox("Please choose user type")

            'Check login details with database record
        ElseIf db.Login(TextBox1.Text, TextBox2.Text, ComboBox1.Text) Then

            EmployeeName = db.LoginEmName(TextBox1.Text, TextBox2.Text, ComboBox1.Text)

            MsgBox("Logged in successfully")
            MsgBox("Welcome " & EmployeeName & "!")
            'Login user into respective form
            If ComboBox1.Text = "Administrator" Then
                Administrator.Show()
                Register.Close()
                Me.Close()
            ElseIf ComboBox1.Text = "Doctor" Then
                Doctor.Show()
                Register.Close()
                Me.Close()
            ElseIf ComboBox1.Text = "Nurse" Then
                Nurse.Show()
                Register.Close()
                Me.Close()

            Else
                MessageBox.Show("Looks like you have beaten the system.", "Congratulations", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        Else
            MsgBox("Wrong Usertype, Username or Password incorrect.")
        End If
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Application.Exit()
    End Sub

    Private Sub LinklblNewUser_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinklblNewUser.LinkClicked
        Me.Hide()
        Register.Show()
    End Sub


    Private Sub TextBox1_MouseHover(sender As Object, e As EventArgs) Handles TextBox1.MouseHover
        ToolTip1.Show("Insert Username", TextBox1)
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        If TextBox1.Text = "Username" Then
            TextBox1.Text = ""
        Else

        End If

    End Sub

    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox2.Enter
        If TextBox2.Text = "Password" Then
            TextBox2.UseSystemPasswordChar = True
            TextBox2.Text = ""
        Else
        End If
    End Sub

    Private Sub TextBox2_MouseHover(sender As Object, e As EventArgs) Handles TextBox2.MouseHover
        ToolTip1.Show("Insert Password", TextBox2)
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = "" Then
            TextBox1.Text = "Username"
        Else
        End If
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        If TextBox2.Text = "" Then
            TextBox2.Text = "Password"
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub LinklblForgot_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinklblForgot.LinkClicked
        MsgBox("Please Request For Account to be reset by an Administrator")
    End Sub

    Private Sub ComboBox1_MouseHover(sender As Object, e As EventArgs) Handles ComboBox1.MouseHover
        ToolTip1.Show("Choose User Authorisation", ComboBox1)
    End Sub

    Private Sub CheckBox1_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckStateChanged
        If TextBox2.UseSystemPasswordChar = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Button1.PerformClick()
        End If

    End Sub
End Class