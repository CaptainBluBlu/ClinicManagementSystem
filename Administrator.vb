Public Class Administrator
    Dim db As New Database

    Dim emname = Login.EmployeeName
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Administrator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView3.DataSource = db.ViewPatientTable()
        lblEmName.Text = emname
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnLogOut_MouseHover(sender As Object, e As EventArgs)
        ToolTip1.Show("Log Out", btnLogOut)
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs)
        'make silent when enter key is pressed in textbox
        e.SuppressKeyPress = True
    End Sub

    Private Sub btnLogOut_Click_1(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Log out? You will need to Log In again. ", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

        If result = DialogResult.OK Then
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnViewPatient_Click(sender As Object, e As EventArgs) Handles btnViewPatient.Click
        panelVisiblity(1)

        pnlBlueSideBar.Location = New Point(1, 27)
    End Sub

    Private Sub btnAddPatient_Click(sender As Object, e As EventArgs) Handles btnAddPatient.Click
        panelVisiblity(2)

        AddPatientTable.DataSource = db.ViewPatientTable
        cboPrimaryDoctor.DataSource = db.DoctorComboBox
        pnlBlueSideBar.Location = New Point(1, 75)
    End Sub

    Private Sub btnUpdatePatient_Click(sender As Object, e As EventArgs) Handles btnUpdatePatient.Click
        panelVisiblity(3)

        UpdateViewPatient.DataSource = db.ViewPatientTable
        cboPrimaryDoctorUp.DataSource = db.DoctorComboBox
        pnlBlueSideBar.Location = New Point(1, 124)
    End Sub

    Private Sub btnBillPatient_Click(sender As Object, e As EventArgs) Handles btnBillPatient.Click
        panelVisiblity(4)
        pnlBlueSideBar.Location = New Point(1, 172)
        PaymentViewPatient.DataSource = db.PatientName
        txtPaymentChange.Text = "0"
        cboPaymentType.DataSource = db.PaymentComboBox
        cboPaymentType.ValueMember = "PtID"
        cboPaymentType.DisplayMember = "Type"
    End Sub

    Private Sub btnTreatment_Click(sender As Object, e As EventArgs) Handles btnTreatment.Click
        panelVisiblity(5)
        pnlBlueSideBar.Location = New Point(1, 219)
        cboDoctorTreat.DataSource = db.DoctorComboBox
        TreatmentTypeTable.DataSource = db.MS
        PatientTable.DataSource = db.PatientName
        TreatmentTypeTable.Columns(1).Visible = False
        dtpDate.Value = Date.Now
    End Sub

    Private Sub btnPatientTreatment_Click(sender As Object, e As EventArgs) Handles btnPatientTreatment.Click
        pnlBlueSideBar.Location = New Point(1, 267)
        panelVisiblity(7)
        ViewPatientTreatment.DataSource = db.PatientTreaments
    End Sub

    Private Sub btnViewPayment_Click(sender As Object, e As EventArgs) Handles btnViewPayment.Click
        pnlBlueSideBar.Location = New Point(1, 315)
        panelVisiblity(8)
        ViewPayment.DataSource = db.PaymentRecordTable
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        panelVisiblity(6)
        pnlBlueSideBar.Location = New Point(1, 363)
        UsersTable.DataSource = db.UserTable
        UsersTable.Columns(2).Visible = False
    End Sub



    'Sub To easily change visibility
    Private Sub panelVisiblity(Panel As Integer)
        pnlViewPatient.Visible = False
        pnlAddPatient.Visible = False
        pnlUpdatePatient.Visible = False
        pnlBillPatient.Visible = False
        pnlTreatment.Visible = False
        PanelUser.Visible = False
        pnlPatientTreatment.Visible = False
        pnlViewPayment.Visible = False

        Select Case Panel
            Case 1
                pnlViewPatient.Visible = True
            Case 2
                pnlAddPatient.Visible = True
            Case 3
                pnlUpdatePatient.Visible = True
            Case 4
                pnlBillPatient.Visible = True
            Case 5
                pnlTreatment.Visible = True
            Case 6
                PanelUser.Visible = True
            Case 7
                pnlPatientTreatment.Visible = True
            Case 8
                pnlViewPayment.Visible = True
        End Select

    End Sub

    Private Sub pnlViewSearch_Paint(sender As Object, e As PaintEventArgs) Handles pnlViewSearch.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim Name = txtName.Text
    End Sub

    'adding new users into the database
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrWhiteSpace(cboUserType.Text) Or String.IsNullOrWhiteSpace(txtUsername.Text) Or String.IsNullOrWhiteSpace(txtPassword.Text) Or String.IsNullOrWhiteSpace(txtEmName.Text) Then
            MessageBox.Show("Please fill in all the required fields.", "Empty Fields")
        ElseIf db.CheckUserExist(txtUsername.Text) Then 'check if another user with the same username exist
            MsgBox("Username has already been taken.", MsgBoxStyle.Exclamation, "Username Taken")
        Else
            db.NewUser(cboUserType.Text, txtUsername.Text, txtPassword.Text, txtEmName.Text)

            For Each ctrl As Control In pnlAddPatientForm.Controls
                If TypeOf ctrl Is TextBox Then
                    Dim textbox As TextBox = ctrl

                    textbox.Clear()
                ElseIf TypeOf ctrl Is ComboBox Then
                    Dim combobox As ComboBox = ctrl

                    combobox.Text = combobox.Items(0)
                End If
            Next

            UsersTable.DataSource = db.UserTable
        End If

    End Sub

    'To Display, delete and update user table 
    Private Sub UsersTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UsersTable.CellContentClick
        If e.ColumnIndex = 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

            If result = DialogResult.OK Then
                Dim selected As String
                selected = UsersTable.Rows(e.RowIndex).Cells(2).Value

                db.DeleteUsers(selected)

            End If
        ElseIf e.ColumnIndex = 1 Then
            Dim Password As String
            Dim defaultpassword = UsersTable.Rows(e.RowIndex).Cells(5).Value
            Dim defaultemployeename = UsersTable.Rows(e.RowIndex).Cells(6).Value
            Dim employeename As String

            Password = InputBox("Insert the new password: ", UsersTable.Rows(e.RowIndex).Cells(4).Value, defaultpassword)
            employeename = InputBox("Insert Employee Name: ", UsersTable.Rows(e.RowIndex).Cells(4).Value, defaultemployeename)

            If String.IsNullOrWhiteSpace(Password) Or String.IsNullOrWhiteSpace(employeename) Then
                MessageBox.Show("Please fill in all the required fields.", "Empty Fields")
            Else
                db.UpdateUser(UsersTable.Rows(e.RowIndex).Cells(4).Value, Password, employeename)
            End If
        End If
        UsersTable.DataSource = db.UserTable
    End Sub


    '.........................................................Patient Information Section..................................................................


    'double click to remove allgery that are wrongly inputted
    Private Sub ListBoxAllergy_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBoxAllergy.MouseDoubleClick
        ListBoxAllergy.Items.Remove(ListBoxAllergy.SelectedItem)
    End Sub

    Private Sub ListBox2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox2.MouseDoubleClick
        ListBox2.Items.Remove(ListBox2.SelectedItem)
    End Sub
    'check if there is things in the textbox before input
    Private Sub txtAllergies_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAllergies.KeyDown
        If e.KeyCode = Keys.Enter And String.IsNullOrWhiteSpace(txtAllergies.Text) Then
            MsgBox("Please insert data first")
        ElseIf e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            ListBoxAllergy.Items.Add(txtAllergies.Text)
            txtAllergies.Clear()
        End If
    End Sub
    Private Sub txtUpAllergies_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUpAllergies.KeyDown

        If e.KeyCode = Keys.Enter And String.IsNullOrWhiteSpace(txtUpAllergies.Text) Then
            MsgBox("Please Insert data first")
        ElseIf e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            ListBox2.Items.Add(txtUpAllergies.Text)
            txtUpAllergies.Clear()
        End If
    End Sub

    'to auto fill fields when select in patient table
    Private Sub UpdateViewPatient_SelectionChanged(sender As Object, e As EventArgs) Handles UpdateViewPatient.SelectionChanged


        If UpdateViewPatient.SelectedCells.Count > 0 Then
            Dim selectedrowindex = UpdateViewPatient.SelectedCells(0).RowIndex

            txtUpIC.Text = UpdateViewPatient.Rows(selectedrowindex).Cells(1).Value
            txtUpName.Text = UpdateViewPatient.Rows(selectedrowindex).Cells(2).Value
            cboGenderUp.Text = UpdateViewPatient.Rows(selectedrowindex).Cells(3).Value
            cboPrimaryDoctorUp.Text = UpdateViewPatient.Rows(selectedrowindex).Cells(4).Value
            txtAddressUp.Text = UpdateViewPatient.Rows(selectedrowindex).Cells(5).Value
            txtUpPhone.Text = UpdateViewPatient.Rows(selectedrowindex).Cells(6).Value
            txtDOBUp.Value = Date.Parse(UpdateViewPatient.Rows(selectedrowindex).Cells(7).Value)
            txtUpWeight.Text = UpdateViewPatient.Rows(selectedrowindex).Cells(8).Value
            txtUpHeight.Text = UpdateViewPatient.Rows(selectedrowindex).Cells(9).Value
            cboBlood.Text = UpdateViewPatient.Rows(selectedrowindex).Cells(11).Value
            Dim value As String = UpdateViewPatient.Rows(selectedrowindex).Cells(10).Value.ToString
            Dim MyArray As String() = value.Split(",")
            ListBox2.Items.Clear()

            For Each item In MyArray
                ListBox2.Items.Add(item)
            Next

        End If
    End Sub

    'updating action to the database
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrWhiteSpace(txtUpIC.Text) Or String.IsNullOrWhiteSpace(txtUpName.Text) Or String.IsNullOrWhiteSpace(cboGenderUp.Text) Or String.IsNullOrWhiteSpace(txtAddressUp.Text) Or String.IsNullOrWhiteSpace(cboPrimaryDoctorUp.Text) Or String.IsNullOrWhiteSpace(txtUpPhone.Text) Or String.IsNullOrWhiteSpace(txtUpWeight.Text) Or String.IsNullOrWhiteSpace(txtUpHeight.Text) Or String.IsNullOrWhiteSpace(cboBlood.Text) Then
            MessageBox.Show("Please fill in all the required fields.", "Empty Fields")
        Else
            db.UpdatePatientInformation(txtUpIC.Text, txtUpName.Text, cboGenderUp.Text, cboPrimaryDoctorUp.Text, txtAddressUp.Text, txtUpPhone.Text, txtDOBUp.Value.ToString("dd/MM/yyyy"), txtUpWeight.Text, txtUpHeight.Text, cboBlood.Text, ListBox2.Items)
            'clear all fields once clicked add
            For Each ctrl As Control In pnlAddPatientForm.Controls
                If TypeOf ctrl Is TextBox Then
                    Dim textbox As TextBox = ctrl

                    textbox.Clear()
                ElseIf TypeOf ctrl Is ComboBox Then
                    Dim combobox As ComboBox = ctrl

                    combobox.Text = combobox.Items(0)

                ElseIf TypeOf ctrl Is ListBox Then
                    Dim listbox As ListBox = ctrl

                    listbox.Items.Clear()
                ElseIf TypeOf ctrl Is MaskedTextBox Then
                    Dim maskedtextbox As MaskedTextBox = ctrl

                    maskedtextbox.Clear()
                End If
            Next

            UpdateViewPatient.DataSource = db.ViewPatientTable
        End If
    End Sub

    'delete patient inforamtion in the update
    Private Sub UpdateViewPatient_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UpdateViewPatient.CellContentClick

        If e.ColumnIndex = 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

            If result = DialogResult.OK Then
                Dim selected As String
                selected = UpdateViewPatient.Rows(e.RowIndex).Cells(1).Value

                db.DeletePatientInformation(selected)

            End If
            UpdateViewPatient.DataSource = db.ViewPatientTable()
        End If
    End Sub

    'add patient inforamtion to the database
    Private Sub btnAddPatientInformation_Click(sender As Object, e As EventArgs) Handles btnAddPatientInformation.Click
        If String.IsNullOrWhiteSpace(txtIC.Text) Or String.IsNullOrWhiteSpace(txtName.Text) Or String.IsNullOrWhiteSpace(cboGenderAdd.Text) Or String.IsNullOrWhiteSpace(txtAddressAdd.Text) Or String.IsNullOrWhiteSpace(cboPrimaryDoctor.Text) Or String.IsNullOrWhiteSpace(txtPhone.Text) Or String.IsNullOrWhiteSpace(txtWeight.Text) Or String.IsNullOrWhiteSpace(txtHeight.Text) Or String.IsNullOrWhiteSpace(cboAddBlood.Text) Then
            MessageBox.Show("Please fill in all the required fields.", "Empty Fields")
        ElseIf db.CheckPatientExist(txtIC.Text) Then
            MessageBox.Show("The patient that you are trying to add already exist!", "ERROR : SAME IC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            db.AddPatientInformation(txtIC.Text, txtName.Text, cboGenderAdd.Text, cboPrimaryDoctor.Text, txtAddressAdd.Text, txtPhone.Text, txtDOB.Value.ToString("dd/MM/yyyy"), txtWeight.Text, txtHeight.Text, cboAddBlood.Text, ListBoxAllergy.Items)
            'clear all fields once clicked add
            For Each ctrl As Control In pnlAddPatientForm.Controls
                If TypeOf ctrl Is TextBox Then
                    Dim textbox As TextBox = ctrl

                    textbox.Clear()
                ElseIf TypeOf ctrl Is ComboBox Then
                    Dim combobox As ComboBox = ctrl

                    combobox.Text = combobox.Items(0)

                ElseIf TypeOf ctrl Is ListBox Then
                    Dim listbox As ListBox = ctrl

                    listbox.Items.Clear()
                ElseIf TypeOf ctrl Is MaskedTextBox Then
                    Dim maskedtextbox As MaskedTextBox = ctrl

                    maskedtextbox.Clear()
                End If
            Next

            AddPatientTable.DataSource = db.ViewPatientTable
        End If
    End Sub

    'enable for chekcbox in treatment panel to be checked
    Private Sub TreatmentTypeTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TreatmentTypeTable.CellContentClick
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then

                Dim checkCell As DataGridViewCheckBoxCell = CType(TreatmentTypeTable.Rows(e.RowIndex).Cells(0), DataGridViewCheckBoxCell)

                checkCell.Value = Not checkCell.Value
            End If
        End If

    End Sub

    'Easy option to autofill patient information in the treatment panel
    Private Sub PatientTable_SelectionChanged(sender As Object, e As EventArgs) Handles PatientTable.SelectionChanged
        If PatientTable.SelectedCells.Count > 0 Then


            Dim selectedrowindex = PatientTable.SelectedCells(0).RowIndex

            txtICTreatment.Text = PatientTable.Rows(selectedrowindex).Cells(0).Value
            txtNameTreatment.Text = PatientTable.Rows(selectedrowindex).Cells(1).Value

        End If

    End Sub
    'treatment panel to add treat patient
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        Dim checked As New List(Of String)
        Dim TreatmentID As String = db.TreatmentAutoID

        Dim datestring = dtpDate.Value.ToString("dd/MM/yyyy")
        checked.Clear()
        For i As Integer = 0 To TreatmentTypeTable.Rows.Count - 1
            Dim checkCell As DataGridViewCheckBoxCell = CType(TreatmentTypeTable.Rows(i).Cells(0), DataGridViewCheckBoxCell)
            If checkCell.Value = True Then
                checked.Add(TreatmentTypeTable.Rows(i).Cells(1).Value)
            End If
        Next

        If String.IsNullOrWhiteSpace(txtICTreatment.Text) Or String.IsNullOrWhiteSpace(txtNameTreatment.Text) Or String.IsNullOrWhiteSpace(cboDoctorTreat.Text) Or String.IsNullOrWhiteSpace(dtpDate.Value) Or checked Is Nothing Then
            MessageBox.Show("Please fill in all the required fields.", "Empty Fields")
            Return
        Else
            db.AddPatientTreatment(TreatmentID, txtICTreatment.Text, datestring, cboDoctorTreat.Text, txtNote.Text, checked)
            'clear all fields once clicked add
            For Each ctrl As Control In pnlTreatment.Controls
                If TypeOf ctrl Is TextBox Then
                    Dim textbox As TextBox = ctrl

                    textbox.Clear()

                ElseIf TypeOf ctrl Is ComboBox Then
                    Dim combobox As ComboBox = ctrl

                    combobox.Text = combobox.Items(0)
                End If
            Next
        End If
    End Sub

    '.............................................. PAYMENT PANEL FOR ADMINISTRATOR .....................................................
    Public Shared PaymentID As String
    Public Shared DateString As String

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        PaymentID = db.PaymentAutoID
        DateString = PaymentDate.Value.ToString("dd/MM/yyyy")
        If String.IsNullOrWhiteSpace(txtPaymentIC.Text) Or String.IsNullOrWhiteSpace(txtPaymentTreatment.Text) Or String.IsNullOrWhiteSpace(txtAmoutPaying.Text) Or String.IsNullOrWhiteSpace(cboPaymentType.Text) Or String.IsNullOrWhiteSpace(PaymentDate.Value.ToString) Then
            MessageBox.Show("Please fill in all the required fields.", "Empty Fields")
            Return
        ElseIf IsNumeric(txtAmoutPaying.Text) Then

            Dim remaining = txtPaymentRemaining.Text

            If remaining < 0 Then
                MessageBox.Show("Remaining cannot be negative value!", "ERROR : Negative Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                db.NewPayment(PaymentID, txtPaymentTreatment.Text, cboPaymentType.SelectedValue, txtPaymentNote.Text, DateString, txtAmoutPaying.Text, txtPaymentChange.Text)
                'clear all fields once clicked add
                For Each ctrl As Control In pnlBillPatient.Controls
                    If TypeOf ctrl Is TextBox Then
                        Dim textbox As TextBox = ctrl

                        textbox.Clear()

                    ElseIf TypeOf ctrl Is ComboBox Then
                        Dim combobox As ComboBox = ctrl

                        combobox.Text = combobox.Items(0)
                    End If
                Next
                ReceiptAdmin.Show()
                PaymentViewTreatment.DataSource = db.PatientOutstanding(txtPaymentIC.Text)
            End If
        Else
            MessageBox.Show("You cannot enter numbers in text!", "ERROR: Data Type", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub txtPaymentIC_TextChanged(sender As Object, e As EventArgs) Handles txtPaymentIC.TextChanged
        PaymentViewTreatment.DataSource = db.PatientOutstanding(txtPaymentIC.Text)
    End Sub

    'Easy option to autofill patient information in the payment panel
    Private Sub PaymentViewPatient_SelectionChanged(sender As Object, e As EventArgs) Handles PaymentViewPatient.SelectionChanged
        For Each ctrl As Control In pnlForm.Controls
            If TypeOf ctrl Is TextBox Then
                Dim textbox As TextBox = ctrl
                textbox.Clear()
            End If
        Next
        txtPaymentChange.Text = "0"
        txtPaymentRemaining.Text = "0"

        If PaymentViewPatient.SelectedCells.Count > 0 Then
            Dim selectedrowindex = PaymentViewPatient.SelectedCells(0).RowIndex

            txtPaymentIC.Text = PaymentViewPatient.Rows(selectedrowindex).Cells(0).Value
            txtPaymentName.Text = PaymentViewPatient.Rows(selectedrowindex).Cells(1).Value
        End If

    End Sub

    'Easy option to autofill treatmentdetails in the payment panel
    Private Sub PaymentViewTreatment_SelectionChanged(sender As Object, e As EventArgs) Handles PaymentViewTreatment.SelectionChanged
        If PaymentViewTreatment.SelectedCells.Count > 0 Then

            Dim selectedrowindex = PaymentViewTreatment.SelectedCells(0).RowIndex

            txtPaymentTreatment.Text = PaymentViewTreatment.Rows(selectedrowindex).Cells(0).Value
            txtPaymentTotal.Text = PaymentViewTreatment.Rows(selectedrowindex).Cells(3).Value
            txtOutstanding.Text = PaymentViewTreatment.Rows(selectedrowindex).Cells(4).Value
            Dim value As String = PaymentViewTreatment.Rows(selectedrowindex).Cells(2).Value.ToString
            Dim MyArray As String() = value.Split(",")
            MSList.Items.Clear()
            For Each item In MyArray
                MSList.Items.Add(item)
            Next

        End If
    End Sub

    Private Sub txtAmoutPaying_TextChanged(sender As Object, e As EventArgs) Handles txtAmoutPaying.TextChanged
        Dim outstanding = Val(txtOutstanding.Text)
        Dim paying = Val(txtAmoutPaying.Text)
        Dim NewBalance = outstanding - paying

        txtPaymentRemaining.Text = NewBalance
    End Sub

    Private Sub txtPaymentRemaining_TextChanged(sender As Object, e As EventArgs) Handles txtPaymentRemaining.TextChanged
        Dim remainnig = Val(txtPaymentRemaining.Text)
        Dim amountpaying = Val(txtAmoutPaying.Text)
        Dim outstanding = Val(txtOutstanding.Text)

        If remainnig < 0 Then
            txtPaymentRemaining.Text = 0

            txtPaymentChange.Text = amountpaying - outstanding
        End If
    End Sub










    '............................................................... SEARCH PANELS .................................................................
    ' search for patient treatment
    Private Sub txtPatientTreatmentSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPatientTreatmentSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            ViewPatientTreatment.DataSource = db.SearchViewPatientTreatment(txtPatientTreatmentSearch.Text)
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ViewPatientTreatment.DataSource = db.SearchViewPatientTreatment(txtPatientTreatmentSearch.Text)
    End Sub
    'search for update patient information
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        UpdateViewPatient.DataSource = db.SearchViewPatientInformation(txtUpSearch.Text)
    End Sub

    Private Sub txtUpSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUpSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            UpdateViewPatient.DataSource = db.SearchViewPatientInformation(txtUpSearch.Text)
        End If
    End Sub

    Private Sub AddAllergy_Click(sender As Object, e As EventArgs) Handles AddAllergy.Click
        ListBoxAllergy.Items.Add(txtAllergies.Text)
        txtAllergies.Clear()
    End Sub

    Private Sub AddAllergies2_Click(sender As Object, e As EventArgs) Handles AddAllergies2.Click
        ListBox2.Items.Add(txtUpAllergies.Text)
        txtUpAllergies.Clear()
    End Sub
    'search view payment
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        ViewPayment.DataSource = db.SearchPaymentRecordTable(txtViewPaymentSearch.Text)
    End Sub
    'search view payment
    Private Sub txtViewPaymentSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtViewPaymentSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            ViewPayment.DataSource = db.SearchPaymentRecordTable(txtViewPaymentSearch.Text)
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        DataGridView3.DataSource = db.SearchViewPatientInformation(TextBox1.Text)
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            DataGridView3.DataSource = db.SearchViewPatientInformation(TextBox1.Text)
        End If
    End Sub

    Private Sub Seach_Click(sender As Object, e As EventArgs) Handles Seach.Click
        PatientTable.DataSource = db.SearchPatientSidePart(txtSeach.Text)
    End Sub

    Private Sub txtSeach_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSeach.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            PatientTable.DataSource = db.SearchPatientSidePart(txtSeach.Text)
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        PaymentViewPatient.DataSource = db.SearchPatientSidePart(txtPaymentSearch.Text)
    End Sub

    Private Sub txtPaymentSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPaymentSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            PaymentViewPatient.DataSource = db.SearchPatientSidePart(txtPaymentSearch.Text)
        End If
    End Sub

End Class