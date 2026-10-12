using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// StatementsRefreshRequest defines the request schema for <c>/statements/refresh</c>
/// </summary>
public record StatementsRefreshRequest
{
    /// <summary>
    /// The access token associated with the Item for which data is being requested.
    /// </summary>
    [JsonPropertyName("access_token")]
    public required string AccessToken { get; init; }

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
    /// The start date for statements, in "YYYY-MM-DD" format, e.g. "2023-08-30". To determine whether a statement falls within the specified date range, Plaid will use the statement posted date. The statement posted date is typically either the last day of the statement period, or the following day.
    /// </summary>
    [JsonPropertyName("start_date")]
    public required DateTimeOffset StartDate { get; init; }

    /// <summary>
    /// The end date for statements, in "YYYY-MM-DD" format, e.g. "2023-10-30". You can request up to two years of data. To determine whether a statement falls within the specified date range, Plaid will use the statement posted date. The statement posted date is typically either the last day of the statement period, or the following day.
    /// </summary>
    [JsonPropertyName("end_date")]
    public required DateTimeOffset EndDate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
