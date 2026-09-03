using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The request was flagged by Plaid's fraud system and requires additional verification to ensure the user is not a bot.
/// </summary>
public record RecaptchaRequiredError
{
    /// <summary>
    /// <c>RECAPTCHA_ERROR</c>
    /// </summary>
    [JsonPropertyName("error_type")]
    public required string ErrorType { get; init; }

    /// <summary>
    /// <c>RECAPTCHA_REQUIRED</c>
    /// </summary>
    [JsonPropertyName("error_code")]
    public required string ErrorCode { get; init; }

    [JsonPropertyName("display_message")]
    public required string? DisplayMessage { get; init; }

    /// <summary>
    /// 400
    /// </summary>
    [JsonPropertyName("http_code")]
    public required int HttpCode { get; init; }

    /// <summary>
    /// Your user will be prompted to solve a Google reCAPTCHA challenge in the Link Recaptcha pane. If they solve the challenge successfully, the user's request is resubmitted and they are directed to the next Item creation step.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("link_user_experience")]
    public string? LinkUserExperience { get; init; }

    /// <summary>
    /// Plaid's fraud system detects abusive traffic and considers a variety of parameters throughout Item creation requests. When a request is considered risky or possibly fraudulent, Link presents a reCAPTCHA for the user to solve.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("common_causes")]
    public string? CommonCauses { get; init; }

    /// <summary>
    /// Link will automatically guide your user through reCAPTCHA verification. As a general rule, we recommend instrumenting basic fraud monitoring to detect and protect your website from spam and abuse.
    /// <para>
    /// If your user cannot verify their session, please submit a support ticket with the following identifiers: <c>link_session_id</c> or <c>request_id</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("troubleshooting_steps")]
    public string? TroubleshootingSteps { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
