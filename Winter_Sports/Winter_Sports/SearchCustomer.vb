Public Class SearchCustomer
    Public custID As Integer = 0

    Private Sub SearchCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        'TODO: This line of code loads data into the 'Winter_Sports_RentalsDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.Winter_Sports_RentalsDataSet.Customer)

    End Sub

    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Winter_Sports_RentalsDataSet)

    End Sub

    Private Sub RBNew_CheckedChanged(sender As Object, e As EventArgs) Handles RBNew.CheckedChanged
        If RBNew.Checked = True Then
            CustomerForm.Show()
        End If
    End Sub

    Private Sub btnSearchByLastName_Click(sender As Object, e As EventArgs) Handles btnSearchByLastName.Click
        Dim lastName As String = String.Empty

        lastName = InputBox("Please enter customers lastname!", "Last Name")
        If Not lastName.Equals("") Then
            Me.CustomerTableAdapter.FillByName(Me.Winter_Sports_RentalsDataSet.Customer, lastName)
        End If

    End Sub

    Private Sub btnSearchByCustomerID_Click(sender As Object, e As EventArgs) Handles btnSearchByCustomerID.Click
        Dim strID As String = String.Empty
        strID = InputBox("Please enter customer's ID number!", "Customer ID")
        If Not strID.Equals("") Then
            Integer.TryParse(strID, custID)
            If custID = 0 Then
                MessageBox.Show("Invaid customer ID number, please try again", "Invaild customer ID")
            Else
                Me.CustomerTableAdapter.FillByName(Me.Winter_Sports_RentalsDataSet.Customer, custID)
            End If
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If CInt(CustomerDataGridView.SelectedRows(0).Cells(0).Value) > 0 Then
            custID = CInt(CustomerDataGridView.SelectedRows(0).Cells(0).Value)
            CheckOut.Show()
        Else
            MessageBox.Show("You must select a customer before clicking OK." & Chr(13) & "If you do not see the customer you are looking for " & Chr(13) & "click the 'Search Again' button.", "No Selection")
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class