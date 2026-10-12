using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// LinkDeliveryGetResponse defines the response schema for <c>/link_delivery/get</c>
/// </summary>
public record LinkDeliveryGetResponse
{
    /// <summary>
    /// The status of the given Hosted Link session.
    /// <para>
    /// <c>CREATED</c>: The session is created but not yet accessed by the user
    /// </para>
    /// <para>
    /// <c>OPENED</c>: The session is opened by the user but not yet completed
    /// </para>
    /// <para>
    /// <c>EXITED</c>: The session has been exited by the user
    /// </para>
    /// <para>
    /// <c>COMPLETED</c>: The session has been completed by the user
    /// </para>
    /// <para>
    /// <c>EXPIRED</c>: The session has expired
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required LinkDeliverySessionStatus Status { get; init; }

    /// <summary>
    /// Timestamp in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (<c>YYYY-MM-DDTHH:mm:ssZ</c>) indicating the time the given Hosted Link session was created at.
    /// </summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// Timestamp in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (<c>YYYY-MM-DDTHH:mm:ssZ</c>) indicating the time the given Hosted Link session was completed at.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("completed_at")]
    public DateTimeOffset? CompletedAt { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    /// <summary>
    /// An array of access tokens associated with the Hosted Link session.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("access_tokens")]
    public IReadOnlyList<string>? AccessTokens { get; init; }

    /// <summary>
    /// An array of <c>item_id</c>s associated with the Hosted Link session.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_ids")]
    public IReadOnlyList<string>? ItemIds { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
