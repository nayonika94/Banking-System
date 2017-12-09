Public Module ModBank

    'This holds "global" type definitions, not "global" variables...  :-)

    'Enum entries are Integers, which can include negative values.
    'Default value for first entry is 0.
    'Default value for subsequent entries is 1 more than the previous entrie's value.
    'You can assign 
    Public Enum AccountType
        Checking = 1
        Loan
        CreditCard
    End Enum 'AccountType

    Public Enum TransactionType
        MakeDeposit = 1
        MakeWithdrawal
        UseDebitCard
        ChargePurchase
        MakePayment
        TransferFunds
        AllAccounts
        SpecificAccount
    End Enum 'TransactionType

End Module 'ModBank
