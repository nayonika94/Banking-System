'Copyright (c) 2009-2016 Dan Turk

#Region "Class / File Comment Header block"
'Program:            Banking
'File:               ClsAccount_EventArgs_AccountAdded.vb
'Author:             Nayonika Roy
'Description:        User Interface for the Banking project.
'Date:               
'                    2016 Nov 14
'                      - created the Event Args class for adding new accounts
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

Public Class Account_EventArgs_AccountAdded
    Inherits System.EventArgs

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************

    'No Attributes are currently defined.

    '********** Module-level constants

    '********** Module-level variables

    Private mTheAccount As Account

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

    Public Sub New(
            ByVal pAccount As Account
            )

        'Special constructor - create the EventArgs object.

        MyBase.New()

        _account = pAccount

    End Sub

    '********** Copy constructor(s)
    '             - one parameter, an object of the same class

#End Region 'Constructors

#Region "Get/Set Methods"
    '******************************************************************
    'Get/Set Methods
    '******************************************************************

    '********** Public Get/Set Methods
    '             - call private get/set methods to implement
    Public ReadOnly Property account As Account
        Get
            Return _account
        End Get
    End Property

    'Private Get/Set Methods - access attributes, 
    '                          begin name with underscore (_)

    Private Property _account As Account
        Get
            Return mTheAccount
        End Get
        Set(pValue As Account)
            mTheAccount = pValue
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

        'ToString() is the public interface that
        'provides a String version of the data
        'stored in the class attributes.

        Return _toString()

    End Function 'ToString()

    'Private Non-Shared Behavioral Methods

    Private Function _toString() As String

        '_toString() is the private interface that
        'provides a String version of the data
        'stored in the class attributes.
        '_toString() does the actual work of composing
        'and formatting the string.

        Dim tmpStr As String

        tmpStr =
            "( Account EVENT_ARGS Account_ADDED: " _
            & "Account=" & _account.ToString _
            & " )"

        Return tmpStr

    End Function '_toString()

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

End Class 'Account_EventArgs_AccountAdded
