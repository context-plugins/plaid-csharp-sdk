using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Result summary object specifying values for <c>email</c> attributes of risk check.
/// </summary>
public record RiskCheckEmail
{
    /// <summary>
    /// SMTP-MX check to confirm the email address exists if known.
    /// </summary>
    [JsonPropertyName("is_deliverable")]
    public required RiskCheckEmailIsDeliverableStatus IsDeliverable { get; init; }

    /// <summary>
    /// Count of all known breaches of this email address if known.
    /// </summary>
    [JsonPropertyName("breach_count")]
    public required int? BreachCount { get; init; }

    /// <summary>
    /// A date in the format YYYY-MM-DD (RFC 3339 Section 5.6).
    /// </summary>
    [JsonPropertyName("first_breached_at")]
    public required DateTimeOffset? FirstBreachedAt { get; init; }

    /// <summary>
    /// A date in the format YYYY-MM-DD (RFC 3339 Section 5.6).
    /// </summary>
    [JsonPropertyName("last_breached_at")]
    public required DateTimeOffset? LastBreachedAt { get; init; }

    /// <summary>
    /// A date in the format YYYY-MM-DD (RFC 3339 Section 5.6).
    /// </summary>
    [JsonPropertyName("domain_registered_at")]
    public required DateTimeOffset? DomainRegisteredAt { get; init; }

    /// <summary>
    /// Indicates whether the email address domain is a free provider such as Gmail or Hotmail if known.
    /// </summary>
    [JsonPropertyName("domain_is_free_provider")]
    public required RiskCheckEmailDomainIsFreeProvider DomainIsFreeProvider { get; init; }

    /// <summary>
    /// Indicates whether the email address domain is custom if known, i.e. a company domain and not free or disposable.
    /// </summary>
    [JsonPropertyName("domain_is_custom")]
    public required RiskCheckEmailDomainIsCustom DomainIsCustom { get; init; }

    /// <summary>
    /// Indicates whether the email domain is listed as disposable if known. Disposable domains are often used to create email addresses that are part of a fake set of user details.
    /// </summary>
    [JsonPropertyName("domain_is_disposable")]
    public required RiskCheckEmailDomainIsDisposable DomainIsDisposable { get; init; }

    /// <summary>
    /// Indicates whether the email address top level domain, which is the last part of the domain, is fraudulent or risky if known. In most cases, a suspicious top level domain is also associated with a disposable or high-risk domain.
    /// </summary>
    [JsonPropertyName("top_level_domain_is_suspicious")]
    public required RiskCheckEmailTopLevelDomainIsSuspicious TopLevelDomainIsSuspicious { get; init; }

    /// <summary>
    /// Indicates whether the email address domain is an educational institution domain if known.
    /// </summary>
    [JsonPropertyName("is_edu")]
    public required RiskCheckEmailIsEdu IsEdu { get; init; }

    /// <summary>
    /// Indicates whether the email address includes the date of birth or year of birth if known.
    /// </summary>
    [JsonPropertyName("includes_date_of_birth")]
    public required RiskCheckEmailIncludesDateOfBirth IncludesDateOfBirth { get; init; }

    /// <summary>
    /// Indicates whether the provided name matches the email address according to the KYC name-matches-email inference result if known.
    /// <para>
    /// <c>match</c> - "The email's name identifiers match the user's name."
    /// </para>
    /// <para>
    /// <c>partial_match</c> - "The email's name identifiers partially match the user's name."
    /// </para>
    /// <para>
    /// <c>no_match</c> - "The email's name identifiers do not match the user's name."
    /// </para>
    /// <para>
    /// <c>indeterminate</c> - "The email does not contain any name identifiers, and a match could not be determined."
    /// </para>
    /// <para>
    /// <c>no_input</c> - "The user's profile does not contain the required user inputs to determine a match."
    /// </para>
    /// <para>
    /// <c>no_data</c> - "Field could not be verified against available sources."
    /// </para>
    /// </summary>
    [JsonPropertyName("name")]
    public required RiskCheckEmailName Name { get; init; }

    /// <summary>
    /// A list of online services where this email address has been detected to have accounts or other activity.
    /// </summary>
    [JsonPropertyName("linked_services")]
    [UniqueItems]
    public required IReadOnlyList<RiskCheckLinkedService> LinkedServices { get; init; }

    /// <summary>
    /// Risk level for the given risk check type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("risk_level")]
    public RiskLevel? RiskLevel { get; init; }

    /// <summary>
    /// List of factors, when available, that contribute towards the risk level of the given risk check type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("factors")]
    public IReadOnlyList<string>? Factors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
