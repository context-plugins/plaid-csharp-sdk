using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Reason why the Item is about to be disconnected.
/// <c>INSTITUTION_MIGRATION</c>: The institution is moving to API or to a different integration. For example, this can occur when an institution moves from a non-OAuth integration to an OAuth integration.
/// <c>INSTITUTION_TOKEN_EXPIRATION</c>: The consent on an Item associated with a US or CA institution is about to expire.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PendingDisconnectWebhookReason>))]
public sealed record PendingDisconnectWebhookReason : StringEnum<PendingDisconnectWebhookReason>
{
    private PendingDisconnectWebhookReason(string value) : base(value)
    {
    }

    public static readonly PendingDisconnectWebhookReason InstitutionMigration = new("INSTITUTION_MIGRATION");

    public static readonly PendingDisconnectWebhookReason InstitutionTokenExpiration = new("INSTITUTION_TOKEN_EXPIRATION");

    public static PendingDisconnectWebhookReason FromValue(string value) => FromValueCore(value);
}
