using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// A detailed breakdown of the institution's performance for a request type. The values for <c>success</c>, <c>error_plaid</c>, and <c>error_institution</c> sum to 1. The time range used for calculating the breakdown may range from the most recent few minutes to the past six hours. In general, smaller institutions will show status that was calculated over a longer period of time. For Investment updates, which are refreshed less frequently, the period assessed may be 24 hours or more. For more details, see <see href="https://plaid.com/docs/account/activity/#troubleshooting-institution-insights">Institution status details</see>.
/// </summary>
public record StatusBreakdown
{
    /// <summary>
    /// The percentage of login attempts that are successful, expressed as a decimal.
    /// </summary>
    [JsonPropertyName("success")]
    public required double Success { get; init; }

    /// <summary>
    /// The percentage of logins that are failing due to an internal Plaid issue, expressed as a decimal.
    /// </summary>
    [JsonPropertyName("error_plaid")]
    public required double ErrorPlaid { get; init; }

    /// <summary>
    /// The percentage of logins that are failing due to an issue in the institution's system, expressed as a decimal.
    /// </summary>
    [JsonPropertyName("error_institution")]
    public required double ErrorInstitution { get; init; }

    /// <summary>
    /// How frequently data for subscription products like Investments, Transactions, and Liabilities, is being refreshed, relative to the institution's normal scheduling. The <c>refresh_interval</c> may be <c>DELAYED</c> or <c>STOPPED</c> even when the success rate is high.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refresh_interval")]
    public RefreshInterval? RefreshInterval { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
