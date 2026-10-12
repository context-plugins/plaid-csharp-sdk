using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// CreditBankEmploymentGetResponse defines the response schema for <c>/beta/credit/v1/bank_employment/get</c>.
/// </summary>
public record CreditBankEmploymentGetResponse
{
    /// <summary>
    /// Bank Employment data. Each entry in the array will be a distinct bank employment report.
    /// </summary>
    [JsonPropertyName("bank_employment_reports")]
    public required IReadOnlyList<CreditBankEmploymentReport> BankEmploymentReports { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
