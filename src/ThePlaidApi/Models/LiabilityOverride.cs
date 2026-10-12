using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Used to configure Sandbox test data for the Liabilities product
/// </summary>
public record LiabilityOverride
{
    /// <summary>
    /// The type of the liability object, either <c>credit</c> or <c>student</c>. Mortgages are not currently supported in the custom Sandbox.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    /// <summary>
    /// The purchase APR percentage value. For simplicity, this is the only interest rate used to calculate interest charges. Can only be set if <c>type</c> is <c>credit</c>.
    /// </summary>
    [JsonPropertyName("purchase_apr")]
    public required double PurchaseApr { get; init; }

    /// <summary>
    /// The cash APR percentage value. Can only be set if <c>type</c> is <c>credit</c>.
    /// </summary>
    [JsonPropertyName("cash_apr")]
    public required double CashApr { get; init; }

    /// <summary>
    /// The balance transfer APR percentage value. Can only be set if <c>type</c> is <c>credit</c>.
    /// </summary>
    [JsonPropertyName("balance_transfer_apr")]
    public required double BalanceTransferApr { get; init; }

    /// <summary>
    /// The special APR percentage value. Can only be set if <c>type</c> is <c>credit</c>.
    /// </summary>
    [JsonPropertyName("special_apr")]
    public required double SpecialApr { get; init; }

    /// <summary>
    /// Override the <c>last_payment_amount</c> field. Can only be set if <c>type</c> is <c>credit</c>.
    /// </summary>
    [JsonPropertyName("last_payment_amount")]
    public required double LastPaymentAmount { get; init; }

    /// <summary>
    /// Override the <c>minimum_payment_amount</c> field. Can only be set if <c>type</c> is <c>credit</c> or <c>student</c>.
    /// </summary>
    [JsonPropertyName("minimum_payment_amount")]
    public required double MinimumPaymentAmount { get; init; }

    /// <summary>
    /// Override the <c>is_overdue</c> field
    /// </summary>
    [JsonPropertyName("is_overdue")]
    public required bool IsOverdue { get; init; }

    /// <summary>
    /// The date on which the loan was initially lent, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> (YYYY-MM-DD) format. Can only be set if <c>type</c> is <c>student</c>.
    /// </summary>
    [JsonPropertyName("origination_date")]
    public required DateTimeOffset OriginationDate { get; init; }

    /// <summary>
    /// The original loan principal. Can only be set if <c>type</c> is <c>student</c>.
    /// </summary>
    [JsonPropertyName("principal")]
    public required double Principal { get; init; }

    /// <summary>
    /// The interest rate on the loan as a percentage. Can only be set if <c>type</c> is <c>student</c>.
    /// </summary>
    [JsonPropertyName("nominal_apr")]
    public required double NominalApr { get; init; }

    /// <summary>
    /// If set, interest capitalization begins at the given number of months after loan origination. By default interest is never capitalized. Can only be set if <c>type</c> is <c>student</c>.
    /// </summary>
    [JsonPropertyName("interest_capitalization_grace_period_months")]
    public required double InterestCapitalizationGracePeriodMonths { get; init; }

    /// <summary>
    /// Student loan repayment information used to configure Sandbox test data for the Liabilities product
    /// </summary>
    [JsonPropertyName("repayment_model")]
    public required StudentLoanRepaymentModel RepaymentModel { get; init; }

    /// <summary>
    /// Override the <c>expected_payoff_date</c> field. Can only be set if <c>type</c> is <c>student</c>.
    /// </summary>
    [JsonPropertyName("expected_payoff_date")]
    public required DateTimeOffset ExpectedPayoffDate { get; init; }

    /// <summary>
    /// Override the <c>guarantor</c> field. Can only be set if <c>type</c> is <c>student</c>.
    /// </summary>
    [JsonPropertyName("guarantor")]
    public required string Guarantor { get; init; }

    /// <summary>
    /// Override the <c>is_federal</c> field. Can only be set if <c>type</c> is <c>student</c>.
    /// </summary>
    [JsonPropertyName("is_federal")]
    public required bool IsFederal { get; init; }

    /// <summary>
    /// Override the <c>loan_name</c> field. Can only be set if <c>type</c> is <c>student</c>.
    /// </summary>
    [JsonPropertyName("loan_name")]
    public required string LoanName { get; init; }

    /// <summary>
    /// An object representing the status of the student loan
    /// </summary>
    [JsonPropertyName("loan_status")]
    public required StudentLoanStatus LoanStatus { get; init; }

    /// <summary>
    /// Override the <c>payment_reference_number</c> field. Can only be set if <c>type</c> is <c>student</c>.
    /// </summary>
    [JsonPropertyName("payment_reference_number")]
    public required string PaymentReferenceNumber { get; init; }

    /// <summary>
    /// Information about the student's eligibility in the Public Service Loan Forgiveness program. This is only returned if the institution is FedLoan (<c>ins_116527</c>). Since FedLoan no longer services student loans, this field is no longer returned.
    /// </summary>
    [JsonPropertyName("pslf_status")]
    public required PslfStatus PslfStatus { get; init; }

    /// <summary>
    /// Override the <c>repayment_plan.description</c> field. Can only be set if <c>type</c> is <c>student</c>.
    /// </summary>
    [JsonPropertyName("repayment_plan_description")]
    public required string RepaymentPlanDescription { get; init; }

    /// <summary>
    /// Override the <c>repayment_plan.type</c> field. Can only be set if <c>type</c> is <c>student</c>. Possible values are: <c>"extended graduated"</c>, <c>"extended standard"</c>, <c>"graduated"</c>, <c>"income-contingent repayment"</c>, <c>"income-based repayment"</c>, <c>"income-sensitive repayment"</c>, <c>"interest only"</c>, <c>"other"</c>, <c>"pay as you earn"</c>, <c>"revised pay as you earn"</c>, <c>"standard"</c>, or <c>"saving on a valuable education"</c>.
    /// </summary>
    [JsonPropertyName("repayment_plan_type")]
    public required string RepaymentPlanType { get; init; }

    /// <summary>
    /// Override the <c>sequence_number</c> field. Can only be set if <c>type</c> is <c>student</c>.
    /// </summary>
    [JsonPropertyName("sequence_number")]
    public required string SequenceNumber { get; init; }

    /// <summary>
    /// A physical mailing address.
    /// </summary>
    [JsonPropertyName("servicer_address")]
    public required Address ServicerAddress { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
