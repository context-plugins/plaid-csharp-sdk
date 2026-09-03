using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The point at which the user exited the Link flow. One of the following values.
/// </summary>
public record Status2
{
    /// <summary>
    /// User prompted to answer security questions
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requires_questions")]
    public object? RequiresQuestions { get; init; }

    /// <summary>
    /// User prompted to answer multiple choice question(s)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requires_selections")]
    public object? RequiresSelections { get; init; }

    /// <summary>
    /// User prompted to provide a one-time passcode
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requires_code")]
    public object? RequiresCode { get; init; }

    /// <summary>
    /// User prompted to select a device on which to receive a one-time passcode
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("choose_device")]
    public object? ChooseDevice { get; init; }

    /// <summary>
    /// User prompted to provide credentials for the selected financial institution or has not yet selected a financial institution
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requires_credentials")]
    public object? RequiresCredentials { get; init; }

    /// <summary>
    /// User prompted to select one or more financial accounts to share
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requires_account_selection")]
    public object? RequiresAccountSelection { get; init; }

    /// <summary>
    /// User prompted to enter an OAuth flow
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requires_oauth")]
    public object? RequiresOauth { get; init; }

    /// <summary>
    /// User exited the Link flow after unsuccessfully (no results returned) searching for a financial institution
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("institution_not_found")]
    public object? InstitutionNotFound { get; init; }

    /// <summary>
    /// User exited the Link flow after discovering their selected institution is no longer supported by Plaid
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("institution_not_supported")]
    public object? InstitutionNotSupported { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
