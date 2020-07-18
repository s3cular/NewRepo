Option Strict On
Public Class carClass
#Region "Declaring Variable"

    Private carID As Integer = 0
    Shared carCount As Integer = 0
    Private carYear As Integer = 0
    Private carPrice As Decimal = 0.0D
    Private carMake As String = String.Empty
    Private carModel As String = String.Empty
    Private carNew As Boolean = False

#End Region

#Region "Methods of Property"
    Public ReadOnly Property IdentificationNumber() As Integer
        Get
            Return carID
        End Get
    End Property

    Public ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get
    End Property

    Public Property Year() As Integer
        Get
            Return carYear
        End Get
        Set(value As Integer)
            carYear = value
        End Set
    End Property

    Public Property Price() As Decimal
        Get
            Return carPrice
        End Get
        Set(value As Decimal)
            carPrice = value
        End Set
    End Property

    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(value As String)
            carMake = value
        End Set
    End Property

    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(value As String)
            carModel = value
        End Set
    End Property

    Public Property NewStatus() As Boolean
        Get
            Return carNew
        End Get
        Set(value As Boolean)
            carNew = value
        End Set
    End Property

    Friend Function GetCarData() As String
        Return IIf(carNew, "New ", "Used ").ToString & carYear & " " & carMake & " " & carModel & " for " & carPrice.ToString("c")
    End Function
#End Region

#Region "Constructors"
    Public Sub New()
        carID = carCount
        carCount += 1
    End Sub

    Friend Sub New(makeValue As String, modelValue As String, yearValue As Integer, priceValue As Decimal, carState As Boolean)
        Me.New()
        carMake = makeValue
        carModel = modelValue
        carYear = yearValue
        carPrice = priceValue
        carNew = carState
    End Sub

#End Region

End Class
