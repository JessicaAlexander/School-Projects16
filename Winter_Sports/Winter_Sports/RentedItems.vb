Public Class RentedItems
    Public Property EquipmentID As Int64
    Public Property RentalFee As Double
    Public Property Description As String

    Sub New(equipID As Int64, desc As String, fee As Double)
        EquipmentID = equipID
        RentalFee = fee
        Description = desc
    End Sub

    Sub New()
        EquipmentID = 0
        RentalFee = 0.0
    End Sub
End Class
