using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// CreditPayrollIncomeRefreshResponse defines the response schema for <c>/credit/payroll_income/refresh</c>
/// </summary>
public record CreditPayrollIncomeRefreshResponse
{
    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    /// <summary>
    /// The verification refresh status. One of the following:
    /// <para>
    /// <c>"USER_PRESENCE_REQUIRED"</c> User presence is required to refresh an income verification.
    /// <c>"SUCCESSFUL"</c> The income verification refresh was successful.
    /// <c>"NOT_FOUND"</c> No new data was found after the income verification refresh.
    /// </para>
    /// </summary>
    [JsonPropertyName("verification_refresh_status")]
    public required string VerificationRefreshStatus { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
