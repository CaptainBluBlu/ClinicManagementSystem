Public Class Doctor
    Dim db As New Database
    Dim emname = Login.EmployeeName

    Private Sub btnViewPatient_Click(sender As Object, e As EventArgs) Handles btnViewPatient.Click
        PanelVisibility(1)

        pnlBlueSideBar.Location = New Point(1, 30)
    End Sub

    Private Sub btnAddTreatment_Click(sender As Object, e As EventArgs) Handles btnAddTreatment.Click
        PanelVisibility(2)
        ViewMS.DataSource = db.MS
        pnlBlueSideBar.Location = New Point(1, 78)
    End Sub

    Private Sub btnTreatment_Click(sender As Object, e As EventArgs) Handles btnTreatment.Click
        PanelVisibility(3)
        pnlBlueSideBar.Location = New Point(1, 126)
        cboDoctorTreat.DataSource = db.DoctorComboBox
        TreatmentTypeTable.DataSource = db.MS
        PatientTable.DataSource = db.PatientName
        TreatmentTypeTable.Columns(1).Visible = False
        dtpDate.Value = Date.Now


    End Sub
    Private Sub btnPatientTreatment_Click(sender As Object, e As EventArgs) Handles btnPatientTreatment.Click
        PanelVisibility(4)
        pnlBlueSideBar.Location = New Point(1, 174)
        ViewPatientTreatment.DataSource = db.PatientTreaments
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Log out? You will need to Log In again. ", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

        If result = DialogResult.OK Then
            Login.Show()
            Me.Close()
        End If

    End Sub

    Private Sub PanelVisibility(Panel As Integer)
        pnlViewPatient.Visible = False
        pnlAddTreatment.Visible = False
        pnlTreatment.Visible = False
        pnlPatientTreatment.Visible = False

        Select Case Panel
            Case 1
                pnlViewPatient.Visible = True
            Case 2
                pnlAddTreatment.Visible = True
            Case 3
                pnlTreatment.Visible = True
            Case 4
                pnlPatientTreatment.Visible = True
        End Select
    End Sub

    Private Sub Doctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = db.ViewPatientTable()
        lblEmName.Text = emname
    End Sub


    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAddMS_Click(sender As Object, e As EventArgs) Handles btnAddMS.Click
        If String.IsNullOrWhiteSpace(txtFee.Text) Or String.IsNullOrWhiteSpace(txtNew.Text) Then
            MessageBox.Show("Please fill in all the required fields.", "Empty Fields")
            Return
        ElseIf IsNumeric(txtFee.Text) Then
            If db.CheckTreatmentExist(txtNew.Text) Then
                MsgBox("The same treatment type already exist!")
            Else
            End If
            db.NewTreatment(txtNew.Text, txtFee.Text)
            ViewMS.DataSource = db.MS
        Else
            MessageBox.Show("Please enter numeric data for Price.", "Error Data Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If




    End Sub

    Private Sub ViewMS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ViewMS.CellContentClick
        If e.ColumnIndex = 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete medical or service type?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

            If result = DialogResult.OK Then
                Dim selected As String
                selected = ViewMS.Rows(e.RowIndex).Cells(1).Value

                db.DeleteMS(selected)

            End If
            ViewMS.DataSource = db.MS()
        End If
    End Sub

    'allow user to check the check box 
    Private Sub TreatmentTypeTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TreatmentTypeTable.CellContentClick
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then

                Dim checkCell As DataGridViewCheckBoxCell = CType(TreatmentTypeTable.Rows(e.RowIndex).Cells(0), DataGridViewCheckBoxCell)

                checkCell.Value = Not checkCell.Value
            End If
        End If

    End Sub

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

        If String.IsNullOrWhiteSpace(txtIC.Text) Or String.IsNullOrWhiteSpace(txtName.Text) Or String.IsNullOrWhiteSpace(cboDoctorTreat.Text) Or String.IsNullOrWhiteSpace(dtpDate.Value) Or checked Is Nothing Then
            MessageBox.Show("Please fill in all the required fields.", "Empty Fields")
            Return
        Else
            db.AddPatientTreatment(TreatmentID, txtIC.Text, datestring, cboDoctorTreat.Text, txtNote.Text, checked)
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

    'Easy option to autofill patient information in the treatment panel
    Private Sub PatientTable_SelectionChanged(sender As Object, e As EventArgs) Handles PatientTable.SelectionChanged
        If PatientTable.SelectedCells.Count > 0 Then


            Dim selectedrowindex = PatientTable.SelectedCells(0).RowIndex

            txtIC.Text = PatientTable.Rows(selectedrowindex).Cells(0).Value
            txtName.Text = PatientTable.Rows(selectedrowindex).Cells(1).Value

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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        DataGridView1.DataSource = db.SearchViewPatientInformation(TextBox1.Text)

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            DataGridView1.DataSource = db.SearchViewPatientInformation(TextBox1.Text)
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ViewPatientTreatment.DataSource = db.SearchViewPatientTreatment(TextBox3.Text)
    End Sub

    Private Sub TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            ViewPatientTreatment.DataSource = db.SearchViewPatientTreatment(TextBox3.Text)
        End If
    End Sub
End Class