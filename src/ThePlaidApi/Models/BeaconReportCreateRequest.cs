using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Request input for creating a Beacon Report
/// </summary>
public record BeaconReportCreateRequest
{
    /// <summary>
    /// ID of the associated Beacon User.
    /// </summary>
    [JsonPropertyName("beacon_user_id")]
    public required string BeaconUserId { get; init; }

    /// <summary>
    /// The type of Beacon Report.
    /// <para>
    /// <c>first_party</c>: If this is the same individual as the one who submitted the KYC.
    /// </para>
    /// <para>
    /// <c>stolen</c>: If this is a different individual from the one who submitted the KYC.
    /// </para>
    /// <para>
    /// <c>synthetic</c>: If this is an individual using fabricated information.
    /// </para>
    /// <para>
    /// <c>account_takeover</c>: If this individual's account was compromised.
    /// </para>
    /// <para>
    /// <c>unknown</c>: If you aren't sure who committed the fraud.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required BeaconReportCreateType Type { get; init; }

    /// <summary>
    /// A date in the format YYYY-MM-DD (RFC 3339 Section 5.6).
    /// </summary>
    [JsonPropertyName("fraud_date")]
    public required DateTimeOffset FraudDate { get; init; }

    /// <summary>
    /// The amount and currency of the fraud or attempted fraud.
    /// <c>fraud_amount</c> should be omitted to indicate an unknown fraud amount.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fraud_amount")]
    public FraudAmount? FraudAmount { get; init; }

    /// <summary>
    /// Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secret")]
    public string? Secret { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
