using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Contains details about a student loan account
/// </summary>
public record StudentLoan
{
    /// <summary>
    /// The ID of the account that this liability belongs to. Each account can only contain one liability.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string? AccountId { get; init; }

    /// <summary>
    /// The account number of the loan. For some institutions, this may be a masked version of the number (e.g., the last 4 digits instead of the entire number).
    /// </summary>
    [JsonPropertyName("account_number")]
    public required string? AccountNumber { get; init; }

    /// <summary>
    /// The dates on which loaned funds were disbursed or will be disbursed. These are often in the past. Dates are returned in an <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("disbursement_dates")]
    public required IReadOnlyList<DateTimeOffset>? DisbursementDates { get; init; }

    /// <summary>
    /// The date when the student loan is expected to be paid off. Availability for this field is limited. Dates are returned in an <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("expected_payoff_date")]
    public required DateTimeOffset? ExpectedPayoffDate { get; init; }

    /// <summary>
    /// The guarantor of the student loan.
    /// </summary>
    [JsonPropertyName("guarantor")]
    public required string? Guarantor { get; init; }

    /// <summary>
    /// The interest rate on the loan as a percentage.
    /// </summary>
    [JsonPropertyName("interest_rate_percentage")]
    public required double InterestRatePercentage { get; init; }

    /// <summary>
    /// <c>true</c> if a payment is currently overdue. Availability for this field is limited.
    /// </summary>
    [JsonPropertyName("is_overdue")]
    public required bool? IsOverdue { get; init; }

    /// <summary>
    /// The amount of the last payment.
    /// </summary>
    [JsonPropertyName("last_payment_amount")]
    public required double? LastPaymentAmount { get; init; }

    /// <summary>
    /// The date of the last payment. Dates are returned in an <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("last_payment_date")]
    public required DateTimeOffset? LastPaymentDate { get; init; }

    /// <summary>
    /// The total amount owed as of the last statement issued
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_statement_balance")]
    public double? LastStatementBalance { get; init; }

    /// <summary>
    /// The date of the last statement. Dates are returned in an <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("last_statement_issue_date")]
    public required DateTimeOffset? LastStatementIssueDate { get; init; }

    /// <summary>
    /// The type of loan, e.g., "Consolidation Loans".
    /// </summary>
    [JsonPropertyName("loan_name")]
    public required string? LoanName { get; init; }

    /// <summary>
    /// An object representing the status of the student loan
    /// </summary>
    [JsonPropertyName("loan_status")]
    public required StudentLoanStatus LoanStatus { get; init; }

    /// <summary>
    /// The minimum payment due for the next billing cycle. There are some exceptions:
    /// Some institutions require a minimum payment across all loans associated with an account number. Our API presents that same minimum payment amount on each loan. The institutions that do this are: Great Lakes ( <c>ins_116861</c>), Firstmark (<c>ins_116295</c>), Commonbond Firstmark Services (<c>ins_116950</c>), Granite State (<c>ins_116308</c>), and Oklahoma Student Loan Authority (<c>ins_116945</c>).
    /// Firstmark (<c>ins_116295</c> ) and Navient (<c>ins_116248</c>) will display as $0 if there is an autopay program in effect.
    /// </summary>
    [JsonPropertyName("minimum_payment_amount")]
    public required double? MinimumPaymentAmount { get; init; }

    /// <summary>
    /// The due date for the next payment. The due date is <c>null</c> if a payment is not expected. A payment is not expected if <c>loan_status.type</c> is <c>deferment</c>, <c>in school</c>, <c>consolidated</c>, <c>paid in full</c>, or <c>transferred</c>. Dates are returned in an <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("next_payment_due_date")]
    public required DateTimeOffset? NextPaymentDueDate { get; init; }

    /// <summary>
    /// The date on which the loan was initially lent. Dates are returned in an <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("origination_date")]
    public required DateTimeOffset? OriginationDate { get; init; }

    /// <summary>
    /// The original principal balance of the loan.
    /// </summary>
    [JsonPropertyName("origination_principal_amount")]
    public required double? OriginationPrincipalAmount { get; init; }

    /// <summary>
    /// The total dollar amount of the accrued interest balance. For Sallie Mae ( <c>ins_116944</c>), this amount is included in the current balance of the loan, so this field will return as <c>null</c>.
    /// </summary>
    [JsonPropertyName("outstanding_interest_amount")]
    public required double? OutstandingInterestAmount { get; init; }

    /// <summary>
    /// The relevant account number that should be used to reference this loan for payments. In the majority of cases, <c>payment_reference_number</c> will match <c>account_number</c>, but in some institutions, such as Great Lakes (<c>ins_116861</c>), it will be different.
    /// </summary>
    [JsonPropertyName("payment_reference_number")]
    public required string? PaymentReferenceNumber { get; init; }

    /// <summary>
    /// Information about the student's eligibility in the Public Service Loan Forgiveness program. This is only returned if the institution is FedLoan (<c>ins_116527</c>). Since FedLoan no longer services student loans, this field is no longer returned.
    /// </summary>
    [JsonPropertyName("pslf_status")]
    public required PslfStatus PslfStatus { get; init; }

    /// <summary>
    /// An object representing the repayment plan for the student loan
    /// </summary>
    [JsonPropertyName("repayment_plan")]
    public required StudentRepaymentPlan RepaymentPlan { get; init; }

    /// <summary>
    /// The sequence number of the student loan. Heartland ECSI (<c>ins_116948</c>) does not make this field available.
    /// </summary>
    [JsonPropertyName("sequence_number")]
    public required string? SequenceNumber { get; init; }

    /// <summary>
    /// The address of the student loan servicer. This is generally the remittance address to which payments should be sent.
    /// </summary>
    [JsonPropertyName("servicer_address")]
    public required ServicerAddressData ServicerAddress { get; init; }

    /// <summary>
    /// The year to date (YTD) interest paid. Availability for this field is limited.
    /// </summary>
    [JsonPropertyName("ytd_interest_paid")]
    public required double? YtdInterestPaid { get; init; }

    /// <summary>
    /// The year to date (YTD) principal paid. Availability for this field is limited.
    /// </summary>
    [JsonPropertyName("ytd_principal_paid")]
    public required double? YtdPrincipalPaid { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
