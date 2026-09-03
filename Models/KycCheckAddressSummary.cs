using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Result summary object specifying how the <c>address</c> field matched.
/// </summary>
public record KycCheckAddressSummary
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
    [JsonPropertyName("summary")]
    public required MatchSummaryCode Summary { get; init; }

    /// <summary>
    /// Field describing whether the associated address is a post office box. Will be <c>yes</c> when a P.O. box is detected, <c>no</c> when Plaid confirmed the address is not a P.O. box, and <c>no_data</c> when Plaid was not able to determine if the address is a P.O. box.
    /// </summary>
    [JsonPropertyName("po_box")]
    public required PoBoxStatus PoBox { get; init; }

    /// <summary>
    /// Field describing whether the associated address is being used for commercial or residential purposes.
    /// <para>
    /// Note: This value will be <c>no_data</c> when Plaid does not have sufficient data to determine the address's use.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required AddressPurposeLabel Type { get; init; }

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
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("street")]
    public HiddenMatchSummaryCode? Street { get; init; }

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
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("city")]
    public HiddenMatchSummaryCode? City { get; init; }

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
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("region")]
    public HiddenMatchSummaryCode? Region { get; init; }

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
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postal_code")]
    public HiddenMatchSummaryCode? PostalCode { get; init; }

    /// <summary>
    /// Result summary object specifying how the <c>address</c> field matched for fields that are only present on an international KYC check.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("international_details")]
    public KycCheckDetailsInternationalAddress? InternationalDetails { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
