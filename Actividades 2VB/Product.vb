Public Class Product
    Protected name As String
    Protected price As Decimal
    Protected quantity As Int32
    Protected category As String
    Protected description As String

    Public Property _Name As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property
    Public Property _Price As Decimal
        Get
            Return price
        End Get
        Set(value As Decimal)
            price = value
        End Set
    End Property
    Public Property _Quantity As Int32
        Get
            Return quantity
        End Get
        Set(value As Int32)
            quantity = value
        End Set
    End Property
    Public Property _Category As String
        Get
            Return category
        End Get
        Set(value As String)
            category = value
        End Set
    End Property
    Public Property _Description
        Get
            Return description
        End Get
        Set(value)
            description = value
        End Set
    End Property
    Public Sub New()
        name = String.Empty
        price = Nothing
        quantity = Nothing
        category = String.Empty
        description = String.Empty
    End Sub
    Public Sub New(name As String, price As Decimal, quantity As Int32, category As String, description As String)
        Me.name = name
        Me.price = price
        Me.quantity = quantity
        Me.category = category
        Me.description = description
    End Sub
    Public Overrides Function ToString() As String
        Return name & "," & "$" & price.ToString() & "," & category & "," & quantity.ToString() & "," & description
    End Function
End Class
