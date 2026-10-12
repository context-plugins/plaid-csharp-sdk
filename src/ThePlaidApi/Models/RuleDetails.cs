using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Rules are run in numerical order. The first rule with a logic match is triggered. These are the details of that rule.
/// </summary>
public record RuleDetails
{
    /// <summary>
    /// An optional message attached to the triggered rule, defined within the Dashboard, for your internal use. Useful for debugging, such as "Account appears to be closed."
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("internal_note")]
    public string? InternalNote { get; init; }

    /// <summary>
    /// A string key, defined within the Dashboard, used to trigger programmatic behavior for a certain result. For instance, you could optionally choose to define a "3-day-hold" <c>custom_action_key</c> for an ACCEPT result.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_action_key")]
    public string? CustomActionKey { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
