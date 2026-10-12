using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// A Beacon Report describes the type of fraud committed by a user as well as the date the fraud was committed and the total amount of money lost due to the fraud incident.
/// <para>
/// This information is used to block similar fraud attempts on your platform as well as alert other companies who screen a user with matching identity information.
/// Other companies will not receive any new identity information, just what matched, plus information such as industry, type of fraud, and date of fraud.
/// </para>
/// <para>
/// You can manage your fraud reports by adding, deleting, or editing reports as you get additional information on fraudulent users.
/// </para>
/// </summary>
public record BeaconReportGetResponse
{
    /// <summary>
    /// ID of the associated Beacon Report.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// ID of the associated Beacon User.
    /// </summary>
    [JsonPropertyName("beacon_user_id")]
    public required string BeaconUserId { get; init; }

    /// <summary>
    /// An ISO8601 formatted timestamp.
    /// </summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

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
    /// <c>data_breach</c>: If this individual's data was compromised in a breach.
    /// </para>
    /// <para>
    /// <c>unknown</c>: If you aren't sure who committed the fraud.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required BeaconReportType Type { get; init; }

    /// <summary>
    /// A date in the format YYYY-MM-DD (RFC 3339 Section 5.6).
    /// </summary>
    [JsonPropertyName("fraud_date")]
    public required DateTimeOffset? FraudDate { get; init; }

    /// <summary>
    /// A date in the format YYYY-MM-DD (RFC 3339 Section 5.6).
    /// </summary>
    [JsonPropertyName("event_date")]
    public required DateTimeOffset EventDate { get; init; }

    /// <summary>
    /// The amount and currency of the fraud or attempted fraud.
    /// <c>fraud_amount</c> should be omitted to indicate an unknown fraud amount.
    /// </summary>
    [JsonPropertyName("fraud_amount")]
    public required FraudAmount? FraudAmount { get; init; }

    /// <summary>
    /// Information about the last change made to the parent object specifying what caused the change as well as when it occurred.
    /// </summary>
    [JsonPropertyName("audit_trail")]
    public required BeaconAuditTrail AuditTrail { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
