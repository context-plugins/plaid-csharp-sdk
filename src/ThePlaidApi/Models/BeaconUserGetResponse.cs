using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// A Beacon User represents an end user that has been scanned against the Beacon Network.
/// </summary>
public record BeaconUserGetResponse
{
    /// <summary>
    /// An array of Plaid Item IDs corresponding to the Accounts associated with this Beacon User.
    /// </summary>
    [JsonPropertyName("item_ids")]
    [UniqueItems]
    public required IReadOnlyList<string> ItemIds { get; init; }

    /// <summary>
    /// ID of the associated Beacon User.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The <c>version</c> field begins with 1 and increments each time the user is updated.
    /// </summary>
    [JsonPropertyName("version")]
    public required int Version { get; init; }

    /// <summary>
    /// An ISO8601 formatted timestamp.
    /// </summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// An ISO8601 formatted timestamp. This field indicates the last time the resource was modified.
    /// </summary>
    [JsonPropertyName("updated_at")]
    public required DateTimeOffset UpdatedAt { get; init; }

    /// <summary>
    /// A status of a Beacon User.
    /// <para>
    /// <c>rejected</c>: The Beacon User has been rejected for fraud. Users can be automatically or manually rejected.
    /// </para>
    /// <para>
    /// <c>pending_review</c>: The Beacon User has been marked for review.
    /// </para>
    /// <para>
    /// <c>cleared</c>: The Beacon User has been cleared of fraud.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required BeaconUserStatus Status { get; init; }

    /// <summary>
    /// ID of the associated Beacon Program.
    /// </summary>
    [JsonPropertyName("program_id")]
    public required string ProgramId { get; init; }

    /// <summary>
    /// A unique ID that identifies the end user in your system. Either a <c>user_id</c> or the <c>client_user_id</c> must be provided. This ID can also be used to associate user-specific data from other Plaid products. Financial Account Matching requires this field and the <c>/link/token/create</c> <c>client_user_id</c> to be consistent. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.
    /// </summary>
    [JsonPropertyName("client_user_id")]
    public required string ClientUserId { get; init; }

    /// <summary>
    /// A Beacon User's data and resulting analysis when checked against duplicate records and the Beacon Fraud Network.
    /// </summary>
    [JsonPropertyName("user")]
    public required BeaconUserData User { get; init; }

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
