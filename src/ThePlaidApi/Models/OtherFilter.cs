using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// A filter to apply to <c>other</c>-type accounts
/// </summary>
public record OtherFilter
{
    /// <summary>
    /// An array of account subtypes to display in Link. If not specified, all account subtypes will be shown. For a full list of valid types and subtypes, see the <see href="https://plaid.com/docs/api/accounts#account-type-schema">Account schema</see>.
    /// </summary>
    [JsonPropertyName("account_subtypes")]
    public required IReadOnlyList<OtherAccountSubtype> AccountSubtypes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
