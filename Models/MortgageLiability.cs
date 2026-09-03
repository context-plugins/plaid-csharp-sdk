using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Contains details about a mortgage account.
/// </summary>
public record MortgageLiability
{
    /// <summary>
    /// The ID of the account that this liability belongs to.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// The account number of the loan.
    /// </summary>
    [JsonPropertyName("account_number")]
    public required string? AccountNumber { get; init; }

    /// <summary>
    /// The current outstanding amount charged for late payment.
    /// </summary>
    [JsonPropertyName("current_late_fee")]
    public required double? CurrentLateFee { get; init; }

    /// <summary>
    /// Total amount held in escrow to pay taxes and insurance on behalf of the borrower.
    /// </summary>
    [JsonPropertyName("escrow_balance")]
    public required double? EscrowBalance { get; init; }

    /// <summary>
    /// Indicates whether the borrower has private mortgage insurance in effect.
    /// </summary>
    [JsonPropertyName("has_pmi")]
    public required bool? HasPmi { get; init; }

    /// <summary>
    /// Indicates whether the borrower will pay a penalty for early payoff of mortgage.
    /// </summary>
    [JsonPropertyName("has_prepayment_penalty")]
    public required bool? HasPrepaymentPenalty { get; init; }

    /// <summary>
    /// Object containing metadata about the interest rate for the mortgage.
    /// </summary>
    [JsonPropertyName("interest_rate")]
    public required MortgageInterestRate InterestRate { get; init; }

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
    /// Description of the type of loan, for example <c>conventional</c>, <c>fixed</c>, or <c>variable</c>. This field is provided directly from the loan servicer and does not have an enumerated set of possible values.
    /// </summary>
    [JsonPropertyName("loan_type_description")]
    public required string? LoanTypeDescription { get; init; }

    /// <summary>
    /// Full duration of mortgage as at origination (e.g. <c>10 year</c>).
    /// </summary>
    [JsonPropertyName("loan_term")]
    public required string? LoanTerm { get; init; }

    /// <summary>
    /// Original date on which mortgage is due in full. Dates are returned in an <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("maturity_date")]
    public required DateTimeOffset? MaturityDate { get; init; }

    /// <summary>
    /// The amount of the next payment.
    /// </summary>
    [JsonPropertyName("next_monthly_payment")]
    public required double? NextMonthlyPayment { get; init; }

    /// <summary>
    /// The due date for the next payment. Dates are returned in an <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("next_payment_due_date")]
    public required DateTimeOffset? NextPaymentDueDate { get; init; }

    /// <summary>
    /// The date on which the loan was initially lent. Dates are returned in an <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("origination_date")]
    public required DateTimeOffset? OriginationDate { get; init; }

    /// <summary>
    /// The original principal balance of the mortgage.
    /// </summary>
    [JsonPropertyName("origination_principal_amount")]
    public required double? OriginationPrincipalAmount { get; init; }

    /// <summary>
    /// Amount of loan (principal + interest) past due for payment.
    /// </summary>
    [JsonPropertyName("past_due_amount")]
    public required double? PastDueAmount { get; init; }

    /// <summary>
    /// Object containing fields describing property address.
    /// </summary>
    [JsonPropertyName("property_address")]
    public required MortgagePropertyAddress PropertyAddress { get; init; }

    /// <summary>
    /// The year to date (YTD) interest paid.
    /// </summary>
    [JsonPropertyName("ytd_interest_paid")]
    public required double? YtdInterestPaid { get; init; }

    /// <summary>
    /// The YTD principal paid.
    /// </summary>
    [JsonPropertyName("ytd_principal_paid")]
    public required double? YtdPrincipalPaid { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
