using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of bank transfer. This will be either <c>debit</c> or <c>credit</c>.  A <c>debit</c> indicates a transfer of money into the origination account; a <c>credit</c> indicates a transfer of money out of the origination account.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BankTransferType>))]
public sealed record BankTransferType : StringEnum<BankTransferType>
{
    private BankTransferType(string value) : base(value)
    {
    }

    public static readonly BankTransferType Debit = new("debit");

    public static readonly BankTransferType Credit = new("credit");

    public static BankTransferType FromValue(string value) => FromValueCore(value);
}
