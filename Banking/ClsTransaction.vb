'Copyright (c) 2009-2016 Dan Turk

#Region "Class / File Comment Header block"
'Program:            Banking
'File:               ClsTransaction.vb
'Author:             Nayonika Roy
'Description:        User Interface for the Banking project.
'Date:               
'                    2016 Oct 18
'                      - attributes declared, public 
'                           And private properties declared, Get/Set methods written And ToString methods written
'                       - special constructors made for the three transaction tabs namely 
'                           makeDeposit/ withdrawal / useDebitCard / chargePurchase, makePayment/transferFunds 
'                           and accrueInterest   
'                   2016 Nov 15
'                   - updated necessary attribute related changes
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

Public Class Transaction

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************

    'No Attributes are currently defined.

    '********** Module-level constants

    '********** Module-level variables
    Private mTrxID As String
    Private mTrxLineID As String
    Private mTrxDateTime As Date
    Private mTrxType As TransactionType
    Private mTrxAmount As Decimal
    Private mToAccID As String
    Private mFromAccID As String
    Private mTrxCustID As String
    Private mTrxAccID As String
    Private mTrxLineIDPrefix As String
    Private mTrxIDStart As String
    Private mTrxIDPrefix As String
    Private mTrxLineIDStart As String
    Private mTrxAccType As String
    Private mFromTrxLineID As String
    Private mToTrxLineID As String

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
    'Special Constructor for MakePayment/TransferFunds
    Public Sub New(ByVal pTrxType As TransactionType,
                    ByVal pTrxCustID As String,
                    ByVal pTrxID As String,
                    ByVal pFromAccID As String,
                    ByVal pToAccID As String,
                    ByVal pFromTrxLineID As String,
                    ByVal pToTrxLineID As String,
                    ByVal pTrxAmount As Decimal,
                    ByVal pTrxDateTime As Date)
        MyBase.New()
        _trxType = pTrxType
        _trxCustID = pTrxCustID
        _trxID = pTrxID
        _fromAccID = pFromAccID
        _fromTrxLineID = pFromTrxLineID
        _toTrxLineID = pToTrxLineID
        _trxDateTime = pTrxDateTime
        '_customer = pCustomer
        '_account = pAccount

        _trxAmount = pTrxAmount

    End Sub
    'Special Constructor for MakeDeposit/MakeWithdrawal/UseDebitCard/ChargePurchase
    Public Sub New(ByVal pTrxType As TransactionType,
                                    ByVal pTrxCustID As String,
                                    ByVal pTrxID As String,
                                    ByVal pTrxAccID As String,
                                    ByVal pTrxLineID As String,
                                    ByVal pTrxAmount As Decimal,
                                    ByVal pTrxDateTime As Date)
        MyBase.New()
        _trxID = pTrxID
        _trxLineID = pTrxLineID
        _trxDateTime = pTrxDateTime
        _trxAccID = pTrxAccID
        _trxCustID = pTrxCustID
        _trxType = pTrxType
        _trxAmount = pTrxAmount

    End Sub
    'Special Constructor For AccrueInterest
    Public Sub New(ByRef pTrxType As TransactionType,
                    ByVal pTrxIDPrefix As String,
                    ByVal pTrxIDStart As String,
                    ByVal pTrxLineIDPrefix As String,
                    ByVal pTrxLineIDStart As String,
                    ByVal pTrxAccID As String,
                    ByVal pTrxID As String,
                    ByVal pTrxLineID As String)
        MyBase.New()
        _trxType = pTrxType
        _trxIDPrefix = pTrxIDPrefix
        _trxIDStart = pTrxIDStart
        _trxLineIDPrefix = pTrxLineIDPrefix
        _trxLineIDStart = pTrxLineIDStart
        _trxAccID = pTrxAccID
        _trxID = pTrxID
        _trxLineID = pTrxLineID



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
    Public Property trxID As String
        Get
            Return _trxID
        End Get
        Set(pValue As String)
            _trxID = pValue

        End Set
    End Property
    Public Property trxLineID As String
        Get
            Return _trxLineID
        End Get
        Set(pValue As String)
            _trxLineID = pValue

        End Set
    End Property
    Public Property fromTrxLineID As String
        Get
            Return _fromTrxLineID
        End Get
        Set(pValue As String)
            _fromTrxLineID = pValue

        End Set
    End Property
    Public Property toTrxLineID As String
        Get
            Return _toTrxLineID
        End Get
        Set(pValue As String)
            _toTrxLineID = pValue

        End Set
    End Property
    Public Property trxDateTime As DateTime
        Get
            Return _trxDateTime
        End Get
        Set(pValue As Date)
            _trxDateTime = pValue

        End Set
    End Property

    Public Property trxType As TransactionType
        Get
            Return _trxType
        End Get
        Set(pValue As TransactionType)
            _trxType = pValue

        End Set
    End Property
    Public Property trxAmount As Decimal
        Get
            Return _trxAmount
        End Get
        Set(pValue As Decimal)
            _trxAmount = pValue

        End Set
    End Property
    Public Property fromAccID As String
        Get
            Return _fromAccID
        End Get
        Set(pValue As String)
            _fromAccID = pValue

        End Set
    End Property
    Public Property toAccID As String
        Get
            Return _toAccID
        End Get
        Set(pValue As String)
            _toAccID = pValue

        End Set
    End Property
    Public Property trxAccID As String
        Get
            Return _trxAccID
        End Get
        Set(pValue As String)
            _trxAccID = pValue

        End Set
    End Property
    Public Property trxCustID As String
        Get
            Return _trxCustID
        End Get
        Set(pValue As String)
            _trxCustID = pValue

        End Set
    End Property
    Public Property trxLineIDPrefix As String
        Get
            Return _trxLineIDPrefix
        End Get
        Set(pValue As String)
            _trxLineIDPrefix = pValue

        End Set
    End Property
    Public Property trxLineIDStart As String
        Get
            Return _trxLineIDStart
        End Get
        Set(pValue As String)
            _trxLineIDStart = pValue

        End Set
    End Property

    Public Property trxIDPrefix As String
        Get
            Return _trxIDPrefix
        End Get
        Set(pValue As String)
            _trxIDPrefix = pValue

        End Set
    End Property
    Public Property trxIDStart As String
        Get
            Return _trxIDStart
        End Get
        Set(pValue As String)
            _trxIDStart = pValue

        End Set
    End Property

    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)
    Private Property _trxID As String
        Get
            Return mTrxID
        End Get
        Set(pValue As String)
            mTrxID = pValue
        End Set
    End Property
    Private Property _trxLineID As String
        Get
            Return mTrxLineID
        End Get
        Set(pValue As String)
            mTrxLineID = pValue
        End Set
    End Property

    Private Property _fromTrxLineID As String
        Get
            Return mFromTrxLineID
        End Get
        Set(pValue As String)
            mFromTrxLineID = pValue
        End Set
    End Property
    Private Property _toTrxLineID As String
        Get
            Return mToTrxLineID
        End Get
        Set(pValue As String)
            mToTrxLineID = pValue
        End Set
    End Property

    Private Property _trxDateTime As DateTime
        Get
            Return mTrxDateTime
        End Get
        Set(pValue As DateTime)
            mTrxDateTime = pValue
        End Set
    End Property
    'Private Property _customer As Customer
    '    Get
    '        Return mCustomer
    '    End Get
    '    Set(pValue As Customer)
    '        mCustomer = pValue
    '    End Set
    'End Property
    'Private Property _account As Account
    '    Get
    '        Return mAccount
    '    End Get
    '    Set(pValue As Account)
    '        mAccount = pValue
    '    End Set
    'End Property
    Private Property _trxType As TransactionType
        Get
            Return mTrxType
        End Get
        Set(pValue As TransactionType)
            mTrxType = pValue
        End Set
    End Property
    Private Property _trxAmount As Decimal
        Get
            Return mTrxAmount
        End Get
        Set(pValue As Decimal)
            mTrxAmount = pValue
        End Set
    End Property
    Private Property _fromAccID As String
        Get
            Return mFromAccID
        End Get
        Set(pValue As String)
            mFromAccID = pValue
        End Set
    End Property
    Private Property _toAccID As String
        Get
            Return mToAccID
        End Get
        Set(pValue As String)
            mToAccID = pValue
        End Set
    End Property
    Private Property _trxAccID As String
        Get
            Return mTrxAccID
        End Get
        Set(pValue As String)
            mTrxAccID = pValue
        End Set
    End Property
    Private Property _trxCustID As String
        Get
            Return mTrxCustID
        End Get
        Set(pValue As String)
            mTrxCustID = pValue
        End Set
    End Property
    Private Property _trxLineIDPrefix As String
        Get
            Return mTrxLineIDPrefix
        End Get
        Set(pValue As String)
            mTrxLineIDPrefix = pValue
        End Set
    End Property
    Private Property _trxLineIDStart As String
        Get
            Return mTrxLineIDStart
        End Get
        Set(pValue As String)
            mTrxLineIDStart = pValue
        End Set
    End Property
    Private Property _trxIDPrefix As String
        Get
            Return mTrxIDPrefix
        End Get
        Set(pValue As String)
            mTrxIDPrefix = pValue
        End Set
    End Property
    Private Property _trxIDStart As String
        Get
            Return mTrxIDStart
        End Get
        Set(pValue As String)
            mTrxIDStart = pValue
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
            "( Transaction:" _
             & "trxType= '" & _trxType _
              & "', trxCustID= '" & _trxCustID _
            & "', trxID= '" & _trxID _
             & "', trxAccID= '" & _trxAccID _
             & "', trxLineID = '" & _trxLineID _
        & "', FromAccID= '" & _fromAccID _
               & "', ToAccID= '" & _toAccID _
            & "', fromTrxLineID = '" & _fromTrxLineID _
            & "', toTrxLineID = '" & _toTrxLineID _
            & "', trxAmount = '" & _trxAmount _
            & "', trxDateTime = '" & _trxDateTime _
            & "', trxIDPrefix = '" & _trxIDPrefix _
            & "', trxIDStart = '" & _trxIDStart _
            & "', trxLineIDPrefix = '" & _trxLineIDPrefix _
            & "', trxLineIDStart = '" & _trxLineIDStart _
             & " )"

        Return tempstr

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

End Class 'Transaction
