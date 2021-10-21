'Author: Casey Bement
'Purpose: Manage the Person
'Date: 10/19/2021

Option Strict On
Option Explicit On
Public Class Person
    'Define Class or Module Level Variables
    Private intPersonID As Integer
    Private strName As String
    Private dblCarbohydrates As Double
    Private dblCurrentBloodSugar As Double
    Private dblInsulinToCarbRatio As Double
    Private strMeal As String
    Private strInsulinUnitsToGive As String
    Private strFormulaOutput As String
    Private dteDoseDateGiven As DateTime



    Public Property PersonID As Integer
        Get
            Return intPersonID
        End Get
        Set(ByVal intValue As Integer)
            intPersonID = intValue
        End Set
    End Property

    Public Property Name As String
        Get
            Return strName
        End Get
        Set(ByVal strValue As String)
            strName = strValue
        End Set
    End Property

    Public Property Carbohydrates As Double
        Get
            Return dblCarbohydrates
        End Get
        Set(ByVal dblValue As Double)
            dblCarbohydrates = dblValue
        End Set
    End Property

    Public Property CurrentBloodSugar As Double
        Get
            Return dblCurrentBloodSugar
        End Get
        Set(ByVal dblValue As Double)
            dblCurrentBloodSugar = dblValue
        End Set
    End Property

    Public Property InsulinToCarbRatio As Double
        Get
            Return dblInsulinToCarbRatio
        End Get
        Set(ByVal dblValue As Double)
            dblInsulinToCarbRatio = dblValue
        End Set
    End Property

    Public Property Meal As String
        Get
            Return strMeal
        End Get
        Set(ByVal strValue As String)
            strMeal = strValue
        End Set
    End Property

    Public Property InsulinUnitsToGive As String
        Get
            Return strInsulinUnitsToGive
        End Get
        Set(ByVal strValue As String)
            strInsulinUnitsToGive = strValue
        End Set
    End Property

    Public Property FormulaOutput As String
        Get
            Return strFormulaOutput
        End Get
        Set(ByVal strValue As String)
            strFormulaOutput = strValue
        End Set
    End Property

    Public Property DoseDateGiven As DateTime
        Get
            Return dteDoseDateGiven
        End Get
        Set(ByVal dteValue As DateTime)
            dteDoseDateGiven = dteValue
        End Set
    End Property

    'Default Constructor
    Public Sub New()
        intPersonID = 0
        strName = String.Empty
        dblCarbohydrates = 0
        dblCurrentBloodSugar = 0
        dblInsulinToCarbRatio = 0
        strMeal = String.Empty
        strInsulinUnitsToGive = String.Empty
        strFormulaOutput = String.Empty
        dteDoseDateGiven = Date.Now



    End Sub

    'Overload Constructors
    Public Sub New(ByVal PersonID As Integer)
        intPersonID = PersonID
        strName = String.Empty
        dblCarbohydrates = 0
        dblCurrentBloodSugar = 0
        dblInsulinToCarbRatio = 0
        strMeal = String.Empty
        strInsulinUnitsToGive = String.Empty
        strFormulaOutput = String.Empty
        dteDoseDateGiven = Date.Now
    End Sub







End Class
