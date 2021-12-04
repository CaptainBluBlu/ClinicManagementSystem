Public Class Recept
    Dim db As New Database


    Dim PaymentIDnurse = Nurse.PaymentID
    Dim datesting = Nurse.DateString


    Private Sub Recept_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        PaymentID.Text = PaymentIDnurse
        IC.Text = Nurse.txtPaymentIC.Text
        PatientName.Text = Nurse.txtPaymentName.Text
        TreatmentID.Text = Nurse.txtPaymentTreatment.Text
        DatePH.Text = datesting
        Total.Text = "RM" & Nurse.txtPaymentTotal.Text
        Paid.Text = "RM" & Nurse.txtAmoutPaying.Text
        Outstanding.Text = "RM" & Nurse.txtPaymentRemaining.Text
        PaymentType.Text = Nurse.cboPaymentType.Text
        PaymentNote.Text = Nurse.txtPaymentNote.Text
        Payable.Text = "RM" & Nurse.txtOutstanding.Text
        Change.Text = "RM" & Nurse.txtPaymentChange.Text

        Dim i As Integer = 0


        'adding treatment names from the nurse form
        For Each item In Nurse.MSList.Items

            i += 1
            ListBoxTreatment.Items.Add(i & " . " & item)

            ListBoxPrice.Items.Add("RM" & db.ReceiptMSfee(item))
        Next
    End Sub


    Private Sub ListBoxClick(sender As Object, e As MouseEventArgs) Handles ListBoxTreatment.MouseClick, ListBoxPrice.MouseClick
        ListBoxTreatment.SelectedIndex = -1
        ListBoxPrice.SelectedIndex = -1
    End Sub
End Class