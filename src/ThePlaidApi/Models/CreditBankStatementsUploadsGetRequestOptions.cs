using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An optional object for <c>/credit/bank_statements/uploads/get</c> request options.
/// </summary>
public record CreditBankStatementsUploadsGetRequestOptions
{
    /// <summary>
    /// An array of <c>item_id</c>s whose bank statements information is returned. Each <c>item_id</c> should uniquely identify a bank statements uploaded item. If this field is not provided, all <c>item_id</c>s associated with the <c>user_token</c> will be returned in the response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_ids")]
    public IReadOnlyList<string>? ItemIds { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
