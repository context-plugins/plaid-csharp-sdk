using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Contains loan data to register.
/// </summary>
public record CraLoanRegister
{
    /// <summary>
    /// The user token for the user associated with the loan.
    /// </summary>
    [JsonPropertyName("user_token")]
    public required string UserToken { get; init; }

    /// <summary>
    /// A unique identifier for the loan.
    /// Personally identifiable information, such as an email address or phone number, should not be used in the <c>loan_id</c>.
    /// </summary>
    [JsonPropertyName("loan_id")]
    public required string LoanId { get; init; }

    /// <summary>
    /// The type of loan the user applied for.
    /// </summary>
    [JsonPropertyName("type")]
    public required CraLoanType Type { get; init; }

    /// <summary>
    /// The frequency of a loan's payment schedule.
    /// <c>BIWEEKLY</c> represents one payment every two weeks.
    /// </summary>
    [JsonPropertyName("payment_schedule")]
    public required CraLoanPaymentSchedule PaymentSchedule { get; init; }

    /// <summary>
    /// The date the loan account was opened. The date should be in ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("opened_date")]
    public required DateTimeOffset OpenedDate { get; init; }

    /// <summary>
    /// Contains the status and date information of the loan when registering.
    /// </summary>
    [JsonPropertyName("opened_with_status")]
    public required CraLoanOpenedStatus OpenedWithStatus { get; init; }

    /// <summary>
    /// The total amount of the approved loan.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loan_amount")]
    public double? LoanAmount { get; init; }

    /// <summary>
    /// Contains loan application data to register.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("application")]
    public CraLoanRegisterApplication? Application { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
