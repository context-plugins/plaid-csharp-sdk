using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of transfer. Valid values are <c>debit</c> or <c>credit</c>.  A <c>debit</c> indicates a transfer of money into the origination account; a <c>credit</c> indicates a transfer of money out of the origination account. This field is omitted for Plaid Ledger Sweep events.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OmittableTransferType>))]
public sealed record OmittableTransferType : StringEnum<OmittableTransferType>
{
    private OmittableTransferType(string value) : base(value)
    {
    }

    public static readonly OmittableTransferType Debit = new("debit");

    public static readonly OmittableTransferType Credit = new("credit");

    public static OmittableTransferType FromValue(string value) => FromValueCore(value);
}
