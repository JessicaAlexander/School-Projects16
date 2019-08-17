<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchCustomer
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.RBExisting = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RBNew = New System.Windows.Forms.RadioButton()
        Me.btnSearchByCustomerID = New System.Windows.Forms.Button()
        Me.btnSearchByLastName = New System.Windows.Forms.Button()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CustomerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Winter_Sports_RentalsDataSet = New Winter_Sports.Winter_Sports_RentalsDataSet()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.CustomerTableAdapter = New Winter_Sports.Winter_Sports_RentalsDataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager = New Winter_Sports.Winter_Sports_RentalsDataSetTableAdapters.TableAdapterManager()
        Me.EquipmentTableAdapter = New Winter_Sports.Winter_Sports_RentalsDataSetTableAdapters.EquipmentTableAdapter()
        Me.InventoryTableAdapter = New Winter_Sports.Winter_Sports_RentalsDataSetTableAdapters.InventoryTableAdapter()
        Me.InvoicesTableAdapter = New Winter_Sports.Winter_Sports_RentalsDataSetTableAdapters.InvoicesTableAdapter()
        Me.Rental_ItemsTableAdapter = New Winter_Sports.Winter_Sports_RentalsDataSetTableAdapters.Rental_ItemsTableAdapter()
        Me.EquipmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rental_ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Winter_Sports_RentalsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rental_ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(368, 426)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 8
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'RBExisting
        '
        Me.RBExisting.AutoSize = True
        Me.RBExisting.Location = New System.Drawing.Point(12, 29)
        Me.RBExisting.Name = "RBExisting"
        Me.RBExisting.Size = New System.Drawing.Size(141, 21)
        Me.RBExisting.TabIndex = 10
        Me.RBExisting.TabStop = True
        Me.RBExisting.Text = "Existing Customer"
        Me.RBExisting.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(285, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(349, 38)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Customer Information"
        '
        'RBNew
        '
        Me.RBNew.AutoSize = True
        Me.RBNew.Location = New System.Drawing.Point(159, 30)
        Me.RBNew.Name = "RBNew"
        Me.RBNew.Size = New System.Drawing.Size(120, 21)
        Me.RBNew.TabIndex = 11
        Me.RBNew.TabStop = True
        Me.RBNew.Text = "New Customer"
        Me.RBNew.UseVisualStyleBackColor = True
        '
        'btnSearchByCustomerID
        '
        Me.btnSearchByCustomerID.Location = New System.Drawing.Point(147, 21)
        Me.btnSearchByCustomerID.Name = "btnSearchByCustomerID"
        Me.btnSearchByCustomerID.Size = New System.Drawing.Size(120, 55)
        Me.btnSearchByCustomerID.TabIndex = 2
        Me.btnSearchByCustomerID.Text = "Search By Customer ID"
        Me.btnSearchByCustomerID.UseVisualStyleBackColor = True
        '
        'btnSearchByLastName
        '
        Me.btnSearchByLastName.Location = New System.Drawing.Point(26, 22)
        Me.btnSearchByLastName.Name = "btnSearchByLastName"
        Me.btnSearchByLastName.Size = New System.Drawing.Size(115, 54)
        Me.btnSearchByLastName.TabIndex = 1
        Me.btnSearchByLastName.Text = "Search By Last Name"
        Me.btnSearchByLastName.UseVisualStyleBackColor = True
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CustomerDataGridView)
        Me.GroupBox1.Controls.Add(Me.btnSearchByCustomerID)
        Me.GroupBox1.Controls.Add(Me.btnSearchByLastName)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1019, 465)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search For Name"
        '
        'CustomerDataGridView
        '
        Me.CustomerDataGridView.AutoGenerateColumns = False
        Me.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.CustomerDataGridView.DataSource = Me.CustomerBindingSource1
        Me.CustomerDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.CustomerDataGridView.Location = New System.Drawing.Point(26, 82)
        Me.CustomerDataGridView.MultiSelect = False
        Me.CustomerDataGridView.Name = "CustomerDataGridView"
        Me.CustomerDataGridView.RowTemplate.Height = 24
        Me.CustomerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CustomerDataGridView.ShowEditingIcon = False
        Me.CustomerDataGridView.Size = New System.Drawing.Size(832, 271)
        Me.CustomerDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Customer ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Customer ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "First Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Last Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Street Address"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Street Address"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn5.HeaderText = "City"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "State"
        Me.DataGridViewTextBoxColumn6.HeaderText = "State"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Zip Code"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Zip Code"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Phone Number"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Phone Number"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'CustomerBindingSource1
        '
        Me.CustomerBindingSource1.DataMember = "Customer"
        Me.CustomerBindingSource1.DataSource = Me.Winter_Sports_RentalsDataSet
        '
        'Winter_Sports_RentalsDataSet
        '
        Me.Winter_Sports_RentalsDataSet.DataSetName = "Winter_Sports_RentalsDataSet"
        Me.Winter_Sports_RentalsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(908, 29)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 6
        Me.BtnExit.Text = "Close"
        Me.BtnExit.UseVisualStyleBackColor = True
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
        'EquipmentBindingSource
        '
        Me.EquipmentBindingSource.DataMember = "Equipment"
        Me.EquipmentBindingSource.DataSource = Me.Winter_Sports_RentalsDataSet
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
        'SearchCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 523)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.RBExisting)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RBNew)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnExit)
        Me.Name = "SearchCustomer"
        Me.Text = "SearchCustomer"
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Winter_Sports_RentalsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rental_ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOK As Button
    Friend WithEvents RBExisting As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents RBNew As RadioButton
    Friend WithEvents btnSearchByCustomerID As Button
    Friend WithEvents btnSearchByLastName As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnExit As Button
    Friend WithEvents Winter_Sports_RentalsDataSet As Winter_Sports_RentalsDataSet
    Friend WithEvents CustomerBindingSource1 As BindingSource
    Friend WithEvents CustomerTableAdapter As Winter_Sports_RentalsDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager As Winter_Sports_RentalsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EquipmentTableAdapter As Winter_Sports_RentalsDataSetTableAdapters.EquipmentTableAdapter
    Friend WithEvents EquipmentBindingSource As BindingSource
    Friend WithEvents InventoryTableAdapter As Winter_Sports_RentalsDataSetTableAdapters.InventoryTableAdapter
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents InvoicesTableAdapter As Winter_Sports_RentalsDataSetTableAdapters.InvoicesTableAdapter
    Friend WithEvents InvoicesBindingSource As BindingSource
    Friend WithEvents Rental_ItemsTableAdapter As Winter_Sports_RentalsDataSetTableAdapters.Rental_ItemsTableAdapter
    Friend WithEvents Rental_ItemsBindingSource As BindingSource
    Friend WithEvents CustomerDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
