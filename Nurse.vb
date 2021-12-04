Public Class Nurse
    'connecting this class with database.class for functions and subs
    Dim db As New Database
    Dim emname = Login.EmployeeName

    'Side menu Coding to show Different Panels
    Private Sub btnViewPatient_Click(sender As Object, e As EventArgs) Handles btnViewPatient.Click
        PanelVisibilty(3)
        pnlBlueSideBar.Location = New Point(1, 27)

        DataGridView2.DataSource = db.ViewPatientTable
    End Sub

    Private Sub btnAddPatient_Click(sender As Object, e As EventArgs) Handles btnAddPatient.Click
        PanelVisibilty(1)
        pnlBlueSideBar.Location = New Point(1, 75)

        AddPatientTable.DataSource = db.ViewPatientTable
        cboPrimaryDoctor.DataSource = db.DoctorComboBox

    End Sub

    Private Sub btnUpdatePatient_Click(sender As Object, e As EventArgs) Handles btnUpdatePatient.Click
        PanelVisibilty(4)

        UpdateViewPatient.DataSource = db.ViewPatientTable
        cboPrimaryDoctorUp.DataSource = db.DoctorComboBox

        pnlBlueSideBar.Location = New Point(1, 123)
    End Sub

    Private Sub btnBillPatient_Click(sender As Object, e As EventArgs) Handles btnBillPatient.Click
        PanelVisibilty(2)
        pnlBlueSideBar.Location = New Point(1, 171)
        PaymentDate.Value = Date.Now
        PaymentViewPatient.DataSource = db.PatientName
        txtPaymentChange.Text = "0"
        cboPaymentType.DataSource = db.PaymentComboBox
        cboPaymentType.ValueMember = "PtID"
        cboPaymentType.DisplayMember = "Type"

    End Sub
    Private Sub btnViewPayment_Click(sender As Object, e As EventArgs) Handles btnViewPayment.Click
        PanelVisibilty(5)
        pnlBlueSideBar.Location = New Point(1, 219)

        ViewPayment.DataSource = db.PaymentRecordTable
    End Sub

    Private Sub btnPatientTreatment_Click(sender As Object, e As EventArgs) Handles btnPatientTreatment.Click
        PanelVisibilty(6)
        ViewPatientTreatment.DataSource = db.PatientTreaments
        pnlBlueSideBar.Location = New Point(1, 267)
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Log out? You will need to Log In again. ", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

        If result = DialogResult.OK Then
            Login.Show()
            Me.Close()
        End If
    End Sub

    'reduce redandant coding with sub that changes panel visibility
    Private Sub PanelVisibilty(Panel As Integer)
        pnlAddPatient.Visible = False
        pnlBillPatient.Visible = False
        pnlViewPatient.Visible = False
        pnlViewPayment.Visible = False
        pnlUpdatePatient.Visible = False
        pnlPatientTreatment.Visible = False

        Select Case Panel
            Case 1
                pnlAddPatient.Visible = True
            Case 2
                pnlBillPatient.Visible = True
            Case 3
                pnlViewPatient.Visible = True
            Case 4
                pnlUpdatePatient.Visible = True
            Case 5
                pnlViewPayment.Visible = True
            Case 6
                pnlPatientTreatment.Visible = True
        End Select

    End Sub
    '....................................................END CODING FOR PANELS...............................................



    Private Sub Nurse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loading in the data from PatientInformation table in database
        DataGridView2.DataSource = db.ViewPatientTable
        lblEmName.Text = emname
    End Sub

    Private Sub AddAllergy_Click(sender As Object, e As EventArgs) Handles AddAllergy.Click
        ListBoxAllergy.Items.Add(txtAllergies.Text)
        txtAllergies.Clear()
    End Sub

    Private Sub AddAllergies2_Click(sender As Object, e As EventArgs) Handles AddAllergies2.Click
        ListBox2.Items.Add(txtUpAllergies.Text)
        txtUpAllergies.Clear()
    End Sub

    'adding new patient information
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
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


    'double click to remove allgery that are wrongly inputted........................................................
    Private Sub ListBoxAllergy_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBoxAllergy.MouseDoubleClick
        ListBoxAllergy.Items.Remove(ListBoxAllergy.SelectedItem)
    End Sub

    Private Sub ListBox2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox2.MouseDoubleClick
        ListBox2.Items.Remove(ListBox2.SelectedItem)
    End Sub
    'check if there is things in the textbox before input................................................
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

    'delete option to remove row of data in the patient information
    Private Sub UpdateViewPatient_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UpdateViewPatient.CellContentClick

        If e.ColumnIndex = 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete information of " & UpdateViewPatient.Rows(e.RowIndex).Cells(2).Value & "?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

            If result = DialogResult.OK Then
                Dim selected As String
                selected = UpdateViewPatient.Rows(e.RowIndex).Cells(1).Value

                db.DeletePatientInformation(selected)
                UpdateViewPatient.DataSource = db.ViewPatientTable()
            End If

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


    '...........................................................PAYMENT PANEL............................................................................
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
            Recept.Show()
            PaymentViewTreatment.DataSource = db.PatientOutstanding(txtPaymentIC.Text)
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


    '................................................................. SEARCH PANELS ....................................................................

    'search bar For viewing the patients' treatment
    Private Sub picturebox2_click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ViewPatientTreatment.DataSource = db.SearchViewPatientTreatment(txtViewTreatmentSearch.Text)

        If PaymentViewPatient.SelectedCells.Count > 0 Then


            Dim selectedrowindex = PaymentViewPatient.SelectedCells(0).RowIndex

            txtPaymentIC.Text = PaymentViewPatient.Rows(selectedrowindex).Cells(0).Value
            txtPaymentName.Text = PaymentViewPatient.Rows(selectedrowindex).Cells(1).Value

        End If
    End Sub

    Private Sub txtviewtreatmentsearch_keydown(sender As Object, e As KeyEventArgs) Handles txtViewTreatmentSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            ViewPatientTreatment.DataSource = db.SearchViewPatientTreatment(txtViewTreatmentSearch.Text)
        End If
    End Sub
    '..............................................................................................................................................

    'search bar for update patient 
    Private Sub picturebox1_click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        UpdateViewPatient.DataSource = db.SearchViewPatientInformation(txtUpSearch.Text)
    End Sub

    Private Sub txtupsearch_keydown(sender As Object, e As KeyEventArgs) Handles txtUpSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            UpdateViewPatient.DataSource = db.SearchViewPatientInformation(txtUpSearch.Text)
        End If
    End Sub

    Private Sub txtViewPatientSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtViewPatientSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            DataGridView2.DataSource = db.SearchViewPatientInformation(txtViewPatientSearch.Text)
        End If

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        DataGridView2.DataSource = db.SearchViewPatientInformation(txtViewPatientSearch.Text)
    End Sub

    'search for payment record
    Private Sub txtViewPaymentSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtViewPaymentSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            ViewPayment.DataSource = db.SearchPaymentRecordTable(txtViewPaymentSearch.Text)
        End If
    End Sub
    'search for payment record
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        ViewPayment.DataSource = db.SearchPaymentRecordTable(txtViewPaymentSearch.Text)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PaymentViewPatient.DataSource = db.SearchPatientSidePart(txtPaymentSearch.Text)
    End Sub

    Private Sub txtPaymentSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPaymentSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            PaymentViewPatient.DataSource = db.SearchPatientSidePart(txtPaymentSearch.Text)
        End If
    End Sub

End Class