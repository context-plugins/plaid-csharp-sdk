using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Score found by matching name provided by the API with the name on the account at the financial institution. If the account contains multiple owners, the maximum match score is filled.
/// </summary>
public record NameMatchScore
{
    /// <summary>
    /// Match score for name. 100 is a perfect score, 99-85 means a strong match, 84-70 is a partial match, any score less than 70 is a mismatch. Typically, the match threshold should be set to a score of 70 or higher. If the name is missing from either the API or financial institution, this is null.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("score")]
    public int? Score { get; init; }

    /// <summary>
    /// first or last name completely matched, likely a family member
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_first_name_or_last_name_match")]
    public bool? IsFirstNameOrLastNameMatch { get; init; }

    /// <summary>
    /// nickname matched, example Jennifer and Jenn.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_nickname_match")]
    public bool? IsNicknameMatch { get; init; }

    /// <summary>
    /// Is <c>true</c> if the name on either of the names that was matched for the score contained strings indicative of a business name, such as "CORP", "LLC", "INC", or "LTD". A <c>true</c> result generally indicates that an account's name is a business name. However, a <c>false</c> result does not mean the account name is not a business name, as some businesses do not use these strings in the names used for their financial institution accounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_business_name_detected")]
    public bool? IsBusinessNameDetected { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
