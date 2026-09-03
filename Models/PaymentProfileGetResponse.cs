using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// PaymentProfileGetResponse defines the response schema for <c>/payment_profile/get</c>
/// </summary>
public record PaymentProfileGetResponse
{
    /// <summary>
    /// Timestamp in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (<c>YYYY-MM-DDTHH:mm:ssZ</c>) indicating the last time the given Payment Profile was updated at
    /// </summary>
    [JsonPropertyName("updated_at")]
    public required DateTimeOffset UpdatedAt { get; init; }

    /// <summary>
    /// Timestamp in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (<c>YYYY-MM-DDTHH:mm:ssZ</c>) indicating the time the given Payment Profile was created at
    /// </summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// Timestamp in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (<c>YYYY-MM-DDTHH:mm:ssZ</c>) indicating the time the given Payment Profile was deleted at. Always <c>null</c> if the Payment Profile has not been deleted
    /// </summary>
    [JsonPropertyName("deleted_at")]
    public required DateTimeOffset? DeletedAt { get; init; }

    /// <summary>
    /// The status of the given Payment Profile.
    /// <para>
    /// <c>READY</c>: This Payment Profile is ready to be used to create transfers using <c>/transfer/authorization/create</c> and <c>/transfer/create</c>.
    /// </para>
    /// <para>
    /// <c>PENDING</c>: This Payment Profile is not ready to be used. You'll need to call <c>/link/token/create</c> and provide the <c>payment_profile_token</c> in the <c>transfer.payment_profile_token</c> field to initiate the account linking experience.
    /// </para>
    /// <para>
    /// <c>REMOVED</c>: This Payment Profile has been removed.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required PaymentProfileStatus Status { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
