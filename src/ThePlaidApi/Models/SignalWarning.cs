using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Conveys information about the errors causing missing or stale bank data used to construct the <c>/signal/evaluate</c> scores and response
/// </summary>
public record SignalWarning
{
    /// <summary>
    /// A broad categorization of the warning. Safe for programmatic use.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warning_type")]
    public string? WarningType { get; init; }

    /// <summary>
    /// The warning code identifies a specific kind of warning that pertains to the error causing bank data to be missing. Safe for programmatic use. For more details on warning codes, please refer to Plaid standard error codes documentation. If you receive the <c>ITEM_LOGIN_REQUIRED</c> warning, we recommend re-authenticating your user by implementing Link's update mode. This will guide your user to fix their credentials, allowing Plaid to start fetching data again for future requests.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warning_code")]
    public string? WarningCode { get; init; }

    /// <summary>
    /// A developer-friendly representation of the warning type. This may change over time and is not safe for programmatic use.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warning_message")]
    public string? WarningMessage { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
