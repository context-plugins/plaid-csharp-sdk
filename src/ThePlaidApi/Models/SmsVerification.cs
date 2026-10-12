using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Additional information for the individual SMS verification.
/// </summary>
public record SmsVerification
{
    /// <summary>
    /// The outcome status for the individual SMS verification.
    /// </summary>
    [JsonPropertyName("status")]
    public required SmsVerificationStatus Status { get; init; }

    /// <summary>
    /// The attempt field begins with 1 and increments with each subsequent SMS verification.
    /// </summary>
    [JsonPropertyName("attempt")]
    public required int Attempt { get; init; }

    /// <summary>
    /// A phone number in E.164 format.
    /// </summary>
    [JsonPropertyName("phone_number")]
    public required string? PhoneNumber { get; init; }

    /// <summary>
    /// The number of delivery attempts made within the verification to send the SMS code to the user. Each delivery attempt represents the user taking action from the front end UI to request creation and delivery of a new SMS verification code, or to resend an existing SMS verification code. There is a limit of 3 delivery attempts per verification.
    /// </summary>
    [JsonPropertyName("delivery_attempt_count")]
    public required int DeliveryAttemptCount { get; init; }

    /// <summary>
    /// The number of attempts made by the user within the verification to verify the SMS code by entering it into the front end UI. There is a limit of 3 solve attempts per verification.
    /// </summary>
    [JsonPropertyName("solve_attempt_count")]
    public required int SolveAttemptCount { get; init; }

    /// <summary>
    /// An ISO8601 formatted timestamp.
    /// </summary>
    [JsonPropertyName("initially_sent_at")]
    public required DateTimeOffset? InitiallySentAt { get; init; }

    /// <summary>
    /// An ISO8601 formatted timestamp.
    /// </summary>
    [JsonPropertyName("last_sent_at")]
    public required DateTimeOffset? LastSentAt { get; init; }

    /// <summary>
    /// An ISO8601 formatted timestamp.
    /// </summary>
    [JsonPropertyName("redacted_at")]
    public required DateTimeOffset? RedactedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
