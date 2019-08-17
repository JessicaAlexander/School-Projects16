<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckOut
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
        Me.txbBalance = New System.Windows.Forms.TextBox()
        Me.txbDeposit = New System.Windows.Forms.TextBox()
        Me.txbInsuarance = New System.Windows.Forms.TextBox()
        Me.txbTax = New System.Windows.Forms.TextBox()
        Me.txbSubtotal = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblBalanceDue = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblDeposit = New System.Windows.Forms.Label()
        Me.lblInsurance = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.txbExpMonth = New System.Windows.Forms.TextBox()
        Me.txbCreditCardNumber = New System.Windows.Forms.TextBox()
        Me.tbxCRVCode = New System.Windows.Forms.TextBox()
        Me.txbExpYear = New System.Windows.Forms.TextBox()
        Me.txbNameOnCard = New System.Windows.Forms.TextBox()
        Me.lblCRVCode = New System.Windows.Forms.Label()
        Me.lblExpYear = New System.Windows.Forms.Label()
        Me.lblExpMonth = New System.Windows.Forms.Label()
        Me.lblCreditCardNumber = New System.Windows.Forms.Label()
        Me.lblNameOnCard = New System.Windows.Forms.Label()
        Me.rbPayPal = New System.Windows.Forms.RadioButton()
        Me.rbCheck = New System.Windows.Forms.RadioButton()
        Me.rbCredit = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstRentalItems = New System.Windows.Forms.ListBox()
        Me.InvoicesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Winter_Sports_RentalsDataSet = New Winter_Sports.Winter_Sports_RentalsDataSet()
        Me.lblCustomerInformation = New System.Windows.Forms.Label()
        Me.lblRentalItems = New System.Windows.Forms.Label()
        Me.txbName = New System.Windows.Forms.TextBox()
        Me.txbDate = New System.Windows.Forms.TextBox()
        Me.txbCustomerID = New System.Windows.Forms.TextBox()
        Me.tbxAddress = New System.Windows.Forms.TextBox()
        Me.txbCity = New System.Windows.Forms.TextBox()
        Me.txbState = New System.Windows.Forms.TextBox()
        Me.txbZipCode = New System.Windows.Forms.TextBox()
        Me.txbPhone = New System.Windows.Forms.TextBox()
        Me.txbInvoice = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblZipCode = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.lblInvoice = New System.Windows.Forms.Label()
        Me.Rental_ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EquipmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New Winter_Sports.Winter_Sports_RentalsDataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager = New Winter_Sports.Winter_Sports_RentalsDataSetTableAdapters.TableAdapterManager()
        Me.EquipmentTableAdapter = New Winter_Sports.Winter_Sports_RentalsDataSetTableAdapters.EquipmentTableAdapter()
        Me.InventoryTableAdapter = New Winter_Sports.Winter_Sports_RentalsDataSetTableAdapters.InventoryTableAdapter()
        Me.InvoicesTableAdapter = New Winter_Sports.Winter_Sports_RentalsDataSetTableAdapters.InvoicesTableAdapter()
        Me.EquipmentBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rental_ItemsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rental_ItemsTableAdapter = New Winter_Sports.Winter_Sports_RentalsDataSetTableAdapters.Rental_ItemsTableAdapter()
        CType(Me.InvoicesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Winter_Sports_RentalsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rental_ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipmentBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rental_ItemsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txbBalance
        '
        Me.txbBalance.Location = New System.Drawing.Point(644, 846)
        Me.txbBalance.Name = "txbBalance"
        Me.txbBalance.Size = New System.Drawing.Size(100, 22)
        Me.txbBalance.TabIndex = 105
        '
        'txbDeposit
        '
        Me.txbDeposit.Location = New System.Drawing.Point(644, 812)
        Me.txbDeposit.Name = "txbDeposit"
        Me.txbDeposit.Size = New System.Drawing.Size(100, 22)
        Me.txbDeposit.TabIndex = 104
        '
        'txbInsuarance
        '
        Me.txbInsuarance.Location = New System.Drawing.Point(644, 774)
        Me.txbInsuarance.Name = "txbInsuarance"
        Me.txbInsuarance.Size = New System.Drawing.Size(100, 22)
        Me.txbInsuarance.TabIndex = 103
        '
        'txbTax
        '
        Me.txbTax.Location = New System.Drawing.Point(644, 740)
        Me.txbTax.Name = "txbTax"
        Me.txbTax.Size = New System.Drawing.Size(100, 22)
        Me.txbTax.TabIndex = 102
        '
        'txbSubtotal
        '
        Me.txbSubtotal.Location = New System.Drawing.Point(644, 706)
        Me.txbSubtotal.Name = "txbSubtotal"
        Me.txbSubtotal.Size = New System.Drawing.Size(100, 22)
        Me.txbSubtotal.TabIndex = 101
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(548, 904)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 100
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblBalanceDue
        '
        Me.lblBalanceDue.AutoSize = True
        Me.lblBalanceDue.Location = New System.Drawing.Point(545, 851)
        Me.lblBalanceDue.Name = "lblBalanceDue"
        Me.lblBalanceDue.Size = New System.Drawing.Size(93, 17)
        Me.lblBalanceDue.TabIndex = 99
        Me.lblBalanceDue.Text = "Balance Due:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(545, 743)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(35, 17)
        Me.lblTax.TabIndex = 98
        Me.lblTax.Text = "Tax:"
        '
        'lblDeposit
        '
        Me.lblDeposit.AutoSize = True
        Me.lblDeposit.Location = New System.Drawing.Point(545, 815)
        Me.lblDeposit.Name = "lblDeposit"
        Me.lblDeposit.Size = New System.Drawing.Size(60, 17)
        Me.lblDeposit.TabIndex = 97
        Me.lblDeposit.Text = "Deposit:"
        '
        'lblInsurance
        '
        Me.lblInsurance.AutoSize = True
        Me.lblInsurance.Location = New System.Drawing.Point(545, 779)
        Me.lblInsurance.Name = "lblInsurance"
        Me.lblInsurance.Size = New System.Drawing.Size(74, 17)
        Me.lblInsurance.TabIndex = 96
        Me.lblInsurance.Text = "Insurance:"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(545, 707)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(64, 17)
        Me.lblSubtotal.TabIndex = 95
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'txbExpMonth
        '
        Me.txbExpMonth.Location = New System.Drawing.Point(95, 831)
        Me.txbExpMonth.Name = "txbExpMonth"
        Me.txbExpMonth.Size = New System.Drawing.Size(100, 22)
        Me.txbExpMonth.TabIndex = 94
        '
        'txbCreditCardNumber
        '
        Me.txbCreditCardNumber.Location = New System.Drawing.Point(153, 793)
        Me.txbCreditCardNumber.Name = "txbCreditCardNumber"
        Me.txbCreditCardNumber.Size = New System.Drawing.Size(258, 22)
        Me.txbCreditCardNumber.TabIndex = 93
        '
        'tbxCRVCode
        '
        Me.tbxCRVCode.Location = New System.Drawing.Point(93, 877)
        Me.tbxCRVCode.Name = "tbxCRVCode"
        Me.tbxCRVCode.Size = New System.Drawing.Size(100, 22)
        Me.tbxCRVCode.TabIndex = 92
        '
        'txbExpYear
        '
        Me.txbExpYear.Location = New System.Drawing.Point(305, 834)
        Me.txbExpYear.Name = "txbExpYear"
        Me.txbExpYear.Size = New System.Drawing.Size(100, 22)
        Me.txbExpYear.TabIndex = 91
        '
        'txbNameOnCard
        '
        Me.txbNameOnCard.Location = New System.Drawing.Point(153, 757)
        Me.txbNameOnCard.Name = "txbNameOnCard"
        Me.txbNameOnCard.Size = New System.Drawing.Size(258, 22)
        Me.txbNameOnCard.TabIndex = 90
        '
        'lblCRVCode
        '
        Me.lblCRVCode.AutoSize = True
        Me.lblCRVCode.Location = New System.Drawing.Point(14, 877)
        Me.lblCRVCode.Name = "lblCRVCode"
        Me.lblCRVCode.Size = New System.Drawing.Size(73, 17)
        Me.lblCRVCode.TabIndex = 89
        Me.lblCRVCode.Text = "CRV Code"
        '
        'lblExpYear
        '
        Me.lblExpYear.AutoSize = True
        Me.lblExpYear.Location = New System.Drawing.Point(232, 834)
        Me.lblExpYear.Name = "lblExpYear"
        Me.lblExpYear.Size = New System.Drawing.Size(69, 17)
        Me.lblExpYear.TabIndex = 88
        Me.lblExpYear.Text = "Exp. Year"
        '
        'lblExpMonth
        '
        Me.lblExpMonth.AutoSize = True
        Me.lblExpMonth.Location = New System.Drawing.Point(14, 834)
        Me.lblExpMonth.Name = "lblExpMonth"
        Me.lblExpMonth.Size = New System.Drawing.Size(78, 17)
        Me.lblExpMonth.TabIndex = 87
        Me.lblExpMonth.Text = "Exp. Month"
        '
        'lblCreditCardNumber
        '
        Me.lblCreditCardNumber.AutoSize = True
        Me.lblCreditCardNumber.Location = New System.Drawing.Point(14, 796)
        Me.lblCreditCardNumber.Name = "lblCreditCardNumber"
        Me.lblCreditCardNumber.Size = New System.Drawing.Size(133, 17)
        Me.lblCreditCardNumber.TabIndex = 86
        Me.lblCreditCardNumber.Text = "Credit Card Number"
        '
        'lblNameOnCard
        '
        Me.lblNameOnCard.AutoSize = True
        Me.lblNameOnCard.Location = New System.Drawing.Point(12, 757)
        Me.lblNameOnCard.Name = "lblNameOnCard"
        Me.lblNameOnCard.Size = New System.Drawing.Size(102, 17)
        Me.lblNameOnCard.TabIndex = 85
        Me.lblNameOnCard.Text = "Name On Card"
        '
        'rbPayPal
        '
        Me.rbPayPal.AutoSize = True
        Me.rbPayPal.Location = New System.Drawing.Point(194, 707)
        Me.rbPayPal.Name = "rbPayPal"
        Me.rbPayPal.Size = New System.Drawing.Size(73, 21)
        Me.rbPayPal.TabIndex = 84
        Me.rbPayPal.TabStop = True
        Me.rbPayPal.Text = "PayPal"
        Me.rbPayPal.UseVisualStyleBackColor = True
        '
        'rbCheck
        '
        Me.rbCheck.AutoSize = True
        Me.rbCheck.Location = New System.Drawing.Point(95, 707)
        Me.rbCheck.Name = "rbCheck"
        Me.rbCheck.Size = New System.Drawing.Size(68, 21)
        Me.rbCheck.TabIndex = 83
        Me.rbCheck.TabStop = True
        Me.rbCheck.Text = "Check"
        Me.rbCheck.UseVisualStyleBackColor = True
        '
        'rbCredit
        '
        Me.rbCredit.AutoSize = True
        Me.rbCredit.Location = New System.Drawing.Point(13, 707)
        Me.rbCredit.Name = "rbCredit"
        Me.rbCredit.Size = New System.Drawing.Size(66, 21)
        Me.rbCredit.TabIndex = 82
        Me.rbCredit.TabStop = True
        Me.rbCredit.Text = "Credit"
        Me.rbCredit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 687)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 20)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Payment Information"
        '
        'lstRentalItems
        '
        Me.lstRentalItems.DisplayMember = "Invoice Number"
        Me.lstRentalItems.FormattingEnabled = True
        Me.lstRentalItems.ItemHeight = 16
        Me.lstRentalItems.Location = New System.Drawing.Point(2, 350)
        Me.lstRentalItems.Name = "lstRentalItems"
        Me.lstRentalItems.Size = New System.Drawing.Size(802, 324)
        Me.lstRentalItems.TabIndex = 80
        Me.lstRentalItems.ValueMember = "Invoice Number"
        '
        'InvoicesBindingSource1
        '
        Me.InvoicesBindingSource1.DataMember = "Invoices"
        Me.InvoicesBindingSource1.DataSource = Me.Winter_Sports_RentalsDataSet
        '
        'Winter_Sports_RentalsDataSet
        '
        Me.Winter_Sports_RentalsDataSet.DataSetName = "Winter_Sports_RentalsDataSet"
        Me.Winter_Sports_RentalsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblCustomerInformation
        '
        Me.lblCustomerInformation.AutoSize = True
        Me.lblCustomerInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerInformation.Location = New System.Drawing.Point(12, 57)
        Me.lblCustomerInformation.Name = "lblCustomerInformation"
        Me.lblCustomerInformation.Size = New System.Drawing.Size(218, 25)
        Me.lblCustomerInformation.TabIndex = 79
        Me.lblCustomerInformation.Text = "Customer Information"
        '
        'lblRentalItems
        '
        Me.lblRentalItems.AutoSize = True
        Me.lblRentalItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentalItems.Location = New System.Drawing.Point(350, 322)
        Me.lblRentalItems.Name = "lblRentalItems"
        Me.lblRentalItems.Size = New System.Drawing.Size(131, 25)
        Me.lblRentalItems.TabIndex = 78
        Me.lblRentalItems.Text = "Rental Items"
        '
        'txbName
        '
        Me.txbName.Location = New System.Drawing.Point(253, 107)
        Me.txbName.Name = "txbName"
        Me.txbName.Size = New System.Drawing.Size(379, 22)
        Me.txbName.TabIndex = 77
        '
        'txbDate
        '
        Me.txbDate.Location = New System.Drawing.Point(670, 9)
        Me.txbDate.Name = "txbDate"
        Me.txbDate.Size = New System.Drawing.Size(118, 22)
        Me.txbDate.TabIndex = 76
        '
        'txbCustomerID
        '
        Me.txbCustomerID.Location = New System.Drawing.Point(15, 107)
        Me.txbCustomerID.Name = "txbCustomerID"
        Me.txbCustomerID.Size = New System.Drawing.Size(162, 22)
        Me.txbCustomerID.TabIndex = 75
        '
        'tbxAddress
        '
        Me.tbxAddress.Location = New System.Drawing.Point(15, 187)
        Me.tbxAddress.Name = "tbxAddress"
        Me.tbxAddress.Size = New System.Drawing.Size(332, 22)
        Me.tbxAddress.TabIndex = 74
        '
        'txbCity
        '
        Me.txbCity.Location = New System.Drawing.Point(383, 187)
        Me.txbCity.Name = "txbCity"
        Me.txbCity.Size = New System.Drawing.Size(133, 22)
        Me.txbCity.TabIndex = 73
        '
        'txbState
        '
        Me.txbState.Location = New System.Drawing.Point(568, 187)
        Me.txbState.Name = "txbState"
        Me.txbState.Size = New System.Drawing.Size(51, 22)
        Me.txbState.TabIndex = 72
        '
        'txbZipCode
        '
        Me.txbZipCode.Location = New System.Drawing.Point(670, 187)
        Me.txbZipCode.Name = "txbZipCode"
        Me.txbZipCode.Size = New System.Drawing.Size(100, 22)
        Me.txbZipCode.TabIndex = 71
        '
        'txbPhone
        '
        Me.txbPhone.Location = New System.Drawing.Point(15, 262)
        Me.txbPhone.Name = "txbPhone"
        Me.txbPhone.Size = New System.Drawing.Size(100, 22)
        Me.txbPhone.TabIndex = 70
        '
        'txbInvoice
        '
        Me.txbInvoice.Location = New System.Drawing.Point(82, 4)
        Me.txbInvoice.Name = "txbInvoice"
        Me.txbInvoice.Size = New System.Drawing.Size(167, 22)
        Me.txbInvoice.TabIndex = 69
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(12, 242)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(49, 17)
        Me.lblPhone.TabIndex = 68
        Me.lblPhone.Text = "Phone"
        '
        'lblZipCode
        '
        Me.lblZipCode.AutoSize = True
        Me.lblZipCode.Location = New System.Drawing.Point(667, 167)
        Me.lblZipCode.Name = "lblZipCode"
        Me.lblZipCode.Size = New System.Drawing.Size(65, 17)
        Me.lblZipCode.TabIndex = 67
        Me.lblZipCode.Text = "Zip Code"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(565, 167)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(41, 17)
        Me.lblState.TabIndex = 66
        Me.lblState.Text = "State"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(380, 167)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(31, 17)
        Me.lblCity.TabIndex = 65
        Me.lblCity.Text = "City"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(12, 167)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(60, 17)
        Me.lblAddress.TabIndex = 64
        Me.lblAddress.Text = "Address"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(613, 12)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(38, 17)
        Me.lblDate.TabIndex = 63
        Me.lblDate.Text = "Date"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(256, 87)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 17)
        Me.lblName.TabIndex = 62
        Me.lblName.Text = "Name"
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.Location = New System.Drawing.Point(12, 87)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(85, 17)
        Me.lblCustomerID.TabIndex = 61
        Me.lblCustomerID.Text = "Customer ID"
        '
        'lblInvoice
        '
        Me.lblInvoice.AutoSize = True
        Me.lblInvoice.Location = New System.Drawing.Point(12, 9)
        Me.lblInvoice.Name = "lblInvoice"
        Me.lblInvoice.Size = New System.Drawing.Size(64, 17)
        Me.lblInvoice.TabIndex = 60
        Me.lblInvoice.Text = "Invoice #"
        '
        'Rental_ItemsBindingSource
        '
        Me.Rental_ItemsBindingSource.DataMember = "Rental Items"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        '
        'EquipmentBindingSource
        '
        Me.EquipmentBindingSource.DataMember = "Equipment"
        '
        'InvoicesBindingSource
        '
        Me.InvoicesBindingSource.DataMember = "Invoices"
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
        Me.TableAdapterManager.Rental_ItemsTableAdapter = Nothing
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
        'EquipmentBindingSource1
        '
        Me.EquipmentBindingSource1.DataMember = "Equipment"
        Me.EquipmentBindingSource1.DataSource = Me.Winter_Sports_RentalsDataSet
        '
        'InventoryBindingSource
        '
        Me.InventoryBindingSource.DataMember = "Inventory"
        Me.InventoryBindingSource.DataSource = Me.Winter_Sports_RentalsDataSet
        '
        'Rental_ItemsBindingSource1
        '
        Me.Rental_ItemsBindingSource1.DataMember = "Rental Items"
        Me.Rental_ItemsBindingSource1.DataSource = Me.Winter_Sports_RentalsDataSet
        '
        'Rental_ItemsTableAdapter
        '
        Me.Rental_ItemsTableAdapter.ClearBeforeFill = True
        '
        'CheckOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 947)
        Me.Controls.Add(Me.txbBalance)
        Me.Controls.Add(Me.txbDeposit)
        Me.Controls.Add(Me.txbInsuarance)
        Me.Controls.Add(Me.txbTax)
        Me.Controls.Add(Me.txbSubtotal)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblBalanceDue)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblDeposit)
        Me.Controls.Add(Me.lblInsurance)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.txbExpMonth)
        Me.Controls.Add(Me.txbCreditCardNumber)
        Me.Controls.Add(Me.tbxCRVCode)
        Me.Controls.Add(Me.txbExpYear)
        Me.Controls.Add(Me.txbNameOnCard)
        Me.Controls.Add(Me.lblCRVCode)
        Me.Controls.Add(Me.lblExpYear)
        Me.Controls.Add(Me.lblExpMonth)
        Me.Controls.Add(Me.lblCreditCardNumber)
        Me.Controls.Add(Me.lblNameOnCard)
        Me.Controls.Add(Me.rbPayPal)
        Me.Controls.Add(Me.rbCheck)
        Me.Controls.Add(Me.rbCredit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstRentalItems)
        Me.Controls.Add(Me.lblCustomerInformation)
        Me.Controls.Add(Me.lblRentalItems)
        Me.Controls.Add(Me.txbName)
        Me.Controls.Add(Me.txbDate)
        Me.Controls.Add(Me.txbCustomerID)
        Me.Controls.Add(Me.tbxAddress)
        Me.Controls.Add(Me.txbCity)
        Me.Controls.Add(Me.txbState)
        Me.Controls.Add(Me.txbZipCode)
        Me.Controls.Add(Me.txbPhone)
        Me.Controls.Add(Me.txbInvoice)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblZipCode)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblCustomerID)
        Me.Controls.Add(Me.lblInvoice)
        Me.Name = "CheckOut"
        Me.Text = "CheckOut"
        CType(Me.InvoicesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Winter_Sports_RentalsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rental_ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipmentBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rental_ItemsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txbBalance As TextBox
    Friend WithEvents txbDeposit As TextBox
    Friend WithEvents txbInsuarance As TextBox
    Friend WithEvents txbTax As TextBox
    Friend WithEvents txbSubtotal As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents lblBalanceDue As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblDeposit As Label
    Friend WithEvents lblInsurance As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents txbExpMonth As TextBox
    Friend WithEvents txbCreditCardNumber As TextBox
    Friend WithEvents tbxCRVCode As TextBox
    Friend WithEvents txbExpYear As TextBox
    Friend WithEvents txbNameOnCard As TextBox
    Friend WithEvents lblCRVCode As Label
    Friend WithEvents lblExpYear As Label
    Friend WithEvents lblExpMonth As Label
    Friend WithEvents lblCreditCardNumber As Label
    Friend WithEvents Rental_ItemsBindingSource As BindingSource
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents lblNameOnCard As Label
    Friend WithEvents rbPayPal As RadioButton
    Friend WithEvents rbCheck As RadioButton
    Friend WithEvents rbCredit As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents EquipmentBindingSource As BindingSource
    Friend WithEvents lstRentalItems As ListBox
    Friend WithEvents lblCustomerInformation As Label
    Friend WithEvents lblRentalItems As Label
    Friend WithEvents txbName As TextBox
    Friend WithEvents txbDate As TextBox
    Friend WithEvents txbCustomerID As TextBox
    Friend WithEvents tbxAddress As TextBox
    Friend WithEvents txbCity As TextBox
    Friend WithEvents txbState As TextBox
    Friend WithEvents txbZipCode As TextBox
    Friend WithEvents txbPhone As TextBox
    Friend WithEvents txbInvoice As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblZipCode As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents InvoicesBindingSource As BindingSource
    Friend WithEvents lblInvoice As Label
    Friend WithEvents Winter_Sports_RentalsDataSet As Winter_Sports_RentalsDataSet
    Friend WithEvents CustomerBindingSource1 As BindingSource
    Friend WithEvents CustomerTableAdapter As Winter_Sports_RentalsDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager As Winter_Sports_RentalsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EquipmentTableAdapter As Winter_Sports_RentalsDataSetTableAdapters.EquipmentTableAdapter
    Friend WithEvents EquipmentBindingSource1 As BindingSource
    Friend WithEvents InventoryTableAdapter As Winter_Sports_RentalsDataSetTableAdapters.InventoryTableAdapter
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents InvoicesTableAdapter As Winter_Sports_RentalsDataSetTableAdapters.InvoicesTableAdapter
    Friend WithEvents InvoicesBindingSource1 As BindingSource
    Friend WithEvents Rental_ItemsBindingSource1 As BindingSource
    Friend WithEvents Rental_ItemsTableAdapter As Winter_Sports_RentalsDataSetTableAdapters.Rental_ItemsTableAdapter
End Class
