using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Result summary object specifying how the <c>address</c> field matched for fields that are only present on an international KYC check.
/// </summary>
public record KycCheckDetailsInternationalAddress
{
    /// <summary>
    /// An enum indicating the match type between data provided by user and data checked against an external data source.
    /// <para>
    ///
    /// <c>match</c> indicates that the provided input data was a strong match against external data.
    /// </para>
    /// <para>
    /// <c>partial_match</c> indicates the data approximately matched against external data. For example, "Knope" vs. "Knope-Wyatt" for last name.
    /// </para>
    /// <para>
    /// <c>no_match</c> indicates that Plaid was able to perform a check against an external data source and it did not match the provided input data.
    /// </para>
    /// <para>
    /// <c>no_data</c> indicates that Plaid was unable to find external data to compare against the provided input data.
    /// </para>
    /// <para>
    /// <c>no_input</c> indicates that Plaid was unable to perform a check because no information was provided for this field by the end user.
    /// </para>
    /// </summary>
    [JsonPropertyName("building")]
    public required HiddenMatchSummaryCode Building { get; init; }

    /// <summary>
    /// An enum indicating the match type between data provided by user and data checked against an external data source.
    /// <para>
    ///
    /// <c>match</c> indicates that the provided input data was a strong match against external data.
    /// </para>
    /// <para>
    /// <c>partial_match</c> indicates the data approximately matched against external data. For example, "Knope" vs. "Knope-Wyatt" for last name.
    /// </para>
    /// <para>
    /// <c>no_match</c> indicates that Plaid was able to perform a check against an external data source and it did not match the provided input data.
    /// </para>
    /// <para>
    /// <c>no_data</c> indicates that Plaid was unable to find external data to compare against the provided input data.
    /// </para>
    /// <para>
    /// <c>no_input</c> indicates that Plaid was unable to perform a check because no information was provided for this field by the end user.
    /// </para>
    /// </summary>
    [JsonPropertyName("county")]
    public required HiddenMatchSummaryCode County { get; init; }

    /// <summary>
    /// An enum indicating the match type between data provided by user and data checked against an external data source.
    /// <para>
    ///
    /// <c>match</c> indicates that the provided input data was a strong match against external data.
    /// </para>
    /// <para>
    /// <c>partial_match</c> indicates the data approximately matched against external data. For example, "Knope" vs. "Knope-Wyatt" for last name.
    /// </para>
    /// <para>
    /// <c>no_match</c> indicates that Plaid was able to perform a check against an external data source and it did not match the provided input data.
    /// </para>
    /// <para>
    /// <c>no_data</c> indicates that Plaid was unable to find external data to compare against the provided input data.
    /// </para>
    /// <para>
    /// <c>no_input</c> indicates that Plaid was unable to perform a check because no information was provided for this field by the end user.
    /// </para>
    /// </summary>
    [JsonPropertyName("district")]
    public required HiddenMatchSummaryCode District { get; init; }

    /// <summary>
    /// An enum indicating the match type between data provided by user and data checked against an external data source.
    /// <para>
    ///
    /// <c>match</c> indicates that the provided input data was a strong match against external data.
    /// </para>
    /// <para>
    /// <c>partial_match</c> indicates the data approximately matched against external data. For example, "Knope" vs. "Knope-Wyatt" for last name.
    /// </para>
    /// <para>
    /// <c>no_match</c> indicates that Plaid was able to perform a check against an external data source and it did not match the provided input data.
    /// </para>
    /// <para>
    /// <c>no_data</c> indicates that Plaid was unable to find external data to compare against the provided input data.
    /// </para>
    /// <para>
    /// <c>no_input</c> indicates that Plaid was unable to perform a check because no information was provided for this field by the end user.
    /// </para>
    /// </summary>
    [JsonPropertyName("house_number")]
    public required HiddenMatchSummaryCode HouseNumber { get; init; }

    /// <summary>
    /// An enum indicating the match type between data provided by user and data checked against an external data source.
    /// <para>
    ///
    /// <c>match</c> indicates that the provided input data was a strong match against external data.
    /// </para>
    /// <para>
    /// <c>partial_match</c> indicates the data approximately matched against external data. For example, "Knope" vs. "Knope-Wyatt" for last name.
    /// </para>
    /// <para>
    /// <c>no_match</c> indicates that Plaid was able to perform a check against an external data source and it did not match the provided input data.
    /// </para>
    /// <para>
    /// <c>no_data</c> indicates that Plaid was unable to find external data to compare against the provided input data.
    /// </para>
    /// <para>
    /// <c>no_input</c> indicates that Plaid was unable to perform a check because no information was provided for this field by the end user.
    /// </para>
    /// </summary>
    [JsonPropertyName("subpremise")]
    public required HiddenMatchSummaryCode Subpremise { get; init; }

    /// <summary>
    /// An enum indicating the match type between data provided by user and data checked against an external data source.
    /// <para>
    ///
    /// <c>match</c> indicates that the provided input data was a strong match against external data.
    /// </para>
    /// <para>
    /// <c>partial_match</c> indicates the data approximately matched against external data. For example, "Knope" vs. "Knope-Wyatt" for last name.
    /// </para>
    /// <para>
    /// <c>no_match</c> indicates that Plaid was able to perform a check against an external data source and it did not match the provided input data.
    /// </para>
    /// <para>
    /// <c>no_data</c> indicates that Plaid was unable to find external data to compare against the provided input data.
    /// </para>
    /// <para>
    /// <c>no_input</c> indicates that Plaid was unable to perform a check because no information was provided for this field by the end user.
    /// </para>
    /// </summary>
    [JsonPropertyName("thoroughfare")]
    public required HiddenMatchSummaryCode Thoroughfare { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
