Public Class Form1
    Public itemsList As New List(Of RentedItems)
    Public rentalPrices As New Equipment
    Public Tax As Double
    Public Total As Double
    Public Deposit As Double
    Public Insurance As Double
    Public DueBack As Double
    Public RentalFee As Double
    Public NumOfDays As Integer
    Public startDate As Date
    Public DueDate As Date
    Public subtotal As Double = 0
    Public desc As String
    Public equipID As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Winter_Sports_RentalsDataSet.Rental_Items' table. You can move, or remove it, as needed.
        Me.Rental_ItemsTableAdapter.Fill(Me.Winter_Sports_RentalsDataSet.Rental_Items)
        'TODO: This line of code loads data into the 'Winter_Sports_RentalsDataSet.Invoices' table. You can move, or remove it, as needed.
        Me.InvoicesTableAdapter.Fill(Me.Winter_Sports_RentalsDataSet.Invoices)
        'TODO: This line of code loads data into the 'Winter_Sports_RentalsDataSet.Inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.Winter_Sports_RentalsDataSet.Inventory)
        'TODO: This line of code loads data into the 'Winter_Sports_RentalsDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.Winter_Sports_RentalsDataSet.Customer)
        'TODO: This line of code loads data into the 'Winter_Sports_RentalsDataSet.Equipment' table. You can move, or remove it, as needed.
        Me.EquipmentTableAdapter.Fill(Me.Winter_Sports_RentalsDataSet.Equipment)
        chkList_Equipment.Items.Add("Ski  $25  $35  $70  $140  $270  $320")
        chkList_Equipment.Items.Add("Ski  $25  $35  $70  $140  $270  $320")
        chkList_Equipment.Items.Add("Ski  $25  $35  $70  $140  $270  $320")
        chkList_Equipment.Items.Add("Ski  $25  $35  $70  $140  $270  $320")
        chkList_Equipment.Items.Add("Ski Bindings  $35  $45  $90  $180  $310  $400")
        chkList_Equipment.Items.Add("Ski Bindings  $35  $45  $90  $180  $310  $400")
        chkList_Equipment.Items.Add("Ski Bindings  $35  $45  $90  $180  $310  $400")
        chkList_Equipment.Items.Add("Ski Bindings  $35  $45  $90  $180  $310  $400")
        chkList_Equipment.Items.Add("Ski Boots  $15  $30  $45  $90  $150  $230")
        chkList_Equipment.Items.Add("Ski Boots  $15  $30  $45  $90  $150  $230")
        chkList_Equipment.Items.Add("Ski Boots  $15  $30  $45  $90  $150  $230")
        chkList_Equipment.Items.Add("Ski Boots  $15  $30  $45  $90  $150  $230")
        chkList_Equipment.Items.Add("Ski Helment  $30  $60  $120  $170  $250  $370")
        chkList_Equipment.Items.Add("Ski Helment  $30  $60  $120  $170  $250  $370")
        chkList_Equipment.Items.Add("Ski Helment  $30  $60  $120  $170  $250  $370")
        chkList_Equipment.Items.Add("Ski Helment  $30  $60  $120  $170  $250  $370")
        chkList_Equipment.Items.Add("Ski Goggles  $15  $30  $45  $90  $220  $310")
        chkList_Equipment.Items.Add("Ski Goggles  $15  $30  $45  $90  $220  $310")
        chkList_Equipment.Items.Add("Ski Goggles  $15  $30  $45  $90  $220  $310")
        chkList_Equipment.Items.Add("Ski Goggles  $15  $30  $45  $90  $220  $310")
        chkList_Equipment.Items.Add("Ski Backpack  $30  $65  $90  $150  $200  $270")
        chkList_Equipment.Items.Add("Ski Backpack  $30  $65  $90  $150  $200  $270")
        chkList_Equipment.Items.Add("Ski Backpack  $30  $65  $90  $150  $200  $270")
        chkList_Equipment.Items.Add("Ski Backpack  $30  $65  $90  $150  $200  $270")

        CBDuration.Items.Add("1 Day")
        CBDuration.Items.Add("2 Days")
        CBDuration.Items.Add("3 Days")
        CBDuration.Items.Add("1 Week")
        CBDuration.Items.Add("2 Weeks")
        CBDuration.Items.Add("3 Weeks")
    End Sub

    Private Sub llbWeather_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbWeather.LinkClicked
        WeatherForm.ShowDialog()
    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        If CBLiabilityWaiver.Checked Then

            If Not TBDeposit1.Text.Equals(String.Empty) Then

                If Not CBDuration.Text.Equals(String.Empty) Then

                    If chkList_Equipment.CheckedIndices.Count > 0 Then


                        Double.TryParse(TBDeposit1.SelectedText.ToString, Deposit)
                        Deposit = TBDeposit1.Text

                        Dim duration As Equipment.EquipmentType = CType(CBDuration.SelectedIndex, Equipment.EquipmentType)
                        Dim equipType As Equipment.EquipmentType


                        For Each Index As Integer In chkList_Equipment.CheckedIndices
                            If Index >= 0 And Index <= 3 Then
                                equipType = CType(Equipment.EquipmentType.Skis, Equipment.EquipmentType)
                            ElseIf Index >= 4 And Index <= 7 Then
                                equipType = CType(Equipment.EquipmentType.Ski_Bindings, Equipment.EquipmentType)
                            ElseIf Index >= 8 And Index <= 11 Then
                                equipType = CType(Equipment.EquipmentType.Ski_Boots, Equipment.EquipmentType)
                            ElseIf Index >= 12 And Index <= 15 Then
                                equipType = CType(Equipment.EquipmentType.Ski_Helment, Equipment.EquipmentType)
                            ElseIf Index >= 16 And Index <= 19 Then
                                equipType = CType(Equipment.EquipmentType.Ski_Goggels, Equipment.EquipmentType)
                            ElseIf Index >= 20 And Index <= 23 Then
                                equipType = CType(Equipment.EquipmentType.Ski_Backpack, Equipment.EquipmentType)
                            End If

                            Me.EquipmentTableAdapter.FillByDescriptionByID(Me.Winter_Sports_RentalsDataSet.Equipment, Index + 1)
                            If Not String.IsNullOrEmpty(LBLEquipID.Text) Then
                                equipID = Convert.ToInt32(LBLEquipID.Text)
                                Me.EquipmentTableAdapter.UpdateRentalStatus(equipID)
                                RentalFee = rentalPrices.GetRentalPrices(equipType, duration)
                                subtotal += rentalPrices.GetRentalPrices(equipType, duration)
                                desc = txbDescript.Text
                                'MessageBox.Show("ID: " & Index.ToString() & "desc: " & desc & " fee: " & RentalFee)
                                Dim anItem As New RentedItems(Index + 1, desc, RentalFee)
                                itemsList.Add(anItem)
                            Else
                                MessageBox.Show("No " & Index + 1 & " are available at this time.", "Unavialable for Rent")

                            End If
                        Next Index
                        lblTotalRentalFee1.Text = subtotal.ToString("C2")

                        Tax = subtotal * 0.0825
                        lblTax1.Text = Tax.ToString("C2")

                        If CBDamageIns.Checked Then
                            Insurance = subtotal * 0.1
                            lblInsurance1.Text = Insurance.ToString("C2")

                            Total = subtotal + Tax + Deposit + Insurance
                            lblTotalDue1.Text = Total.ToString("C2")

                            DueBack = Deposit
                            lblDueBack1.Text = DueBack.ToString("C2")

                            RentalFee = (subtotal + Tax + Deposit + Insurance) - Deposit
                            lblRentalFeeDue1.Text = RentalFee.ToString("C2")
                        End If

                        startDate = dtpCalender.Value
                        Select Case (CBDuration.SelectedIndex)
                            Case 0
                                DueDate = startDate.AddDays(1)
                                NumOfDays = 1
                            Case 1
                                DueDate = startDate.AddDays(2)
                                NumOfDays = 2
                            Case 2
                                DueDate = startDate.AddDays(3)
                                NumOfDays = 3
                            Case 3
                                DueDate = startDate.AddDays(7)
                                NumOfDays = 7
                            Case 4
                                DueDate = startDate.AddDays(14)
                                NumOfDays = 14
                            Case 5
                                DueDate = startDate.AddDays(21)
                                NumOfDays = 21
                        End Select
                        lblDueDate1.Text = DueDate

                    Else
                        MessageBox.Show("Please Select Equipment!")
                    End If
                Else
                    MessageBox.Show("Please select a duration!")
                End If
            Else
                MessageBox.Show("Please enter a deposit!")
            End If
        Else
            MessageBox.Show("Liability Waiver must be signed!")
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnNewCust_Click(sender As Object, e As EventArgs) Handles BtnNewCust.Click
        CustomerForm.Show()
    End Sub

    Private Sub Equipment1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Equipment1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Winter_Sports_RentalsDataSet)

    End Sub



    Private Sub Equipment1BindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Equipment1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Winter_Sports_RentalsDataSet)

    End Sub


    Private Sub Equipment1BindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Equipment1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Winter_Sports_RentalsDataSet)

    End Sub


    Private Sub Equipment1BindingNavigatorSaveItem_Click_3(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Equipment1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Winter_Sports_RentalsDataSet)

    End Sub

    Private Sub btnCompleteRental_Click(sender As Object, e As EventArgs) Handles btnCompleteRental.Click

        CheckOut.Show()
    End Sub

    Private Sub btnSearchCustomer_Click(sender As Object, e As EventArgs) Handles btnSearchCustomer.Click
        SearchCustomer.Show()
    End Sub

    Private Sub FillByIDToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub
End Class
