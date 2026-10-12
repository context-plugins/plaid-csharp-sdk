using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Analyzed AAMVA data for the associated hit.
/// <para>
/// Note: This field is only available for U.S. driver's licenses issued by participating states.
/// </para>
/// </summary>
public record AamvaAnalysis
{
    /// <summary>
    /// The overall outcome of checking the associated hit against the issuing state database.
    /// </summary>
    [JsonPropertyName("is_verified")]
    public required bool IsVerified { get; init; }

    /// <summary>
    /// The outcome of checking the particular field against state databases.
    /// <para>
    ///
    /// <c>match</c> - The field is an exact match with the state database.
    /// </para>
    /// <para>
    /// <c>no_match</c> - The field is not an exact match with the state database.
    /// </para>
    /// <para>
    /// <c>no_data</c> - The field was unable to be checked against state databases.
    /// </para>
    /// </summary>
    [JsonPropertyName("id_number")]
    public required AamvaMatchResult IdNumber { get; init; }

    /// <summary>
    /// The outcome of checking the particular field against state databases.
    /// <para>
    ///
    /// <c>match</c> - The field is an exact match with the state database.
    /// </para>
    /// <para>
    /// <c>no_match</c> - The field is not an exact match with the state database.
    /// </para>
    /// <para>
    /// <c>no_data</c> - The field was unable to be checked against state databases.
    /// </para>
    /// </summary>
    [JsonPropertyName("id_issue_date")]
    public required AamvaMatchResult IdIssueDate { get; init; }

    /// <summary>
    /// The outcome of checking the particular field against state databases.
    /// <para>
    ///
    /// <c>match</c> - The field is an exact match with the state database.
    /// </para>
    /// <para>
    /// <c>no_match</c> - The field is not an exact match with the state database.
    /// </para>
    /// <para>
    /// <c>no_data</c> - The field was unable to be checked against state databases.
    /// </para>
    /// </summary>
    [JsonPropertyName("id_expiration_date")]
    public required AamvaMatchResult IdExpirationDate { get; init; }

    /// <summary>
    /// The outcome of checking the associated hit against state databases.
    /// <para>
    ///
    /// <c>match</c> - The field is an exact match with the state database.
    /// </para>
    /// <para>
    /// <c>partial_match</c> - The field is a partial match with the state database.
    /// </para>
    /// <para>
    /// <c>no_match</c> - The field is not an exact match with the state database.
    /// </para>
    /// <para>
    /// <c>no_data</c> - The field was unable to be checked against state databases.
    /// </para>
    /// </summary>
    [JsonPropertyName("street")]
    public required AamvaDetailedMatchResult Street { get; init; }

    /// <summary>
    /// The outcome of checking the particular field against state databases.
    /// <para>
    ///
    /// <c>match</c> - The field is an exact match with the state database.
    /// </para>
    /// <para>
    /// <c>no_match</c> - The field is not an exact match with the state database.
    /// </para>
    /// <para>
    /// <c>no_data</c> - The field was unable to be checked against state databases.
    /// </para>
    /// </summary>
    [JsonPropertyName("city")]
    public required AamvaMatchResult City { get; init; }

    /// <summary>
    /// The outcome of checking the associated hit against state databases.
    /// <para>
    ///
    /// <c>match</c> - The field is an exact match with the state database.
    /// </para>
    /// <para>
    /// <c>partial_match</c> - The field is a partial match with the state database.
    /// </para>
    /// <para>
    /// <c>no_match</c> - The field is not an exact match with the state database.
    /// </para>
    /// <para>
    /// <c>no_data</c> - The field was unable to be checked against state databases.
    /// </para>
    /// </summary>
    [JsonPropertyName("postal_code")]
    public required AamvaDetailedMatchResult PostalCode { get; init; }

    /// <summary>
    /// The outcome of checking the particular field against state databases.
    /// <para>
    ///
    /// <c>match</c> - The field is an exact match with the state database.
    /// </para>
    /// <para>
    /// <c>no_match</c> - The field is not an exact match with the state database.
    /// </para>
    /// <para>
    /// <c>no_data</c> - The field was unable to be checked against state databases.
    /// </para>
    /// </summary>
    [JsonPropertyName("date_of_birth")]
    public required AamvaMatchResult DateOfBirth { get; init; }

    /// <summary>
    /// The outcome of checking the particular field against state databases.
    /// <para>
    ///
    /// <c>match</c> - The field is an exact match with the state database.
    /// </para>
    /// <para>
    /// <c>no_match</c> - The field is not an exact match with the state database.
    /// </para>
    /// <para>
    /// <c>no_data</c> - The field was unable to be checked against state databases.
    /// </para>
    /// </summary>
    [JsonPropertyName("gender")]
    public required AamvaMatchResult Gender { get; init; }

    /// <summary>
    /// The outcome of checking the particular field against state databases.
    /// <para>
    ///
    /// <c>match</c> - The field is an exact match with the state database.
    /// </para>
    /// <para>
    /// <c>no_match</c> - The field is not an exact match with the state database.
    /// </para>
    /// <para>
    /// <c>no_data</c> - The field was unable to be checked against state databases.
    /// </para>
    /// </summary>
    [JsonPropertyName("height")]
    public required AamvaMatchResult Height { get; init; }

    /// <summary>
    /// The outcome of checking the particular field against state databases.
    /// <para>
    ///
    /// <c>match</c> - The field is an exact match with the state database.
    /// </para>
    /// <para>
    /// <c>no_match</c> - The field is not an exact match with the state database.
    /// </para>
    /// <para>
    /// <c>no_data</c> - The field was unable to be checked against state databases.
    /// </para>
    /// </summary>
    [JsonPropertyName("eye_color")]
    public required AamvaMatchResult EyeColor { get; init; }

    /// <summary>
    /// The outcome of checking the associated hit against state databases.
    /// <para>
    ///
    /// <c>match</c> - The field is an exact match with the state database.
    /// </para>
    /// <para>
    /// <c>partial_match</c> - The field is a partial match with the state database.
    /// </para>
    /// <para>
    /// <c>no_match</c> - The field is not an exact match with the state database.
    /// </para>
    /// <para>
    /// <c>no_data</c> - The field was unable to be checked against state databases.
    /// </para>
    /// </summary>
    [JsonPropertyName("first_name")]
    public required AamvaDetailedMatchResult FirstName { get; init; }

    /// <summary>
    /// The outcome of checking the associated hit against state databases.
    /// <para>
    ///
    /// <c>match</c> - The field is an exact match with the state database.
    /// </para>
    /// <para>
    /// <c>partial_match</c> - The field is a partial match with the state database.
    /// </para>
    /// <para>
    /// <c>no_match</c> - The field is not an exact match with the state database.
    /// </para>
    /// <para>
    /// <c>no_data</c> - The field was unable to be checked against state databases.
    /// </para>
    /// </summary>
    [JsonPropertyName("middle_name")]
    public required AamvaDetailedMatchResult MiddleName { get; init; }

    /// <summary>
    /// The outcome of checking the associated hit against state databases.
    /// <para>
    ///
    /// <c>match</c> - The field is an exact match with the state database.
    /// </para>
    /// <para>
    /// <c>partial_match</c> - The field is a partial match with the state database.
    /// </para>
    /// <para>
    /// <c>no_match</c> - The field is not an exact match with the state database.
    /// </para>
    /// <para>
    /// <c>no_data</c> - The field was unable to be checked against state databases.
    /// </para>
    /// </summary>
    [JsonPropertyName("last_name")]
    public required AamvaDetailedMatchResult LastName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
