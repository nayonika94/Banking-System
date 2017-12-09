'Copyright (c) 2009-2016 Dan Turk

#Region "Class / File Comment Header block"
'Program:            Banking
'File:               ClsCustomer.vb
'Author:             Nayonika Roy
'Description:        User Interface for the Banking project.
'Date:               
'                    2016 Oct 15
'                      
'                      - Variables declared, public 
'                           And private properties declared, Get/Set methods written And ToString methods written
'                       -special constructor made
'                     2016 Nov 15
'                       - added the method to calculate the age of the customer
'                       - made necessary attribute related changes
'                       
'Tier:               User Interface.
'Exceptions:         None Defined.
'Exception-Handling: None.
'Events:             None Defined.
'Event-Handling:     Regular User-Interface Events handled.   
#End Region 'Class / File Comment Header block

#Region "Option / Imports"
Option Explicit On      'Must declare variables before using them
Option Strict On        'Must perform explicit data type conversions
#End Region 'Option / Imports

Public Class Customer

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************

    'No Attributes are currently defined.

    '********** Module-level constants

    '********** Module-level variables
    Private mCustID As String
    Private mCustName As String
    Private mCustBirth As Date
    Private mCustAge As Integer
    Private mCustIsChild As Boolean
    Private mRefDate As Date



#End Region 'Attributes

#Region "Constructors"
    '******************************************************************
    'Constructors
    '******************************************************************

    'No Constructors are currently defined.
    'These are all public.

    '********** Default constructor
    '             - no parameters

    '********** Special constructor(s)
    '             - typically constructors have parameters 
    '               that are used to initialize attributes
    Public Sub New(ByVal pCustID As String,
                    ByVal pCustName As String,
                    ByVal pCustBirth As Date
                   )

        MyBase.New()

        _custID = pCustID
        _custName = pCustName
        _custBirth = pCustBirth
        _calculateAge()



    End Sub
    Public Sub New(ByVal pCustID As String,
                    ByVal pCustName As String,
                    ByVal pCustBirth As Date,
                    ByVal pRefDate As Date
                   )

        MyBase.New()

        _custID = pCustID
        _custName = pCustName
        _custBirth = pCustBirth

        _calculateAge(pRefDate)


    End Sub

    '********** Copy constructor(s)
    '             - one parameter, an object of the same class

#End Region 'Constructors

#Region "Get/Set Methods"
    '******************************************************************
    'Get/Set Methods
    '******************************************************************

    'No Get/Set Methods are currently defined.

    '********** Public Get/Set Methods
    '             - call private get/set methods to implement
    Public Property custID As String
        Get
            Return _custID
        End Get
        Set(pValue As String)
            mCustID = pValue
        End Set
    End Property
    Public Property custName As String
        Get
            Return _custName
        End Get
        Set(pValue As String)
            mCustName = pValue
        End Set
    End Property
    Public Property custBirth As Date
        Get
            Return _custBirth
        End Get
        Set(pValue As Date)
            mCustBirth = pValue
        End Set
    End Property
    Public Property custAge As Integer
        Get
            Return _custAge
        End Get
        Set(pValue As Integer)
            mCustAge = pValue
        End Set
    End Property
    Public Property custIsChild As Boolean
        Get
            Return _custIsChild
        End Get
        Set(pValue As Boolean)
            mCustIsChild = pValue
        End Set
    End Property

    Public Property refDate As Date
        Get
            Return _refDate
        End Get
        Set(pValue As Date)
            _refDate = pValue
        End Set
    End Property


    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)
    Private Property _custID As String
        Get
            Return mCustID
        End Get
        Set(pValue As String)
            mCustID = pValue
        End Set
    End Property
    Private Property _custName As String
        Get
            Return mCustName
        End Get
        Set(pValue As String)
            mCustName = pValue
        End Set
    End Property
    Private Property _custBirth As Date
        Get
            Return mCustBirth
        End Get
        Set(pValue As Date)
            mCustBirth = pValue
        End Set
    End Property
    Private Property _custAge As Integer
        Get
            Return mCustAge
        End Get
        Set(pValue As Integer)
            mCustAge = pValue
        End Set
    End Property
    Private Property _custIsChild As Boolean
        Get
            Return mCustIsChild
        End Get
        Set(pValue As Boolean)
            mCustIsChild = pValue
        End Set
    End Property
    Private Property _refDate As Date
        Get
            Return mRefDate
        End Get
        Set(pValue As Date)
            mRefDate = pValue
        End Set
    End Property

#End Region 'Get/Set Methods

#Region "Behavioral Methods"
    '******************************************************************
    'Behavioral Methods
    '******************************************************************

    'No Behavioral Methods are currently defined.

    '********** Public Shared Behavioral Methods

    '********** Private Shared Behavioral Methods

    '********** Public Non-Shared Behavioral Methods
    Public Overrides Function ToString() As String
        Return _toString()
    End Function
    '********** Private Non-Shared Behavioral Methods
    Private Function _toString() As String

        Dim tempstr As String


        tempstr =
        "( Customer:" _
            & "custID= '" & _custID & "'" _
            & ", custName = '" & _custName _
            & "', custBirth = '" & _custBirth _
            & "' custAge = '" & _custAge _
            & "', custIsChild = '" & _custIsChild & "'" _
            & " )"

        Return tempstr

    End Function
    ' method to calculate age based on birth date
    Private Function _calculateAge() As Long

        'calculating the age based on the date of birth
        mCustAge = Now.Year - mCustBirth.Year

        'determining whether a customer is a child or not based on their age
        If mCustAge <= 13 Then
            mCustIsChild = True
        Else
            mCustIsChild = False
        End If

    End Function '_calculateAge()

    Private Function _calculateAge(ByRef refDate As Date) As Long
        'calculating the age based on the date of birth
        mCustAge = refDate.Year - mCustBirth.Year

        'determining whether a customer is a child or not based on their age
        If mCustAge <= 13 Then
            mCustIsChild = True
        Else
            mCustIsChild = False
        End If

    End Function
#End Region 'Behavioral Methods

#Region "Event Procedures"
    '******************************************************************
    'Event Procedures
    '******************************************************************

    'No Event Procedures are currently defined.
    'These are all private.

    '********** User-Interface Event Procedures
    '             - Initiated explicitly by user

    '********** User-Interface Event Procedures
    '             - Initiated automatically by system

    '********** Business Logic Event Procedures
    '             - Initiated as a result of business logic
    '               method(s) running

#End Region 'Event Procedures

#Region "Events"
    '******************************************************************
    'Events
    '******************************************************************

    'No Events are currently defined.
    'These are all public.

#End Region 'Events

End Class 'Customer
