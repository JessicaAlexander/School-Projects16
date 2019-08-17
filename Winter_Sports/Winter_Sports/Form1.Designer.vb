<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim DescriptionLabel As System.Windows.Forms.Label
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txbDescript = New System.Windows.Forms.TextBox()
        Me.EquipmentBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Winter_Sports_RentalsDataSet = New Winter_Sports.Winter_Sports_RentalsDataSet()
        Me.btnSearchCustomer = New System.Windows.Forms.Button()
        Me.btnCompleteRental = New System.Windows.Forms.Button()
        Me.LBLEquipID = New System.Windows.Forms.Label()
        Me.lblRentalFeeDue1 = New System.Windows.Forms.Label()
        Me.lblRentalFeeDue = New System.Windows.Forms.Label()
        Me.BtnNewCust = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDueDate1 = New System.Windows.Forms.Label()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.TBDeposit1 = New System.Windows.Forms.TextBox()
        Me.chkList_Equipment = New System.Windows.Forms.CheckedListBox()
        Me.lblEquipment = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.lblDueBack1 = New System.Windows.Forms.Label()
        Me.lblDueBack = New System.Windows.Forms.Label()
        Me.lblTotalDue1 = New System.Windows.Forms.Label()
        Me.lblTax1 = New System.Windows.Forms.Label()
        Me.lblInsurance1 = New System.Windows.Forms.Label()
        Me.lblTotalRentalFee1 = New System.Windows.Forms.Label()
        Me.CBLiabilityWaiver = New System.Windows.Forms.CheckBox()
        Me.CBDamageIns = New System.Windows.Forms.CheckBox()
        Me.lblSubTotalDue = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblDeposit = New System.Windows.Forms.Label()
        Me.lblInsurance = New System.Windows.Forms.Label()
        Me.lblTotalRentalFee = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.CBDuration = New System.Windows.Forms.ComboBox()
        Me.llbWeather = New System.Windows.Forms.LinkLabel()
        Me.dtpCalender = New System.Windows.Forms.DateTimePicker()
        Me.EquipmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New Winter_Sports.Winter_Sports_RentalsDataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager = New Winter_Sports.Winter_Sports_RentalsDataSetTableAdapters.TableAdapterManager()
        Me.EquipmentTableAdapter = New Winter_Sports.Winter_Sports_RentalsDataSetTableAdapters.EquipmentTableAdapter()
        Me.InventoryTableAdapter = New Winter_Sports.Winter_Sports_RentalsDataSetTableAdapters.InventoryTableAdapter()
        Me.InvoicesTableAdapter = New Winter_Sports.Winter_Sports_RentalsDataSetTableAdapters.InvoicesTableAdapter()
        Me.Rental_ItemsTableAdapter = New Winter_Sports.Winter_Sports_RentalsDataSetTableAdapters.Rental_ItemsTableAdapter()
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rental_ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Equipment1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Equipment1TableAdapter = New Winter_Sports.Winter_Sports_RentalsDataSetTableAdapters.Equipment1TableAdapter()
        Me.EquipmentBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EquipmentBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        DescriptionLabel = New System.Windows.Forms.Label()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipmentBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Winter_Sports_RentalsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rental_ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Equipment1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipmentBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipmentBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(1264, 268)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(83, 17)
        DescriptionLabel.TabIndex = 93
        DescriptionLabel.Text = "Description:"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        '
        'txbDescript
        '
        Me.txbDescript.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipmentBindingSource1, "Description", True))
        Me.txbDescript.Location = New System.Drawing.Point(1342, 265)
        Me.txbDescript.Name = "txbDescript"
        Me.txbDescript.Size = New System.Drawing.Size(100, 22)
        Me.txbDescript.TabIndex = 94
        '
        'EquipmentBindingSource1
        '
        Me.EquipmentBindingSource1.DataMember = "Equipment"
        Me.EquipmentBindingSource1.DataSource = Me.Winter_Sports_RentalsDataSet
        '
        'Winter_Sports_RentalsDataSet
        '
        Me.Winter_Sports_RentalsDataSet.DataSetName = "Winter_Sports_RentalsDataSet"
        Me.Winter_Sports_RentalsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSearchCustomer
        '
        Me.btnSearchCustomer.Location = New System.Drawing.Point(586, 457)
        Me.btnSearchCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearchCustomer.Name = "btnSearchCustomer"
        Me.btnSearchCustomer.Size = New System.Drawing.Size(105, 26)
        Me.btnSearchCustomer.TabIndex = 92
        Me.btnSearchCustomer.Text = "Search Customer"
        Me.btnSearchCustomer.UseVisualStyleBackColor = True
        '
        'btnCompleteRental
        '
        Me.btnCompleteRental.Location = New System.Drawing.Point(681, 406)
        Me.btnCompleteRental.Name = "btnCompleteRental"
        Me.btnCompleteRental.Size = New System.Drawing.Size(111, 37)
        Me.btnCompleteRental.TabIndex = 91
        Me.btnCompleteRental.Text = "Complete Rental"
        Me.btnCompleteRental.UseVisualStyleBackColor = True
        '
        'LBLEquipID
        '
        Me.LBLEquipID.AutoSize = True
        Me.LBLEquipID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipmentBindingSource1, "Equipment ID", True))
        Me.LBLEquipID.Location = New System.Drawing.Point(1189, 169)
        Me.LBLEquipID.Name = "LBLEquipID"
        Me.LBLEquipID.Size = New System.Drawing.Size(0, 17)
        Me.LBLEquipID.TabIndex = 90
        '
        'lblRentalFeeDue1
        '
        Me.lblRentalFeeDue1.Location = New System.Drawing.Point(752, 333)
        Me.lblRentalFeeDue1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRentalFeeDue1.Name = "lblRentalFeeDue1"
        Me.lblRentalFeeDue1.Size = New System.Drawing.Size(88, 15)
        Me.lblRentalFeeDue1.TabIndex = 89
        '
        'lblRentalFeeDue
        '
        Me.lblRentalFeeDue.AutoSize = True
        Me.lblRentalFeeDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentalFeeDue.Location = New System.Drawing.Point(640, 333)
        Me.lblRentalFeeDue.Margin = New System.Windows.Forms.Padding(4, 0, 6, 0)
        Me.lblRentalFeeDue.Name = "lblRentalFeeDue"
        Me.lblRentalFeeDue.Size = New System.Drawing.Size(96, 15)
        Me.lblRentalFeeDue.TabIndex = 88
        Me.lblRentalFeeDue.Text = "Rental Fee Due:"
        '
        'BtnNewCust
        '
        Me.BtnNewCust.Location = New System.Drawing.Point(700, 457)
        Me.BtnNewCust.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNewCust.Name = "BtnNewCust"
        Me.BtnNewCust.Size = New System.Drawing.Size(105, 26)
        Me.BtnNewCust.TabIndex = 87
        Me.BtnNewCust.Text = "New Customer"
        Me.BtnNewCust.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(253, -4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(527, 36)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "St. Anton am Arlberg Ski Resort"
        '
        'lblDueDate1
        '
        Me.lblDueDate1.Location = New System.Drawing.Point(752, 370)
        Me.lblDueDate1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDueDate1.Name = "lblDueDate1"
        Me.lblDueDate1.Size = New System.Drawing.Size(88, 15)
        Me.lblDueDate1.TabIndex = 85
        '
        'lblDueDate
        '
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.Location = New System.Drawing.Point(640, 370)
        Me.lblDueDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(72, 17)
        Me.lblDueDate.TabIndex = 84
        Me.lblDueDate.Text = "Due Date:"
        '
        'TBDeposit1
        '
        Me.TBDeposit1.Location = New System.Drawing.Point(750, 259)
        Me.TBDeposit1.Margin = New System.Windows.Forms.Padding(4)
        Me.TBDeposit1.Name = "TBDeposit1"
        Me.TBDeposit1.Size = New System.Drawing.Size(87, 22)
        Me.TBDeposit1.TabIndex = 83
        '
        'chkList_Equipment
        '
        Me.chkList_Equipment.FormattingEnabled = True
        Me.chkList_Equipment.Location = New System.Drawing.Point(4, 77)
        Me.chkList_Equipment.Margin = New System.Windows.Forms.Padding(4)
        Me.chkList_Equipment.Name = "chkList_Equipment"
        Me.chkList_Equipment.Size = New System.Drawing.Size(385, 140)
        Me.chkList_Equipment.TabIndex = 82
        '
        'lblEquipment
        '
        Me.lblEquipment.AutoSize = True
        Me.lblEquipment.Location = New System.Drawing.Point(5, 54)
        Me.lblEquipment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEquipment.Name = "lblEquipment"
        Me.lblEquipment.Size = New System.Drawing.Size(75, 17)
        Me.lblEquipment.TabIndex = 81
        Me.lblEquipment.Text = "Equipment"
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(475, 368)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(88, 26)
        Me.BtnExit.TabIndex = 80
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Location = New System.Drawing.Point(341, 368)
        Me.BtnCalculate.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(88, 26)
        Me.BtnCalculate.TabIndex = 79
        Me.BtnCalculate.Text = "Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = True
        '
        'lblDueBack1
        '
        Me.lblDueBack1.Location = New System.Drawing.Point(752, 301)
        Me.lblDueBack1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDueBack1.Name = "lblDueBack1"
        Me.lblDueBack1.Size = New System.Drawing.Size(88, 15)
        Me.lblDueBack1.TabIndex = 78
        '
        'lblDueBack
        '
        Me.lblDueBack.AutoSize = True
        Me.lblDueBack.Location = New System.Drawing.Point(640, 299)
        Me.lblDueBack.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDueBack.Name = "lblDueBack"
        Me.lblDueBack.Size = New System.Drawing.Size(73, 17)
        Me.lblDueBack.TabIndex = 77
        Me.lblDueBack.Text = "Due Back:"
        '
        'lblTotalDue1
        '
        Me.lblTotalDue1.Location = New System.Drawing.Point(752, 231)
        Me.lblTotalDue1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalDue1.Name = "lblTotalDue1"
        Me.lblTotalDue1.Size = New System.Drawing.Size(88, 15)
        Me.lblTotalDue1.TabIndex = 76
        '
        'lblTax1
        '
        Me.lblTax1.Location = New System.Drawing.Point(752, 191)
        Me.lblTax1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTax1.Name = "lblTax1"
        Me.lblTax1.Size = New System.Drawing.Size(88, 15)
        Me.lblTax1.TabIndex = 75
        '
        'lblInsurance1
        '
        Me.lblInsurance1.Location = New System.Drawing.Point(752, 154)
        Me.lblInsurance1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInsurance1.Name = "lblInsurance1"
        Me.lblInsurance1.Size = New System.Drawing.Size(88, 15)
        Me.lblInsurance1.TabIndex = 74
        '
        'lblTotalRentalFee1
        '
        Me.lblTotalRentalFee1.Location = New System.Drawing.Point(752, 116)
        Me.lblTotalRentalFee1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalRentalFee1.Name = "lblTotalRentalFee1"
        Me.lblTotalRentalFee1.Size = New System.Drawing.Size(88, 15)
        Me.lblTotalRentalFee1.TabIndex = 73
        '
        'CBLiabilityWaiver
        '
        Me.CBLiabilityWaiver.AutoSize = True
        Me.CBLiabilityWaiver.Location = New System.Drawing.Point(432, 263)
        Me.CBLiabilityWaiver.Margin = New System.Windows.Forms.Padding(4)
        Me.CBLiabilityWaiver.Name = "CBLiabilityWaiver"
        Me.CBLiabilityWaiver.Size = New System.Drawing.Size(125, 21)
        Me.CBLiabilityWaiver.TabIndex = 72
        Me.CBLiabilityWaiver.Text = "Liability Waiver"
        Me.CBLiabilityWaiver.UseVisualStyleBackColor = True
        '
        'CBDamageIns
        '
        Me.CBDamageIns.AutoSize = True
        Me.CBDamageIns.Location = New System.Drawing.Point(432, 225)
        Me.CBDamageIns.Margin = New System.Windows.Forms.Padding(4)
        Me.CBDamageIns.Name = "CBDamageIns"
        Me.CBDamageIns.Size = New System.Drawing.Size(109, 21)
        Me.CBDamageIns.TabIndex = 71
        Me.CBDamageIns.Text = "Damage Ins."
        Me.CBDamageIns.UseVisualStyleBackColor = True
        '
        'lblSubTotalDue
        '
        Me.lblSubTotalDue.AutoSize = True
        Me.lblSubTotalDue.Location = New System.Drawing.Point(640, 229)
        Me.lblSubTotalDue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubTotalDue.Name = "lblSubTotalDue"
        Me.lblSubTotalDue.Size = New System.Drawing.Size(74, 17)
        Me.lblSubTotalDue.TabIndex = 70
        Me.lblSubTotalDue.Text = "Total Due:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(640, 192)
        Me.lblTax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(35, 17)
        Me.lblTax.TabIndex = 69
        Me.lblTax.Text = "Tax:"
        '
        'lblDeposit
        '
        Me.lblDeposit.AutoSize = True
        Me.lblDeposit.Location = New System.Drawing.Point(640, 266)
        Me.lblDeposit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDeposit.Name = "lblDeposit"
        Me.lblDeposit.Size = New System.Drawing.Size(60, 17)
        Me.lblDeposit.TabIndex = 68
        Me.lblDeposit.Text = "Deposit:"
        '
        'lblInsurance
        '
        Me.lblInsurance.AutoSize = True
        Me.lblInsurance.Location = New System.Drawing.Point(640, 153)
        Me.lblInsurance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInsurance.Name = "lblInsurance"
        Me.lblInsurance.Size = New System.Drawing.Size(112, 17)
        Me.lblInsurance.TabIndex = 67
        Me.lblInsurance.Text = "Insurance(10%):"
        '
        'lblTotalRentalFee
        '
        Me.lblTotalRentalFee.AutoSize = True
        Me.lblTotalRentalFee.Location = New System.Drawing.Point(640, 116)
        Me.lblTotalRentalFee.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalRentalFee.Name = "lblTotalRentalFee"
        Me.lblTotalRentalFee.Size = New System.Drawing.Size(117, 17)
        Me.lblTotalRentalFee.TabIndex = 66
        Me.lblTotalRentalFee.Text = "Total Rental Fee:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(652, 54)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(38, 17)
        Me.lblDate.TabIndex = 65
        Me.lblDate.Text = "Date"
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Location = New System.Drawing.Point(432, 54)
        Me.lblDuration.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(62, 17)
        Me.lblDuration.TabIndex = 64
        Me.lblDuration.Text = "Duration"
        '
        'CBDuration
        '
        Me.CBDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBDuration.FormattingEnabled = True
        Me.CBDuration.Location = New System.Drawing.Point(432, 76)
        Me.CBDuration.Margin = New System.Windows.Forms.Padding(4)
        Me.CBDuration.Name = "CBDuration"
        Me.CBDuration.Size = New System.Drawing.Size(140, 24)
        Me.CBDuration.TabIndex = 63
        '
        'llbWeather
        '
        Me.llbWeather.AutoSize = True
        Me.llbWeather.Location = New System.Drawing.Point(39, 380)
        Me.llbWeather.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.llbWeather.Name = "llbWeather"
        Me.llbWeather.Size = New System.Drawing.Size(113, 17)
        Me.llbWeather.TabIndex = 62
        Me.llbWeather.TabStop = True
        Me.llbWeather.Text = "Weather Forcast"
        '
        'dtpCalender
        '
        Me.dtpCalender.Location = New System.Drawing.Point(643, 77)
        Me.dtpCalender.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpCalender.Name = "dtpCalender"
        Me.dtpCalender.Size = New System.Drawing.Size(232, 22)
        Me.dtpCalender.TabIndex = 61
        '
        'EquipmentBindingSource
        '
        Me.EquipmentBindingSource.DataMember = "Equipment"
        '
        'CustomerBindingSource1
        '
        Me.CustomerBindingSource1.DataMember = "Customer"
        Me.CustomerBindingSource1.DataSource = Me.Winter_Sports_RentalsDataSet
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.EquipmentTableAdapter = Me.EquipmentTableAdapter
        Me.TableAdapterManager.InventoryTableAdapter = Me.InventoryTableAdapter
        Me.TableAdapterManager.InvoicesTableAdapter = Me.InvoicesTableAdapter
        Me.TableAdapterManager.Rental_ItemsTableAdapter = Me.Rental_ItemsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Winter_Sports.Winter_Sports_RentalsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EquipmentTableAdapter
        '
        Me.EquipmentTableAdapter.ClearBeforeFill = True
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'InvoicesTableAdapter
        '
        Me.InvoicesTableAdapter.ClearBeforeFill = True
        '
        'Rental_ItemsTableAdapter
        '
        Me.Rental_ItemsTableAdapter.ClearBeforeFill = True
        '
        'InventoryBindingSource
        '
        Me.InventoryBindingSource.DataMember = "Inventory"
        Me.InventoryBindingSource.DataSource = Me.Winter_Sports_RentalsDataSet
        '
        'InvoicesBindingSource
        '
        Me.InvoicesBindingSource.DataMember = "Invoices"
        Me.InvoicesBindingSource.DataSource = Me.Winter_Sports_RentalsDataSet
        '
        'Rental_ItemsBindingSource
        '
        Me.Rental_ItemsBindingSource.DataMember = "Rental Items"
        Me.Rental_ItemsBindingSource.DataSource = Me.Winter_Sports_RentalsDataSet
        '
        'Equipment1BindingSource
        '
        Me.Equipment1BindingSource.DataMember = "Equipment1"
        Me.Equipment1BindingSource.DataSource = Me.Winter_Sports_RentalsDataSet
        '
        'Equipment1TableAdapter
        '
        Me.Equipment1TableAdapter.ClearBeforeFill = True
        '
        'EquipmentBindingSource2
        '
        Me.EquipmentBindingSource2.DataMember = "Equipment"
        Me.EquipmentBindingSource2.DataSource = Me.Winter_Sports_RentalsDataSet
        '
        'EquipmentBindingSource3
        '
        Me.EquipmentBindingSource3.DataMember = "Equipment"
        Me.EquipmentBindingSource3.DataSource = Me.Winter_Sports_RentalsDataSet
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1481, 556)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.txbDescript)
        Me.Controls.Add(Me.btnSearchCustomer)
        Me.Controls.Add(Me.btnCompleteRental)
        Me.Controls.Add(Me.LBLEquipID)
        Me.Controls.Add(Me.lblRentalFeeDue1)
        Me.Controls.Add(Me.lblRentalFeeDue)
        Me.Controls.Add(Me.BtnNewCust)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDueDate1)
        Me.Controls.Add(Me.lblDueDate)
        Me.Controls.Add(Me.TBDeposit1)
        Me.Controls.Add(Me.chkList_Equipment)
        Me.Controls.Add(Me.lblEquipment)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Controls.Add(Me.lblDueBack1)
        Me.Controls.Add(Me.lblDueBack)
        Me.Controls.Add(Me.lblTotalDue1)
        Me.Controls.Add(Me.lblTax1)
        Me.Controls.Add(Me.lblInsurance1)
        Me.Controls.Add(Me.lblTotalRentalFee1)
        Me.Controls.Add(Me.CBLiabilityWaiver)
        Me.Controls.Add(Me.CBDamageIns)
        Me.Controls.Add(Me.lblSubTotalDue)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblDeposit)
        Me.Controls.Add(Me.lblInsurance)
        Me.Controls.Add(Me.lblTotalRentalFee)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblDuration)
        Me.Controls.Add(Me.CBDuration)
        Me.Controls.Add(Me.llbWeather)
        Me.Controls.Add(Me.dtpCalender)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipmentBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Winter_Sports_RentalsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rental_ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Equipment1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipmentBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipmentBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents EquipmentBindingSource As BindingSource
    Friend WithEvents txbDescript As TextBox
    Friend WithEvents btnSearchCustomer As Button
    Friend WithEvents btnCompleteRental As Button
    Friend WithEvents LBLEquipID As Label
    Friend WithEvents lblRentalFeeDue1 As Label
    Friend WithEvents lblRentalFeeDue As Label
    Friend WithEvents BtnNewCust As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDueDate1 As Label
    Friend WithEvents lblDueDate As Label
    Friend WithEvents TBDeposit1 As TextBox
    Friend WithEvents chkList_Equipment As CheckedListBox
    Friend WithEvents lblEquipment As Label
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents lblDueBack1 As Label
    Friend WithEvents lblDueBack As Label
    Friend WithEvents lblTotalDue1 As Label
    Friend WithEvents lblTax1 As Label
    Friend WithEvents lblInsurance1 As Label
    Friend WithEvents lblTotalRentalFee1 As Label
    Friend WithEvents CBLiabilityWaiver As CheckBox
    Friend WithEvents CBDamageIns As CheckBox
    Friend WithEvents lblSubTotalDue As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblDeposit As Label
    Friend WithEvents lblInsurance As Label
    Friend WithEvents lblTotalRentalFee As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblDuration As Label
    Friend WithEvents CBDuration As ComboBox
    Friend WithEvents llbWeather As LinkLabel
    Friend WithEvents dtpCalender As DateTimePicker
    Friend WithEvents Winter_Sports_RentalsDataSet As Winter_Sports_RentalsDataSet
    Friend WithEvents CustomerBindingSource1 As BindingSource
    Friend WithEvents CustomerTableAdapter As Winter_Sports_RentalsDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager As Winter_Sports_RentalsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EquipmentTableAdapter As Winter_Sports_RentalsDataSetTableAdapters.EquipmentTableAdapter
    Friend WithEvents EquipmentBindingSource1 As BindingSource
    Friend WithEvents InventoryTableAdapter As Winter_Sports_RentalsDataSetTableAdapters.InventoryTableAdapter
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents InvoicesTableAdapter As Winter_Sports_RentalsDataSetTableAdapters.InvoicesTableAdapter
    Friend WithEvents InvoicesBindingSource As BindingSource
    Friend WithEvents Rental_ItemsTableAdapter As Winter_Sports_RentalsDataSetTableAdapters.Rental_ItemsTableAdapter
    Friend WithEvents Rental_ItemsBindingSource As BindingSource
    Friend WithEvents Equipment1BindingSource As BindingSource
    Friend WithEvents Equipment1TableAdapter As Winter_Sports_RentalsDataSetTableAdapters.Equipment1TableAdapter
    Friend WithEvents EquipmentBindingSource2 As BindingSource
    Friend WithEvents EquipmentBindingSource3 As BindingSource
End Class
