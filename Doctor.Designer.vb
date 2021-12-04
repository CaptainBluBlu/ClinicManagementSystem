<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doctor
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Doctor))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.PanelSIde = New System.Windows.Forms.Panel()
        Me.pnlBlueSideBar = New System.Windows.Forms.Panel()
        Me.btnPatientTreatment = New System.Windows.Forms.Button()
        Me.btnTreatment = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnAddTreatment = New System.Windows.Forms.Button()
        Me.btnViewPatient = New System.Windows.Forms.Button()
        Me.PanelHeading = New System.Windows.Forms.Panel()
        Me.lblEmName = New System.Windows.Forms.Label()
        Me.lblFormTItle = New System.Windows.Forms.Label()
        Me.pnlAddTreatment = New System.Windows.Forms.Panel()
        Me.ViewMS = New System.Windows.Forms.DataGridView()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnAddMS = New System.Windows.Forms.Button()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.txtFee = New System.Windows.Forms.TextBox()
        Me.lblFee = New System.Windows.Forms.Label()
        Me.txtNew = New System.Windows.Forms.TextBox()
        Me.pnlTreatment = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PatientTable = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Seach = New System.Windows.Forms.PictureBox()
        Me.txtSeach = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.cboDoctorTreat = New System.Windows.Forms.ComboBox()
        Me.lblDoctor = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtIC = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.TreatmentTypeTable = New System.Windows.Forms.DataGridView()
        Me.Choose = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.lblTreatment = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblICTreatment = New System.Windows.Forms.Label()
        Me.pnlViewPatient = New System.Windows.Forms.Panel()
        Me.pnlViewPatientTable = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.pnlViewSearch = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlPatientTreatment = New System.Windows.Forms.Panel()
        Me.ViewPatientTreatment = New System.Windows.Forms.DataGridView()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.PanelSIde.SuspendLayout()
        Me.PanelHeading.SuspendLayout()
        Me.pnlAddTreatment.SuspendLayout()
        CType(Me.ViewMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.pnlTreatment.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PatientTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Seach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreatmentTypeTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlViewPatient.SuspendLayout()
        Me.pnlViewPatientTable.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlViewSearch.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPatientTreatment.SuspendLayout()
        CType(Me.ViewPatientTreatment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSearch.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpDate
        '
        Me.dtpDate.CalendarTrailingForeColor = System.Drawing.SystemColors.HotTrack
        Me.dtpDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(146, 134)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(197, 26)
        Me.dtpDate.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.dtpDate, "Today's Date")
        Me.dtpDate.Value = New Date(2020, 3, 25, 0, 0, 0, 0)
        '
        'PanelSIde
        '
        Me.PanelSIde.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.PanelSIde.Controls.Add(Me.pnlBlueSideBar)
        Me.PanelSIde.Controls.Add(Me.btnPatientTreatment)
        Me.PanelSIde.Controls.Add(Me.btnTreatment)
        Me.PanelSIde.Controls.Add(Me.btnLogOut)
        Me.PanelSIde.Controls.Add(Me.btnAddTreatment)
        Me.PanelSIde.Controls.Add(Me.btnViewPatient)
        Me.PanelSIde.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSIde.Location = New System.Drawing.Point(0, 97)
        Me.PanelSIde.Name = "PanelSIde"
        Me.PanelSIde.Size = New System.Drawing.Size(137, 536)
        Me.PanelSIde.TabIndex = 3
        '
        'pnlBlueSideBar
        '
        Me.pnlBlueSideBar.BackColor = System.Drawing.Color.SkyBlue
        Me.pnlBlueSideBar.Location = New System.Drawing.Point(1, 30)
        Me.pnlBlueSideBar.Name = "pnlBlueSideBar"
        Me.pnlBlueSideBar.Size = New System.Drawing.Size(10, 42)
        Me.pnlBlueSideBar.TabIndex = 8
        '
        'btnPatientTreatment
        '
        Me.btnPatientTreatment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnPatientTreatment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnPatientTreatment.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnPatientTreatment.Location = New System.Drawing.Point(0, 174)
        Me.btnPatientTreatment.Name = "btnPatientTreatment"
        Me.btnPatientTreatment.Size = New System.Drawing.Size(137, 42)
        Me.btnPatientTreatment.TabIndex = 9
        Me.btnPatientTreatment.Text = "Patient's Treatments"
        Me.btnPatientTreatment.UseVisualStyleBackColor = True
        '
        'btnTreatment
        '
        Me.btnTreatment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnTreatment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnTreatment.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnTreatment.Location = New System.Drawing.Point(0, 126)
        Me.btnTreatment.Name = "btnTreatment"
        Me.btnTreatment.Size = New System.Drawing.Size(137, 42)
        Me.btnTreatment.TabIndex = 6
        Me.btnTreatment.Text = "Treat Patient"
        Me.btnTreatment.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.Red
        Me.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Image = CType(resources.GetObject("btnLogOut.Image"), System.Drawing.Image)
        Me.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogOut.Location = New System.Drawing.Point(0, 496)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(137, 40)
        Me.btnLogOut.TabIndex = 4
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'btnAddTreatment
        '
        Me.btnAddTreatment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnAddTreatment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnAddTreatment.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAddTreatment.Location = New System.Drawing.Point(0, 78)
        Me.btnAddTreatment.Name = "btnAddTreatment"
        Me.btnAddTreatment.Size = New System.Drawing.Size(137, 42)
        Me.btnAddTreatment.TabIndex = 5
        Me.btnAddTreatment.Text = "Add Treatment"
        Me.btnAddTreatment.UseVisualStyleBackColor = True
        '
        'btnViewPatient
        '
        Me.btnViewPatient.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnViewPatient.Location = New System.Drawing.Point(0, 30)
        Me.btnViewPatient.Name = "btnViewPatient"
        Me.btnViewPatient.Size = New System.Drawing.Size(137, 42)
        Me.btnViewPatient.TabIndex = 3
        Me.btnViewPatient.Text = "View Patient"
        Me.btnViewPatient.UseVisualStyleBackColor = True
        '
        'PanelHeading
        '
        Me.PanelHeading.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelHeading.Controls.Add(Me.lblEmName)
        Me.PanelHeading.Controls.Add(Me.lblFormTItle)
        Me.PanelHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeading.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeading.Name = "PanelHeading"
        Me.PanelHeading.Size = New System.Drawing.Size(1125, 97)
        Me.PanelHeading.TabIndex = 2
        '
        'lblEmName
        '
        Me.lblEmName.AutoSize = True
        Me.lblEmName.Font = New System.Drawing.Font("Lucida Sans Typewriter", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEmName.Location = New System.Drawing.Point(3, 57)
        Me.lblEmName.Name = "lblEmName"
        Me.lblEmName.Size = New System.Drawing.Size(150, 37)
        Me.lblEmName.TabIndex = 15
        Me.lblEmName.Text = "EM Name"
        '
        'lblFormTItle
        '
        Me.lblFormTItle.AutoSize = True
        Me.lblFormTItle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblFormTItle.Font = New System.Drawing.Font("Gadugi", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTItle.ForeColor = System.Drawing.Color.White
        Me.lblFormTItle.Location = New System.Drawing.Point(0, 0)
        Me.lblFormTItle.Name = "lblFormTItle"
        Me.lblFormTItle.Size = New System.Drawing.Size(179, 57)
        Me.lblFormTItle.TabIndex = 14
        Me.lblFormTItle.Text = "Doctor"
        '
        'pnlAddTreatment
        '
        Me.pnlAddTreatment.BackColor = System.Drawing.SystemColors.Control
        Me.pnlAddTreatment.Controls.Add(Me.ViewMS)
        Me.pnlAddTreatment.Controls.Add(Me.Panel3)
        Me.pnlAddTreatment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAddTreatment.Location = New System.Drawing.Point(137, 97)
        Me.pnlAddTreatment.Name = "pnlAddTreatment"
        Me.pnlAddTreatment.Size = New System.Drawing.Size(988, 536)
        Me.pnlAddTreatment.TabIndex = 4
        Me.pnlAddTreatment.Visible = False
        '
        'ViewMS
        '
        Me.ViewMS.AllowUserToAddRows = False
        Me.ViewMS.AllowUserToDeleteRows = False
        Me.ViewMS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ViewMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewMS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Delete})
        Me.ViewMS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ViewMS.Location = New System.Drawing.Point(0, 273)
        Me.ViewMS.Name = "ViewMS"
        Me.ViewMS.ReadOnly = True
        Me.ViewMS.Size = New System.Drawing.Size(988, 263)
        Me.ViewMS.TabIndex = 6
        '
        'Delete
        '
        Me.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red
        Me.Delete.DefaultCellStyle = DataGridViewCellStyle1
        Me.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Delete.HeaderText = "Delete"
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        Me.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Delete.Text = "Delete"
        Me.Delete.ToolTipText = "Delete Current Row"
        Me.Delete.Width = 50
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Linen
        Me.Panel3.Controls.Add(Me.btnAddMS)
        Me.Panel3.Controls.Add(Me.lblNew)
        Me.Panel3.Controls.Add(Me.txtFee)
        Me.Panel3.Controls.Add(Me.lblFee)
        Me.Panel3.Controls.Add(Me.txtNew)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(988, 273)
        Me.Panel3.TabIndex = 5
        '
        'btnAddMS
        '
        Me.btnAddMS.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMS.Location = New System.Drawing.Point(704, 207)
        Me.btnAddMS.Name = "btnAddMS"
        Me.btnAddMS.Size = New System.Drawing.Size(105, 37)
        Me.btnAddMS.TabIndex = 3
        Me.btnAddMS.Text = "Add"
        Me.btnAddMS.UseVisualStyleBackColor = True
        '
        'lblNew
        '
        Me.lblNew.AutoSize = True
        Me.lblNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNew.Location = New System.Drawing.Point(90, 72)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(343, 25)
        Me.lblNew.TabIndex = 0
        Me.lblNew.Text = "New Medicine Or Services' Name :"
        '
        'txtFee
        '
        Me.txtFee.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFee.Location = New System.Drawing.Point(475, 141)
        Me.txtFee.Name = "txtFee"
        Me.txtFee.Size = New System.Drawing.Size(334, 35)
        Me.txtFee.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtFee, "Insert Price")
        '
        'lblFee
        '
        Me.lblFee.AutoSize = True
        Me.lblFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFee.Location = New System.Drawing.Point(92, 146)
        Me.lblFee.Name = "lblFee"
        Me.lblFee.Size = New System.Drawing.Size(341, 25)
        Me.lblFee.TabIndex = 1
        Me.lblFee.Text = "Price of New Medicine or Service :"
        '
        'txtNew
        '
        Me.txtNew.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNew.Location = New System.Drawing.Point(475, 67)
        Me.txtNew.Name = "txtNew"
        Me.txtNew.Size = New System.Drawing.Size(334, 35)
        Me.txtNew.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtNew, "Insert Name")
        '
        'pnlTreatment
        '
        Me.pnlTreatment.Controls.Add(Me.Panel1)
        Me.pnlTreatment.Controls.Add(Me.txtNote)
        Me.pnlTreatment.Controls.Add(Me.lblNote)
        Me.pnlTreatment.Controls.Add(Me.cboDoctorTreat)
        Me.pnlTreatment.Controls.Add(Me.lblDoctor)
        Me.pnlTreatment.Controls.Add(Me.dtpDate)
        Me.pnlTreatment.Controls.Add(Me.txtName)
        Me.pnlTreatment.Controls.Add(Me.txtIC)
        Me.pnlTreatment.Controls.Add(Me.btnConfirm)
        Me.pnlTreatment.Controls.Add(Me.TreatmentTypeTable)
        Me.pnlTreatment.Controls.Add(Me.lblTreatment)
        Me.pnlTreatment.Controls.Add(Me.lblDate)
        Me.pnlTreatment.Controls.Add(Me.lblName)
        Me.pnlTreatment.Controls.Add(Me.lblICTreatment)
        Me.pnlTreatment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTreatment.Location = New System.Drawing.Point(137, 97)
        Me.pnlTreatment.Name = "pnlTreatment"
        Me.pnlTreatment.Size = New System.Drawing.Size(988, 536)
        Me.pnlTreatment.TabIndex = 0
        Me.pnlTreatment.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PatientTable)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(626, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(362, 536)
        Me.Panel1.TabIndex = 0
        '
        'PatientTable
        '
        Me.PatientTable.AllowUserToAddRows = False
        Me.PatientTable.AllowUserToDeleteRows = False
        Me.PatientTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PatientTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.PatientTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PatientTable.Location = New System.Drawing.Point(0, 69)
        Me.PatientTable.Name = "PatientTable"
        Me.PatientTable.ReadOnly = True
        Me.PatientTable.RowHeadersVisible = False
        Me.PatientTable.Size = New System.Drawing.Size(362, 467)
        Me.PatientTable.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Seach)
        Me.Panel2.Controls.Add(Me.txtSeach)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(362, 69)
        Me.Panel2.TabIndex = 0
        '
        'Seach
        '
        Me.Seach.BackgroundImage = Global.Assingment.My.Resources.Resources.iconfinder_icon_111_search_314478
        Me.Seach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Seach.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Seach.InitialImage = Nothing
        Me.Seach.Location = New System.Drawing.Point(324, 26)
        Me.Seach.Name = "Seach"
        Me.Seach.Size = New System.Drawing.Size(25, 26)
        Me.Seach.TabIndex = 7
        Me.Seach.TabStop = False
        '
        'txtSeach
        '
        Me.txtSeach.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeach.Location = New System.Drawing.Point(109, 27)
        Me.txtSeach.Name = "txtSeach"
        Me.txtSeach.Size = New System.Drawing.Size(211, 22)
        Me.txtSeach.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Search :"
        '
        'txtNote
        '
        Me.txtNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNote.Location = New System.Drawing.Point(146, 247)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(391, 84)
        Me.txtNote.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.txtNote, "Insert Patient's Name")
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote.Location = New System.Drawing.Point(45, 245)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(69, 25)
        Me.lblNote.TabIndex = 13
        Me.lblNote.Text = "Note :"
        '
        'cboDoctorTreat
        '
        Me.cboDoctorTreat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDoctorTreat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDoctorTreat.FormattingEnabled = True
        Me.cboDoctorTreat.Location = New System.Drawing.Point(184, 191)
        Me.cboDoctorTreat.Name = "cboDoctorTreat"
        Me.cboDoctorTreat.Size = New System.Drawing.Size(251, 28)
        Me.cboDoctorTreat.TabIndex = 3
        '
        'lblDoctor
        '
        Me.lblDoctor.AutoSize = True
        Me.lblDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoctor.Location = New System.Drawing.Point(45, 190)
        Me.lblDoctor.Name = "lblDoctor"
        Me.lblDoctor.Size = New System.Drawing.Size(129, 25)
        Me.lblDoctor.TabIndex = 11
        Me.lblDoctor.Text = "Treated By :"
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(146, 78)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(253, 26)
        Me.txtName.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtName, "Insert Patient's Name")
        '
        'txtIC
        '
        Me.txtIC.Enabled = False
        Me.txtIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIC.Location = New System.Drawing.Point(182, 26)
        Me.txtIC.Name = "txtIC"
        Me.txtIC.Size = New System.Drawing.Size(253, 26)
        Me.txtIC.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtIC, "Insert Patient's IC")
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.LimeGreen
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(470, 496)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(118, 40)
        Me.btnConfirm.TabIndex = 6
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'TreatmentTypeTable
        '
        Me.TreatmentTypeTable.AllowUserToAddRows = False
        Me.TreatmentTypeTable.AllowUserToDeleteRows = False
        Me.TreatmentTypeTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TreatmentTypeTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.TreatmentTypeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TreatmentTypeTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Choose})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TreatmentTypeTable.DefaultCellStyle = DataGridViewCellStyle2
        Me.TreatmentTypeTable.Location = New System.Drawing.Point(208, 346)
        Me.TreatmentTypeTable.Name = "TreatmentTypeTable"
        Me.TreatmentTypeTable.ReadOnly = True
        Me.TreatmentTypeTable.RowHeadersVisible = False
        Me.TreatmentTypeTable.Size = New System.Drawing.Size(329, 136)
        Me.TreatmentTypeTable.TabIndex = 5
        '
        'Choose
        '
        Me.Choose.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Choose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Choose.HeaderText = "Select"
        Me.Choose.Name = "Choose"
        Me.Choose.ReadOnly = True
        Me.Choose.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Choose.Width = 50
        '
        'lblTreatment
        '
        Me.lblTreatment.AutoSize = True
        Me.lblTreatment.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTreatment.Location = New System.Drawing.Point(45, 346)
        Me.lblTreatment.Name = "lblTreatment"
        Me.lblTreatment.Size = New System.Drawing.Size(132, 25)
        Me.lblTreatment.TabIndex = 4
        Me.lblTreatment.Text = "Treatments :"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(45, 134)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(69, 25)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Date :"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(45, 78)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(80, 25)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name :"
        '
        'lblICTreatment
        '
        Me.lblICTreatment.AutoSize = True
        Me.lblICTreatment.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblICTreatment.Location = New System.Drawing.Point(45, 25)
        Me.lblICTreatment.Name = "lblICTreatment"
        Me.lblICTreatment.Size = New System.Drawing.Size(117, 25)
        Me.lblICTreatment.TabIndex = 1
        Me.lblICTreatment.Text = "Patient IC :"
        '
        'pnlViewPatient
        '
        Me.pnlViewPatient.Controls.Add(Me.pnlViewPatientTable)
        Me.pnlViewPatient.Controls.Add(Me.pnlViewSearch)
        Me.pnlViewPatient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlViewPatient.Location = New System.Drawing.Point(137, 97)
        Me.pnlViewPatient.Name = "pnlViewPatient"
        Me.pnlViewPatient.Size = New System.Drawing.Size(988, 536)
        Me.pnlViewPatient.TabIndex = 0
        '
        'pnlViewPatientTable
        '
        Me.pnlViewPatientTable.Controls.Add(Me.DataGridView1)
        Me.pnlViewPatientTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlViewPatientTable.Location = New System.Drawing.Point(0, 72)
        Me.pnlViewPatientTable.Name = "pnlViewPatientTable"
        Me.pnlViewPatientTable.Size = New System.Drawing.Size(988, 464)
        Me.pnlViewPatientTable.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(988, 464)
        Me.DataGridView1.TabIndex = 0
        '
        'pnlViewSearch
        '
        Me.pnlViewSearch.Controls.Add(Me.PictureBox1)
        Me.pnlViewSearch.Controls.Add(Me.lblSearch)
        Me.pnlViewSearch.Controls.Add(Me.TextBox1)
        Me.pnlViewSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlViewSearch.Location = New System.Drawing.Point(0, 0)
        Me.pnlViewSearch.Name = "pnlViewSearch"
        Me.pnlViewSearch.Size = New System.Drawing.Size(988, 72)
        Me.pnlViewSearch.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Assingment.My.Resources.Resources.iconfinder_icon_111_search_314478
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(472, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 26)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(31, 28)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(92, 25)
        Me.lblSearch.TabIndex = 1
        Me.lblSearch.Text = "Search :"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(129, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(337, 26)
        Me.TextBox1.TabIndex = 0
        '
        'pnlPatientTreatment
        '
        Me.pnlPatientTreatment.Controls.Add(Me.ViewPatientTreatment)
        Me.pnlPatientTreatment.Controls.Add(Me.pnlSearch)
        Me.pnlPatientTreatment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPatientTreatment.Location = New System.Drawing.Point(137, 97)
        Me.pnlPatientTreatment.Name = "pnlPatientTreatment"
        Me.pnlPatientTreatment.Size = New System.Drawing.Size(988, 536)
        Me.pnlPatientTreatment.TabIndex = 3
        Me.pnlPatientTreatment.Visible = False
        '
        'ViewPatientTreatment
        '
        Me.ViewPatientTreatment.AllowUserToAddRows = False
        Me.ViewPatientTreatment.AllowUserToDeleteRows = False
        Me.ViewPatientTreatment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ViewPatientTreatment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ViewPatientTreatment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ViewPatientTreatment.DefaultCellStyle = DataGridViewCellStyle4
        Me.ViewPatientTreatment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ViewPatientTreatment.Location = New System.Drawing.Point(0, 81)
        Me.ViewPatientTreatment.Name = "ViewPatientTreatment"
        Me.ViewPatientTreatment.ReadOnly = True
        Me.ViewPatientTreatment.RowHeadersVisible = False
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ViewPatientTreatment.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.ViewPatientTreatment.Size = New System.Drawing.Size(988, 455)
        Me.ViewPatientTreatment.TabIndex = 13
        '
        'pnlSearch
        '
        Me.pnlSearch.Controls.Add(Me.Label2)
        Me.pnlSearch.Controls.Add(Me.PictureBox2)
        Me.pnlSearch.Controls.Add(Me.TextBox3)
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearch.Location = New System.Drawing.Point(0, 0)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(988, 81)
        Me.pnlSearch.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Search :"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Assingment.My.Resources.Resources.iconfinder_icon_111_search_314478
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(512, 26)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 26)
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(169, 26)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(337, 26)
        Me.TextBox3.TabIndex = 9
        '
        'Doctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 633)
        Me.Controls.Add(Me.pnlTreatment)
        Me.Controls.Add(Me.pnlAddTreatment)
        Me.Controls.Add(Me.pnlPatientTreatment)
        Me.Controls.Add(Me.pnlViewPatient)
        Me.Controls.Add(Me.PanelSIde)
        Me.Controls.Add(Me.PanelHeading)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Doctor"
        Me.Text = "Doctor"
        Me.PanelSIde.ResumeLayout(False)
        Me.PanelHeading.ResumeLayout(False)
        Me.PanelHeading.PerformLayout()
        Me.pnlAddTreatment.ResumeLayout(False)
        CType(Me.ViewMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlTreatment.ResumeLayout(False)
        Me.pnlTreatment.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PatientTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Seach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreatmentTypeTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlViewPatient.ResumeLayout(False)
        Me.pnlViewPatientTable.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlViewSearch.ResumeLayout(False)
        Me.pnlViewSearch.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPatientTreatment.ResumeLayout(False)
        CType(Me.ViewPatientTreatment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSIde As Panel
    Friend WithEvents btnLogOut As Button
    Friend WithEvents PanelHeading As Panel
    Friend WithEvents btnAddTreatment As Button
    Friend WithEvents btnViewPatient As Button
    Friend WithEvents btnTreatment As Button
    Friend WithEvents pnlAddTreatment As Panel
    Friend WithEvents pnlTreatment As Panel
    Friend WithEvents pnlViewPatient As Panel
    Friend WithEvents pnlViewPatientTable As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents pnlViewSearch As Panel
    Friend WithEvents lblSearch As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents pnlBlueSideBar As Panel
    Friend WithEvents btnAddMS As Button
    Friend WithEvents txtFee As TextBox
    Friend WithEvents txtNew As TextBox
    Friend WithEvents lblFee As Label
    Friend WithEvents lblNew As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnConfirm As Button
    Friend WithEvents TreatmentTypeTable As DataGridView
    Friend WithEvents lblTreatment As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblICTreatment As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PatientTable As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtSeach As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Seach As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnPatientTreatment As Button
    Friend WithEvents pnlPatientTreatment As Panel
    Friend WithEvents ViewPatientTreatment As DataGridView
    Friend WithEvents pnlSearch As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ViewMS As DataGridView
    Friend WithEvents Delete As DataGridViewButtonColumn
    Friend WithEvents Choose As DataGridViewCheckBoxColumn
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtIC As TextBox
    Friend WithEvents cboDoctorTreat As ComboBox
    Friend WithEvents lblDoctor As Label
    Friend WithEvents txtNote As TextBox
    Friend WithEvents lblNote As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents lblFormTItle As Label
    Friend WithEvents lblEmName As Label
End Class
