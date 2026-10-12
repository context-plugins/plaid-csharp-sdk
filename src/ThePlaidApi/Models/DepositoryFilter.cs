using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// A filter to apply to <c>depository</c>-type accounts
/// </summary>
public record DepositoryFilter
{
    /// <summary>
    /// An array of account subtypes to display in Link. If not specified, all account subtypes will be shown. For a full list of valid types and subtypes, see the <see href="https://plaid.com/docs/api/accounts#account-type-schema">Account schema</see>.
    /// </summary>
    [JsonPropertyName("account_subtypes")]
    public required IReadOnlyList<DepositoryAccountSubtype> AccountSubtypes { get; init; }

    /// <summary>
    /// An array of limited purpose types. Restricts which kinds of limited purpose checking accounts may be connected in Link to prevent users from connecting them for unsupported use cases. Required when 'limited purpose checking' is in the subtypes filter.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limited_purpose_types")]
    public IReadOnlyList<LimitedPurposeType>? LimitedPurposeTypes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
