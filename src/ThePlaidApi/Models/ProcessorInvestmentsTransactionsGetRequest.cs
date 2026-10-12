using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// ProcessorInvestmentsTransactionsGetRequest defines the request schema for <c>/processor/investments/transactions/get</c>
/// </summary>
public record ProcessorInvestmentsTransactionsGetRequest
{
    /// <summary>
    /// Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// An optional object to filter <c>/investments/transactions/get</c> results. If provided, must be non-<c>null</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public InvestmentsTransactionsGetRequestOptions? Options { get; init; }

    /// <summary>
    /// The processor token obtained from the Plaid integration partner. Processor tokens are in the format: <c>processor-&lt;environment&gt;-&lt;identifier&gt;</c>
    /// </summary>
    [JsonPropertyName("processor_token")]
    public required string ProcessorToken { get; init; }

    /// <summary>
    /// Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secret")]
    public string? Secret { get; init; }

    /// <summary>
    /// The earliest date for which data should be returned. Dates should be formatted as YYYY-MM-DD.
    /// </summary>
    [JsonPropertyName("start_date")]
    public required DateTimeOffset StartDate { get; init; }

    /// <summary>
    /// The latest date for which data should be returned. Dates should be formatted as YYYY-MM-DD.
    /// </summary>
    [JsonPropertyName("end_date")]
    public required DateTimeOffset EndDate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
