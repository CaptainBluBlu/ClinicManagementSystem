<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceiptAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReceiptAdmin))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lblReceipt = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.PanelBasicInfo = New System.Windows.Forms.Panel()
        Me.DatePH = New System.Windows.Forms.Label()
        Me.TreatmentID = New System.Windows.Forms.Label()
        Me.PaymentNote = New System.Windows.Forms.Label()
        Me.PatientName = New System.Windows.Forms.Label()
        Me.PaymentType = New System.Windows.Forms.Label()
        Me.IC = New System.Windows.Forms.Label()
        Me.lblPaymentNote = New System.Windows.Forms.Label()
        Me.PaymentID = New System.Windows.Forms.Label()
        Me.lblPaymentType = New System.Windows.Forms.Label()
        Me.PanelTreatmentRecieved = New System.Windows.Forms.Panel()
        Me.Payable = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Outstanding = New System.Windows.Forms.Label()
        Me.Paid = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.Label()
        Me.lblPayable = New System.Windows.Forms.Label()
        Me.lblPaid = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListBoxPrice = New System.Windows.Forms.ListBox()
        Me.lblTreatments = New System.Windows.Forms.Label()
        Me.ListBoxTreatment = New System.Windows.Forms.ListBox()
        Me.lblTreatmentID = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblPaymentID = New System.Windows.Forms.Label()
        Me.lblIC = New System.Windows.Forms.Label()
        Me.Change = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.PanelBasicInfo.SuspendLayout()
        Me.PanelTreatmentRecieved.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblReceipt
        '
        Me.lblReceipt.AutoSize = True
        Me.lblReceipt.Font = New System.Drawing.Font("Courier New", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceipt.Location = New System.Drawing.Point(194, 9)
        Me.lblReceipt.Name = "lblReceipt"
        Me.lblReceipt.Size = New System.Drawing.Size(225, 50)
        Me.lblReceipt.TabIndex = 0
        Me.lblReceipt.Text = "RECEIPT"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(17, 86)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(101, 18)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Patient Name:"
        '
        'PanelBasicInfo
        '
        Me.PanelBasicInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelBasicInfo.Controls.Add(Me.DatePH)
        Me.PanelBasicInfo.Controls.Add(Me.TreatmentID)
        Me.PanelBasicInfo.Controls.Add(Me.PaymentNote)
        Me.PanelBasicInfo.Controls.Add(Me.PatientName)
        Me.PanelBasicInfo.Controls.Add(Me.PaymentType)
        Me.PanelBasicInfo.Controls.Add(Me.IC)
        Me.PanelBasicInfo.Controls.Add(Me.lblPaymentNote)
        Me.PanelBasicInfo.Controls.Add(Me.PaymentID)
        Me.PanelBasicInfo.Controls.Add(Me.lblPaymentType)
        Me.PanelBasicInfo.Controls.Add(Me.PanelTreatmentRecieved)
        Me.PanelBasicInfo.Controls.Add(Me.lblTreatmentID)
        Me.PanelBasicInfo.Controls.Add(Me.lblDate)
        Me.PanelBasicInfo.Controls.Add(Me.lblPaymentID)
        Me.PanelBasicInfo.Controls.Add(Me.lblIC)
        Me.PanelBasicInfo.Controls.Add(Me.lblName)
        Me.PanelBasicInfo.Location = New System.Drawing.Point(12, 62)
        Me.PanelBasicInfo.Name = "PanelBasicInfo"
        Me.PanelBasicInfo.Size = New System.Drawing.Size(607, 548)
        Me.PanelBasicInfo.TabIndex = 2
        '
        'DatePH
        '
        Me.DatePH.AutoSize = True
        Me.DatePH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePH.Location = New System.Drawing.Point(465, 51)
        Me.DatePH.Name = "DatePH"
        Me.DatePH.Size = New System.Drawing.Size(84, 16)
        Me.DatePH.TabIndex = 11
        Me.DatePH.Text = "PlaceHolder"
        '
        'TreatmentID
        '
        Me.TreatmentID.AutoSize = True
        Me.TreatmentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreatmentID.Location = New System.Drawing.Point(518, 16)
        Me.TreatmentID.Name = "TreatmentID"
        Me.TreatmentID.Size = New System.Drawing.Size(84, 16)
        Me.TreatmentID.TabIndex = 10
        Me.TreatmentID.Text = "PlaceHolder"
        '
        'PaymentNote
        '
        Me.PaymentNote.AutoSize = True
        Me.PaymentNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentNote.Location = New System.Drawing.Point(129, 148)
        Me.PaymentNote.Name = "PaymentNote"
        Me.PaymentNote.Size = New System.Drawing.Size(84, 16)
        Me.PaymentNote.TabIndex = 16
        Me.PaymentNote.Text = "PlaceHolder"
        '
        'PatientName
        '
        Me.PatientName.AutoSize = True
        Me.PatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientName.Location = New System.Drawing.Point(122, 88)
        Me.PatientName.Name = "PatientName"
        Me.PatientName.Size = New System.Drawing.Size(84, 16)
        Me.PatientName.TabIndex = 9
        Me.PatientName.Text = "PlaceHolder"
        '
        'PaymentType
        '
        Me.PaymentType.AutoSize = True
        Me.PaymentType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentType.Location = New System.Drawing.Point(129, 119)
        Me.PaymentType.Name = "PaymentType"
        Me.PaymentType.Size = New System.Drawing.Size(84, 16)
        Me.PaymentType.TabIndex = 12
        Me.PaymentType.Text = "PlaceHolder"
        '
        'IC
        '
        Me.IC.AutoSize = True
        Me.IC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IC.Location = New System.Drawing.Point(73, 51)
        Me.IC.Name = "IC"
        Me.IC.Size = New System.Drawing.Size(84, 16)
        Me.IC.TabIndex = 8
        Me.IC.Text = "PlaceHolder"
        '
        'lblPaymentNote
        '
        Me.lblPaymentNote.AutoSize = True
        Me.lblPaymentNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentNote.Location = New System.Drawing.Point(17, 146)
        Me.lblPaymentNote.Name = "lblPaymentNote"
        Me.lblPaymentNote.Size = New System.Drawing.Size(106, 18)
        Me.lblPaymentNote.TabIndex = 15
        Me.lblPaymentNote.Text = "Payment Note:"
        '
        'PaymentID
        '
        Me.PaymentID.AutoSize = True
        Me.PaymentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentID.Location = New System.Drawing.Point(189, 16)
        Me.PaymentID.Name = "PaymentID"
        Me.PaymentID.Size = New System.Drawing.Size(151, 16)
        Me.PaymentID.TabIndex = 7
        Me.PaymentID.Text = "Payment Reference No:"
        '
        'lblPaymentType
        '
        Me.lblPaymentType.AutoSize = True
        Me.lblPaymentType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentType.Location = New System.Drawing.Point(17, 117)
        Me.lblPaymentType.Name = "lblPaymentType"
        Me.lblPaymentType.Size = New System.Drawing.Size(106, 18)
        Me.lblPaymentType.TabIndex = 12
        Me.lblPaymentType.Text = "Payment Type:"
        '
        'PanelTreatmentRecieved
        '
        Me.PanelTreatmentRecieved.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTreatmentRecieved.Controls.Add(Me.Change)
        Me.PanelTreatmentRecieved.Controls.Add(Me.lblChange)
        Me.PanelTreatmentRecieved.Controls.Add(Me.Payable)
        Me.PanelTreatmentRecieved.Controls.Add(Me.Label1)
        Me.PanelTreatmentRecieved.Controls.Add(Me.Outstanding)
        Me.PanelTreatmentRecieved.Controls.Add(Me.Paid)
        Me.PanelTreatmentRecieved.Controls.Add(Me.Total)
        Me.PanelTreatmentRecieved.Controls.Add(Me.lblPayable)
        Me.PanelTreatmentRecieved.Controls.Add(Me.lblPaid)
        Me.PanelTreatmentRecieved.Controls.Add(Me.Label6)
        Me.PanelTreatmentRecieved.Controls.Add(Me.ListBoxPrice)
        Me.PanelTreatmentRecieved.Controls.Add(Me.lblTreatments)
        Me.PanelTreatmentRecieved.Controls.Add(Me.ListBoxTreatment)
        Me.PanelTreatmentRecieved.Location = New System.Drawing.Point(-1, 189)
        Me.PanelTreatmentRecieved.Name = "PanelTreatmentRecieved"
        Me.PanelTreatmentRecieved.Size = New System.Drawing.Size(607, 358)
        Me.PanelTreatmentRecieved.TabIndex = 6
        '
        'Payable
        '
        Me.Payable.AutoSize = True
        Me.Payable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Payable.Location = New System.Drawing.Point(498, 243)
        Me.Payable.Name = "Payable"
        Me.Payable.Size = New System.Drawing.Size(84, 16)
        Me.Payable.TabIndex = 18
        Me.Payable.Text = "PlaceHolder"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 317)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Outstanding :"
        '
        'Outstanding
        '
        Me.Outstanding.AutoSize = True
        Me.Outstanding.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Outstanding.Location = New System.Drawing.Point(122, 320)
        Me.Outstanding.Name = "Outstanding"
        Me.Outstanding.Size = New System.Drawing.Size(84, 16)
        Me.Outstanding.TabIndex = 14
        Me.Outstanding.Text = "PlaceHolder"
        '
        'Paid
        '
        Me.Paid.AutoSize = True
        Me.Paid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Paid.Location = New System.Drawing.Point(498, 277)
        Me.Paid.Name = "Paid"
        Me.Paid.Size = New System.Drawing.Size(84, 16)
        Me.Paid.TabIndex = 13
        Me.Paid.Text = "PlaceHolder"
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.Location = New System.Drawing.Point(498, 215)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(84, 16)
        Me.Total.TabIndex = 12
        Me.Total.Text = "PlaceHolder"
        '
        'lblPayable
        '
        Me.lblPayable.AutoSize = True
        Me.lblPayable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayable.Location = New System.Drawing.Point(427, 240)
        Me.lblPayable.Name = "lblPayable"
        Me.lblPayable.Size = New System.Drawing.Size(73, 20)
        Me.lblPayable.TabIndex = 11
        Me.lblPayable.Text = "Payable :"
        '
        'lblPaid
        '
        Me.lblPaid.AutoSize = True
        Me.lblPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaid.Location = New System.Drawing.Point(452, 273)
        Me.lblPaid.Name = "lblPaid"
        Me.lblPaid.Size = New System.Drawing.Size(48, 20)
        Me.lblPaid.TabIndex = 10
        Me.lblPaid.Text = "Paid :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(448, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Total :"
        '
        'ListBoxPrice
        '
        Me.ListBoxPrice.BackColor = System.Drawing.SystemColors.Control
        Me.ListBoxPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxPrice.FormattingEnabled = True
        Me.ListBoxPrice.ItemHeight = 16
        Me.ListBoxPrice.Location = New System.Drawing.Point(452, 44)
        Me.ListBoxPrice.Name = "ListBoxPrice"
        Me.ListBoxPrice.Size = New System.Drawing.Size(128, 164)
        Me.ListBoxPrice.TabIndex = 8
        '
        'lblTreatments
        '
        Me.lblTreatments.AutoSize = True
        Me.lblTreatments.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTreatments.Location = New System.Drawing.Point(15, 16)
        Me.lblTreatments.Name = "lblTreatments"
        Me.lblTreatments.Size = New System.Drawing.Size(130, 25)
        Me.lblTreatments.TabIndex = 7
        Me.lblTreatments.Text = "Treatments"
        '
        'ListBoxTreatment
        '
        Me.ListBoxTreatment.BackColor = System.Drawing.SystemColors.Control
        Me.ListBoxTreatment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxTreatment.FormattingEnabled = True
        Me.ListBoxTreatment.ItemHeight = 16
        Me.ListBoxTreatment.Location = New System.Drawing.Point(20, 44)
        Me.ListBoxTreatment.Name = "ListBoxTreatment"
        Me.ListBoxTreatment.Size = New System.Drawing.Size(426, 164)
        Me.ListBoxTreatment.TabIndex = 0
        '
        'lblTreatmentID
        '
        Me.lblTreatmentID.AutoSize = True
        Me.lblTreatmentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTreatmentID.Location = New System.Drawing.Point(416, 14)
        Me.lblTreatmentID.Name = "lblTreatmentID"
        Me.lblTreatmentID.Size = New System.Drawing.Size(97, 18)
        Me.lblTreatmentID.TabIndex = 5
        Me.lblTreatmentID.Text = "Treatment ID:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(416, 49)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(43, 18)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "Date:"
        '
        'lblPaymentID
        '
        Me.lblPaymentID.AutoSize = True
        Me.lblPaymentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentID.Location = New System.Drawing.Point(17, 14)
        Me.lblPaymentID.Name = "lblPaymentID"
        Me.lblPaymentID.Size = New System.Drawing.Size(166, 18)
        Me.lblPaymentID.TabIndex = 3
        Me.lblPaymentID.Text = "Payment Reference No:"
        '
        'lblIC
        '
        Me.lblIC.AutoSize = True
        Me.lblIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIC.Location = New System.Drawing.Point(17, 49)
        Me.lblIC.Name = "lblIC"
        Me.lblIC.Size = New System.Drawing.Size(50, 18)
        Me.lblIC.TabIndex = 2
        Me.lblIC.Text = "IC No:"
        '
        'Change
        '
        Me.Change.AutoSize = True
        Me.Change.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Change.Location = New System.Drawing.Point(498, 305)
        Me.Change.Name = "Change"
        Me.Change.Size = New System.Drawing.Size(84, 16)
        Me.Change.TabIndex = 20
        Me.Change.Text = "PlaceHolder"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(427, 301)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(73, 20)
        Me.lblChange.TabIndex = 19
        Me.lblChange.Text = "Change :"
        '
        'ReceiptAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 622)
        Me.Controls.Add(Me.PanelBasicInfo)
        Me.Controls.Add(Me.lblReceipt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReceiptAdmin"
        Me.Text = "Recept"
        Me.PanelBasicInfo.ResumeLayout(False)
        Me.PanelBasicInfo.PerformLayout()
        Me.PanelTreatmentRecieved.ResumeLayout(False)
        Me.PanelTreatmentRecieved.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblReceipt As Label
    Friend WithEvents lblName As Label
    Friend WithEvents PanelBasicInfo As Panel
    Friend WithEvents PanelTreatmentRecieved As Panel
    Friend WithEvents lblTreatmentID As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblPaymentID As Label
    Friend WithEvents lblIC As Label
    Friend WithEvents lblTreatments As Label
    Friend WithEvents ListBoxTreatment As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPayable As Label
    Friend WithEvents lblPaid As Label
    Friend WithEvents DatePH As Label
    Friend WithEvents TreatmentID As Label
    Friend WithEvents PatientName As Label
    Friend WithEvents IC As Label
    Friend WithEvents PaymentID As Label
    Friend WithEvents PaymentNote As Label
    Friend WithEvents PaymentType As Label
    Friend WithEvents lblPaymentNote As Label
    Friend WithEvents lblPaymentType As Label
    Friend WithEvents Outstanding As Label
    Friend WithEvents Paid As Label
    Friend WithEvents Total As Label
    Friend WithEvents Payable As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBoxPrice As ListBox
    Friend WithEvents Change As Label
    Friend WithEvents lblChange As Label
End Class
