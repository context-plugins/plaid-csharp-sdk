using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Contains loan application data.
/// </summary>
public record CraLoanApplication
{
    /// <summary>
    /// The user token for the user associated with the loan.
    /// </summary>
    [JsonPropertyName("user_token")]
    public required string UserToken { get; init; }

    /// <summary>
    /// A unique identifier for the loan application.
    /// Personally identifiable information, such as an email address or phone number, should not be used in the <c>application_id</c>.
    /// </summary>
    [JsonPropertyName("application_id")]
    public required string ApplicationId { get; init; }

    /// <summary>
    /// The type of loan the user applied for.
    /// </summary>
    [JsonPropertyName("type")]
    public required CraLoanType Type { get; init; }

    /// <summary>
    /// The decision of the loan application.
    /// </summary>
    [JsonPropertyName("decision")]
    public required CraLoanApplicationDecision Decision { get; init; }

    /// <summary>
    /// The date the user applied for the loan. The date should be in ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("application_date")]
    public DateTimeOffset? ApplicationDate { get; init; }

    /// <summary>
    /// The date when the loan application's decision was made. The date should be in ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("decision_date")]
    public DateTimeOffset? DecisionDate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
