using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
/// </summary>
public record RoleDetail
{
    /// <summary>
    /// A value from a MISMO defined list that identifies the role that the party plays in the transaction. Parties may be either a person or legal entity. A party may play multiple roles in a transaction.
    /// </summary>
    [JsonPropertyName("PartyRoleType")]
    public required PartyRoleType PartyRoleType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
