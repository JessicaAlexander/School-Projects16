Public Class CheckOut
    Dim rentDate As Date = Form1.startDate
    Dim dueDate As Date = Form1.DueDate
    Dim invNum As Integer
    Dim custID As Integer
    Dim subTotal As Double = Form1.subtotal
    Dim tax As Double = Form1.Tax
    Dim deposit As Double = Form1.Deposit
    Dim rentalFee As Double = Form1.RentalFee
    Dim insurance As Double = Form1.Insurance
    Dim myList As List(Of RentedItems) = Form1.itemsList
    Dim durTime As Integer = Form1.NumOfDays
    Dim EquipmentID As Integer



    Dim balance As Double = Form1.Total
    Dim payType As String = String.Empty

    Private Sub CheckOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Winter_Sports_RentalsDataSet.Rental_Items' table. You can move, or remove it, as needed.
        Me.Rental_ItemsTableAdapter.Fill(Me.Winter_Sports_RentalsDataSet.Rental_Items)
        'TODO: This line of code loads data into the 'Winter_Sports_RentalsDataSet.Invoices' table. You can move, or remove it, as needed.
        Me.InvoicesTableAdapter.Fill(Me.Winter_Sports_RentalsDataSet.Invoices)
        'TODO: This line of code loads data into the 'Winter_Sports_RentalsDataSet.Inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.Winter_Sports_RentalsDataSet.Inventory)
        'TODO: This line of code loads data into the 'Winter_Sports_RentalsDataSet.Equipment' table. You can move, or remove it, as needed.
        Me.EquipmentTableAdapter.Fill(Me.Winter_Sports_RentalsDataSet.Equipment)
        'TODO: This line of code loads data into the 'Winter_Sports_RentalsDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.Winter_Sports_RentalsDataSet.Customer)
        'TODO: This line of code loads data into the 'Winter_Sports_RentalsDataSet.Equipment' table. You can move, or remove it, as needed.
        Me.EquipmentTableAdapter.Fill(Me.Winter_Sports_RentalsDataSet.Equipment)
        'TODO: This line of code loads data into the 'Winter_Sports_RentalsDataSet.Rental_Items' table. You can move, or remove it, as needed.
        Me.Rental_ItemsTableAdapter.Fill(Me.Winter_Sports_RentalsDataSet.Rental_Items)
        'TODO: This line of code loads data into the 'Winter_Sports_RentalsDataSet.Invoices' table. You can move, or remove it, as needed.
        Me.InvoicesTableAdapter.Fill(Me.Winter_Sports_RentalsDataSet.Invoices)

        Dim description As String

        custID = SearchCustomer.custID
        txbCustomerID.Text = custID.ToString()

        txbDate.Text = rentDate.ToString()

        Me.CustomerTableAdapter.FillByID(Me.Winter_Sports_RentalsDataSet.Customer, custID)
        Me.CustomerBindingSource.Position = 0

        invNum = CInt(Me.InvoicesTableAdapter.InvoiceCountQuery() + 1)
        txbInvoice.Text = invNum.ToString()

        Dim firstName As String = DirectCast(CustomerBindingSource1.Current, DataRowView).Item("First Name").ToString
        Dim lastName As String = DirectCast(CustomerBindingSource1.Current, DataRowView).Item("Last Name").ToString

        txbName.Text = firstName & " " & lastName
        tbxAddress.Text = DirectCast(CustomerBindingSource1.Current, DataRowView).Item("Street Address").ToString
        txbCity.Text = DirectCast(CustomerBindingSource1.Current, DataRowView).Item("City").ToString
        txbState.Text = DirectCast(CustomerBindingSource1.Current, DataRowView).Item("State").ToString
        txbZipCode.Text = DirectCast(CustomerBindingSource1.Current, DataRowView).Item("Zip Code").ToString
        txbPhone.Text = DirectCast(CustomerBindingSource1.Current, DataRowView).Item("Phone Number").ToString

        lstRentalItems.Items.Clear()
        For Each item As RentedItems In myList
            description = Me.EquipmentTableAdapter.FillByDescriptionByID(Me.Winter_Sports_RentalsDataSet.Equipment, item.EquipmentID).ToString()
            lstRentalItems.Items.Add(item.EquipmentID.ToString() & "       " & item.Description & "       " & item.RentalFee.ToString("c2"))
        Next

        txbSubtotal.Text = subTotal.ToString("c2")
        txbTax.Text = tax.ToString("c2")
        txbInsuarance.Text = insurance.ToString("c2")
        txbDeposit.Text = deposit.ToString("c2")
        txbBalance.Text = balance.ToString("c2")
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs)
        Me.InvoicesTableAdapter.InsertQuery(custID, dueDate, "CC", Convert.ToDecimal(deposit), Convert.ToDecimal(insurance))
        Dim iNum As Integer = CInt(Me.InvoicesTableAdapter.InsertQuery(custID, dueDate, "CC", deposit, Convert.ToDecimal(rentalFee)))
        myList = Form1.itemsList
        For Each item As RentedItems In myList
            Me.Rental_ItemsTableAdapter.RentedItemsInsertQuery(iNum, EquipmentID, durTime, dueDate, rentalFee)
        Next
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class