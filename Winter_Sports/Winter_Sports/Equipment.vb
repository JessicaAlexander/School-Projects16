Public Class Equipment
    Public Property EquipmentID As Integer
    Public Property Description As String
    Public Property PurchaseDate As Date
    Public Property PurchasePrice As Double
    Public Property Rented As Boolean
    Public Property Duration As Integer

    Enum DurationType
        OneDay
        TwoDay
        ThreeDay
        OneWeek
        TwoWeek
        ThreeWeek
    End Enum

    Enum EquipmentType
        Skis
        Ski_Bindings
        Ski_Boots
        Ski_Helment
        Ski_Goggels
        Ski_Backpack
    End Enum

    Private myPrices(,) As Double = {{"$25", "$35", "$70", "$140", "$270", "$320"},
                                 {"$25", "$35", "$70", "$140", "$270", "$320"},
                                 {"$25", "$35", "$70", "$140", "$270", "$320"},
                                 {"$25", "$35", "$70", "$140", "$270", "$320"},
                                 {"$35", "$45", "$90", "$180", "$310", "$400"},
                                 {"$35", "$45", "$90", "$180", "$310", "$400"},
                                 {"$35", "$45", "$90", "$180", "$310", "$400"},
                                 {"$35", "$45", "$90", "$180", "$310", "$400"},
                                 {"$15", "$30", "$45", "$90", "$150", "$230"},
                                 {"$15", "$30", "$45", "$90", "$150", "$230"},
                                 {"$15", "$30", "$45", "$90", "$150", "$230"},
                                 {"$15", "$30", "$45", "$90", "$150", "$230"},
                                 {"$30", "$60", "$120", "$170", "$250", "$370"},
                                 {"$30", "$60", "$120", "$170", "$250", "$370"},
                                 {"$30", "$60", "$120", "$170", "$250", "$370"},
                                 {"$30", "$60", "$120", "$170", "$250", "$370"},
                                 {"$15", "$30", "$45", "$90", "$220", "$310"},
                                 {"$15", "$30", "$45", "$90", "$220", "$310"},
                                 {"$15", "$30", "$45", "$90", "$220", "$310"},
                                 {"$15", "$30", "$45", "$90", "$220", "$310"},
                                 {"$30", "$65", "$90", "$150", "$200", "$270"},
                                 {"$30", "$65", "$90", "$150", "$200", "$270"},
                                 {"$30", "$65", "$90", "$150", "$200", "$270"},
                                 {"$30", "$65", "$90", "$150", "$200", "$270"}}

    Public Function GetRentalPrices(ByVal equip As EquipmentType, ByVal duration As DurationType) As Double
        Return myPrices(equip, duration)
    End Function
End Class
