'Project:           Mortgage Calculator
'Programmer:        Dan Roberts
'Date:              August 06,2012
'Description:       Data class assigns the property values for each parameter 
'                   and access for each form.

Public Class Data
    'Assign the variables
    Private LoanDouble As Double
    Private TermInteger As Integer
    Private InterestDouble As Double
    Private NumberPaymentsInteger As Integer
    Private Shared TotalLoan As Double
    Private Shared Payment As Double
    Private Shared NumberPayments As Integer
    Private Shared MonthlyInterest As Double
    Private Shared StartDate As Date


    Private Loan As Double
    Public Property _Loan() As Double
        Get
            Return Loan
        End Get
        Set(ByVal value As Double)
            Loan = value
        End Set
    End Property

    Private Term As Integer
    Public Property _Term() As Integer
        Get
            Return Term
        End Get
        Set(ByVal value As Integer)
            Term = value
        End Set
    End Property

    Private Interest As Double
    Public Property _Interest() As Double

        Get
            Return Interest
        End Get
        Set(ByVal value As Double)
            Interest = value
        End Set
    End Property

    Private DateStart As Date
    Public Property _StartDate() As Date
        Get
            Return StartDate
        End Get
        Set(ByVal value As Date)
            StartDate = value
        End Set
    End Property

    Public PaymentNumber As Integer
    Public Property _NumberPayments() As Integer
        Get
            Return NumberPayments
        End Get
        Set(ByVal value As Integer)
            NumberPayments = value
        End Set
    End Property

    Public InterestMonthly As Double
    Public Property _MonthlyInterest() As Double
        Get
            Return MonthlyInterest
        End Get
        Set(ByVal value As Double)
            MonthlyInterest = value
        End Set
    End Property


    Sub New(ByVal LoanIn As Double, ByVal TermIn As Integer, ByVal InterestIn As Double, ByVal StartDateIn As String)
        'Parameter Constructor
        Loan = LoanIn
        Term = TermIn
        Interest = InterestIn
        StartDate = StartDateIn
    End Sub
    Protected Sub TermByMonth()
        'Term divided by Month
        NumberPayments = Term * 12
    End Sub

    Protected Sub InterestByMonth()
        'Interest Divided by Month
        MonthlyInterest = (Interest / 100) / 12

    End Sub

    Public Sub Monthly()
        'Calculate Monthly Payment
        TermByMonth()
        InterestByMonth()
        Payment = -Pmt(MonthlyInterest, NumberPayments, Loan)
        'Calculate Total of the loan
        TotalLoan = Payment * NumberPayments
    End Sub

    Shared ReadOnly Property MonthlyPayment() As Double
        Get
            Return Payment
        End Get
    End Property

    Shared ReadOnly Property LoanTotal() As Double
        Get
            Return TotalLoan
        End Get
    End Property

    Shared ReadOnly Property numPayments() As Integer
        Get
            Return NumberPayments

        End Get
    End Property

    Shared ReadOnly Property MonthInterest() As Double
        Get
            Return MonthlyInterest
        End Get
    End Property

    Shared ReadOnly Property PayDate() As Date
        Get
            Return StartDate
        End Get
    End Property


End Class
