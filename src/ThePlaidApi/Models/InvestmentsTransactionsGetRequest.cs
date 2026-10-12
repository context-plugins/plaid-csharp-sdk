using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// InvestmentsTransactionsGetRequest defines the request schema for <c>/investments/transactions/get</c>
/// </summary>
public record InvestmentsTransactionsGetRequest
{
    /// <summary>
    /// Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secret")]
    public string? Secret { get; init; }

    /// <summary>
    /// The access token associated with the Item for which data is being requested.
    /// </summary>
    [JsonPropertyName("access_token")]
    public required string AccessToken { get; init; }

    /// <summary>
    /// The earliest date for which to fetch transaction history. Dates should be formatted as YYYY-MM-DD.
    /// </summary>
    [JsonPropertyName("start_date")]
    public required DateTimeOffset StartDate { get; init; }

    /// <summary>
    /// The most recent date for which to fetch transaction history. Dates should be formatted as YYYY-MM-DD.
    /// </summary>
    [JsonPropertyName("end_date")]
    public required DateTimeOffset EndDate { get; init; }

    /// <summary>
    /// An optional object to filter <c>/investments/transactions/get</c> results. If provided, must be non-<c>null</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public InvestmentsTransactionsGetRequestOptions? Options { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
