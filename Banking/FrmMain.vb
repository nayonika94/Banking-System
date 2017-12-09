Option Explicit On      'Must declare variables before using them
Option Strict On        'Must perform explicit data type conversions
Imports System.IO
'Copyright (c) 2009-2016 Dan Turk

#Region "Class / File Comment Header block"
'Program:            Banking
'File:               FrmMain.vb
'Author:             Nayonika Roy
'Description:        User Interface for the Banking project.
'Date:               2016 Sep 29
'                      - UI finalized: Dan Turk.  Starting point for Project 2.2016 Nov 12
'                     
'                    2016 Oct 15
'                      - Button Click events created
'                      - attributes and Variables declared, public 
'                         And private properties declared, Get/Set methods written And ToString methods written
'                      - Process Test data method written
'                      - Basic input validation done
'
'                    2016 Nov 12
'                       - Added the event procedures for the business logic
'                       - created the process test data using a single module level variable _theBank
'                    2016 Nov 28
'                       - Removed errors from previous submission
'                    2016 Dec 7
'                       - added method for calculating metrics
'                    2016 Dec 8
'                       - added the event procedures for button click for opening file
'                       -added the event procedure for button click for saving an output file
'                    2016  Dec 9
'                       - updated the process test data to test the functioning of the project
'Tier:               User Interface and Business Logic
'Exceptions:         None Defined.
'Exception-Handling: Exceptions handled for some User Interface 
'Events:             None Defined.
'Event-Handling:     Regular User-Interface Events handled.
#End Region 'Class / File Comment Header block

#Region "Option / Imports"
Imports Banking
#End Region 'Option / Imports

Public Class FrmMain

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************
    Private Const mFORM_TITLE_DEFAULT As String =
        "BANKING APPLICATION"


    '********** Module-level constants

    '********** Module-level variables
    Private WithEvents mTheBank As Bank

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

    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)
    Private Property _theBank As Bank
        Get
            Return mTheBank
        End Get
        Set(pValue As Bank)
            mTheBank = pValue
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

    '********** Private Non-Shared Behavioral Methods
    Private Sub _initializeBusinessLogic()

        '_initializeBusinessLogic() reads in and/or sets any starting
        'data the program has or needs to initialize as the program 
        'starts up.

        mTheBank = New Bank


    End Sub '_initializeBusinessLogic()

    Private Sub _initializeUserInterface()

        '_initializeUserInterface() sets the starting configuration
        'of the user interface as the program starts up.
        Me.Text = mFORM_TITLE_DEFAULT
        Me.AcceptButton = btnCreateCustomerGrpCreateTabCustomerTbcMain
        Me.CancelButton = btnExit
        txtTrxLog.Text = "INITIALIZED"

    End Sub '_initializeUserInterface()

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
    Private Sub _FrmMain_Load(
           sender As System.Object,
           e As System.EventArgs) _
       Handles _
           MyBase.Load

        '_FrmMain_Load() runs when the program initially starts up
        'and causes the business logic data and user-interface
        'fields to be set to their starting values.

        _initializeBusinessLogic()
        _initializeUserInterface()

    End Sub '_FrmMain_Load(sender,e)

    Private Sub _processTestData()
        'Testing for creating new Customer
        Dim aCustomer As Customer
        Dim bCustomer As Customer
        Dim cCustomer As Customer
        Dim dCustomer As Customer
        Dim customerArray() As Customer
        ReDim customerArray(0)

        aCustomer = _theBank.createCustomer("C1", "Sam Smith", New Date(1998, 8, 15))
        bCustomer = _theBank.createCustomer("C2", "Sally Jones", New Date(2000, 1, 1))
        cCustomer = _theBank.createCustomer("C3", "Tim Alfonso", New Date(2002, 12, 25))
        dCustomer = _theBank.createCustomer("C4", "Teresa Willaby", New Date(2001, 12, 1))

        'Testing for opening accounts
        Dim aAccount As Account
        Dim bAccount As Account
        Dim cAccount As Account
        Dim dAccount As Account
        Dim eAccount As Account
        Dim fAccount As Account
        Dim gAccount As Account

        customerArray(0) = aCustomer
        aAccount = _theBank.createAccount("A1", "C1", "1", customerArray, AccountType.Checking, "Sam's Checking", New Date(2015, 9, 5), 1000, 1.5D, "T1", "TL1", New Date(2015, 10, 5))
        customerArray(0) = aCustomer
        bAccount = _theBank.createAccount("A2", "C1", "1", customerArray, AccountType.CreditCard, "Sam's Credit Card", New Date(2016, 3, 10), 0, 20D, "T2", "TL2", New Date(2016, 4, 10))
        customerArray(0) = aCustomer
        cAccount = _theBank.createAccount("A3", "C1", "1", customerArray, AccountType.Loan, "Sam's House Loan", New Date(2016, 8, 15), 100000, 3D, "T3", "TL3", New Date(2016, 9, 15))
        customerArray(0) = aCustomer
        dAccount = _theBank.createAccount("A4", "C1", "1", customerArray, AccountType.Checking, "Sam's 2nd Checking", New Date(2016, 10, 25), 500, 0D, "T4", "TL4", New Date(2016, 11, 25))
        customerArray(0) = bCustomer
        eAccount = _theBank.createAccount("A5", "C2", "1", customerArray, AccountType.Checking, "Sally's Checking", New Date(2016, 6, 19), 1500, 0.5D, "T5", "TL5", New Date(2016, 7, 19))
        customerArray(0) = cCustomer
        fAccount = _theBank.createAccount("A6", "C3", "1", customerArray, AccountType.Checking, "Tim's Checking", New Date(2016, 11, 15), 2000, 0.1D, "T6", "TL6", New Date(2016, 12, 15))
        customerArray(0) = dCustomer
        gAccount = _theBank.createAccount("A7", "C4", "1", customerArray, AccountType.Checking, "Teresa's Checking", New Date(2016, 7, 29), 100, 2D, "T7", "TL7", New Date(2016, 8, 29))

        'Testing for single Transaction Line
        Dim aTransaction As Transaction
        Dim bTransaction As Transaction
        Dim cTransaction As Transaction
        Dim dTransaction As Transaction

        aTransaction = _theBank.depositMade(TransactionType.MakeDeposit, "C1", "T8", "A1", "TL8", 500, New Date(2015, 12, 10))
        bTransaction = _theBank.withdrawalMade(TransactionType.MakeWithdrawal, "C1", "T9", "A1", "TL9", 250, New Date(2016, 1, 10))
        cTransaction = _theBank.debitCardUsed(TransactionType.UseDebitCard, "C1", "T10", "A1", "TL10", 25, New Date(2016, 6, 13))
        dTransaction = _theBank.purchaseCharged(TransactionType.ChargePurchase, "C1", "T11", "A1", "TL11", 75, New Date(2016, 11, 6))

        'Testing for double Transaction lines
        Dim eTransaction As Transaction
        Dim fTransaction As Transaction
        Dim gTransaction As Transaction

        eTransaction = _theBank.fundsTransferred(TransactionType.TransferFunds, "C1", "T12", "A4", "A1", "TL12", "TL13", 150, New Date(2016, 11, 1))
        fTransaction = _theBank.paymentMade(TransactionType.MakePayment, "C1", "T13", "A1", "A2", "TL14", "TL15", 50, New Date(2016, 5, 1))
        gTransaction = _theBank.paymentMade(TransactionType.MakePayment, "C1", "T14", "A1", "A3", "TL16", "TL17", 1500, New Date(2016, 10, 10))

        'Testing for Accrue Interest
        Dim hTransaction As Transaction
        Dim iTransaction As Transaction
        Dim jTransaction As Transaction
        Dim kTransaction As Transaction

        hTransaction = _theBank.accrualCalculation(TransactionType.SpecificAccount, "", "", "", "", "A1", "T15", "TL18")
        iTransaction = _theBank.accrualCalculation(TransactionType.SpecificAccount, "", "", "", "", "A2", "T16", "TL19")
        jTransaction = _theBank.accrualCalculation(TransactionType.SpecificAccount, "", "", "", "", "A3", "T17", "TL20")
        kTransaction = _theBank.accrualCalculation(TransactionType.AllAccounts, "T", "18", "TL", "21", "", "", "")

        'testing add owner
        _theBank.addOwner(New Date(2016, 11, 4), "C2", "A1")
        'printing the toString for Customer
        txtTrxLog.Text &=
            vbCrLf _
            & "- Customer Created: " & aCustomer.ToString
        txtTrxLog.Text &=
            vbCrLf _
            & "- Customer Created: " & bCustomer.ToString
        txtTrxLog.Text &=
            vbCrLf _
            & "- Customer Created: " & cCustomer.ToString
        txtTrxLog.Text &=
            vbCrLf _
            & "- Customer Created: " & dCustomer.ToString

        'printing the toString for Account
        txtTrxLog.Text &=
            vbCrLf _
            & "- Account Created: " & aAccount.ToString
        txtTrxLog.Text &=
            vbCrLf _
            & "- Account Created: " & bAccount.ToString
        txtTrxLog.Text &=
            vbCrLf _
            & "- Account Created: " & cAccount.ToString
        txtTrxLog.Text &=
            vbCrLf _
            & "- Account Created: " & dAccount.ToString
        txtTrxLog.Text &=
            vbCrLf _
            & "- Account Created: " & eAccount.ToString
        txtTrxLog.Text &=
            vbCrLf _
            & "- Account Created: " & fAccount.ToString
        txtTrxLog.Text &=
            vbCrLf _
            & "- Account Created: " & gAccount.ToString

        'printing the toString for Transaction
        txtTrxLog.Text &=
            vbCrLf _
            & "- Deposit Made: " & aTransaction.ToString

        txtTrxLog.Text &=
            vbCrLf _
            & "- Withdrawal Made: " & bTransaction.ToString
        txtTrxLog.Text &=
            vbCrLf _
            & "- Debit Card Used: " & cTransaction.ToString
        txtTrxLog.Text &=
            vbCrLf _
            & "- Purchase Charged: " & dTransaction.ToString
        txtTrxLog.Text &=
            vbCrLf _
            & "- Transferred Funds: " & eTransaction.ToString
        txtTrxLog.Text &=
            vbCrLf _
            & "- Payment Made: " & fTransaction.ToString
        txtTrxLog.Text &=
            vbCrLf _
            & "- Payment Made: " & gTransaction.ToString
        txtTrxLog.Text &=
            vbCrLf _
            & "- Interest Accrued: " & hTransaction.ToString
        txtTrxLog.Text &=
            vbCrLf _
            & "- Interest Accrued: " & iTransaction.ToString
        txtTrxLog.Text &=
            vbCrLf _
            & "- Interest Accrued: " & jTransaction.ToString
        txtTrxLog.Text &=
            vbCrLf _
            & "- Interest Accrued: " & kTransaction.ToString
        txtTrxLog.Text &=
      vbCrLf _
         & "-Bank final : " & _theBank.ToString
    End Sub '_processTestData()

    'exits form on a button click
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'button click event for create customer
    Private Sub _btnCreateCustomerGrpCreateTabCustomerTbcMain_Click(sender As Object, e As EventArgs) Handles btnCreateCustomerGrpCreateTabCustomerTbcMain.Click

        Me.AcceptButton = btnCreateCustomerGrpCreateTabCustomerTbcMain

        'declare the variables
        Dim theCustID As String
        Dim theCustName As String
        Dim theCustBirth As Date

        Dim theCustomer As Customer

        'get/validate input
        theCustID = cboCustomerIDTabCustomerTbcMain.Text
        If theCustID = "" Then
            MessageBox.Show("Please fill in the ID!")
            cboCustomerIDTabCustomerTbcMain.SelectAll()
            cboCustomerIDTabCustomerTbcMain.Focus()
            Exit Sub
        End If

        theCustName = txtNameGrpCreateTabCustomerTbcMain.Text
        If theCustName = "" Then
            MessageBox.Show("Please fill in the Name!")
            txtNameGrpCreateTabCustomerTbcMain.SelectAll()
            txtNameGrpCreateTabCustomerTbcMain.Focus()
            Exit Sub
        End If

        theCustBirth = CDate(dtpBirthdateGrpCreateTabCustomerTbcMain.Value)
        Try
            theCustBirth = CDate(dtpBirthdateGrpCreateTabCustomerTbcMain.Text)
            If theCustBirth >= DateTime.Now _
            Then Throw New Exception
        Catch ex As Exception
            MessageBox.Show("Please enter a valid birth date!")
            Exit Sub
        End Try

        'passing the parameters to the createCustomer method
        theCustomer = _mTheBank.createCustomer(theCustID, theCustName, theCustBirth)

        'the toString method is called to print the customer details
        txtTrxLog.Text &=
            vbCrLf _
            & "- Customer Created: " & theCustomer.ToString


        'get ready for next input
        txtNameGrpCreateTabCustomerTbcMain.Text = ""
        cboCustomerIDTabCustomerTbcMain.Text = ""
        cboCustomerIDTabCustomerTbcMain.Focus()

    End Sub '_btnCreateCustomerGrpCreateTabCustomerTbcMain_Click

    'button click event for creating account
    Private Sub _btnCreateAccountTabAccountTbcMain_Click(sender As Object, e As EventArgs) Handles btnCreateAccountTabAccountTbcMain.Click

        Me.AcceptButton = btnCreateAccountTabAccountTbcMain

        'declare all the variables
        Dim theAccID As String
        Dim theCustID As String
        Dim theAccNumOwners As String
        Dim theAccOwner() As Customer
        Dim theAccType As AccountType
        Dim theAccName As String
        Dim theAccDateOpened As Date
        Dim theAccTrxID As String
        Dim theAccTrxLineID As String
        Dim theAccBalance As Decimal
        Dim theAccAPR As Decimal
        Dim theAccAccrualDate As Date
        Dim theAccount As Account
        Dim custFound As Customer
        Dim i As Integer
        i = 0
        'getting and validating the values of the parameters

        theAccID = cboAccountIDTabAccountTbcMain.Text
        If theAccID = "" Then
            MessageBox.Show("Please fill in the Account ID!")
            cboAccountIDTabAccountTbcMain.SelectAll()
            cboAccountIDTabAccountTbcMain.Focus()
            Exit Sub
        End If

        theCustID = cboCustomerIDGrpCreateModifyTabAccountTbcMain.Text
        If theCustID = "" Then
            MessageBox.Show("Please fill in the Customer ID!")
            cboCustomerIDGrpCreateModifyTabAccountTbcMain.SelectAll()
            cboCustomerIDGrpCreateModifyTabAccountTbcMain.Focus()
            Exit Sub
        End If


        'Fetching the value of the type of account through the radio button
        Dim radButton As RadioButton =
            grpTypeGrpCreateModifyTabAccountTbcMain.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)

        If radButton.Text = "Checking" Then
            theAccType = AccountType.Checking
        End If
        If radButton.Text = "Loan" Then
            theAccType = AccountType.Loan
        End If
        If radButton.Text = "Credit Card" Then
            theAccType = AccountType.CreditCard
        End If

        'input validation for string type variables
        theAccName = txtNameGrpCreateModifyTabAccountTbcMain.Text

        If theAccName = "" Then
            MessageBox.Show("Please fill in the name!")
            txtNameGrpCreateModifyTabAccountTbcMain.Focus()
            Exit Sub
        End If

        theAccTrxID = txtTrxIDGrpCreateModifyTabAccountTbcMain.Text

        If theAccTrxID = "" Then
            MessageBox.Show("Please fill in the Transaction ID!")
            txtTrxIDGrpCreateModifyTabAccountTbcMain.Focus()
            Exit Sub
        End If

        theAccTrxLineID = txtTrxLineIDGrpCreateModifyTabAccountTbcMain.Text

        If theAccTrxLineID = "" Then
            MessageBox.Show("Please fill in the Transaction Line ID!")
            txtTrxLineIDGrpCreateModifyTabAccountTbcMain.Focus()
            Exit Sub
        End If

        theAccDateOpened = CDate(dtpDateOpenedGrpCreateModifyTabAccountTbcMain.Value)
        'checking whether the date of opening is valid
        Try
            If theAccDateOpened > Date.Now _
                Then Throw New Exception
        Catch ex As Exception
            MessageBox.Show("Please Select a valid date!")
            dtpDateOpenedGrpCreateModifyTabAccountTbcMain.Focus()
            Exit Sub
        End Try

        'input validation for account balance
        Try
            theAccBalance = Decimal.Parse(txtAmountGrpCreateModifyTabAccountTbcMain.Text)
        Catch ex As Exception
            MessageBox.Show("Enter a valid amount!")
            txtAmountGrpCreateModifyTabAccountTbcMain.Focus()
            Exit Sub
        End Try
        'validating next interest rate
        Try
            theAccAPR = Decimal.Parse(nudAPRGrpCreateModifyTabAccountTbcMain.Text)
        Catch ex As Exception
            MessageBox.Show("Enter a valid decimal value!")
            nudAPRGrpCreateModifyTabAccountTbcMain.Focus()
            Exit Sub
        End Try

        'validating account owners
        If lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.Items.Count = 0 Then
            MessageBox.Show("Please select the Account owner!")
            cboCustomerIDGrpCreateModifyTabAccountTbcMain.SelectAll()
            cboCustomerIDGrpCreateModifyTabAccountTbcMain.Focus()
            Exit Sub
        End If

        theAccAccrualDate = CDate(dtpNextInterestAccrualDateGrpCreateModifyTabAccountTbcMain.Text)

        theAccNumOwners = CType(lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.Items.Count, String)
        ReDim theAccOwner(lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.Items.Count - 1)

        For pLocationFound = 0 To lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.Items.Count - 1
            custFound = mTheBank.findCustomer(lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.Items(i).ToString)
            theAccOwner(i) = custFound
            i = i + 1
        Next pLocationFound

        'passing the parameters to the createAccount method
        theAccount = _mTheBank.createAccount(theAccID, theCustID, theAccNumOwners, theAccOwner, theAccType, theAccName, theAccDateOpened, theAccBalance, theAccAPR, theAccTrxID, theAccTrxLineID, theAccAccrualDate)
        'the toString method is called to print the account details
        txtTrxLog.Text &=
                        vbCrLf _
                        & "- Account Created: " & theAccount.ToString

        'get ready for next input
        cboAccountIDTabAccountTbcMain.Text = ""
        cboCustomerIDGrpCreateModifyTabAccountTbcMain.Text = ""
        txtNameGrpCreateModifyTabAccountTbcMain.Text = ""
        txtAmountGrpCreateModifyTabAccountTbcMain.Text = ""
        txtTrxIDGrpCreateModifyTabAccountTbcMain.Text = ""
        txtTrxLineIDGrpCreateModifyTabAccountTbcMain.Text = ""
        dtpDateOpenedGrpCreateModifyTabAccountTbcMain.Text = ""
        nudAPRGrpCreateModifyTabAccountTbcMain.Text = ""
        dtpNextInterestAccrualDateGrpCreateModifyTabAccountTbcMain.Text = ""
        cboAccountIDTabAccountTbcMain.Focus()
    End Sub '_btnCreateAccountTabAccountTbcMain_Click

    'button click event for modifying account
    Private Sub _btnModifyAccountTabAccountTbcMain_Click(sender As Object, e As EventArgs) Handles btnModifyAccountTabAccountTbcMain.Click
        Me.AcceptButton = btnCreateAccountTabAccountTbcMain

        'declare all the variables
        Dim theAccID As String
        Dim theCustID As String
        Dim theAccNumOwners As String
        Dim theAccOwner() As Customer
        'Dim theAccType As AccountType
        Dim theAccName As String
        'Dim theAccDateOpened As Date
        'Dim theAccTrxID As String
        'Dim theAccTrxLineID As String
        'Dim theAccBalance As Decimal
        Dim theAccAPR As Decimal
        'Dim theAccAccrualDate As Date
        Dim theAccIsClosed As Boolean
        Dim theAccClosedDate As Date
        Dim theAccount As Account
        Dim custFound As Customer
        Dim maximumOwners As Integer
        Dim i As Integer
        i = 0

        'getting and validating the values of the parameters

        theAccID = cboAccountIDTabAccountTbcMain.Text
        If theAccID = "" Then
            MessageBox.Show("Please fill in the Account ID!")
            cboAccountIDTabAccountTbcMain.SelectAll()
            cboAccountIDTabAccountTbcMain.Focus()
            Exit Sub
        End If



        'theCustID = cboCustomerIDGrpCreateModifyTabAccountTbcMain.Text
        'If theCustID = "" Then
        '    MessageBox.Show("Please fill in the Customer ID!")
        '    cboCustomerIDGrpCreateModifyTabAccountTbcMain.SelectAll()
        '    cboCustomerIDGrpCreateModifyTabAccountTbcMain.Focus()
        '    Exit Sub
        'End If



        'Fetching the value of the type of account through the radio button
        'Dim radButton As RadioButton =
        '    grpTypeGrpCreateModifyTabAccountTbcMain.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)

        'If radButton.Text = "Checking" Then
        '    theAccType = AccountType.Checking
        'End If
        'If radButton.Text = "Loan" Then
        '    theAccType = AccountType.Loan
        'End If
        'If radButton.Text = "Credit Card" Then
        '    theAccType = AccountType.CreditCard
        'End If

        'input validation for string type variables
        theAccName = txtNameGrpCreateModifyTabAccountTbcMain.Text

        If theAccName = "" Then
            MessageBox.Show("Please fill in the name!")
            txtNameGrpCreateModifyTabAccountTbcMain.Focus()
            Exit Sub
        End If

        'theAccTrxID = txtTrxIDGrpCreateModifyTabAccountTbcMain.Text

        'If theAccTrxID = "" Then
        '    MessageBox.Show("Please fill in the Transaction ID!")
        '    txtTrxIDGrpCreateModifyTabAccountTbcMain.Focus()
        '    Exit Sub
        'End If

        'theAccTrxLineID = txtTrxLineIDGrpCreateModifyTabAccountTbcMain.Text

        'If theAccTrxLineID = "" Then
        '    MessageBox.Show("Please fill in the Transaction Line ID!")
        '    txtTrxLineIDGrpCreateModifyTabAccountTbcMain.Focus()
        '    Exit Sub
        'End If

        'theAccDateOpened = CDate(dtpDateOpenedGrpCreateModifyTabAccountTbcMain.Value)

        'Try
        '    If theAccDateOpened > Date.Now _
        '        Then Throw New Exception
        'Catch ex As Exception
        '    MessageBox.Show("Please Select today's date!")
        '    dtpDateOpenedGrpCreateModifyTabAccountTbcMain.Focus()
        '    Exit Sub
        'End Try

        theAccIsClosed = chkClosedGrpClosedTabAccountTbcMain.Checked

        Try
            theAccClosedDate = CDate(dtpClosedDateGrpClosedTabAccountTbcMain.Text)
            If theAccClosedDate > DateTime.Now _
            Then Throw New Exception
        Catch ex As Exception
            MessageBox.Show("Please select today's date!")

        End Try
        'input validation for account balance
        'Try
        '    theAccBalance = Decimal.Parse(txtAmountGrpCreateModifyTabAccountTbcMain.Text)
        'Catch ex As Exception
        '    MessageBox.Show("Enter a valid amount!")
        '    txtAmountGrpCreateModifyTabAccountTbcMain.Focus()
        '    Exit Sub
        'End Try
        Try
            theAccAPR = Decimal.Parse(nudAPRGrpCreateModifyTabAccountTbcMain.Text)
        Catch ex As Exception
            MessageBox.Show("Enter a valid decimal value!")
            nudAPRGrpCreateModifyTabAccountTbcMain.Focus()
            Exit Sub
        End Try

        'theAccNumOwners = CType(lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.Items.Count, String)
        maximumOwners = 2
        ReDim theAccOwner(lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.Items.Count - 1)


        For pLocationFound = 0 To lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.Items.Count - 1
            custFound = mTheBank.findCustomer(lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.Items(i).ToString)
            theAccOwner(i) = custFound
            i = i + 1
        Next pLocationFound

        theAccIsClosed = chkClosedGrpClosedTabAccountTbcMain.Checked

        Try
            theAccClosedDate = CDate(dtpClosedDateGrpClosedTabAccountTbcMain.Text)
            If theAccClosedDate > DateTime.Now _
            Then Throw New Exception
        Catch ex As Exception
            MessageBox.Show("Please enter today's date!")
            Exit Sub
        End Try

        'theAccAccrualDate = CDate(dtpNextInterestAccrualDateGrpCreateModifyTabAccountTbcMain.Text)

        'passing the parameters to the modifyAccount method
        theAccount = _mTheBank.modifyAccount(theAccID, theAccOwner, theAccName, theAccAPR, theAccIsClosed, theAccClosedDate)
        'the toString method is called to print the account details
        txtTrxLog.Text &=
                    vbCrLf _
                    & "- Account Modified: " & theAccount.ToString

        'get ready for next input
        cboAccountIDTabAccountTbcMain.Text = ""
        cboCustomerIDGrpCreateModifyTabAccountTbcMain.Text = ""
        txtNameGrpCreateModifyTabAccountTbcMain.Text = ""
        txtAmountGrpCreateModifyTabAccountTbcMain.Text = ""
        txtTrxIDGrpCreateModifyTabAccountTbcMain.Text = ""
        txtTrxLineIDGrpCreateModifyTabAccountTbcMain.Text = ""
        nudAPRGrpCreateModifyTabAccountTbcMain.Text = ""
        dtpClosedDateGrpClosedTabAccountTbcMain.Text = ""
        dtpDateOpenedGrpCreateModifyTabAccountTbcMain.Text = ""
        dtpNextInterestAccrualDateGrpCreateModifyTabAccountTbcMain.Text = ""
        lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.Items.Clear()


        grpTypeGrpCreateModifyTabAccountTbcMain.Enabled = True
        dtpDateOpenedGrpCreateModifyTabAccountTbcMain.Enabled = True
        txtAmountGrpCreateModifyTabAccountTbcMain.Enabled = True
        txtTrxIDGrpCreateModifyTabAccountTbcMain.Enabled = True
        txtTrxLineIDGrpCreateModifyTabAccountTbcMain.Enabled = True
        grpCreateModifyTabAccountTbcMain.Enabled = True

    End Sub '_btnModifyAccountTabAccountTbcMain_Click

    'button click procedure for processing the transaction for the make deposit option
    Private Sub _btnProcessTrxTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain_Click(sender As Object, e As EventArgs) Handles btnProcessTrxTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Click

        Me.AcceptButton = btnProcessTrxTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain
        'declaring and getting values for variables
        Dim theTrxID As String = txtTrxIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text
        Dim theTrxLineID As String = txtTrxLineIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text
        Dim theTrxDate As Date = CDate(dtpTrxDateTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Value)
        Dim theTrxType As TransactionType
        Dim theTrxAmount As Decimal
        Dim theTrxCustID As String = cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text
        Dim theTrxAccID As String = cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text
        Dim theTransaction As Transaction

        'getting the value for the type of transaction
        Dim radButton As RadioButton =
            grpTypeMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)

        If radButton.Text = "Make Deposit" Then
            theTrxType = TransactionType.MakeDeposit
        End If

        If radButton.Text = "Make Withdrawal" Then
            theTrxType = TransactionType.MakeWithdrawal
        End If
        If radButton.Text = "Use Debit Card" Then
            theTrxType = TransactionType.UseDebitCard
        End If
        If radButton.Text = "Charge Purchase" Then
            theTrxType = TransactionType.ChargePurchase
        End If

        'validating string type variables
        If theTrxID = "" Then
            MessageBox.Show("Please fill in the Transaction ID!")
            txtTrxIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If
        If theTrxLineID = "" Then
            MessageBox.Show("Please fill in the Transaction Line ID!")
            txtTrxLineIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If
        If theTrxCustID = "" Then
            MessageBox.Show("Please select the customer ID!")
            cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.SelectAll()
            cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If
        If theTrxAccID = "" Then
            MessageBox.Show("Please select the account ID!")
            cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.SelectAll()
            cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If
        'validating the date of transaction
        theTrxDate = CDate(dtpTrxDateTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text)
        Try
            theTrxDate = CDate(dtpTrxDateTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text)
            If theTrxDate > DateTime.Now _
            Then Throw New Exception
        Catch ex As Exception
            MessageBox.Show("Please enter a valid date for the transaction!")

        End Try
        'validating the transaction amount variable
        Try
            theTrxAmount = Decimal.Parse(nudAmountTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text)
            If theTrxAmount <= 0 _
                Then Throw New Exception
        Catch ex As Exception
            MessageBox.Show("Enter a valid amount!")
            nudAmountTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End Try
        'passing the values to the appropriate method based on the type of transaction and calling the toString function
        If theTrxType = 1 Then

            theTransaction = _mTheBank.depositMade(theTrxType, theTrxCustID, theTrxID, theTrxAccID, theTrxLineID, theTrxAmount, theTrxDate)

            txtTrxLog.Text &=
            vbCrLf _
            & "- Transaction Processed: " & theTransaction.ToString
        ElseIf theTrxType = 2 Then

            theTransaction = _mTheBank.withdrawalMade(theTrxType, theTrxCustID, theTrxID, theTrxAccID, theTrxLineID, theTrxAmount, theTrxDate)

            txtTrxLog.Text &=
            vbCrLf _
            & "- Transaction Processed: " & theTransaction.ToString
        ElseIf theTrxType = 3 Then

            theTransaction = _mTheBank.debitCardUsed(theTrxType, theTrxCustID, theTrxID, theTrxAccID, theTrxLineID, theTrxAmount, theTrxDate)

            txtTrxLog.Text &=
            vbCrLf _
            & "- Transaction Processed: " & theTransaction.ToString
        ElseIf theTrxType = 4 Then

            theTransaction = _mTheBank.purchaseCharged(theTrxType, theTrxCustID, theTrxID, theTrxAccID, theTrxLineID, theTrxAmount, theTrxDate)

            txtTrxLog.Text &=
            vbCrLf _
            & "- Transaction Processed: " & theTransaction.ToString
        End If

        'get ready for next input
        txtTrxIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text = ""
        txtTrxLineIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text = ""
        cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text = ""
        cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text = ""
        nudAmountTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Value = 0
        cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Focus()
        dtpTrxDateTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text = ""
    End Sub '_btnProcessTrxTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain_Click

    'button click event for making payment and transferring funds
    Private Sub _btnProcessTransactionTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain_Click(sender As Object, e As EventArgs) Handles btnProcessTransactionTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Click

        Me.AcceptButton = btnProcessTransactionTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain
        'declaring and getting values for variables
        Dim theToAccID As String = cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text
        Dim theFromAccID As String = cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text
        Dim theTrxID As String = txtTrxIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text
        Dim theFromTrxLineID As String = txtToTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text
        Dim theToTrxLineID As String = txtFromTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text
        Dim theTrxDateTime As Date = dtpTrxDateTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Value
        Dim theTrxType As TransactionType
        Dim theTrxAmount As Decimal
        Dim theTrxCustID As String = cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text
        Dim theTransaction As Transaction
        Dim radButton As RadioButton =
            grpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)

        If radButton.Text = "Make Payment" Then
            theTrxType = TransactionType.MakePayment
        End If

        If radButton.Text = "Transfer Funds" Then
            theTrxType = TransactionType.TransferFunds
        End If
        'validating string type variables
        If theTrxID = "" Then
            MessageBox.Show("Please fill in the Transaction ID!")
            txtTrxIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If

        If theFromTrxLineID = "" Then
            MessageBox.Show("Please fill in the From Transaction Line ID!")
            txtToTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If

        If theToTrxLineID = "" Then
            MessageBox.Show("Please fill in the To Transaction Line ID!")
            txtFromTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If

        If theTrxCustID = "" Then
            MessageBox.Show("Please select the Customer ID!")
            cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectAll()
            cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If
        'validating the inputs for the from and to acc ID variables
        If theFromAccID = "" Then
            MessageBox.Show("Please select the From Account ID!")
            cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectAll()
            cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If
        If theToAccID = "" Then
            MessageBox.Show("Please select the To Account ID!")
            cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectAll()
            cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If
        'Checking if the from and to accounts for transaction are different or not
        If theFromAccID = theToAccID Then
            MessageBox.Show("Please select different From and To Accounts!")
            cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectAll()
            cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If
        'validating the transaction amount variable
        Try
            theTrxAmount = Decimal.Parse(nudTrxLineAmountTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text)
            If theTrxAmount <= 0 _
                Then Throw New Exception
        Catch ex As Exception
            MessageBox.Show("Enter a valid amount!")
            nudTrxLineAmountTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End Try

        Try
            theTrxDateTime = CDate(dtpTrxDateTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text)
            If theTrxDateTime > DateTime.Now _
            Then Throw New Exception

        Catch ex As Exception
            MessageBox.Show("invalid dob enter valid")

        End Try
        'passing the values to the appropriate method based on the type of transaction and calling the toString function
        If theTrxType = 5 Then

            theTransaction = _mTheBank.paymentMade(theTrxType, theTrxCustID, theTrxID, theFromAccID, theToAccID, theFromTrxLineID, theToTrxLineID, theTrxAmount, theTrxDateTime)

            txtTrxLog.Text &=
            vbCrLf _
            & "- Transaction Processed: " & theTransaction.ToString

        ElseIf theTrxType = 6 Then

            theTransaction = _mTheBank.fundsTransferred(theTrxType, theTrxCustID, theTrxID, theFromAccID, theToAccID, theFromTrxLineID, theToTrxLineID, theTrxAmount, theTrxDateTime)

            txtTrxLog.Text &=
            vbCrLf _
            & "- Transaction Processed: " & theTransaction.ToString

        End If

        'get ready for next input
        txtTrxIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text = ""
        txtFromTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text = ""
        cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text = ""
        cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text = ""
        cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text = ""
        nudTrxLineAmountTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Value = 0
        cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()

    End Sub '_btnProcessTransactionTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain_Click

    Private Sub _btnAccrueInterestTabAccrueInterestTbcTransactionsTabTransactionsTbcMain_Click(sender As Object, e As EventArgs) Handles btnAccrueInterestTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Click
        'Declaring the variables and getting the values
        Dim theTrxIDPrefix As String = txtTrxIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text
        Dim theTrxIDStart As String = txtTrxIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text
        Dim theTrxLineIDPrefix As String = txtTrxIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text
        Dim theTrxLineIDStart As String = txtTrxIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text
        Dim theTrxAccID As String = cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text
        Dim theTrxLineID As String = txtTrxIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text
        Dim theTrxType As TransactionType
        Dim theTrxID As String = txtTrxIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text
        Dim theTransaction As Transaction
        Dim radButton As RadioButton =
            tabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)

        If radButton.Text = "All Accounts" Then
            theTrxType = TransactionType.AllAccounts
        End If

        If radButton.Text = "Specific Account" Then
            theTrxType = TransactionType.SpecificAccount
        End If

        'validating string type variables
        If theTrxType = 7 Then
            'validating the input for the all accounts variables
            If theTrxIDPrefix = "" Then
                MessageBox.Show("Please fill in the Trx ID Prefix!")
                txtTrxIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Focus()
                Exit Sub
            End If
            If theTrxLineIDStart = "" Then
                MessageBox.Show("Please fill in the Trx ID Start Number!")
                txtTrxIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Focus()
                Exit Sub
            End If
            If theTrxLineIDPrefix = "" Then
                MessageBox.Show("Please fill in the Trx Line iD Prefix!")
                txtTrxLineIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Focus()
                Exit Sub
            End If
            If theTrxLineIDStart = "" Then
                MessageBox.Show("Please fill in the Trx line Start Number!")
                txtTrxLineIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Focus()
                Exit Sub
            End If

        ElseIf theTrxType = 8 Then
            'validating the inputs from specific account
            If theTrxID = "" Then
                MessageBox.Show("Please fill in the Trx ID!")
                txtTrxIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Focus()
                Exit Sub
            End If
            If theTrxLineID = "" Then
                MessageBox.Show("Please fill in the Trx Line ID!")
                txtTrxLineIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Focus()
                Exit Sub
            End If
            If theTrxAccID = "" Then
                MessageBox.Show("Please select the Account ID!")
                cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.SelectAll()
                cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Focus()
                Exit Sub
            End If
        End If
        'passing the values to the appropriate method based on the type of transaction and calling the toString function
        theTransaction = _mTheBank.accrualCalculation(theTrxType, theTrxIDPrefix, theTrxIDStart, theTrxLineIDPrefix, theTrxLineIDStart, theTrxAccID, theTrxID, theTrxLineID)

        txtTrxLog.Text &=
        vbCrLf _
        & "- Transaction Processed: " & theTransaction.ToString
    End Sub '_btnAccrueInterestTabAccrueInterestTbcTransactionsTabTransactionsTbcMain_Click

    Private Sub _btnProcessTestDataTabFilesTbcMain_Click(sender As Object, e As EventArgs) Handles btnProcessTestDataTabFilesTbcMain.Click
        _processTestData()
    End Sub

    Private Sub _btnOpenTabFilesTbcMain_Click(sender As Object, e As EventArgs) Handles btnOpenTabFilesTbcMain.Click
        Dim inputFile As StreamReader
        Dim line As String
        Dim field() As String
        Dim pAccDateOpened As Date
        Dim pCustBirth As Date
        Dim pAccAccrualDate As Date
        Dim pAccOwner() As Customer
        ReDim pAccOwner(0)
        Dim fileName As String
        fileName = txtFileNameTabFilesTbcMain.Text
        If fileName = "" Then
            MessageBox.Show("Please enter a valid file name!")
            txtFileNameTabFilesTbcMain.SelectAll()
            txtFileNameTabFilesTbcMain.Focus()
            Exit Sub
        End If

        inputFile = New StreamReader(fileName)
            'reading from the file
            Do While Not inputFile.EndOfStream
                line = inputFile.ReadLine
                field = Split(line, ";")
                If line.StartsWith("# ") = True Then
                    Continue Do
                End If
                If field.Count = 1 Then
                    Continue Do
                End If

                'reading the data related to 'create customer'
                If Trim(field(2)) = "Customer" And Trim(field(3)) = "Create" Then
                    pCustBirth = New Date(Integer.Parse(Trim(field(6)).Substring(0, 4)), Integer.Parse(Trim(field(6)).Substring(4, 2)), Integer.Parse(Trim(field(6)).Substring(6, 2)))
                    Dim refDate As DateTime
                    refDate = New Date(Integer.Parse(Trim(field(0)).Substring(0, 4)), Integer.Parse(Trim(field(0)).Substring(4, 2)), Integer.Parse(Trim(field(0)).Substring(6, 2)))

                    Dim aCustomer = _theBank.createCustomerWithRefDate(Trim(field(4)), Trim(field(5)), pCustBirth, refDate)
                    txtTrxLog.Text &=
                 vbCrLf _
                    & "- New Customer Added: " & aCustomer.ToString
                End If

                'reading the data related to 'Accounts and Open'
                If Trim(field(3)) = "Open" Then
                    Dim aAccount As Account
                    pAccDateOpened = New Date(Integer.Parse(Trim(field(0)).Substring(0, 4)), Integer.Parse(Trim(field(0)).Substring(4, 2)), Integer.Parse(Trim(field(0)).Substring(6, 2)))
                    pAccAccrualDate = _theBank.nextAccrualDate(pAccAccrualDate)
                    pAccOwner(0) = _theBank.findCustomer(Trim(field(9)))
                    If Trim(field(4)) = "Checking" Then
                        aAccount = _theBank.createAccount(Trim(field(7)), Trim(field(9)), "1", pAccOwner, AccountType.Checking, Trim(field(8)), pAccDateOpened, CType(Trim(field(10)), Decimal), CType(Trim(field(11)), Decimal), Trim(field(5)), Trim(field(6)), pAccAccrualDate)
                    End If
                    If Trim(field(4)) = "CreditCard" Then
                        aAccount = _theBank.createAccount(Trim(field(7)), Trim(field(9)), "1", pAccOwner, AccountType.CreditCard, Trim(field(8)), pAccDateOpened, 0, CType(Trim(field(10)), Decimal), Trim(field(5)), Trim(field(6)), pAccAccrualDate)
                    End If
                    If Trim(field(4)) = "Loan" Then
                        aAccount = _theBank.createAccount(Trim(field(7)), Trim(field(9)), "1", pAccOwner, AccountType.Loan, Trim(field(8)), pAccDateOpened, CType(Trim(field(10)), Decimal), CType(Trim(field(11)), Decimal), Trim(field(5)), Trim(field(6)), pAccAccrualDate)
                    End If
                End If

                'reading the data related to 'adding owners to the account'
                If Trim(field(2)) = "Account" And Trim(field(3)) = "AddOwner" Then
                    Dim theOwner = _theBank.addOwner(New Date(Integer.Parse(Trim(field(0)).Substring(0, 4)), Integer.Parse(Trim(field(0)).Substring(4, 2)), Integer.Parse(Trim(field(0)).Substring(6, 2))), Trim(field(5)), Trim(field(4)))
                    txtTrxLog.Text &=
                 vbCrLf _
                    & "- Owner added  : " & theOwner
                End If
                'reading teh data related to 'transaction type'
                If Trim(field(2)) = "Customer" Then

                    Dim theTransaction As Transaction
                    'Dim transactionType As TransactionType
                    Dim trxDate As Date
                    trxDate = New Date(Integer.Parse(Trim(field(0)).Substring(0, 4)), Integer.Parse(Trim(field(0)).Substring(4, 2)), Integer.Parse(Trim(field(0)).Substring(6, 2)))

                If Trim(field(3)) = "MakeDeposit" Then
                    theTransaction = _theBank.depositMade(TransactionType.MakeDeposit, Trim(field(6)), Trim(field(4)), Trim(field(7)), Trim(field(5)), CType(Trim(field(8)), Decimal), trxDate)
                ElseIf Trim(field(3)) = "MakeWithdrawal" Then
                    theTransaction = _theBank.withdrawalMade(TransactionType.MakeWithdrawal, Trim(field(6)), Trim(field(4)), Trim(field(7)), Trim(field(5)), CType(Trim(field(8)), Decimal), trxDate)
                ElseIf Trim(field(3)) = "UseDebitCard" Then
                    theTransaction = _theBank.debitCardUsed(TransactionType.UseDebitCard, Trim(field(6)), Trim(field(4)), Trim(field(7)), Trim(field(5)), CType(Trim(field(8)), Decimal), trxDate)
                ElseIf Trim(field(3)) = "ChargePurchase" Then
                    theTransaction = _theBank.purchaseCharged(TransactionType.ChargePurchase, Trim(field(6)), Trim(field(4)), Trim(field(7)), Trim(field(5)), CType(Trim(field(8)), Decimal), trxDate)
                ElseIf Trim(field(3)) = "TransferFunds" Then
                    theTransaction = _theBank.fundsTransferred(TransactionType.TransferFunds, Trim(field(7)), Trim(field(4)), Trim(field(8)), Trim(field(9)), Trim(field(5)), Trim(field(6)), CType(Trim(field(10)), Decimal), trxDate)
                ElseIf Trim(field(3)) = "MakePayment" Then
                    theTransaction = _theBank.paymentMade(TransactionType.MakePayment, Trim(field(7)), Trim(field(4)), Trim(field(8)), Trim(field(9)), Trim(field(5)), Trim(field(6)), CType(Trim(field(10)), Decimal), trxDate)
                    End If
                End If
                'reading the data related to accruing interest for specific accounts
                If Trim(field(2)) = "Account" And Trim(field(3)) = "AccrueInterestIndividual" Then
                    Dim theTransaction As Transaction
                    theTransaction = _theBank.accrualCalculation(TransactionType.SpecificAccount, "", "", "", "", Trim(field(4)), Trim(field(5)), Trim(field(6)))

                    txtTrxLog.Text &=
                 vbCrLf _
                    & "- Interested accrued for individual account  : " & theTransaction.ToString
                End If
                'reading data for accruing interest for all accounts
                If Trim(field(2)) = "Account" And Trim(field(3)) = "AccrueInterestAll" Then
                    Dim theTransaction As Transaction
                    theTransaction = _theBank.accrualCalculation(TransactionType.AllAccounts, Trim(field(4)), Trim(field(5)), Trim(field(6)), Trim(field(7)), "", "", "")

                    txtTrxLog.Text &=
                 vbCrLf _
                    & "- Interest Accrued for all accounts : " & theTransaction.ToString
                End If
                'reading data for the updated interest rates
                If Trim(field(2)) = "Account" And Trim(field(3)) = "UpdateInterestRate" Then

                    Dim aAccount As Account
                    Dim bAccount As Account
                    aAccount = _theBank.findAccount(Trim(field(4)))
                    bAccount = _theBank.updateAPR(aAccount, CType(Trim(field(5)), Decimal))
                    txtTrxLog.Text &=
                 vbCrLf _
                    & "- Interest rate updated  : " & bAccount.ToString()
                End If
                'reading data to update a name on the account
                If Trim(field(2)) = "Account" And Trim(field(3)) = "UpdateName" Then
                    Dim aAccount As Account
                    Dim bAccount As Account
                    aAccount = _theBank.findAccount(Trim(field(4)))
                    bAccount = _theBank.updateName(aAccount, Trim(field(4)))
                    txtTrxLog.Text &=
                 vbCrLf _
                    & "- Name Updated: " & bAccount.ToString
                End If
                'reading data for closing the accounts
                If Trim(field(2)) = "Account" And Trim(field(3)) = "Close" Then
                Try
                    Dim aAccount As Account
                    Dim bAccount As Account
                    aAccount = _theBank.findAccount(Trim(field(4)))
                    bAccount = _theBank.closeAccount(aAccount)
                    txtTrxLog.Text &=
                     vbCrLf _
                        & "- Account Closed: " & bAccount.ToString
                Catch ex As Exception
                End Try
            End If
            Loop
            inputFile.Close()


    End Sub

    Private Sub _btnSaveTabFilesTbcMain_Click(sender As Object, e As EventArgs) Handles btnSaveTabFilesTbcMain.Click
        Dim outputFile As StreamWriter
        Dim fileName As String
        Try
            fileName = txtFileNameTabFilesTbcMain.Text
            If fileName = "" Then
                MessageBox.Show("Please enter a valid file name!")
                txtFileNameTabFilesTbcMain.SelectAll()
                txtFileNameTabFilesTbcMain.Focus()
                Exit Sub
            End If
            'write the output into the file name entered by the user
            outputFile = New StreamWriter(fileName)

            Dim intC As Integer = 0
            'saving the content of the String array into the ouput file
            Do While intC < _theBank.stringData.Length
                outputFile.WriteLine(_theBank.stringData(intC))
                intC += 1
            Loop
            txtTrxLog.Text &= vbCrLf & "- File has been saved! "
            outputFile.Close()
        Catch ex As Exception
        End Try
    End Sub '_btnSaveTabFilesTbcMain_Click

    Private Sub btnResetAllTabFilesTbcMain_Click(sender As Object, e As EventArgs) Handles btnResetAllTabFilesTbcMain.Click
        txtFileNameTabFilesTbcMain.Text = ""
        txtTrxLog.Text = ""
    End Sub



    'this handles event raised by selection of element in list box
    Private Sub _lstCustomerIDTabSummaryTbcMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCustomerIDTabSummaryTbcMain.SelectedIndexChanged
        'finds the details associated with the customer ID selected in the summary tab
        Dim customer = mTheBank.findCustomer(lstCustomerIDTabSummaryTbcMain.SelectedItem.ToString)
        'prints toString of customer ID selected in the summary tab to ToString information box
        txtToStringInfoTabSummaryTbcMain.Text = customer.ToString
    End Sub '_lstCustomerIDTabSummaryTbcMain_SelectedIndexChanged 

    Private Sub _lstAccountIDTabSummaryTbcMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAccountIDTabSummaryTbcMain.SelectedIndexChanged
        'finds the details associated with the account ID selected in the summary tab
        Dim account = mTheBank.findAccount(lstAccountIDTabSummaryTbcMain.SelectedItem.ToString)
        'prints toString of account ID selected in the summary tab to ToString information box
        txtToStringInfoTabSummaryTbcMain.Text = account.ToString
    End Sub '_lstAccountIDTabSummaryTbcMain_SelectedIndexChanged

    Private Sub _lstTrxIDTabSummaryTbcMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTrxIDTabSummaryTbcMain.SelectedIndexChanged
        'finds the details associated with the trx ID selected in the summary tab
        Try
            Dim transaction = mTheBank.findTransaction(lstTrxIDTabSummaryTbcMain.SelectedItem.ToString)
            'prints toString of trx ID selected in the summary tab to ToString information box
            txtToStringInfoTabSummaryTbcMain.Text = transaction.ToString
        Catch ex As Exception
        End Try
    End Sub '_lstTrxIDTabSummaryTbcMain_SelectedIndexChanged

    Private Sub _lstTrxLineIDTabSummaryTbcMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTrxLineIDTabSummaryTbcMain.SelectedIndexChanged
        'finds the details associated with the trx Line ID selected in the summary tab
        Try
            Dim transaction = mTheBank.findTransactionLine(lstTrxLineIDTabSummaryTbcMain.SelectedItem.ToString)
            'prints toString of trx Line ID selected in the summary tab to ToString information box
            txtToStringInfoTabSummaryTbcMain.Text = transaction.ToString
        Catch ex As Exception
        End Try
    End Sub '_lstTrxLineIDTabSummaryTbcMain_SelectedIndexChanged

    Private Sub _cboCustomerIDTabCustomerTbcMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCustomerIDTabCustomerTbcMain.SelectedIndexChanged
        'finds the details associated with the customer ID selected in the customer tab
        Dim customer = mTheBank.findCustomer(cboCustomerIDTabCustomerTbcMain.SelectedItem.ToString)
        'prints toString of customer ID selected in the customer tab to ToString information box
        txtToStringInfoTabCustomerTbcMain.Text = customer.ToString
    End Sub '_cboCustomerIDTabCustomerTbcMain_SelectedIndexChanged

    Private Sub _lstTrxIDTabCustomerTbcMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTrxIDTabCustomerTbcMain.SelectedIndexChanged
        'prints toString of customer created  in the customer tab to ToString information box
        txtToStringInfoTabCustomerTbcMain.Text = lstTrxIDTabCustomerTbcMain.SelectedItem.ToString

    End Sub '_lstTrxIDTabCustomerTbcMain_SelectedIndexChanged

    Private Sub _lstCustomerIDTabAccountTbcMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCustomerIDTabAccountTbcMain.SelectedIndexChanged
        'finds the details associated with the customer ID selected in the account tab
        Dim customer = mTheBank.findCustomer(lstCustomerIDTabAccountTbcMain.SelectedItem.ToString)
        'prints toString of account ID selected in the account tab to ToString information box
        txtToStringInfoTabAccountTbcMain.Text = customer.ToString
    End Sub '_lstCustomerIDTabAccountTbcMain_SelectedIndexChanged

    Private Sub _lstTrxLineIDTabAccountTbcMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTrxLineIDTabAccountTbcMain.SelectedIndexChanged
        'finds the details associated with the trx Line ID selected in the account tab
        Try
            Dim transaction = mTheBank.findTransactionLine(lstTrxLineIDTabAccountTbcMain.SelectedItem.ToString)
            'prints toString of trx line ID selected in the account tab to ToString information box
            txtToStringInfoTabAccountTbcMain.Text = transaction.ToString
        Catch ex As Exception
        End Try
    End Sub '_lstTrxLineIDTabAccountTbcMain_SelectedIndexChanged

    Private Sub _lstNewOwnerIDGrpCreateModifyTabAccountTbcMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.SelectedIndexChanged

    End Sub '_lstNewOwnerIDGrpCreateModifyTabAccountTbcMain_SelectedIndexChanged

    Private Sub _cboAccountIDTabAccountTbcMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAccountIDTabAccountTbcMain.SelectedIndexChanged
        'finds the details associated with the account ID selected in the account tab
        Dim account = mTheBank.findAccount(cboAccountIDTabAccountTbcMain.SelectedItem.ToString)

        'clearing the customer IDs and trx Line IDs  from the list to prepare for the fresh IDs to be displayed
        lstCustomerIDTabAccountTbcMain.Items.Clear()
        lstTrxLineIDTabAccountTbcMain.Items.Clear()

        'prints toString of account ID selected in the account tab to ToString information box
        txtToStringInfoTabAccountTbcMain.Text = account.ToString
        Try
            For Each accnt As Account In mTheBank.iterateAccount
                If cboAccountIDTabAccountTbcMain.SelectedItem.ToString = account.accID Then
                    For pLocationFound = 0 To accnt.accOwner.Length - 1
                        'all the customer IDs associated with the account IDs are added to the list
                        lstCustomerIDTabAccountTbcMain.Items.Add(accnt.accOwner(pLocationFound).custID)
                    Next pLocationFound
                End If
            Next accnt

            For Each txn As Transaction In mTheBank.iterateTransaction
                If cboAccountIDTabAccountTbcMain.SelectedItem.ToString = txn.trxAccID Then
                    Try
                        'all the trx Line IDs associated with the account IDs are added to the list
                        lstTrxLineIDTabAccountTbcMain.Items.Add(txn.trxLineID)
                    Catch ex As Exception
                        'all the from trx Line IDs associated with the account IDs are added to the list
                        lstTrxLineIDTabAccountTbcMain.Items.Add(txn.fromTrxLineID)
                    End Try
                End If
            Next txn

            'displaying the count of the owners/customer IDs and trx Line IDs 
            lblCountOwnersTabAccountTbcMain.Text = CType(lstCustomerIDTabAccountTbcMain.Items.Count, String)
            lblCountTrxLinesTabAccountTbcMain.Text = CType(lstTrxLineIDTabAccountTbcMain.Items.Count, String)

            If account.accType = AccountType.Checking Then
                radCheckingGrpTypeGrpCreateModifyTabAccountTbcMain.Select()
            End If

            If account.accType = AccountType.Loan Then
                radLoanGrpTypeGrpCreateModifyTabAccountTbcMain.Select()
            End If

            If account.accType = AccountType.CreditCard Then
                radCreditCardGrpTypeGrpCreateModifyTabAccountTbcMain.Select()
            End If
        Catch ex As Exception
        End Try
        'flushing all the fields with the data associated with the selected Account ID
        txtNameGrpCreateModifyTabAccountTbcMain.Text = account.accName
        dtpDateOpenedGrpCreateModifyTabAccountTbcMain.Text = account.accDateOpened.ToString
        txtAmountGrpCreateModifyTabAccountTbcMain.Text = account.accBalance.ToString
        txtTrxIDGrpCreateModifyTabAccountTbcMain.Text = account.accTrxID
        txtTrxLineIDGrpCreateModifyTabAccountTbcMain.Text = account.accTrxLineID
        nudAPRGrpCreateModifyTabAccountTbcMain.Text = account.accAPR.ToString
        dtpNextInterestAccrualDateGrpCreateModifyTabAccountTbcMain.Text = account.accAccrualDate.ToString

        'disabling fields which are not to be modified
        dtpDateOpenedGrpCreateModifyTabAccountTbcMain.Enabled = False
        txtAmountGrpCreateModifyTabAccountTbcMain.Enabled = False
        txtTrxIDGrpCreateModifyTabAccountTbcMain.Enabled = False
        txtTrxLineIDGrpCreateModifyTabAccountTbcMain.Enabled = False
        grpTypeGrpCreateModifyTabAccountTbcMain.Enabled = False
        grpCreateModifyTabAccountTbcMain.Enabled = True
    End Sub '_cboAccountIDTabAccountTbcMain_SelectedIndexChanged


    Private Sub _cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.SelectedIndexChanged
        'clears the account IDs to prepare to print fresh ones
        cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Items.Clear()

        Dim customer = mTheBank.findCustomer(cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.SelectedItem.ToString)
        'prints toString of the customer ID selected in this transaction tab
        txtToStringTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text = customer.ToString
        Try
            For Each accnt As Account In mTheBank.iterateAccount
                For pLocationFound = 0 To accnt.accOwner.Length - 1
                    If cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.SelectedItem.ToString = accnt.accOwner(pLocationFound).custID Then
                        'displaying the account IDs associated with the customer ID
                        cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Items.Add(accnt.accID)
                        'lstCustomerIDTabAccountTbcMain.Items.Add(acc.owner(pLocationFound).custId)
                    End If
                Next pLocationFound
            Next accnt
        Catch ex As Exception
        End Try
    End Sub '_cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain_SelectedIndexChanged

    Private Sub _cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.SelectedIndexChanged
        'finds the details associated with the account ID selected in the transaction tab
        Dim account = mTheBank.findAccount(cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.SelectedItem.ToString)
        'prints toString of account ID selected in the transaction tab to ToString information box
        txtToStringTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text = account.ToString
    End Sub '_cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain_SelectedIndexChanged

    Private Sub _cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectedIndexChanged
        'clears the from and to account IDs from the combo box to prepare for fresh IDs
        cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Items.Clear()
        cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Items.Clear()

        Dim customer = mTheBank.findCustomer(cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectedItem.ToString)
        'prints toString of customer id selected in the transaction tab to ToString information box
        txtToStringTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text = customer.ToString
        Try
            For Each accnt As Account In mTheBank.iterateAccount
                For pLocationFound = 0 To accnt.accOwner.Length - 1
                    If cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectedItem.ToString = accnt.accOwner(pLocationFound).custID Then
                        'displaying account IDs associated with the customer ID selected
                        cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Items.Add(accnt.accID)
                        cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Items.Add(accnt.accID)
                    End If
                Next pLocationFound
            Next accnt
        Catch ex As Exception
        End Try
    End Sub '_cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain_SelectedIndexChanged

    Private Sub _cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectedIndexChanged

        Dim account = mTheBank.findAccount(cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectedItem.ToString)
        'prints toString of account id selected in the transaction tab to ToString information box
        txtToStringTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text = account.ToString
        'clearing the to account IDs to prepare for diplaying the fresh IDs
        cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Items.Clear()

        For Each accnt As Account In mTheBank.iterateAccount
            For pLocationFound = 0 To accnt.accOwner.Length - 1
                If cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectedItem.ToString = accnt.accOwner(pLocationFound).custID Then
                    'displaying the to account IDs associated with the customer ID
                    cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Items.Add(accnt.accID)
                End If
            Next pLocationFound
        Next accnt
        'removing the from account ID from the combo box so that the list gets freshly populated for the next transaction
        cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Items.Remove(cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectedItem.ToString)

    End Sub '_cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain_SelectedIndexChanged

    Private Sub _cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectedIndexChanged
        'finds the to account ID selected in the combo box
        Dim account = mTheBank.findAccount(cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectedItem.ToString)
        'prints toString of account ID selected in the transaction tab to ToString information box
        txtToStringTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text = account.ToString
    End Sub '_cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain_SelectedIndexChanged

    Private Sub _cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.SelectedIndexChanged
        'finds the account ID selected in the combo box
        Dim account = mTheBank.findAccount(cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.SelectedItem.ToString)
        'prints toString of account ID selected in the transaction tab to ToString information box
        txtToStringTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text = account.ToString
    End Sub '_cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain_SelectedIndexChanged

    'this handles disabling of boxes according to radio buttonselected
    Private Sub _radAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain_SelectedIndexChanged(
            sender As Object,
            e As EventArgs) _
        Handles _
            radAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.CheckedChanged, radSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.CheckedChanged

        If radAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Checked Then
            grpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Enabled = True
            grpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Enabled = False
        Else
            grpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Enabled = False
            grpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Enabled = True
        End If

    End Sub '_radAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain

    Private Sub _txtTrxLog_TextChanged(
           sender As Object,
           e As EventArgs) Handles txtTrxLog.TextChanged


        txtTrxLog.SelectionStart = txtTrxLog.TextLength
        txtTrxLog.ScrollToCaret()

    End Sub '_txtTransactionLogTabLog(sender,e)

    Private Sub _btnAddAccountOwnerGrpCreateModifyTabAccountTbcMain_Click(sender As Object, e As EventArgs) Handles btnAddAccountOwnerGrpCreateModifyTabAccountTbcMain.Click
        'adding a new customer ID into the add owner array
        lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.Items.Add(cboCustomerIDGrpCreateModifyTabAccountTbcMain.SelectedItem.ToString)
    End Sub '_btnAddAccountOwnerGrpCreateModifyTabAccountTbcMain_Click


    '********** Business Logic Event Procedures
    '             - Initiated as a result of business logic
    '               method(s) running
    Private Sub _customerAdded(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mTheBank.Bank_CustomerAdded

        'Declare variables
        Dim theCustomer_EventArgs_CustomerAdded As Customer_EventArgs_CustomerAdded
        Dim theCustomer As Customer

        'Get/validate data
        theCustomer_EventArgs_CustomerAdded = CType(e, Customer_EventArgs_CustomerAdded)

        theCustomer = theCustomer_EventArgs_CustomerAdded.customer

        lstCustomerIDTabSummaryTbcMain.Items.Add(theCustomer.custID)
        cboCustomerIDTabCustomerTbcMain.Items.Add(theCustomer.custID)
        cboCustomerIDGrpCreateModifyTabAccountTbcMain.Items.Add(theCustomer.custID)
        cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Items.Add(theCustomer.custID)
        cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Items.Add(theCustomer.custID)
        lblCountCustomerTabCustomerTbcMain.Text = CType(_theBank.numCustomers, String)

        'Display output
        '   txtTrx.Text &= vbCrLf & "- Customer ADDED: " & theDatesTimes.ToString

        'Get ready for next input

    End Sub '_customerAdded(sender,e)

    Private Sub _accountAdded(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mTheBank.Bank_AccountAdded

        'Declare variables
        Dim theAccount_EventArgs_AccountAdded As Account_EventArgs_AccountAdded
        Dim theAccount As Account

        'Get/validate data
        theAccount_EventArgs_AccountAdded = CType(e, Account_EventArgs_AccountAdded)

        theAccount = theAccount_EventArgs_AccountAdded.account

        cboAccountIDTabAccountTbcMain.Items.Add(theAccount.accID)
        cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Items.Add(theAccount.accID)
        lstAccountIDTabSummaryTbcMain.Items.Add(theAccount.accID)
        lblCountTrxTabSummaryTbcMain.Text = CType(_theBank.numTransactions, String)
        lblCountTrxLineTabSummaryTbcMain.Text = CType(_theBank.numTransactions, String)

        'Display output
        txtTrxLog.Text &= vbCrLf & "- Account ADDED: " & theAccount.ToString

    End Sub '_accountAdded(sender,e)
    Private Sub _modifyAccount(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mTheBank.Bank_AccountModified

        'Declare variables
        Dim theAccount_EventArgs_AccountModified As Account_EventArgs_AccountModified
        Dim theAccount As Account

        'Get/validate data
        theAccount_EventArgs_AccountModified = CType(e, Account_EventArgs_AccountModified)

        theAccount = theAccount_EventArgs_AccountModified.account



    End Sub '_modifyAccount(sender, e)

    Private Sub _depositMade(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mTheBank.Bank_DepositMade

        'Declare variables
        Dim theTransaction_EventArgs_TransactionProcessed As Transaction_EventArgs_TransactionProcessed
        Dim theTransaction As Transaction

        'Get/validate data
        theTransaction_EventArgs_TransactionProcessed = CType(e, Transaction_EventArgs_TransactionProcessed)

        theTransaction = theTransaction_EventArgs_TransactionProcessed.transaction
        lstTrxIDTabSummaryTbcMain.Items.Add(theTransaction.trxID)
        lstTrxLineIDTabSummaryTbcMain.Items.Add(theTransaction.trxLineID)
        lblCountTrxTabSummaryTbcMain.Text = CType(_theBank.numTransactions, String)
        lblCountTrxLineTabSummaryTbcMain.Text = CType(_theBank.numTransactions, String)


    End Sub '_depositMade(sender,e)

    Private Sub _withdrawalMade(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mTheBank.Bank_WithdrawalMade

        'Declare variables
        Dim theTransaction_EventArgs_TransactionProcessed As Transaction_EventArgs_TransactionProcessed
        Dim theTransaction As Transaction

        'Get/validate data
        theTransaction_EventArgs_TransactionProcessed = CType(e, Transaction_EventArgs_TransactionProcessed)

        theTransaction = theTransaction_EventArgs_TransactionProcessed.transaction
        lstTrxIDTabSummaryTbcMain.Items.Add(theTransaction.trxID)
        lstTrxLineIDTabSummaryTbcMain.Items.Add(theTransaction.trxLineID)
        lblCountTrxTabSummaryTbcMain.Text = CType(_theBank.numTransactions, String)
        lblCountTrxLineTabSummaryTbcMain.Text = CType(_theBank.numTransactions, String)



    End Sub '_withdrawalMade(sender,e)

    Private Sub _debitCardUsed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mTheBank.Bank_DebitCardUsed

        'Declare variables
        Dim theTransaction_EventArgs_TransactionProcessed As Transaction_EventArgs_TransactionProcessed
        Dim theTransaction As Transaction

        'Get/validate data
        theTransaction_EventArgs_TransactionProcessed = CType(e, Transaction_EventArgs_TransactionProcessed)

        theTransaction = theTransaction_EventArgs_TransactionProcessed.transaction
        lstTrxIDTabSummaryTbcMain.Items.Add(theTransaction.trxID)
        lstTrxLineIDTabSummaryTbcMain.Items.Add(theTransaction.trxLineID)
        lblCountTrxTabSummaryTbcMain.Text = CType(_theBank.numTransactions, String)
        lblCountTrxLineTabSummaryTbcMain.Text = CType(_theBank.numTransactions, String)


    End Sub '_debitCardUsed(sender,e)

    Private Sub _purchaseCharged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mTheBank.Bank_PurchaseCharged

        'Declare variables
        Dim theTransaction_EventArgs_TransactionProcessed As Transaction_EventArgs_TransactionProcessed
        Dim theTransaction As Transaction

        'Get/validate data
        theTransaction_EventArgs_TransactionProcessed = CType(e, Transaction_EventArgs_TransactionProcessed)

        theTransaction = theTransaction_EventArgs_TransactionProcessed.transaction
        lstTrxIDTabSummaryTbcMain.Items.Add(theTransaction.trxID)
        lstTrxLineIDTabSummaryTbcMain.Items.Add(theTransaction.trxLineID)
        lblCountTrxTabSummaryTbcMain.Text = CType(_theBank.numTransactions, String)
        lblCountTrxLineTabSummaryTbcMain.Text = CType(_theBank.numTransactions, String)


    End Sub '_customerAdded(sender,e)

    Private Sub _paymentMade(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mTheBank.Bank_PaymentMade

        'Declare variables
        Dim theTransaction_EventArgs_TransactionProcessed As Transaction_EventArgs_TransactionProcessed
        Dim theTransaction As Transaction

        'Get/validate data
        theTransaction_EventArgs_TransactionProcessed = CType(e, Transaction_EventArgs_TransactionProcessed)

        theTransaction = theTransaction_EventArgs_TransactionProcessed.transaction
        lstTrxIDTabSummaryTbcMain.Items.Add(theTransaction.trxID)

        lstTrxLineIDTabSummaryTbcMain.Items.Add(theTransaction.toTrxLineID)
        lblCountTrxTabSummaryTbcMain.Text = CType(_theBank.numTransactions, String)
        lblCountTrxLineTabSummaryTbcMain.Text = CType(_theBank.numTransactions, String)

    End Sub '_paymentMade(sender,e)

    Private Sub _fundsTransferred(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mTheBank.Bank_FundsTransferred

        'Declare variables
        Dim theTransaction_EventArgs_TransactionProcessed As Transaction_EventArgs_TransactionProcessed
        Dim theTransaction As Transaction

        'Get/validate data
        theTransaction_EventArgs_TransactionProcessed = CType(e, Transaction_EventArgs_TransactionProcessed)

        theTransaction = theTransaction_EventArgs_TransactionProcessed.transaction
        lstTrxIDTabSummaryTbcMain.Items.Add(theTransaction.trxID)

        lstTrxLineIDTabSummaryTbcMain.Items.Add(theTransaction.toTrxLineID)
        lblCountTrxTabSummaryTbcMain.Text = CType(_theBank.numTransactions, String)
        lblCountTrxLineTabSummaryTbcMain.Text = CType(_theBank.numTransactions, String)


    End Sub '_fundsTransferred(sender,e)

    Private Sub _accrualCalculation(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mTheBank.Bank_AccrualCalculated

        'Declare variables
        Dim theTransaction_EventArgs_TransactionProcessed As Transaction_EventArgs_TransactionProcessed
        Dim theTransaction As Transaction

        'Get/validate data
        theTransaction_EventArgs_TransactionProcessed = CType(e, Transaction_EventArgs_TransactionProcessed)

        theTransaction = theTransaction_EventArgs_TransactionProcessed.transaction
        lstTrxIDTabSummaryTbcMain.Items.Add(theTransaction.trxID)
        lstTrxLineIDTabSummaryTbcMain.Items.Add(theTransaction.trxLineID)
        lblCountTrxTabSummaryTbcMain.Text = CType(_theBank.numTransactions, String)
        lblCountTrxLineTabSummaryTbcMain.Text = CType(_theBank.numTransactions, String)

    End Sub '_accrualCalculation(sender,e)

    Private Sub dtpDateOpenedGrpCreateModifyTabAccountTbcMain_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateOpenedGrpCreateModifyTabAccountTbcMain.ValueChanged
        Dim theAccDateOpened As Date
        Dim theAccAccrualDate As Date
        theAccDateOpened = CDate(dtpDateOpenedGrpCreateModifyTabAccountTbcMain.Text)
        '
        If theAccDateOpened.AddDays(1).Day.Equals(1) Then
            theAccAccrualDate = theAccDateOpened.AddDays(1).AddMonths(1).AddDays(-1).Date
        Else
            theAccAccrualDate = theAccDateOpened.AddMonths(1).Date
        End If

        dtpNextInterestAccrualDateGrpCreateModifyTabAccountTbcMain.Text = theAccAccrualDate.ToString

    End Sub

    Private Sub _changedMetrics(
            ByVal sender As System.Object,
            ByVal e As System.EventArgs) _
        Handles mTheBank.Bank_ChangedMetrics

        Dim totalBalance As Decimal
        Dim averageBalance As Decimal
        Dim totalAge As Decimal
        Dim averageAge As Decimal
        Dim maxAge As Integer
        maxAge = 0
        Dim noOfCheckingAccount As Integer
        noOfCheckingAccount = 0


        For Each accnt As Account In _theBank.iterateAccount
            If accnt.accType.ToString = "Checking" Then
                totalBalance = totalBalance + accnt.accBalance
                noOfCheckingAccount = noOfCheckingAccount + 1
            End If
        Next accnt

        For Each cust As Customer In _theBank.iterateCustomer
            totalAge = totalAge + CType(cust.custAge, Decimal)
            If maxAge < cust.custAge Then
                maxAge = cust.custAge
            End If
        Next cust

        Try
            averageBalance = totalBalance / noOfCheckingAccount
            averageAge = totalAge / _theBank.numCustomers

        Catch ex As Exception
        End Try


        txtMetricsGrpMetricsTabSummaryTbcMain.Text = vbCrLf & "The average checking balance is: " & averageBalance & vbCrLf & "The average age: " & averageAge & vbCrLf & "The maximum age: " & maxAge


    End Sub '_changedMetrics(sender,e)
#End Region 'Event Procedures

#Region "Events"
    '******************************************************************
    'Events
    '******************************************************************

    'No Events are currently defined.
    'These are all public.

#End Region 'Events

End Class 'FrmMain