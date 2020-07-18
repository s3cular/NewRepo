' Author: Smit Mangroliya
' Date: 17 July 2020
' Description: This class file is created for lab 4 NETD 2202. 
' Reference: The method of property is written from Austin's student list project.

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

    ''' <summary>
    ''' It returns car Identification number.
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property IdentificationNumber() As Integer
        Get
            Return carID
        End Get
    End Property

    ''' <summary>
    ''' it will return number of cars.
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get
    End Property

    ''' <summary>
    ''' it returns manufacture date of car
    ''' </summary>
    ''' <returns></returns>
    Public Property Year() As Integer
        Get
            Return carYear
        End Get
        Set(value As Integer)
            carYear = value
        End Set
    End Property

    ''' <summary>
    ''' it returns price of car
    ''' </summary>
    ''' <returns></returns>
    Public Property Price() As Decimal
        Get
            Return carPrice
        End Get
        Set(value As Decimal)
            carPrice = value
        End Set
    End Property

    ''' <summary>
    ''' it returns company of car.
    ''' </summary>
    ''' <returns></returns>
    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(value As String)
            carMake = value
        End Set
    End Property

    ''' <summary>
    ''' it returns model of car.
    ''' </summary>
    ''' <returns></returns>
    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(value As String)
            carModel = value
        End Set
    End Property

    ''' <summary>
    ''' it returns value of, if car is new or used
    ''' </summary>
    ''' <returns></returns>
    Public Property NewStatus() As Boolean
        Get
            Return carNew
        End Get
        Set(value As Boolean)
            carNew = value
        End Set
    End Property

    ''' <summary>
    ''' it returns a string which describe the car.
    ''' </summary>
    ''' <returns></returns>
    Friend Function GetCarData() As String
        Return IIf(carNew, "New ", "Used ").ToString & carYear & " " & carMake & " " & carModel & " for " & carPrice.ToString
    End Function
#End Region

#Region "Constructors"

    ''' <summary>
    ''' it increases the car count
    ''' </summary>
    Public Sub New()
        carID = carCount
        carCount += 1
    End Sub

    ''' <summary>
    ''' private variable 
    ''' </summary>
    ''' <param name="makeValue"></param>
    ''' <param name="modelValue"></param>
    ''' <param name="yearValue"></param>
    ''' <param name="priceValue"></param>
    ''' <param name="carState"></param>
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
