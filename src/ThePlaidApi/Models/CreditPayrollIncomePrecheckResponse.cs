using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the response schema for <c>/credit/payroll_income/precheck</c>.
/// </summary>
public record CreditPayrollIncomePrecheckResponse
{
    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    /// <summary>
    /// The confidence that Plaid can support the user in the digital income verification flow instead of requiring a manual paystub upload. One of the following:
    /// <para>
    /// <c>"HIGH"</c>: It is very likely that this user can use the digital income verification flow.
    /// </para>
    /// <para>
    /// "<c>LOW</c>": It is unlikely that this user can use the digital income verification flow.
    /// </para>
    /// <para>
    /// <c>"UNKNOWN"</c>: It was not possible to determine if the user is supportable with the information passed.
    /// </para>
    /// </summary>
    [JsonPropertyName("confidence")]
    public required IncomeVerificationPrecheckConfidence Confidence { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
