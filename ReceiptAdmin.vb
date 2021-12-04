Public Class ReceiptAdmin
    Dim db As New Database
    Dim PaymentIDnurse = Administrator.PaymentID
    Dim datesting = Administrator.DateString

    Private Sub Recept_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PaymentID.Text = PaymentIDnurse
        IC.Text = Administrator.txtPaymentIC.Text
        PatientName.Text = Administrator.txtPaymentName.Text
        TreatmentID.Text = Administrator.txtPaymentTreatment.Text
        DatePH.Text = datesting
        Total.Text = "RM" & Administrator.txtPaymentTotal.Text
        Paid.Text = "RM" & Administrator.txtAmoutPaying.Text
        Outstanding.Text = "RM" & Administrator.txtPaymentRemaining.Text
        PaymentType.Text = Administrator.cboPaymentType.Text
        PaymentNote.Text = Administrator.txtPaymentNote.Text
        Payable.Text = "RM" & Administrator.txtOutstanding.Text
        Change.Text = "RM" & Administrator.txtPaymentChange.Text

        Dim i As Integer = 0

        'adding treatment names from the nurse form
        For Each item In Administrator.MSList.Items
            i += 1
            ListBoxTreatment.Items.Add(i & " . " & item)
            ListBoxPrice.Items.Add("RM" & db.ReceiptMSfee(item))
        Next


    End Sub


    Private Sub ListBoxClick(sender As Object, e As MouseEventArgs) Handles ListBoxTreatment.MouseClick, ListBoxPrice.MouseClick
        ListBoxTreatment.SelectedIndex = -1
        ListBoxPrice.SelectedIndex = -1
    End Sub

    Private Sub PanelTreatmentRecieved_Paint(sender As Object, e As PaintEventArgs) Handles PanelTreatmentRecieved.Paint

    End Sub
End Class