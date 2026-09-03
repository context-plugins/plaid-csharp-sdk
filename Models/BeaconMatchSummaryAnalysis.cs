using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Analysis of which fields matched between one Beacon User and another.
/// </summary>
public record BeaconMatchSummaryAnalysis
{
    /// <summary>
    /// An enum indicating the match type between two Beacon Users.
    /// <para>
    ///
    /// <c>match</c> indicates that the provided input data was a strong match against the other Beacon User.
    /// </para>
    /// <para>
    /// <c>partial_match</c> indicates the data approximately matched the other Beacon User. For example, "Knope" vs. "Knope-Wyatt" for last name.
    /// </para>
    /// <para>
    /// <c>no_match</c> indicates that Plaid was able to compare this field against the other Beacon User and it did not match the provided input data.
    /// </para>
    /// <para>
    /// <c>no_data</c> indicates that Plaid was unable to compare this field against the original Beacon User because the field was not present in one of the Beacon Users.
    /// </para>
    /// </summary>
    [JsonPropertyName("address")]
    public required BeaconMatchSummaryCode Address { get; init; }

    /// <summary>
    /// An enum indicating the match type between two Beacon Users.
    /// <para>
    ///
    /// <c>match</c> indicates that the provided input data was a strong match against the other Beacon User.
    /// </para>
    /// <para>
    /// <c>partial_match</c> indicates the data approximately matched the other Beacon User. For example, "Knope" vs. "Knope-Wyatt" for last name.
    /// </para>
    /// <para>
    /// <c>no_match</c> indicates that Plaid was able to compare this field against the other Beacon User and it did not match the provided input data.
    /// </para>
    /// <para>
    /// <c>no_data</c> indicates that Plaid was unable to compare this field against the original Beacon User because the field was not present in one of the Beacon Users.
    /// </para>
    /// </summary>
    [JsonPropertyName("date_of_birth")]
    public required BeaconMatchSummaryCode DateOfBirth { get; init; }

    /// <summary>
    /// An enum indicating the match type between two Beacon Users.
    /// <para>
    ///
    /// <c>match</c> indicates that the provided input data was a strong match against the other Beacon User.
    /// </para>
    /// <para>
    /// <c>partial_match</c> indicates the data approximately matched the other Beacon User. For example, "Knope" vs. "Knope-Wyatt" for last name.
    /// </para>
    /// <para>
    /// <c>no_match</c> indicates that Plaid was able to compare this field against the other Beacon User and it did not match the provided input data.
    /// </para>
    /// <para>
    /// <c>no_data</c> indicates that Plaid was unable to compare this field against the original Beacon User because the field was not present in one of the Beacon Users.
    /// </para>
    /// </summary>
    [JsonPropertyName("email_address")]
    public required BeaconMatchSummaryCode EmailAddress { get; init; }

    /// <summary>
    /// An enum indicating the match type between two Beacon Users.
    /// <para>
    ///
    /// <c>match</c> indicates that the provided input data was a strong match against the other Beacon User.
    /// </para>
    /// <para>
    /// <c>partial_match</c> indicates the data approximately matched the other Beacon User. For example, "Knope" vs. "Knope-Wyatt" for last name.
    /// </para>
    /// <para>
    /// <c>no_match</c> indicates that Plaid was able to compare this field against the other Beacon User and it did not match the provided input data.
    /// </para>
    /// <para>
    /// <c>no_data</c> indicates that Plaid was unable to compare this field against the original Beacon User because the field was not present in one of the Beacon Users.
    /// </para>
    /// </summary>
    [JsonPropertyName("name")]
    public required BeaconMatchSummaryCode Name { get; init; }

    /// <summary>
    /// An enum indicating the match type between two Beacon Users.
    /// <para>
    ///
    /// <c>match</c> indicates that the provided input data was a strong match against the other Beacon User.
    /// </para>
    /// <para>
    /// <c>partial_match</c> indicates the data approximately matched the other Beacon User. For example, "Knope" vs. "Knope-Wyatt" for last name.
    /// </para>
    /// <para>
    /// <c>no_match</c> indicates that Plaid was able to compare this field against the other Beacon User and it did not match the provided input data.
    /// </para>
    /// <para>
    /// <c>no_data</c> indicates that Plaid was unable to compare this field against the original Beacon User because the field was not present in one of the Beacon Users.
    /// </para>
    /// </summary>
    [JsonPropertyName("id_number")]
    public required BeaconMatchSummaryCode IdNumber { get; init; }

    /// <summary>
    /// An enum indicating the match type between two Beacon Users.
    /// <para>
    ///
    /// <c>match</c> indicates that the provided input data was a strong match against the other Beacon User.
    /// </para>
    /// <para>
    /// <c>partial_match</c> indicates the data approximately matched the other Beacon User. For example, "Knope" vs. "Knope-Wyatt" for last name.
    /// </para>
    /// <para>
    /// <c>no_match</c> indicates that Plaid was able to compare this field against the other Beacon User and it did not match the provided input data.
    /// </para>
    /// <para>
    /// <c>no_data</c> indicates that Plaid was unable to compare this field against the original Beacon User because the field was not present in one of the Beacon Users.
    /// </para>
    /// </summary>
    [JsonPropertyName("ip_address")]
    public required BeaconMatchSummaryCode IpAddress { get; init; }

    /// <summary>
    /// An enum indicating the match type between two Beacon Users.
    /// <para>
    ///
    /// <c>match</c> indicates that the provided input data was a strong match against the other Beacon User.
    /// </para>
    /// <para>
    /// <c>partial_match</c> indicates the data approximately matched the other Beacon User. For example, "Knope" vs. "Knope-Wyatt" for last name.
    /// </para>
    /// <para>
    /// <c>no_match</c> indicates that Plaid was able to compare this field against the other Beacon User and it did not match the provided input data.
    /// </para>
    /// <para>
    /// <c>no_data</c> indicates that Plaid was unable to compare this field against the original Beacon User because the field was not present in one of the Beacon Users.
    /// </para>
    /// </summary>
    [JsonPropertyName("phone_number")]
    public required BeaconMatchSummaryCode PhoneNumber { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
