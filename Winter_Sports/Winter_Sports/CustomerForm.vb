Public Class CustomerForm


    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomerTableAdapter.Fill(Winter_Sports_RentalsDataSet.Customer)

    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Winter_Sports_RentalsDataSet)
    End Sub

    Private Sub Zip_CodeTextBox_TextChanged(sender As Object, e As EventArgs) Handles Zip_CodeTextBox.TextChanged

    End Sub
End Class