using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of a transfer. Returned only when <see href="https://plaid.com/docs/transfer/using-transfer-ui">Transfer UI</see> is implemented.
/// <list type="bullet">
///   <item><description><c>COMPLETE</c> - The transfer was completed.</description></item>
///   <item><description><c>INCOMPLETE</c> - The transfer could not be completed. For help, see <see href="https://plaid.com/docs/transfer/using-transfer-ui/#troubleshooting-transfer-ui">Troubleshooting transfers</see>.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LinkSessionSuccessMetadataTransferStatus>))]
public sealed record LinkSessionSuccessMetadataTransferStatus : StringEnum<LinkSessionSuccessMetadataTransferStatus>
{
    private LinkSessionSuccessMetadataTransferStatus(string value) : base(value)
    {
    }

    public static readonly LinkSessionSuccessMetadataTransferStatus Complete = new("COMPLETE");

    public static readonly LinkSessionSuccessMetadataTransferStatus Incomplete = new("INCOMPLETE");

    public static LinkSessionSuccessMetadataTransferStatus FromValue(string value) => FromValueCore(value);
}
