using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Asset Transaction Type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AssetTransactionType>))]
public sealed record AssetTransactionType : StringEnum<AssetTransactionType>
{
    private AssetTransactionType(string value) : base(value)
    {
    }

    public static readonly AssetTransactionType Credit = new("Credit");

    public static readonly AssetTransactionType Debit = new("Debit");

    public static AssetTransactionType FromValue(string value) => FromValueCore(value);
}
