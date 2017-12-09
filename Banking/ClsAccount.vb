'Copyright (c) 2009-2016 Dan Turk

#Region "Class / File Comment Header block"
'Program:            Banking
'File:               ClsAccount.vb
'Author:             Nayonika Roy
'Description:        User Interface for the Banking project.
'Date:               
'                    2016 Oct 17
'                      - attributes declared, public 
'                       And private properties declared, specil constructors made,
'                       Get/Set methods written And ToString methods written
'                   2016 Nov 15
'                       - updated necessary attribute related changes
'
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


Public Class Account

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************

    'No Attributes are currently defined.

    '********** Module-level constants

    '********** Module-level variables
    Private mAccID As String
    Private mAccCustID As String
    Private mAccNumOwners As String
    Private mAccOwner() As Customer
    Private mAccName As String
    Private mAccDateOpened As Date
    Private mAccIsClosed As Boolean
    Private mAccBalance As Decimal
    Private mAccAPR As Decimal
    Private mAccAccrualDate As Date
    Private mAccType As AccountType
    Private mAccClosedDate As Date
    Private mAccTrxID As String
    Private mAccTrxLineID As String



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

    'Special constructor for modify account
    Public Sub New(ByVal pAccID As String,
                                    ByVal pAccOwner() As Customer,
                                    ByVal pAccName As String,
                                    ByVal pAccBalance As Decimal,
                                    ByVal pAccAPR As Decimal,
                                    ByVal pAccIsClosed As Boolean,
                                    ByVal pAccClosedDate As Date
                   )
        MyBase.New()

        _accID = pAccID
        _accIsClosed = pAccIsClosed
        _accClosedDate = pAccClosedDate
        _accOwner = pAccOwner
        _accName = pAccName
        _accBalance = pAccBalance
        _accAPR = pAccAPR

    End Sub
    'special constructor for the create account without the closing of account
    Public Sub New(ByVal pAccID As String,
                   ByVal pAccCustID As String,
                   ByVal pAccNumOwners As String,
                   ByVal pAccOwner() As Customer,
                   ByVal pAccType As AccountType,
                   ByVal pAccName As String,
                   ByVal pAccDateOpened As Date,
                   ByVal pAccBalance As Decimal,
                   ByVal pAccAPR As Decimal,
                   ByVal pAccTrxID As String,
                   ByVal pAccTrxLineID As String,
                   ByVal pAccAccrualDate As Date
                   )


        MyBase.New()

        _accID = pAccID
        _accCustID = pAccCustID
        _accNumOwners = pAccNumOwners
        _accOwner = pAccOwner
        _accType = pAccType
        _accName = pAccName
        _accDateOpened = pAccDateOpened
        _accTrxID = pAccTrxID
        _accTrxLineID = pAccTrxLineID
        _accBalance = pAccBalance
        _accAPR = pAccAPR
        _accAccrualDate = pAccAccrualDate



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
    Public Property accID As String
        Get
            Return _accID
        End Get
        Set(pValue As String)
            _accID = pValue

        End Set
    End Property

    Public Property accName As String
        Get
            Return _accName
        End Get
        Set(pValue As String)
            _accName = pValue

        End Set
    End Property
    Public Property accDateOpened As Date
        Get
            Return _accDateOpened
        End Get
        Set(pValue As Date)
            _accDateOpened = pValue

        End Set

    End Property


    Public Property accIsClosed As Boolean
        Get
            Return _accIsClosed
        End Get
        Set(pValue As Boolean)
            _accIsClosed = pValue

        End Set
    End Property



    Public Property accOwner() As Customer()
        Get
            Return _accOwner
        End Get
        Set(pValue As Customer())
            _accOwner = pValue

        End Set
    End Property

    Public Property accNumOwners As String
        Get
            Return _accNumOwners
        End Get
        Set(pValue As String)
            _accNumOwners = pValue

        End Set
    End Property
    Public Property accBalance As Decimal
        Get
            Return _accBalance
        End Get
        Set(pValue As Decimal)
            _accBalance = pValue

        End Set
    End Property
    Public Property accAPR As Decimal
        Get
            Return _accAPR
        End Get
        Set(pValue As Decimal)
            _accAPR = pValue

        End Set
    End Property
    Public Property accAccrualDate As Date
        Get
            Return _accAccrualDate
        End Get
        Set(pValue As Date)
            _accAccrualDate = pValue

        End Set
    End Property
    Public Property accType As AccountType
        Get
            Return _accType
        End Get
        Set(pValue As AccountType)
            _accType = pValue

        End Set
    End Property
    Public Property accClosedDate As Date
        Get
            Return _accClosedDate
        End Get
        Set(pValue As Date)
            _accClosedDate = pValue

        End Set
    End Property


    Public Property accCustID As String
        Get
            Return _accCustID
        End Get
        Set(pValue As String)
            _accCustID = pValue

        End Set
    End Property
    Public Property accTrxID As String
        Get
            Return _accTrxID
        End Get
        Set(pValue As String)
            _accTrxID = pValue

        End Set
    End Property
    Public Property accTrxLineID As String
        Get
            Return _accTrxLineID
        End Get
        Set(pValue As String)
            _accTrxLineID = pValue

        End Set
    End Property


    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)
    Private Property _accID As String
        Get
            Return mAccID
        End Get
        Set(pValue As String)
            mAccID = pValue
        End Set
    End Property
    Private Property _accName As String
        Get
            Return mAccName
        End Get
        Set(pValue As String)
            mAccName = pValue
        End Set
    End Property
    Private Property _accDateOpened As Date
        Get
            Return mAccDateOpened
        End Get
        Set(pValue As Date)
            mAccDateOpened = pValue
        End Set
    End Property

    Private Property _accIsClosed As Boolean
        Get
            Return mAccIsClosed
        End Get
        Set(pValue As Boolean)
            mAccIsClosed = pValue
        End Set
    End Property

    Private Property _accOwner As Customer()
        Get
            Return mAccOwner
        End Get
        Set(pValue As Customer())
            _setAccOwnerArray(pValue)
        End Set
    End Property


    Private Property _accNumOwners As String
        Get
            Return mAccNumOwners
        End Get
        Set(pValue As String)
            mAccNumOwners = pValue
        End Set
    End Property
    Private Property _accBalance As Decimal
        Get
            Return mAccBalance
        End Get
        Set(pValue As Decimal)
            mAccBalance = pValue
        End Set
    End Property
    Private Property _accAPR As Decimal
        Get
            Return mAccAPR
        End Get
        Set(pValue As Decimal)
            mAccAPR = pValue
        End Set
    End Property
    Private Property _accAccrualDate As Date
        Get
            Return mAccAccrualDate
        End Get
        Set(pValue As Date)
            mAccAccrualDate = pValue
        End Set
    End Property
    Private Property _accType As AccountType
        Get
            Return mAccType
        End Get
        Set(pValue As AccountType)
            mAccType = pValue
        End Set
    End Property

    Private Property _accClosedDate As Date
        Get
            Return mAccClosedDate
        End Get
        Set(pValue As Date)
            mAccClosedDate = pValue
        End Set
    End Property
    Private Property _accCustID As String
        Get
            Return mAccCustID
        End Get
        Set(pValue As String)
            mAccCustID = pValue
        End Set
    End Property
    Private Property _accTrxID As String
        Get
            Return mAccTrxID
        End Get
        Set(pValue As String)
            mAccTrxID = pValue
        End Set
    End Property
    Private Property _accTrxLineID As String
        Get
            Return mAccTrxLineID
        End Get
        Set(pValue As String)
            mAccTrxLineID = pValue
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
        "( Account:" _
            & "accID= '" & _accID & "'" _
            & "', accIsClosed = '" & _accIsClosed _
            & "', accClosedDate= '" & _accClosedDate _
            & "', accCustID = '" & _accCustID _
            & "', accOwner = '" & _accOwner.ToString _
            & "', accNumOwners = '" & _accNumOwners _
            & "', accType = '" & _accType _
            & ", accName = '" & _accName _
            & "', accDateOpened = '" & _accDateOpened _
            & "', accTrxID = '" & _accTrxID _
            & "', accTrxLineID = '" & _accTrxLineID _
            & "', accBalance = '" & _accBalance _
            & "', accAPR = '" & _accAPR _
            & "', accAccrualDate = '" & _accAccrualDate & "'" _
            & " )"

        Return tempstr

    End Function

    Private Function _setAccOwnerArray(ByVal pValue() As Customer) As Customer

        ReDim mAccOwner(pValue.Length - 1)

        Dim pLocationFound As Integer
        For pLocationFound = 0 To mAccOwner.Length - 1
            mAccOwner(pLocationFound) = pValue(pLocationFound)

        Next pLocationFound

    End Function

    Private Function _getOwnerArrayString(ByVal pValue As Customer()) As String

        Dim str As String
        Dim pLocationFound As Integer

        For pLocationFound = 0 To pValue.Length - 1
            str += pValue(pLocationFound).ToString
        Next pLocationFound

        Return str

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

End Class 'Account
