using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of transfer. This will be either <c>debit</c> or <c>credit</c>.  A <c>debit</c> indicates a transfer of money into the origination account; a <c>credit</c> indicates a transfer of money out of the origination account.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferType>))]
public sealed record TransferType : StringEnum<TransferType>
{
    private TransferType(string value) : base(value)
    {
    }

    public static readonly TransferType Debit = new("debit");

    public static readonly TransferType Credit = new("credit");

    public static TransferType FromValue(string value) => FromValueCore(value);
}
