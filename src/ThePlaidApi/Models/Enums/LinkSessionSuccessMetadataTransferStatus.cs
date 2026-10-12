using System;
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
public sealed record LinkSessionSuccessMetadataTransferStatus : OpenStringEnum<LinkSessionSuccessMetadataTransferStatus>
{
    private LinkSessionSuccessMetadataTransferStatus(string value) : base(value)
    {
    }

    public static readonly LinkSessionSuccessMetadataTransferStatus Complete = new("COMPLETE");

    public static readonly LinkSessionSuccessMetadataTransferStatus Incomplete = new("INCOMPLETE");

    public TResult Match<TResult>(Func<TResult> onComplete,
        Func<TResult> onIncomplete,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Complete => onComplete(),
            _ when this == Incomplete => onIncomplete(),
            _ => otherwise(Value)
        };

    public void Match(Action onComplete, Action onIncomplete, Action<string> otherwise)
    {
        if (this == Complete) onComplete();
        else if (this == Incomplete) onIncomplete();
        else otherwise(Value);
    }
}
