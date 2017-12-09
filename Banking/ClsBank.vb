Option Explicit On      'Must declare variables before using them
Option Strict On        'Must perform explicit data type conversions
'Copyright (c) 2009-2016 Dan Turk

#Region "Class / File Comment Header block"
'Program:            Banking
'File:               ClasBank.vb
'Author:             Nayonika Roy
'Description:        User Interface for the Banking project.
'Date:               
'                    2016 Oct 18
'                      - create methods written
'                      - Variables declared, public 
'                           And private properties declared, Get/Set methods written And ToString methods written
'                      -special constructors made
'                    2016 Nov 14
'                      - written public and private implementation of the events
'                      - declared all the necessary events 
'                    2016 Nov 30
'                      - cleaned up code from previous submission
'                    2016 Dec 4
'                      - added the arrays for customer and account
'                    2016 Dec 6
'                       - added the arrays for transaction
'                       - added methods to find customers, accounts and transactions
'                    2016 Dec 7
'                       - added the functionality for updating the name, interest rate
'                    2016 Dec 8
'                       - worked on the interest calculation
'                    2016 Dec 9
'                       - tested the code to clean up and verify if the functions are working properly
'Tier:               User Interface and Business Logic
'Exceptions:         None Defined.
'Exception-Handling: None.
'Events:             None Defined.
'Event-Handling:     Regular User-Interface Events handled.
#End Region 'Class / File Comment Header block

#Region "Option / Imports"
Imports Banking
#End Region 'Option / Imports

Public Class Bank

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************

    'No Attributes are currently defined.

    '********** Module-level constants
    Private Const mARRAY_SIZE_DEFAULT As Integer = 5
    Private Const mARRAY_INCREMENT_DEFAULT As Integer = 5
    Private Const mARRAY_SIZE_DEFAULT_STRING As Integer = 5
    Private Const mARRAY_INCREMENT_DEFAULT_STRING As Integer = 5
    '********** Module-level variables
    Private mBankName As String
    Private mNumCustomers As Integer
    Private mNumAccounts As Integer
    Private mNumTransactions As Integer
    Private mNumStringData As Integer
    Private mCustomer() As Customer
    Private mAccount() As Account
    Private mTransaction() As Transaction
    Private mStringData() As String
    Private mMaxCustomer As Integer
    Private mMaxAccount As Integer
    Private mMaxTransaction As Integer
    Private mMaxStringData As Integer

#End Region 'Attributes

#Region "Constructors"
    '******************************************************************
    'Constructors
    '******************************************************************

    'No Constructors are currently defined.
    'These are all public.

    '********** Default constructor
    '             - no parameters
    Public Sub New()
        MyBase.New()
    End Sub
    '********** Special constructor(s)

    Public Sub New(ByVal pBankName As String,
                   ByVal pNumCustomers As Integer,
                   ByVal pNumAccounts As Integer,
                   ByVal pNumTransactions As Integer)
        MyBase.New()
        _bankName = pBankName
        _numCustomers = pNumCustomers
        _numAccounts = pNumAccounts
        _numTransactions = pNumTransactions
        'array for keeping track of customers
        _maxCustomer = _ARRAY_SIZE_DEFAULT
        ReDim mCustomer(_maxCustomer - 1)
        _numCustomers = 0
        'array for keeping track of accounts
        _maxAccount = _ARRAY_SIZE_DEFAULT
        ReDim mAccount(_maxAccount - 1)
        _numAccounts = 0
        'array for keeping track of transactions
        _maxTransaction = _ARRAY_SIZE_DEFAULT
        ReDim mTransaction(_maxTransaction - 1)
        _numTransactions = 0
        'array for keeping track of the customer data for writing into file
        _maxStringData = _ARRAY_SIZE_DEFAULT_STRING
        ReDim mStringData(_maxStringData - 1)
        _numStringData = 0
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

    Public Property bankName As String
        Get
            Return _bankName
        End Get
        Set(pValue As String)
            _bankName = pValue

        End Set
    End Property
    Public Property numCustomers As Integer
        Get
            Return _numCustomers
        End Get
        Set(pValue As Integer)
            _numCustomers = pValue

        End Set
    End Property
    Public Property numAccounts As Integer
        Get
            Return _numAccounts
        End Get
        Set(pValue As Integer)
            _numAccounts = pValue

        End Set
    End Property
    Public Property numTransactions As Integer
        Get
            Return _numTransactions
        End Get
        Set(pValue As Integer)
            _numTransactions = pValue

        End Set
    End Property
    Public Property numStringData As Integer
        Get
            Return _numStringData
        End Get
        Set(pValue As Integer)
            _numStringData = pValue
        End Set
    End Property

    Public Property maxCustomer As Integer
        Get
            Return _maxCustomer
        End Get
        Set(pValue As Integer)
            _maxCustomer = pValue
        End Set
    End Property
    Public Property maxAccount As Integer
        Get
            Return _maxAccount
        End Get
        Set(pValue As Integer)
            _maxAccount = pValue
        End Set
    End Property
    Public Property maxTransaction As Integer
        Get
            Return _maxTransaction
        End Get
        Set(pValue As Integer)
            _maxTransaction = pValue
        End Set
    End Property
    Public Property maxStringData As Integer
        Get
            Return _maxStringData
        End Get
        Set(pValue As Integer)
            _maxStringData = pValue
        End Set
    End Property

    Public Property stringData() As String()
        Get
            Return _stringData
        End Get
        Set(pValue As String())
            _stringData = pValue
        End Set
    End Property
    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)
    Private Property _bankName As String
        Get
            Return mBankName
        End Get
        Set(pValue As String)
            mBankName = pValue
        End Set
    End Property
    Private Property _numCustomers As Integer
        Get
            Return mNumCustomers
        End Get
        Set(pValue As Integer)
            mNumCustomers = pValue
        End Set
    End Property
    Private Property _numAccounts As Integer
        Get
            Return mNumAccounts
        End Get
        Set(pValue As Integer)
            mNumAccounts = pValue
        End Set
    End Property
    Private Property _numTransactions As Integer
        Get
            Return mNumTransactions
        End Get
        Set(pValue As Integer)
            mNumTransactions = pValue
        End Set
    End Property
    Private Property _maxCustomer As Integer
        Get
            Return mMaxCustomer
        End Get
        Set(pValue As Integer)
            mMaxCustomer = pValue
        End Set
    End Property
    Private Property _maxAccount As Integer
        Get
            Return mMaxAccount
        End Get
        Set(pValue As Integer)
            mMaxAccount = pValue
        End Set
    End Property
    Private Property _maxTransaction As Integer
        Get
            Return mMaxTransaction
        End Get
        Set(pValue As Integer)
            mMaxTransaction = pValue
        End Set
    End Property
    Private Property _stringData As String()
        Get
            Return mStringData
        End Get
        Set(pValue As String())
        End Set
    End Property
    Private Property _numStringData As Integer
        Get
            Return mNumStringData
        End Get
        Set(pValue As Integer)
            mNumStringData = pValue
        End Set
    End Property
    Private Property _maxStringData As Integer
        Get
            Return mMaxStringData
        End Get
        Set(pValue As Integer)
            mMaxStringData = pValue
        End Set
    End Property
    Private ReadOnly Property _ARRAY_SIZE_DEFAULT As Integer
        Get
            Return mARRAY_SIZE_DEFAULT
        End Get
    End Property

    Private ReadOnly Property _ARRAY_INCREMENT_DEFAULT As Integer
        Get
            Return mARRAY_INCREMENT_DEFAULT
        End Get
    End Property

    Private ReadOnly Property _ARRAY_SIZE_DEFAULT_STRING As Integer
        Get
            Return mARRAY_SIZE_DEFAULT_STRING
        End Get
    End Property


    Private ReadOnly Property _ARRAY_INCREMENT_DEFAULT_STRING As Integer
        Get
            Return mARRAY_INCREMENT_DEFAULT_STRING
        End Get
    End Property

    Private Property _ithCustomer(ByVal pI As Integer) As Customer

        Get
            If pI >= 0 And pI < _maxCustomer Then
                Return mCustomer(pI)
            Else
                Throw New IndexOutOfRangeException
            End If
        End Get
        Set(ByVal pvalue As Customer)
            If pI >= 0 And pI < _maxCustomer Then
                mCustomer(pI) = pvalue
            Else
                Throw New IndexOutOfRangeException
            End If
        End Set
    End Property

    Private Property _ithAccount(ByVal pI As Integer) As Account

        Get
            If pI >= 0 And pI < _maxAccount Then
                Return mAccount(pI)
            Else
                Throw New IndexOutOfRangeException
            End If
        End Get
        Set(ByVal pvalue As Account)
            If pI >= 0 And pI < _maxAccount Then
                mAccount(pI) = pvalue
            Else
                Throw New IndexOutOfRangeException
            End If
        End Set
    End Property

    Private Property _ithTransaction(ByVal pI As Integer) As Transaction

        Get
            If pI >= 0 And pI < _maxTransaction Then
                Return mTransaction(pI)
            Else
                Throw New IndexOutOfRangeException
            End If
        End Get
        Set(ByVal pvalue As Transaction)
            If pI >= 0 And pI < _maxTransaction Then
                mTransaction(pI) = pvalue
            Else
                Throw New IndexOutOfRangeException
            End If
        End Set
    End Property

    Private Property _ithStringData(ByVal pI As Integer) As String

        Get
            If pI >= 0 And pI < _maxStringData Then
                Return mStringData(pI)
            Else
                Throw New IndexOutOfRangeException
            End If
        End Get
        Set(ByVal pvalue As String)
            If pI >= 0 And pI < _maxStringData Then
                mStringData(pI) = pvalue
            Else
                Throw New IndexOutOfRangeException
            End If
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

    Public Function createCustomer(
            ByVal pCustID As String,
            ByVal pCustName As String,
            ByVal pCustBirth As Date
            ) _
        As _
            Customer

        Return _createCustomer(pCustID, pCustName, pCustBirth)

    End Function 'createCustomer(pCustID, pCustName, pCustBirth)

    Public Function createCustomerWithRefDate(
          ByVal pCustId As String,
          ByVal pCustName As String,
          ByVal pBirthDate As Date,
          ByVal pRefDate As Date
          ) _
      As _
          Customer

        Return _createCustomerWithRefDate(pCustId, pCustName, pBirthDate, pRefDate)

    End Function 'createCustomerWithRefDate
    Public Function createAccount(ByVal pAccID As String,
                                    ByVal pCustID As String,
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
                        ) _
        As _
            Account

        Return _createAccount(pAccID, pCustID, pAccNumOwners, pAccOwner, pAccType, pAccName, pAccDateOpened, pAccBalance, pAccAPR, pAccTrxID, pAccTrxLineID, pAccAccrualDate)

    End Function 'createAccount(pAccID, pCustID, pAccType, pAccName, pAccDateOpened, pAccBalance, pAccAPR, pAccTrxID, pAccTrxLineID, pAccAccrualDate)

    Public Function modifyAccount(ByVal pAccID As String,
                                   ByVal pAccOwner() As Customer,
                                    ByVal pAccName As String,
                                    ByVal pAccAPR As Decimal,
                                    ByVal pIsClosed As Boolean,
                                    ByVal pClosedDate As Date
            ) _
        As _
            Account

        Return _modifyAccount(pAccID, pAccOwner, pAccName, pAccAPR, pIsClosed, pClosedDate)

    End Function 'modifyAccount(pAccID, pCustID, pAccType, pAccName, pAccDateOpened, pAccBalance, pAccAPR, pAccTrxID, pAccTrxLineID, pAccAccrualDate, pIsClosed, pClosedDate)

    Public Function depositMade(ByVal pTrxType As TransactionType,
            ByVal pCustID As String,
            ByVal pTrxID As String,
            ByVal pAccID As String,
            ByVal pTrxLineID As String,
            ByVal pTrxAmt As Decimal,
            ByVal pTrxDate As Date
            ) _
        As _
            Transaction

        Return _depositMade(pTrxType, pCustID, pTrxID, pAccID, pTrxLineID, pTrxAmt, pTrxDate)

    End Function 'depositMade(pTrxType, pCustID, pTrxID, pAccID, pTrxLineID, pTrxAmt, pTrxDate)

    Public Function withdrawalMade(ByVal pTrxType As TransactionType,
            ByVal pCustID As String,
            ByVal pTrxID As String,
            ByVal pAccID As String,
            ByVal pTrxLineID As String,
            ByVal pTrxAmt As Decimal,
            ByVal pTrxDate As Date
            ) _
        As _
            Transaction

        Return _withdrawalMade(pTrxType, pCustID, pTrxID, pAccID, pTrxLineID, pTrxAmt, pTrxDate)

    End Function 'withdrawalMade(pTrxType, pCustID, pTrxID, pAccID, pTrxLineID, pTrxAmt, pTrxDate)

    Public Function debitCardUsed(ByVal pTrxType As TransactionType,
            ByVal pCustID As String,
            ByVal pTrxID As String,
            ByVal pAccID As String,
            ByVal pTrxLineID As String,
            ByVal pTrxAmt As Decimal,
            ByVal pTrxDate As Date
            ) _
        As _
            Transaction

        Return _debitCardUsed(pTrxType, pCustID, pTrxID, pAccID, pTrxLineID, pTrxAmt, pTrxDate)

    End Function 'debitCardUsed(pTrxType, pCustID, pTrxID, pAccID, pTrxLineID, pTrxAmt, pTrxDate)

    Public Function purchaseCharged(ByVal pTrxType As TransactionType,
            ByVal pCustID As String,
            ByVal pTrxID As String,
            ByVal pAccID As String,
            ByVal pTrxLineID As String,
            ByVal pTrxAmt As Decimal,
            ByVal pTrxDate As Date
            ) _
        As _
            Transaction

        Return _purchaseCharged(pTrxType, pCustID, pTrxID, pAccID, pTrxLineID, pTrxAmt, pTrxDate)

    End Function 'purchaseCharged(pTrxType, pCustID, pTrxID, pAccID, pTrxLineID, pTrxAmt, pTrxDate)

    Public Function paymentMade(ByVal pTrxType As TransactionType,
            ByVal pCustID As String,
            ByVal pTrxID As String,
            ByVal pFromAccID As String,
            ByVal pToAccID As String,
            ByVal pFromTrxLineID As String,
            ByVal pToTrxLineID As String,
            ByVal pTrxAmt As Decimal,
            ByVal pTrxDate As Date
            ) _
        As _
            Transaction

        Return _paymentMade(pTrxType, pCustID, pTrxID, pFromAccID, pToAccID, pFromTrxLineID, pToTrxLineID, pTrxAmt, pTrxDate)

    End Function 'paymentMade(pTrxType, pCustID, pTrxID, pFromAccID, pToAccID, pTrxLineID, pTrxAmt, pTrxDate)

    Public Function fundsTransferred(ByVal pTrxType As TransactionType,
            ByVal pCustID As String,
            ByVal pTrxID As String,
            ByVal pFromAccID As String,
            ByVal pToAccID As String,
            ByVal pFromTrxLineID As String,
            ByVal pToTrxLineID As String,
            ByVal pTrxAmt As Decimal,
            ByVal pTrxDate As Date
            ) _
        As _
            Transaction

        Return _fundsTransferred(pTrxType, pCustID, pTrxID, pFromAccID, pToAccID, pFromTrxLineID, pToTrxLineID, pTrxAmt, pTrxDate)

    End Function 'fundsTransferred(pTrxType, pCustID, pTrxID, pFromAccID, pToAccID, pTrxLineID, pTrxAmt, pTrxDate)

    Public Function accrualCalculation(ByVal pTrxAccType As TransactionType,
                                        ByVal pTrxIDPrefix As String,
                                        ByVal pTrxIDStart As String,
                                        ByVal pTrxLineIDPrefix As String,
                                        ByVal pTrxLineIDStart As String,
                                        ByVal pTrxAccID As String,
                                        ByVal pTrxID As String,
                                        ByVal pTrxLineID As String) _
       As _
       Transaction


        Return _accrualCalculation(pTrxAccType, pTrxIDPrefix, pTrxIDStart, pTrxLineIDPrefix, pTrxLineIDStart, pTrxAccID, pTrxID, pTrxLineID)

    End Function '_accrueInterest(pTrxAccType, pTrxIDPrefix, pTrxIDStart, pTrxLineIDPrefix, pTrxLineIDStart, pTrxAccID, pTrxID, pTrxLineID)

    Public Function findCustomer(ByVal pCustomerToFind As String) As Customer

        Dim locationFound As Integer

        Return _findCustomer(pCustomerToFind, locationFound)

    End Function 'findCustomer(pCustomerToFind)

    Public Function findAccount(ByVal pAccountToFind As String) As Account

        Dim locationFound As Integer

        Return _findAccount(pAccountToFind, locationFound)

    End Function 'findAccount(pAccountToFind)

    Public Function findTransaction(ByVal pTransactionToFind As String) As Transaction

        Dim locationFound As Integer

        Return _findTransaction(pTransactionToFind, locationFound)

    End Function 'findTransaction(pTransactionToFind)

    Public Function findTransactionLine(ByVal pTransactionToFind As String) As Transaction

        Dim locationFound As Integer

        Return _findTransactionLine(pTransactionToFind, locationFound)

    End Function 'findTransactionLine(pTransactionToFind)

    Public Iterator Function iterateCustomer() _
        As _
            IEnumerable

        Dim theObject As Object

        For Each theObject In _iterateCustomer()
            Yield theObject
        Next theObject

    End Function 'iterateCustomer()
    Public Iterator Function iterateAccount() _
        As _
            IEnumerable

        Dim theObject As Object

        For Each theObject In _iterateAccount()
            Yield theObject
        Next theObject

    End Function 'iterateAccount()

    Public Iterator Function iterateTransaction() _
        As _
            IEnumerable

        Dim theObject As Object

        For Each theObject In _iterateTransaction()
            Yield theObject
        Next theObject

    End Function 'iterateTransaction()

    Public Function addOwner(ByVal pDateTime As Date,
                              ByVal pCustID As String,
                              ByVal pAccID As String) As Boolean

        Return _addOwner(pDateTime, pCustID, pAccID)

    End Function 'addOwner(pItemToFind)

    Public Function updateName(ByVal theAccount As Account,
                                ByVal pAccName As String) As Account

        Return _updateName(theAccount, pAccName)
    End Function 'updateName
    Public Function updateAPR(ByVal theAccount As Account,
                                ByVal pAccAPR As Decimal) As Account

        Return _updateAPR(theAccount, pAccAPR)
    End Function 'updateAPR

    Public Function nextAccrualDate(ByVal pAccDateOpened As Date) As Date

        Return _nextAccrualDate(pAccDateOpened)
    End Function 'nextAccrualDate
    Public Function closeAccount(ByVal theAccount As Account
       ) _
 As _
 Account

        Return _closeAccount(theAccount)
    End Function 'closeAccount
    Public Function updateStringArray(ByVal theString As String
       ) _
 As _
 String

        Return _updateStringArray(theString)

    End Function 'updateStringArray
    '********** Private Non-Shared Behavioral Methods
    Private Function _toString() As String

        Dim tempstr As String

        tempstr =
        "( Bank:" _
            & "bankName = '" & _bankName & "')"

        Return tempstr

    End Function

    'creating new customers
    Private Function _createCustomer(
            ByVal pCustId As String,
            ByVal pCustName As String,
            ByVal pCustBirth As Date
            ) _
        As _
            Customer

        Dim theCustomer As Customer

        theCustomer = New Customer(pCustId, pCustName, pCustBirth)
        'update the customer array with the new customer
        If _numCustomers >= _maxCustomer Then
            _maxCustomer += _ARRAY_INCREMENT_DEFAULT
            ReDim Preserve mCustomer(_maxCustomer - 1)
        End If

        Try
            _ithCustomer(_numCustomers) = theCustomer
        Catch ex As Exception
            Throw New IndexOutOfRangeException
        End Try
        'incrementing number of customers by 1
        _numCustomers += 1
        'preparing the customer string to update the String Array
        theCustomer.refDate = Date.Now()
        Dim theString As String
        theString = theCustomer.refDate.ToString("yyyyMMdd") + "; " + theCustomer.refDate.ToString("HHmm") + "; Customer;" + "Create; " + theCustomer.custID + " ; " + theCustomer.custName + " ; " + theCustomer.custBirth.ToString("yyyyMMdd") & vbCrLf
        _updateStringArray(theString)
        'raising the event for the create customer
        RaiseEvent Bank_CustomerAdded(
            Me,
            New Customer_EventArgs_CustomerAdded(
                theCustomer
                )
            )
        RaiseEvent Bank_ChangedMetrics(
            Me,
            New Customer_EventArgs_CustomerAdded(
                theCustomer
                )
            )

        Return theCustomer

    End Function '_createCustomer(pCustID, pCustName, pCustBirth)
    Private Function _createCustomerWithRefDate(
            ByVal pCustId As String,
            ByVal pCustName As String,
            ByVal pBirthDate As Date,
            ByVal pRefDate As Date
            ) _
        As _
            Customer

        Dim theCustomer As Customer

        theCustomer = New Customer(pCustId, pCustName, pBirthDate, pRefDate)
        'update the customer array with the new customer
        If _numCustomers >= _maxCustomer Then
            _maxCustomer += _ARRAY_INCREMENT_DEFAULT
            ReDim Preserve mCustomer(_maxCustomer - 1)
        End If

        Try
            _ithCustomer(_numCustomers) = theCustomer
        Catch ex As Exception
            Throw New IndexOutOfRangeException
        End Try

        'it keeps tracks of total no. of customer
        _numCustomers += 1
        'preparing the customer string to update the String Array
        Dim theString As String
        theString = theCustomer.refDate.ToString("yyyyMMdd") + "; " + theCustomer.refDate.ToString("HHmm") + "; Customer;" + "Create; " + theCustomer.custID + " ; " + theCustomer.custName + " ; " + theCustomer.custBirth.ToString("yyyyMMdd") & vbCrLf
        _updateStringArray(theString)
        'event is raised from here and its handeled in frmMain
        RaiseEvent Bank_CustomerAdded(
            Me,
            New Customer_EventArgs_CustomerAdded(
                theCustomer
                )
            )
        RaiseEvent Bank_ChangedMetrics(
            Me,
            New Customer_EventArgs_CustomerAdded(
                theCustomer
                )
            )

        Return theCustomer

    End Function '_createCustomerWithRefDate

    'creating new accounts
    Private Function _createAccount(
            ByVal pAccID As String,
                   ByVal pCustID As String,
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
                   ) _
        As _
            Account

        Dim theAccount As Account
        Dim theTransaction As Transaction

        theAccount = New Account(pAccID, pCustID, pAccNumOwners, pAccOwner, pAccType, pAccName, pAccDateOpened, pAccBalance, pAccAPR, pAccTrxID, pAccTrxLineID, pAccAccrualDate)
        'update the account array
        If _numAccounts >= _maxAccount Then
            _maxAccount += _ARRAY_INCREMENT_DEFAULT
            ReDim Preserve mAccount(_maxAccount - 1)
        End If

        Try
            _ithAccount(_numAccounts) = theAccount
        Catch ex As Exception
            Throw New IndexOutOfRangeException
        End Try

        'when an account is created with an initial balance it is processed as a deposit made into the account
        theTransaction = _depositMade(TransactionType.MakeDeposit, pAccOwner(0).custID, pAccTrxID, pAccID, pAccTrxLineID, pAccBalance, pAccDateOpened)

        'incrementing the number of accounts and transactions by 1
        _numAccounts += 1

        Dim accountType As String
        If theAccount.accType.ToString = "Checking" Then
            accountType = "Checking"
        ElseIf theAccount.accType.ToString = "Credit Card" Then
            accountType = "CreditCard"
        Else
            accountType = "Loan"
        End If
        'preparing the account string to update the String Array
        Dim theString As String
        theString = theAccount.accDateOpened.ToString("yyyyMMdd") + "; " + theAccount.accDateOpened.ToString("HHmm") + "; Account ; Open ;" + accountType + "; " + theAccount.accTrxID + "; " + theAccount.accTrxLineID + "; " + theAccount.accID + "; " + theAccount.accName + "; " + theAccount.accOwner(0).custID + "; " + CType(theAccount.accBalance, String) + "; " + CType(theAccount.accAPR, String)
        _updateStringArray(theString)

        'raising the eevent for creating a new account
        RaiseEvent Bank_AccountAdded(
            Me,
            New Account_EventArgs_AccountAdded(
                theAccount
                )
            )
        RaiseEvent Bank_ChangedMetrics(
            Me,
            New Account_EventArgs_AccountAdded(
                theAccount
                )
            )

        Return theAccount

    End Function '_createAccount(pAccID, pCustID, pAccType, pAccName, pAccDateOpened, pAccBalance, pAccAPR, pAccTrxID, pAccTrxLineID, pAccAccrualDate)



    'modifying an account
    Private Function _modifyAccount(ByVal pAccID As String,
                                   ByVal pAccOwner() As Customer,
                                     ByVal pAccName As String,
                                   ByVal pAccAPR As Decimal,
                                    ByVal pAccIsClosed As Boolean,
                                    ByVal pAccClosedDate As Date
                             ) _
        As _
            Account

        Dim pLocationFound As Integer
        Dim theAccount As Account
        For Each accnt As Account In iterateAccount()

            For pLocationFound = 0 To mAccount.Length - 1
                If accnt.accID = pAccID Then
                    theAccount = accnt
                End If
            Next pLocationFound
        Next accnt
        'modifying account includes either closing the account entirely or updating certain details in the account
        If pAccIsClosed = True Then
            _closeAccount(theAccount)
        Else
            _updateName(theAccount, pAccName)
            _updateAPR(theAccount, pAccAPR)

            If pAccOwner.Length > 0 Then

                For pLocationFound = 0 To pAccOwner.Length - 1
                    _addOwner(theAccount.accDateOpened, pAccOwner(pLocationFound).custID, theAccount.accID)
                Next pLocationFound
            End If

            'raising the event to modify an account
            RaiseEvent Bank_AccountModified(
            Me,
            New Account_EventArgs_AccountModified(
                theAccount
                )
            )
        End If

        Return theAccount

    End Function '_modifyAccount()

    'transaction creation for deposits
    Private Function _depositMade(
            ByVal pTrxType As TransactionType,
            ByVal pCustID As String,
            ByVal pTrxID As String,
            ByVal pAccID As String,
            ByVal pTrxLineID As String,
            ByVal pTrxAmt As Decimal,
            ByVal pTrxDate As Date
            ) _
        As _
            Transaction

        Dim theTransaction As Transaction

        theTransaction = New Transaction(pTrxType, pCustID, pTrxID, pAccID, pTrxLineID, pTrxAmt, pTrxDate)
        'updating the transaction array
        If _numTransactions >= _maxTransaction Then
            _maxTransaction += _ARRAY_INCREMENT_DEFAULT
            ReDim Preserve mTransaction(_maxTransaction - 1)
        End If

        Try
            _ithTransaction(_numTransactions) = theTransaction
        Catch ex As Exception
            Throw New IndexOutOfRangeException
        End Try

        'incrementing the number of transactions by 1
        _numTransactions += 1

        Dim theString As String
        theString = theTransaction.trxDateTime.ToString("yyyyMMdd") + "; " + theTransaction.trxDateTime.ToString("HHmm") + "; Customer; Make Deposit ; " + theTransaction.trxID + "; " + theTransaction.trxLineID + "; " + theTransaction.trxCustID + "; " + theTransaction.trxAccID + "; " + CType(theTransaction.trxAmount, String)
        _updateStringArray(theString)

        'raising the event for this transaction
        RaiseEvent Bank_DepositMade(
            Me,
            New Transaction_EventArgs_TransactionProcessed(
                theTransaction
                )
            )

        Return theTransaction

    End Function '_depositMade(pTrxType, pCustID, pTrxID, pAccID, pTrxLineID, pTrxAmt, pTrxDate)


    'transaction creation for withdrawals
    Private Function _withdrawalMade(
            ByVal pTrxType As TransactionType,
            ByVal pCustID As String,
            ByVal pTrxID As String,
            ByVal pAccID As String,
            ByVal pTrxLineID As String,
            ByVal pTrxAmt As Decimal,
            ByVal pTrxDate As Date
            ) _
        As _
            Transaction

        Dim theTransaction As Transaction

        theTransaction = New Transaction(pTrxType, pCustID, pTrxID, pAccID, pTrxLineID, pTrxAmt, pTrxDate)
        'updating the transaction array
        If _numTransactions >= _maxTransaction Then
            _maxTransaction += _ARRAY_INCREMENT_DEFAULT
            ReDim Preserve mTransaction(_maxTransaction - 1)
        End If

        Try
            _ithTransaction(_numTransactions) = theTransaction
        Catch ex As Exception
            Throw New IndexOutOfRangeException
        End Try

        'incrementing the number of transactions by 1
        _numTransactions += 1

        Dim theString As String
        theString = theTransaction.trxDateTime.ToString("yyyyMMdd") + "; " + theTransaction.trxDateTime.ToString("HHmm") + "; Customer; Make Withdrawal ; " + theTransaction.trxID + "; " + theTransaction.trxLineID + "; " + theTransaction.trxCustID + "; " + theTransaction.trxAccID + "; " + CType(theTransaction.trxAmount, String)
        _updateStringArray(theString)
        'raising an event for this transaction
        RaiseEvent Bank_WithdrawalMade(
            Me,
            New Transaction_EventArgs_TransactionProcessed(
                theTransaction
                )
            )

        Return theTransaction

    End Function '_withdrawalMade(pTrxType, pCustID, pTrxID, pAccID, pTrxLineID, pTrxAmt, pTrxDate)
    'transaction creation for debit card used
    Private Function _debitCardUsed(
            ByVal pTrxType As TransactionType,
            ByVal pCustID As String,
            ByVal pTrxID As String,
            ByVal pAccID As String,
            ByVal pTrxLineID As String,
            ByVal pTrxAmt As Decimal,
            ByVal pTrxDate As Date
            ) _
        As _
            Transaction

        Dim theTransaction As Transaction

        theTransaction = New Transaction(pTrxType, pCustID, pTrxID, pAccID, pTrxLineID, pTrxAmt, pTrxDate)
        'updating the transaction array
        If _numTransactions >= _maxTransaction Then
            _maxTransaction += _ARRAY_INCREMENT_DEFAULT
            ReDim Preserve mTransaction(_maxTransaction - 1)
        End If

        Try
            _ithTransaction(_numTransactions) = theTransaction
        Catch ex As Exception
            Throw New IndexOutOfRangeException
        End Try

        'incrementing the number of transactions by 1
        _numTransactions += 1

        Dim theString As String
        theString = theTransaction.trxDateTime.ToString("yyyyMMdd") + "; " + theTransaction.trxDateTime.ToString("HHmm") + "; Customer; Use Debit Card ; " + theTransaction.trxID + "; " + theTransaction.trxLineID + "; " + theTransaction.trxCustID + "; " + theTransaction.trxAccID + "; " + CType(theTransaction.trxAmount, String)
        _updateStringArray(theString)
        'raising an event forthis transaction
        RaiseEvent Bank_DebitCardUsed(
            Me,
            New Transaction_EventArgs_TransactionProcessed(
                theTransaction
                )
            )

        Return theTransaction

    End Function '_debitCardUsed(pTrxType, pCustID, pTrxID, pAccID, pTrxLineID, pTrxAmt, pTrxDate)

    'creating a transaction for charging purchase
    Private Function _purchaseCharged(
            ByVal pTrxType As TransactionType,
            ByVal pCustID As String,
            ByVal pTrxID As String,
            ByVal pAccID As String,
            ByVal pTrxLineID As String,
            ByVal pTrxAmt As Decimal,
            ByVal pTrxDate As Date
            ) _
        As _
            Transaction

        Dim theTransaction As Transaction

        theTransaction = New Transaction(pTrxType, pCustID, pTrxID, pAccID, pTrxLineID, pTrxAmt, pTrxDate)
        'updating the transaction array
        If _numTransactions >= _maxTransaction Then
            _maxTransaction += _ARRAY_INCREMENT_DEFAULT
            ReDim Preserve mTransaction(_maxTransaction - 1)
        End If

        Try
            _ithTransaction(_numTransactions) = theTransaction
        Catch ex As Exception
            Throw New IndexOutOfRangeException
        End Try

        'incrementing the number of transactions by 1
        _numTransactions += 1

        Dim theString As String
        theString = theTransaction.trxDateTime.ToString("yyyyMMdd") + "; " + theTransaction.trxDateTime.ToString("HHmm") + "; Customer; Charge Purchase ; " + theTransaction.trxID + "; " + theTransaction.trxLineID + "; " + theTransaction.trxCustID + "; " + theTransaction.trxAccID + "; " + CType(theTransaction.trxAmount, String)
        _updateStringArray(theString)
        'raising an event for this transaction
        RaiseEvent Bank_PurchaseCharged(
            Me,
            New Transaction_EventArgs_TransactionProcessed(
                theTransaction
                )
            )

        Return theTransaction

    End Function '_purchaseCharged(pTrxType, pCustID, pTrxID, pAccID, pTrxLineID, pTrxAmt, pTrxDate)

    ' creating a transaction for making a payment
    Private Function _paymentMade(
            ByVal pTrxType As TransactionType,
            ByVal pCustID As String,
            ByVal pTrxID As String,
            ByVal pFromAccID As String,
            ByVal pToAccID As String,
            ByVal pFromTrxLineID As String,
            ByVal pToTrxLineID As String,
            ByVal pTrxAmt As Decimal,
            ByVal pTrxDate As Date
            ) _
        As _
            Transaction

        Dim theTransaction As Transaction

        theTransaction = New Transaction(pTrxType, pCustID, pTrxID, pFromAccID, pToAccID, pFromTrxLineID, pToTrxLineID, pTrxAmt, pTrxDate)
        'updating the transaction array
        If _numTransactions >= _maxTransaction Then
            _maxTransaction += _ARRAY_INCREMENT_DEFAULT
            ReDim Preserve mTransaction(_maxTransaction - 1)
        End If

        Try
            _ithTransaction(_numTransactions) = theTransaction
        Catch ex As Exception
            Throw New IndexOutOfRangeException
        End Try

        'incrementing the number of transactions by 1
        _numTransactions += 1

        Dim theString As String
        theString = theTransaction.trxDateTime.ToString("yyyyMMdd") + "; " + theTransaction.trxDateTime.ToString("HHmm") + "; Customer; Make Payment ; " + theTransaction.trxID + "; " + theTransaction.fromTrxLineID + "; " + theTransaction.toTrxLineID + "; " + theTransaction.trxID + ";" + theTransaction.trxCustID + "; " + theTransaction.fromAccID + "; " + theTransaction.toAccID + "; " + CType(theTransaction.trxAmount, String)
        _updateStringArray(theString)
        'raising an event for this transaction
        RaiseEvent Bank_PaymentMade(
            Me,
            New Transaction_EventArgs_TransactionProcessed(
                theTransaction
                )
            )

        Return theTransaction

    End Function '_paymentMade(pTrxType, pCustID, pTrxID, pFromAccID, pToAccID, pTrxLineID, pTrxAmt, pTrxDate)

    'creating a transaction for transferring funds
    Private Function _fundsTransferred(
            ByVal pTrxType As TransactionType,
            ByVal pCustID As String,
            ByVal pTrxID As String,
            ByVal pFromAccID As String,
            ByVal pToAccID As String,
            ByVal pFromTrxLineID As String,
            ByVal pToTrxLineID As String,
            ByVal pTrxAmt As Decimal,
            ByVal pTrxDate As Date
            ) _
        As _
            Transaction

        Dim theTransaction As Transaction

        theTransaction = New Transaction(pTrxType, pCustID, pTrxID, pFromAccID, pToAccID, pFromTrxLineID, pToTrxLineID, pTrxAmt, pTrxDate)
        'updating the transaction array
        If _numTransactions >= _maxTransaction Then
            _maxTransaction += _ARRAY_INCREMENT_DEFAULT
            ReDim Preserve mTransaction(_maxTransaction - 1)
        End If

        Try
            _ithTransaction(_numTransactions) = theTransaction
        Catch ex As Exception
            Throw New IndexOutOfRangeException
        End Try

        'incrementing the number of transactions by 1
        _numTransactions += 1

        Dim theString As String
        theString = theTransaction.trxDateTime.ToString("yyyyMMdd") + "; " + theTransaction.trxDateTime.ToString("HHmm") + "; Customer; Transfer Funds ; " + theTransaction.trxID + "; " + theTransaction.fromTrxLineID + "; " + theTransaction.toTrxLineID + "; " + theTransaction.trxID + ";" + theTransaction.trxCustID + "; " + theTransaction.fromAccID + "; " + theTransaction.toAccID + "; " + CType(theTransaction.trxAmount, String)
        _updateStringArray(theString)
        'raising the event for this transaction
        RaiseEvent Bank_FundsTransferred(
            Me,
            New Transaction_EventArgs_TransactionProcessed(
                theTransaction
                )
            )

        Return theTransaction

    End Function '_fundsTransferred(pTrxType, pCustID, pTrxID, pFromAccID, pToAccID, pTrxLineID, pTrxAmt, pTrxDate)
    'creating a transaction for calculating the interest
    Private Function _accrualCalculation(ByVal pTrxAccType As TransactionType,
                                        ByVal pTrxIDPrefix As String,
                                        ByVal pTrxIDStart As String,
                                        ByVal pTrxLineIDPrefix As String,
                                        ByVal pTrxLineIDStart As String,
                                        ByVal pTrxAccID As String,
                                        ByVal pTrxID As String,
                                        ByVal pTrxLineID As String
            ) _
        As _
            Transaction

        Dim theTransaction As Transaction

        theTransaction = New Transaction(pTrxAccType, pTrxIDPrefix, pTrxIDStart, pTrxLineIDPrefix, pTrxLineIDStart, pTrxAccID, pTrxID, pTrxLineID)
        'updating the transaction array
        If _numTransactions >= _maxTransaction Then
            _maxTransaction += _ARRAY_INCREMENT_DEFAULT
            ReDim Preserve mTransaction(_maxTransaction - 1)
        End If

        Try
            _ithTransaction(_numTransactions) = theTransaction
        Catch ex As Exception
            Throw New IndexOutOfRangeException
        End Try

        'incrementing the transaction by 1
        _numTransactions += 1
        'calculating the interest for specific account
        If (theTransaction.trxType.ToString = "SpecificAccount") Then

            Dim pLocationFound As Integer
            Dim interestRate As Decimal
            Try
                For pLocationFound = 0 To mAccount.Length - 1
                    If mAccount(pLocationFound).accID = theTransaction.trxID Then
                        interestRate = mAccount(pLocationFound).accAPR / 12
                        mAccount(pLocationFound).accBalance = mAccount(pLocationFound).accBalance + (mAccount(pLocationFound).accBalance * interestRate)
                        Exit For
                    End If
                Next pLocationFound
            Catch ex As Exception
            End Try

            Dim theString As String
            theString = theTransaction.trxDateTime.ToString("yyyyMMdd") + "; " + theTransaction.trxDateTime.ToString("HHmm") + "; Account; AccrueInterestIndividual ; " + theTransaction.trxID + "; " + theTransaction.trxLineID + "; " + theTransaction.trxAccID
            _updateStringArray(theString)

        End If
        'calculating the interest for all the accounts
        If (theTransaction.trxType.ToString = "AllAccounts") Then
            Dim interestRate As Decimal
            Try
                For pLocationFound = 0 To mAccount.Length - 1
                    interestRate = mAccount(pLocationFound).accAPR / 12
                    mAccount(pLocationFound).accBalance = mAccount(pLocationFound).accBalance + (mAccount(pLocationFound).accBalance * interestRate)
                Next pLocationFound
            Catch ex As Exception
            End Try
            Dim theString As String
            theString = theTransaction.trxDateTime.ToString("yyyyMMdd") + "; " + theTransaction.trxDateTime.ToString("HHmm") + "; Account; AccrueInterestAll ; " + theTransaction.trxID + "; " + theTransaction.trxLineID + "; " + theTransaction.trxAccID
            _updateStringArray(theString)
        End If

        'raising the event for this transaction
        RaiseEvent Bank_AccrualCalculated(
            Me,
            New Transaction_EventArgs_TransactionProcessed(
                theTransaction
                )
            )

        Return theTransaction

    End Function '_accrualCalculated(pTrxAccType, pTrxIDPrefix, pTrxIDStart, pTrxLineIDPrefix, pTrxLineIDStart, pTrxAccID, pTrxID, pTrxLineID)
    Private Function _findCustomer(
            ByVal pCustomerToFind As String,
            ByRef pLocationFound As Integer
            ) _
        As _
            Customer

        Dim itemFound As Customer
        Try
            For pLocationFound = 0 To mCustomer.Length - 1
                itemFound = _ithCustomer(pLocationFound)
                If itemFound.custID = pCustomerToFind Then
                    'the item is found so return it
                    Return itemFound
                End If
            Next pLocationFound
        Catch ex As Exception
        End Try
    End Function '_findCustomer(pCustomerToFind,pLocationFound)

    Private Function _findAccount(
            ByVal pAccountToFind As String,
            ByRef pLocationFound As Integer
            ) _
        As _
            Account


        Dim itemFound As Account
        Try
            For pLocationFound = 0 To mCustomer.Length - 1
                itemFound = _ithAccount(pLocationFound)
                If itemFound.accID = pAccountToFind Then
                    'the item is found so return it
                    Return itemFound
                End If
            Next pLocationFound
        Catch ex As Exception
        End Try
    End Function '_findAccount(pAccountToFind,pLocationFound)

    Private Function _findTransaction(
            ByVal pTransactionToFind As String,
            ByRef pLocationFound As Integer
            ) _
        As _
            Transaction

        Dim itemFound As Transaction
        Try
            For pLocationFound = 0 To mTransaction.Length - 1
                itemFound = _ithTransaction(pLocationFound)
                If itemFound.trxID = pTransactionToFind Then
                    'the item is found so return it
                    Return itemFound
                End If
            Next pLocationFound
        Catch ex As Exception
        End Try

    End Function '_findTransaction(pTransactionToFind,pLocationFound)

    Private Function _findTransactionLine(
            ByVal pTransactionToFind As String,
            ByRef pLocationFound As Integer
            ) _
        As _
            Transaction
        Dim itemFound As Transaction
        Try
            For pLocationFound = mTransaction.Length - 1 To 0 Step -1
                itemFound = _ithTransaction(pLocationFound)
                If itemFound.trxLineID = pTransactionToFind Then
                    'the item is found so return it
                    Return itemFound
                ElseIf itemFound.toTrxLineID = pTransactionToFind Then
                    'the item is found so return it
                    Return itemFound
                End If
            Next pLocationFound
        Catch ex As Exception
            Throw New Exception
        End Try
    End Function '_findTransactionLine(pTransactionToFind,pLocationFound)

    Private Iterator Function _iterateCustomer() _
        As _
            IEnumerable
        Dim i As Integer

        For i = 0 To _numCustomers - 1
            Yield _ithCustomer(i)
        Next i
    End Function '_iterateCustomer()
    Private Iterator Function _iterateAccount() _
        As _
            IEnumerable
        Dim i As Integer

        For i = 0 To _numAccounts - 1
            Yield _ithAccount(i)
        Next i
    End Function '_iterateAccount()

    Private Iterator Function _iterateTransaction() _
        As _
            IEnumerable

        Dim i As Integer

        For i = 0 To _numTransactions - 1
            Yield _ithTransaction(i)
        Next i

    End Function '_iterateTransaction  ()

    Private Function _addOwner(
              ByVal pDateTime As Date,
              ByVal pCustId As String,
              ByVal pAccId As String
            ) As Boolean

        Dim itemFound As Customer
        Dim customerFound As Customer

        For pLocationFound = 0 To mCustomer.Length - 1
            itemFound = _ithCustomer(pLocationFound)
            If itemFound.custID = pCustId Then
                'the item is found so return it
                customerFound = itemFound
                Exit For
            End If
        Next pLocationFound


        For Each accnt As Account In iterateAccount()
            For pLocationFound = 0 To accnt.accOwner.Length - 1
                If accnt.accID = pAccId Then
                    ReDim Preserve accnt.accOwner(accnt.accOwner.Length)
                    customerFound = accnt.accOwner(accnt.accOwner.Length - 1)
                    Exit For
                End If
            Next pLocationFound
        Next accnt

        Return True

    End Function '_addOwner

    Private Function _updateName(
        ByVal theAccount As Account,
        ByVal pAccName As String) _
 As _
 Account

        theAccount.accName = pAccName

        Return theAccount

    End Function '_updateName

    Private Function _updateAPR(
        ByVal theAccount As Account,
        ByVal pAccAPR As Decimal) _
 As _
 Account

        theAccount.accAPR = pAccAPR

        Return theAccount

    End Function '_updateAPR

    Private Function _nextAccrualDate(
            ByVal pAccDateOpened As Date
            ) _
        As _
            Date

        Dim theAccAccrualDate As Date

        'the next accrual date should be after a month
        If pAccDateOpened.AddDays(1).Day.Equals(1) Then
            theAccAccrualDate = pAccDateOpened.AddDays(1).AddMonths(1).AddDays(-1).Date
        Else
            theAccAccrualDate = pAccDateOpened.AddMonths(1).Date
        End If
        Return theAccAccrualDate
    End Function '_nextAccuralDate

    Private Function _closeAccount(
        ByVal theAccount As Account
       ) _
 As _
 Account
        Dim accDateClosed As Date
        accDateClosed = Date.Now
        Dim theString As String
        'update the array showing that the account is closed
        Try
            theString = accDateClosed.ToString("yyyyMMdd") + "; " + accDateClosed.ToString("HHmm") + "; Account ; Close ;" + theAccount.accID
            _updateStringArray(theString)
        Catch ex As Exception
        End Try
        Return theAccount

    End Function '_closeAccount

    Private Function _updateStringArray(
            ByVal pString As String
            ) _
        As _
            String

        If _numStringData >= _maxStringData Then
            _maxStringData += _ARRAY_INCREMENT_DEFAULT_STRING
            ReDim Preserve mStringData(_maxStringData - 1)
        End If

        Try
            _ithStringData(_numStringData) = pString
        Catch ex As Exception
            Throw New IndexOutOfRangeException
        End Try

        _numStringData += 1
        Return pString

    End Function '_updateStringArray


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


    Public Event Bank_CustomerAdded(
        ByVal sender As System.Object,
        ByVal e As System.EventArgs)

    Public Event Bank_AccountAdded(
        ByVal sender As System.Object,
        ByVal e As System.EventArgs)

    Public Event Bank_AccountModified(
        ByVal sender As System.Object,
        ByVal e As System.EventArgs)

    Public Event Bank_DepositMade(
        ByVal sender As System.Object,
        ByVal e As System.EventArgs)

    Public Event Bank_WithdrawalMade(
        ByVal sender As System.Object,
        ByVal e As System.EventArgs)

    Public Event Bank_DebitCardUsed(
        ByVal sender As System.Object,
        ByVal e As System.EventArgs)

    Public Event Bank_PurchaseCharged(
        ByVal sender As System.Object,
        ByVal e As System.EventArgs)

    Public Event Bank_PaymentMade(
        ByVal sender As System.Object,
        ByVal e As System.EventArgs)

    Public Event Bank_FundsTransferred(
        ByVal sender As System.Object,
        ByVal e As System.EventArgs)

    Public Event Bank_AccrualCalculated(
        ByVal sender As System.Object,
        ByVal e As System.EventArgs)

    Public Event Bank_ChangedMetrics(
      ByVal sender As System.Object,
      ByVal e As System.EventArgs)
#End Region 'Events

End Class 'Bank
